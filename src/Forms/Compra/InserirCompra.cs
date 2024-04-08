﻿using PDV.Entities;
using PDV.Enums;
using PDV.Infrastructure.Repositories;
using PDV.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDV
{
    public partial class InserirCompra : Form {
        List<Produto> produtos = new List<Produto>();
        List<Fornecedor> fornecedores = [];
        List<ItemCompra> itens = new List<ItemCompra>();
        TabelaItemCompra _tabela;

        private double total = 0;
        public InserirCompra() {
            InitializeComponent();
            ObterProdutos();
            ObterFornecedores();
            cb_parcela.Enabled = false;

            _tabela = new TabelaItemCompra(); // Instanciação da tabela
            dataViewItemVenda.DataSource = _tabela;
            dataViewItemVenda.Columns[0].Width = 200;
            dataViewItemVenda.Columns[1].Width = 200;
            dataViewItemVenda.Columns[2].Width = 200;
            dataViewItemVenda.Columns[3].Width = 200;
            dataViewItemVenda.Columns[4].Width = 200;

            prod_box.DataSource = produtos;
            prod_box.DisplayMember = "Nome";
            prod_box.ValueMember = "Id_produto";

            pessoa_box.DataSource = fornecedores;
            pessoa_box.DisplayMember = "Nome";
            pessoa_box.ValueMember = "Id_fornecedor";
        }

        public void ObterProdutos(string nomePesquisa = null) {
            var repository = new ProdutoRepository();
            produtos = repository.Get(nomePesquisa);
        }
        public Produto ObterProdutos(int id) {
            var repository = new ProdutoRepository();
            produtos = repository.Get();
            Produto prod = new Produto();
            foreach (var item in produtos) {
                if (id == item.Id_produto) {
                    prod = item;
                    break;
                }
            }
            return prod;
        }

        public void ObterFornecedores(string? nomePesquisa = null) {
            var repository = new FornecedorRepository();
            fornecedores = repository.Get();
        }

        public Fornecedor ObterFornecedores(int id) {
            var repository = new FornecedorRepository();
            fornecedores = repository.Get();
            Fornecedor forn = new Fornecedor();
            foreach (var item in fornecedores) {
                if (id == item.Id_fornecedor) {
                    forn = item;
                    break;
                }
            }
            return forn;
        }

        private void btn_carrinho_Click(object sender, EventArgs e) {
            int qtd = int.Parse(qtd_box.Text);
            Produto prod = new Produto();
            prod = ObterProdutos((int) prod_box.SelectedValue);
            if (prod.Qtd_estoque < qtd) {
                MessageBox.Show("Não há estoque suficiente para o produto " + prod.Nome, "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {
                ItemCompra item = new ItemCompra(qtd, prod.Preco, qtd * prod.Preco, prod);
                itens.Add(item);

                _tabela.Incluir(item);

                total += qtd * prod.Preco;
                lb_total.Text = total.ToString();
            }
        }

        private void btn_compra_Click(object sender, EventArgs e) {
            var itemRepository = new ItemCompraRepository();
            var movimentoCaixaRepository = new MovimentoCaixaRepository();
            var formaPagamentoRepository = new FormaPagamentoVendaRepository();

            Fornecedor fornecedor = ObterFornecedores((int) pessoa_box.SelectedValue);

            // Cria uma nova venda
            Compra compra = new Compra(total, EStatus.EFETUADA, fornecedor.Id_fornecedor);

            // Salva a venda no banco de dados
            int idCompra = itemRepository.Add(compra, itens, true);

            // Cria a forma de pagamento venda usando o ID da compra salva
            var formaPagamento = CriarFormaPagamentoVenda(total, idCompra);

            // Adiciona a forma de pagamento venda ao banco de dados
            formaPagamentoRepository.Add(formaPagamento);

            // Cria o movimento do Caixa
            var movimentoCaixa = CriarMovimentoCaixa(total, ETipoMovimento.ENTRADA, true);
            movimentoCaixaRepository.Add(movimentoCaixa);

            // Criar contas a pagar


            Close();
        }

        private void btn_cancelar_Click(object sender, EventArgs e) {
            var itemRepository = new ItemCompraRepository();
            var movimentoCaixaRepository = new MovimentoCaixaRepository();

            Fornecedor fornecedor = ObterFornecedores((int) pessoa_box.SelectedValue);

            // Cria uma nova venda
            Compra compra = new Compra(total, EStatus.CANCELADA, fornecedor.Id_fornecedor);

            // Salva a venda no banco de dados
            itemRepository.Add(compra, itens, false);

            var movimentoCaixa = CriarMovimentoCaixa(total, ETipoMovimento.ENTRADA, false);
            movimentoCaixaRepository.Add(movimentoCaixa);

            Close();
        }

        private FormaPagamentoVenda CriarFormaPagamentoVenda(double total, int idVenda) {
            // Verifica qual forma de pagamento foi selecionada
            var formaPagamentoRepository = new FormaPagamentoVendaRepository();

            int idFormaPagamento = 0; // Inicializa com valor padrão
            if (rb_credito.Checked) {
                idFormaPagamento = formaPagamentoRepository.GetById(EFormaPagamento.CREDITO);
            } else if (rb_debito.Checked) {
                idFormaPagamento = formaPagamentoRepository.GetById(EFormaPagamento.DEBITO);
            } else if (rb_pix.Checked) {
                idFormaPagamento = formaPagamentoRepository.GetById(EFormaPagamento.PIX);
            } else if (rb_especie.Checked) {
                idFormaPagamento = formaPagamentoRepository.GetById(EFormaPagamento.ESPECIE);
            }

            // Cria o objeto FormaPagamentoVenda
            var formaPagamentoVenda = new FormaPagamentoVenda(idVenda, idFormaPagamento, total);

            return formaPagamentoVenda;
        }

        private MovimentoCaixa CriarMovimentoCaixa(double valor, ETipoMovimento tipoMovimento, bool efetuarVenda) {
            // Obtém o ID do último caixa disponível
            var caixaRepository = new CaixaRepository();
            int idCaixa = caixaRepository.GetLastId();

            // Obtém o saldo atual do caixa
            var saldoAtual = caixaRepository.GetSaldo(idCaixa);

            // Calcula o novo saldo do caixa com base na situação da compra
            double novoSaldo = saldoAtual;
            if (efetuarVenda) {
                novoSaldo -= valor; // Aumenta o saldo caso a compra seja efetuada
                bool sucessoAtualizacaoSaldo = caixaRepository.UpdateSaldo(idCaixa, novoSaldo);

                if (!sucessoAtualizacaoSaldo) {
                    throw new Exception("Falha ao atualizar o saldo do caixa.");
                }
            }

            MovimentoCaixa movimentoCaixa = new MovimentoCaixa(idCaixa, valor, tipoMovimento, DateTime.Now);

            return movimentoCaixa;
        }

        private void InserirCompra_Load(object sender, EventArgs e) {

        }

        
    }
}
