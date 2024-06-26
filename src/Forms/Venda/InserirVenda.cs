﻿using Dapper;
using PDV.Entities;
using PDV.Enums;
using PDV.Infrastructure.Database;
using PDV.Infrastructure.Repositories;
using PDV.Tables;

namespace PDV
{
    public partial class InserirVenda : Form
    {
        List<Produto> produtos = new List<Produto>();
        List<Cliente> clientes = [];
        List<ItemVenda> itens = new List<ItemVenda>();
        TabelaItemVenda _tabela;

        private double total = 0;
        public InserirVenda()
        {
            InitializeComponent();
            ObterProdutos();
            ObterClientes();
            cb_parcela.Enabled = false;

            _tabela = new TabelaItemVenda(); // Instanciação da tabela
            dataViewItemVenda.DataSource = _tabela;
            dataViewItemVenda.Columns[0].Width = 200;
            dataViewItemVenda.Columns[1].Width = 200;
            dataViewItemVenda.Columns[2].Width = 200;
            dataViewItemVenda.Columns[3].Width = 200;
            dataViewItemVenda.Columns[4].Width = 200;

            prod_box.DataSource = produtos;
            prod_box.DisplayMember = "Nome";
            prod_box.ValueMember = "Id_produto";

            pessoa_box.DataSource = clientes;
            pessoa_box.DisplayMember = "Nome";
            pessoa_box.ValueMember = "Id_cliente";
        }

        public void ObterProdutos(string nomePesquisa = null)
        {
            var repository = new ProdutoRepository();
            produtos = repository.Get(nomePesquisa);
        }
        public Produto ObterProdutos(int id)
        {
            var repository = new ProdutoRepository();
            produtos = repository.Get();
            Produto prod = new Produto();
            foreach (var item in produtos)
            {
                if (id == item.Id_produto)
                {
                    prod = item;
                    break;
                }
            }
            return prod;
        }

        public void ObterClientes(string? nomePesquisa = null)
        {
            var repository = new ClienteRepository();
            clientes = repository.Get();
        }

        public Cliente ObterClientes(int id)
        {
            var repository = new ClienteRepository();
            clientes = repository.Get();
            Cliente clie = new Cliente();
            foreach (var item in clientes)
            {
                if (id == item.Id_cliente)
                {
                    clie = item;
                    break;
                }
            }
            return clie;
        }

