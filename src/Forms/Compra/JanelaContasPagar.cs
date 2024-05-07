using Org.BouncyCastle.Asn1.Cmp;
using PDV.Entities;
using PDV.Enums;
using PDV.Infrastructure.Repositories;
using PDV.Tables;

namespace PDV.Forms;
public partial class JanelaContasPagar : Form
{
    List<ContaPagar> contas = new List<ContaPagar>();
    List<Fornecedor> fornecedores = [];
    TabelaContaPagar _tabela;


    public JanelaContasPagar()
    {
        InitializeComponent();
        _tabela = new TabelaContaPagar(); // Instanciação da tabela
        dataViewContaPagar.DataSource = _tabela;
        dataViewContaPagar.Columns[0].Width = 200;
        dataViewContaPagar.Columns[1].Width = 200;
        dataViewContaPagar.Columns[2].Width = 200;
        dataViewContaPagar.Columns[3].Width = 200;
        dataViewContaPagar.Columns[4].Width = 200;
        dataViewContaPagar.Columns[5].Width = 200;
        dataViewContaPagar.Columns[6].Width = 200;

        ObterContaPagar();
        ObterFornecedores();

        fornecedor_box.DataSource = fornecedores;
        fornecedor_box.DisplayMember = "Nome";
        fornecedor_box.ValueMember = "Id_fornecedor";

    }
    public void ObterContaPagar(string nomePesquisa = null)
    {
        var repository = new ContaPagarRepository();
        contas = repository.Get();
        foreach (var item in contas)
        {
            _tabela.Incluir(item);
        }
    }


    public Fornecedor ObterFornecedores(int id)
    {
        var repository = new FornecedorRepository();
        fornecedores = repository.Get();
        Fornecedor clie = new Fornecedor();
        foreach (var item in fornecedores)
        {
            if (id == item.Id_fornecedor)
            {
                clie = item;
                break;
            }
        }
        return clie;
    }

    public void ObterFornecedores(string? nomePesquisa = null)
    {
        var repository = new FornecedorRepository();
        fornecedores = repository.Get();
    }

    private void dataViewContsPagar_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void JanelaContasPagar_Load(object sender, EventArgs e)
    {

    }

    private void btn_voltar_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        ContaPagar conta = _tabela.ObterContaPagarNaLinhaSelecionada(dataViewContaPagar.CurrentRow.Index);

        if (conta.Descricao.Equals(EStatusConta.PAGO.ToString()))
        {
            MessageBox.Show("Esta conta já foi paga.");
            return;
        }
        else if (conta.Data_vencimento < DateTime.Now)
        {
            MessageBox.Show("Esta conta já venceu. Seu nome está no Serasa");
        }
        else
        {
            var movimentoCaixaRepository = new MovimentoCaixaRepository();
            ContaPagarRepository con = new ContaPagarRepository();

            var movimentoCaixa = CriarMovimentoCaixa(conta.Valor_pagamento, ETipoMovimento.SAIDA, true); //pode ter um erro no conta.valor pagamente
            movimentoCaixaRepository.Add(movimentoCaixa);

            //update EStatusConta
            MessageBox.Show("Baixa de conta paga com sucesso!");
            con.UpdateDescricaoAndValorPagamento(conta.Id_conta_pagar, EStatusConta.PAGO.ToString(), conta.Valor_pagamento, DateTime.Now);
            _tabela.Clear();
            ObterContaPagar();
        }


    }

    private MovimentoCaixa CriarMovimentoCaixa(double valor, ETipoMovimento tipoMovimento, bool efetuarVenda)
    {
        // Obtém o ID do último caixa disponível
        var caixaRepository = new CaixaRepository();
        int idCaixa = caixaRepository.GetLastId();

        // Obtém o saldo atual do caixa
        var saldoAtual = caixaRepository.GetSaldo(idCaixa);

        // Calcula o novo saldo do caixa com base na situação da compra
        double novoSaldo = saldoAtual;
        if (efetuarVenda)
        {
            novoSaldo -= valor;
            bool sucessoAtualizacaoSaldo = caixaRepository.UpdateSaldo(idCaixa, novoSaldo);

            if (!sucessoAtualizacaoSaldo)
            {
                throw new Exception("Falha ao atualizar o saldo do caixa.");
            }
        }

        MovimentoCaixa movimentoCaixa = new MovimentoCaixa(idCaixa, valor, tipoMovimento, DateTime.Now, tipoMovimento.ToString());

        return movimentoCaixa;
    }

    private void btn_filtrar_Click(object sender, EventArgs e)
    {
        ContaPagarRepository repository = new ContaPagarRepository();
        Fornecedor fornecedor = ObterFornecedores((int)fornecedor_box.SelectedValue);

        _tabela.Clear();

        var contas = repository.GetContasPagarByFornecedor(fornecedor.Id_fornecedor);

        foreach (var item in contas)
        {
            _tabela.Incluir(item);
        }
    }
}
