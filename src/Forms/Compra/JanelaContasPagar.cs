using Org.BouncyCastle.Asn1.Cmp;
using PDV.Entities;
using PDV.Enums;
using PDV.Infrastructure.Repositories;
using PDV.Tables;

namespace PDV.Forms;
public partial class JanelaContasPagar : Form
{
    List<ContaPagar> contas = new List<ContaPagar>();
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
        


        //txt_pesquisar.TextChanged += txt_pesquisar_TextChanged;

        ObterContaPagar();

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
        var movimentoCaixaRepository = new MovimentoCaixaRepository();
        ContaPagarRepository con = new ContaPagarRepository();

        ContaPagar conta = _tabela.ObterContaPagarNaLinhaSelecionada(dataViewContaPagar.CurrentRow.Index);

        var movimentoCaixa = CriarMovimentoCaixa(conta.Valor_pagamento, ETipoMovimento.SAIDA, true); //pode ter um erro no conta.valor pagamente
        movimentoCaixaRepository.Add(movimentoCaixa);

        //update EStatusConta

        con.UpdateDescricao(conta.Id_conta_pagar, "PAGO");
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

        MovimentoCaixa movimentoCaixa = new MovimentoCaixa(idCaixa, valor, tipoMovimento, DateTime.Now);

        return movimentoCaixa;
    }
}