        private void btn_carrinho_Click(object sender, EventArgs e)
        {
            int qtd = int.Parse(qtd_box.Text);
            Produto prod = new Produto();
            prod = ObterProdutos((int)prod_box.SelectedValue);
            if (prod.Qtd_estoque < qtd)
            {
                MessageBox.Show("Não há estoque suficiente para o produto " + prod.Nome, "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ItemVenda item = new ItemVenda(qtd, prod.Preco, qtd * prod.Preco, prod);
                itens.Add(item);

                _tabela.Incluir(item);

                total += qtd * prod.Preco;
                lb_total.Text = total.ToString();
            }
        }
        private void btn_venda_Click(object sender, EventArgs e)
        {
            var itemRepository = new ItemVendaRepository();
            var formaPagamentoRepository = new FormaPagamentoVendaRepository();
            var movimentoCaixaRepository = new MovimentoCaixaRepository();
            var contaReceberRepository = new ContaReceberRepository();

            Cliente cliente = ObterClientes((int)pessoa_box.SelectedValue);

            // Cria uma nova venda
            Venda venda = new Venda(total, EStatus.EFETUADA, cliente.Id_cliente);

            // Salva a venda no banco de dados
            int idVenda = itemRepository.Add(venda, itens, true);

            // Cria a forma de pagamento venda usando o ID da venda salva
            var formaPagamento = CriarFormaPagamentoVenda(total, idVenda);

            // Adiciona a forma de pagamento venda ao banco de dados
            formaPagamentoRepository.Add(formaPagamento);

            // Cria o movimento do Caixa

            if (!rb_credito.Checked) {
                var movimentoCaixa = CriarMovimentoCaixa(total, ETipoMovimento.ENTRADA,true);
                movimentoCaixaRepository.Add(movimentoCaixa);
            }
            //Cria a contaReceber   
            CriarContaReceber(contaReceberRepository, cliente.Id_cliente);

            Close();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            var itemRepository = new ItemVendaRepository();
            var movimentoRepository = new MovimentoCaixaRepository();

            Cliente cliente = new Cliente();
            cliente = ObterClientes((int)pessoa_box.SelectedValue);

            Venda venda = new Venda(total, EStatus.CANCELADA, cliente.Id_cliente);
            itemRepository.Add(venda, itens, false);

            var movimentoCaixa = CriarMovimentoCaixa(total, ETipoMovimento.ENTRADA, false);
            movimentoRepository.Add(movimentoCaixa);

            Close();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lb_total_Click(object sender, EventArgs e)
        {

        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            ItemVenda item = _tabela.ObterItemVendaNaLinhaSelecionada(dataViewItemVenda.CurrentRow.Index);

            itens.Remove(item);

            // verificar porque a lista não está deletando.

            Console.WriteLine(itens);

            MessageBox.Show("Item excluído com sucesso!");
            total -= item.Total_item;
            lb_total.Text = total.ToString();


            _tabela.Excluir(dataViewItemVenda.CurrentRow.Index);
        }

        private void InserirVenda_Load(object sender, EventArgs e)
        {

        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            ItemVenda item = _tabela.ObterItemVendaNaLinhaSelecionada(dataViewItemVenda.CurrentRow.Index);
            Produto prod = new Produto();

            int novaQuantidade = int.Parse(qtd_box.Text);
            prod = ObterProdutos((int)prod_box.SelectedValue);

            if (prod.Qtd_estoque < novaQuantidade)
            {
                MessageBox.Show("Não há estoque suficiente para o produto " + prod.Nome, "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double totalAnterior = item.Total_item; // Salva o total anterior do item

                // Atualiza o item de venda com a nova quantidade e recalcula o total
                item.Qtd_item = novaQuantidade;
                item.Total_item = novaQuantidade * prod.Preco;

                // Atualiza a linha na tabela
                _tabela.Alterar(dataViewItemVenda.CurrentRow.Index, item);

                // Atualiza o preço total da venda
                total -= totalAnterior; // Remove o total anterior
                total += item.Total_item; // Adiciona o novo total
                lb_total.Text = total.ToString();
            }
        }

        private void rb_pix_CheckedChanged(object sender, EventArgs e)
        {

        }

        private MovimentoCaixa CriarMovimentoCaixa(double valor, ETipoMovimento tipoMovimento, bool efetuarVenda)
        {
            // Obtém o ID do último caixa disponível
            var caixaRepository = new CaixaRepository();
            int idCaixa = caixaRepository.GetLastId();

            // Obtém o saldo atual do caixa
            var saldoAtual = caixaRepository.GetSaldo(idCaixa);

            // Calcula o novo saldo do caixa com base na situação da venda
            double novoSaldo = saldoAtual;
            if (efetuarVenda)
            {
                novoSaldo += valor; // Aumenta o saldo caso a venda seja efetuada
                bool sucessoAtualizacaoSaldo = caixaRepository.UpdateSaldo(idCaixa, novoSaldo);

                if (!sucessoAtualizacaoSaldo)
                {
                    throw new Exception("Falha ao atualizar o saldo do caixa.");
                }
            }

            MovimentoCaixa movimentoCaixa = new MovimentoCaixa(idCaixa, valor, tipoMovimento,DateTime.Now, tipoMovimento.ToString());

            return movimentoCaixa;
        }


        private FormaPagamentoVenda CriarFormaPagamentoVenda(double total, int idVenda)
        {
            var formaPagamentoRepository = new FormaPagamentoVendaRepository();

            // Verifica qual forma de pagamento foi selecionada
            int idFormaPagamento = 0; // Inicializa com valor padrão
            if (rb_credito.Checked)
            {
                idFormaPagamento = formaPagamentoRepository.GetById(EFormaPagamento.CREDITO);
            }
            else if (rb_debito.Checked)
            {
                idFormaPagamento = formaPagamentoRepository.GetById(EFormaPagamento.DEBITO);
            }
            else if (rb_pix.Checked)
            {
                idFormaPagamento = formaPagamentoRepository.GetById(EFormaPagamento.PIX);
            }
            else if (rb_especie.Checked)
            {
                idFormaPagamento = formaPagamentoRepository.GetById(EFormaPagamento.ESPECIE);
            }

            // Cria o objeto FormaPagamentoVenda
            var formaPagamentoVenda = new FormaPagamentoVenda(idVenda, idFormaPagamento, total);

            return formaPagamentoVenda;
        }

        private void rb_credito_CheckedChanged(object sender, EventArgs e)
        {

            if (rb_credito.Checked)
            {
                cb_parcela.Enabled = true;
            }
            else
            {
                cb_parcela.Enabled = false;
            }

        }

        private void CriarContaReceber(ContaReceberRepository contaReceberRepository,int idCliente)
        {
           
            if (rb_credito.Checked && cb_parcela.Text != "À vista")
            {
                for (int i = 1; i <= int.Parse(cb_parcela.Text); i++)
                {

                    ContaReceber receba = new ContaReceber(idCliente, 0.0, total / int.Parse(cb_parcela.Text), DateTime.Now, DateTime.Now.AddMonths(i));
                    contaReceberRepository.Add(receba);
                }

            }
        }
    }
}
