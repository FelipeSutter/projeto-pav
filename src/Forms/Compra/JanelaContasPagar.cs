using iTextSharp.text.pdf;
using iTextSharp.text;
using Org.BouncyCastle.Asn1.Cmp;
using PDV.Entities;
using PDV.Enums;
using PDV.Infrastructure.Repositories;
using PDV.Tables;

namespace PDV.Forms;
public partial class JanelaContasPagar : Form {
    List<ContaPagar> contas = new List<ContaPagar>();
    List<Fornecedor> fornecedores = [];
    TabelaContaPagar _tabela;
    String path = "../../../PDFs/";


    public JanelaContasPagar() {
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
    public void ObterContaPagar(string nomePesquisa = null) {
        var repository = new ContaPagarRepository();
        contas = repository.Get();
        foreach (var item in contas) {
            _tabela.Incluir(item);
        }
    }


    public Fornecedor ObterFornecedores(int id) {
        var repository = new FornecedorRepository();
        fornecedores = repository.Get();
        Fornecedor clie = new Fornecedor();
        foreach (var item in fornecedores) {
            if (id == item.Id_fornecedor) {
                clie = item;
                break;
            }
        }
        return clie;
    }

    public void ObterFornecedores(string? nomePesquisa = null) {
        var repository = new FornecedorRepository();
        fornecedores = repository.Get();
    }

    private void dataViewContsPagar_CellContentClick(object sender, DataGridViewCellEventArgs e) {

    }

    private void JanelaContasPagar_Load(object sender, EventArgs e) {

    }

    private void btn_voltar_Click(object sender, EventArgs e) {
        Close();
    }

    private void button1_Click(object sender, EventArgs e) {
        ContaPagar conta = _tabela.ObterContaPagarNaLinhaSelecionada(dataViewContaPagar.CurrentRow.Index);

        if (conta.Descricao.Equals(EStatusConta.PAGO.ToString())) {
            MessageBox.Show("Esta conta já foi paga.");
            return;
        } else if (conta.Data_vencimento < DateTime.Now) {
            MessageBox.Show("Esta conta já venceu. Seu nome está no Serasa");
        } else {
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

    private MovimentoCaixa CriarMovimentoCaixa(double valor, ETipoMovimento tipoMovimento, bool efetuarVenda) {
        // Obtém o ID do último caixa disponível
        var caixaRepository = new CaixaRepository();
        int idCaixa = caixaRepository.GetLastId();

        // Obtém o saldo atual do caixa
        var saldoAtual = caixaRepository.GetSaldo(idCaixa);

        // Calcula o novo saldo do caixa com base na situação da compra
        double novoSaldo = saldoAtual;
        if (efetuarVenda) {
            novoSaldo -= valor;
            bool sucessoAtualizacaoSaldo = caixaRepository.UpdateSaldo(idCaixa, novoSaldo);

            if (!sucessoAtualizacaoSaldo) {
                throw new Exception("Falha ao atualizar o saldo do caixa.");
            }
        }

        MovimentoCaixa movimentoCaixa = new MovimentoCaixa(idCaixa, valor, tipoMovimento, DateTime.Now, tipoMovimento.ToString());

        return movimentoCaixa;
    }

    private void btn_filtrar_Click(object sender, EventArgs e) {
        ContaPagarRepository repository = new ContaPagarRepository();
        Fornecedor fornecedor = ObterFornecedores((int) fornecedor_box.SelectedValue);

        _tabela.Clear();

        var contas = repository.GetContasPagarByFornecedor(fornecedor.Id_fornecedor);

        foreach (var item in contas) {
            _tabela.Incluir(item);
        }
    }

    private void btn_filtrar_data_Click(object sender, EventArgs e) {

        ContaPagarRepository repository = new ContaPagarRepository();

        DateTime dataInicio = inicio_datetime.Value.Date;
        DateTime dataFim = final_datetime.Value.Date.AddDays(1).AddSeconds(-1); // Ajuste para incluir até o fim do dia selecionado

        // Limpa a tabela antes de aplicar o filtro
        _tabela.Clear();

        // Obtém as contas filtradas com base nas datas selecionadas
        var contasFiltradas = repository.Get(dataInicio, dataFim);

        // Adiciona as contas filtradas à tabela
        foreach (var conta in contasFiltradas) {
            _tabela.Incluir(conta);
        }

    }

    private void btn_imprimir_Click(object sender, EventArgs e) {
        // Obtem as contas no período especificado
        ContaPagarRepository contaRepository = new ContaPagarRepository();
        FornecedorRepository fornecedorRepository = new FornecedorRepository();

        DateTime dataInicio = inicio_datetime.Value.Date;
        DateTime dataFim = final_datetime.Value.Date.AddDays(1).AddSeconds(-1);

        var contasFiltradas = contaRepository.Get(dataInicio, dataFim);

        // Cria um novo documento PDF para o relatório de contas
        string nomeArquivo = path + "Relatorio_ContaPagar.pdf";
        FileStream arquivoPDF = new FileStream(nomeArquivo, FileMode.Create);
        Document document = new Document(PageSize.A4);
        PdfWriter writer = PdfWriter.GetInstance(document, arquivoPDF);

        document.Open();

        // Adiciona o título do relatório
        Paragraph titulo = new Paragraph($"Relatório de ContaPagar de {dataInicio.ToShortDateString()} a {dataFim.ToShortDateString()}\n\n");
        titulo.Alignment = Element.ALIGN_CENTER;
        document.Add(titulo);

        // Adiciona o cabeçalho da tabela
        PdfPTable tabela = new PdfPTable(6);
        tabela.AddCell("Fornecedor");
        tabela.AddCell("Código");
        tabela.AddCell("Data Lançamento");
        tabela.AddCell("Data Vencimento");
        tabela.AddCell("Status da Conta");
        tabela.AddCell("Valor Pagamento");

        // Adiciona as contas à tabela
        foreach (var conta in contasFiltradas) {

            Fornecedor fornecedor = fornecedorRepository.GetByContaPagarId(conta.Id_conta_pagar);

            // Adiciona os dados da conta à tabela
            tabela.AddCell(fornecedor.Nome);
            tabela.AddCell(conta.Id_conta_pagar.ToString());
            tabela.AddCell(conta.Data_lancamento.ToString());
            tabela.AddCell(conta.Data_vencimento.ToString());
            tabela.AddCell(conta.Descricao.ToString());
            tabela.AddCell(conta.Valor_pagamento.ToString());
        }

        // Adiciona a tabela ao documento
        document.Add(tabela);

        // Adiciona os totais ao documento
        document.Add(new Paragraph("\n"));

        // Fecha o documento
        document.Close();

        MessageBox.Show("Relatório de contas impresso com sucesso!");
    }
}
