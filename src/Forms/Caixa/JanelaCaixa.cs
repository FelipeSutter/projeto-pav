using iTextSharp.text;
using iTextSharp.text.pdf;
using PDV.Entities;
using PDV.Enums;
using PDV.Infrastructure.Repositories;
using PDV.Tabelas;

namespace PDV {
    public partial class JanelaCaixa : Form {
        List<MovimentoCaixa> movimentos = new List<MovimentoCaixa>();
        TabelaMovimentoCaixa _tabela;
        String path = "../../../PDFs/";


        public JanelaCaixa() {
            CaixaRepository _caixaRepository = new CaixaRepository();

            int idCaixa = _caixaRepository.GetLastId();

            InitializeComponent();
            _tabela = new TabelaMovimentoCaixa(); // Instanciação da tabela
            dataViewMovimentoCaixa.DataSource = _tabela;
            dataViewMovimentoCaixa.Columns[0].Width = 200;
            dataViewMovimentoCaixa.Columns[1].Width = 200;
            dataViewMovimentoCaixa.Columns[2].Width = 200;
            dataViewMovimentoCaixa.Columns[3].Width = 200;
            dataViewMovimentoCaixa.Columns[4].Width = 200;
            dataViewMovimentoCaixa.Columns[5].Width = 200;

            ObterMovimentoCaixa();
            lb_total_caixa.Text = _caixaRepository.GetSaldo(idCaixa).ToString();
        }

        public void ObterMovimentoCaixa(string nomePesquisa = null) {
            var repository = new MovimentoCaixaRepository();
            movimentos = repository.Get();
            foreach (var item in movimentos) {
                _tabela.Incluir(item);
            }
        }

        private void btn_voltar_Click(object sender, EventArgs e) {
            Close();
        }

        private void JanelaCaixa_Load(object sender, EventArgs e) {

        }

        private void btn_imprimir_Click(object sender, EventArgs e) {
            // Obtem as contas no período especificado
            MovimentoCaixaRepository movimentoRepository = new MovimentoCaixaRepository();
            CaixaRepository caixaRepository = new CaixaRepository();

            int idCaixa = caixaRepository.GetLastId();

            int dia = inicio_datetime.Value.Day;
            int mes = inicio_datetime.Value.Month;
            int ano = inicio_datetime.Value.Year;

            var movimentosFiltrados = movimentoRepository.Get(dia, mes, ano); // Corrigido para usar o método correto

            // Cria um novo documento PDF para o relatório de contas
            string nomeArquivo = path + "Relatorio_Caixa.pdf";
            FileStream arquivoPDF = new FileStream(nomeArquivo, FileMode.Create);
            Document document = new Document(PageSize.A4);
            PdfWriter writer = PdfWriter.GetInstance(document, arquivoPDF);

            document.Open();

            // Adiciona o título do relatório
            Paragraph titulo = new Paragraph($"Relatório de Fechamento de Caixa do dia {dia}/{mes}/{ano}\n\n");
            titulo.Alignment = Element.ALIGN_CENTER;
            document.Add(titulo);

            // Adiciona o cabeçalho da tabela
            PdfPTable tabela = new PdfPTable(3); // Ajustado para 3 colunas
            tabela.AddCell("ID Caixa");
            tabela.AddCell("Tipo de Movimento");
            tabela.AddCell("Total");

            double totalEntradas = 0;
            double totalSaidas = 0;

            // Adiciona as contas à tabela
            foreach (var movimento in movimentosFiltrados) {
                if (movimento.Tipo_movimento == ETipoMovimento.ENTRADA) {
                    totalEntradas += movimento.Valor;
                } else if (movimento.Tipo_movimento == ETipoMovimento.SAIDA) {
                    totalSaidas += movimento.Valor;
                }

                // Adiciona os dados da conta à tabela
                tabela.AddCell(idCaixa.ToString()); // ID do caixa
                tabela.AddCell(movimento.Tipo_movimento.ToString()); // Tipo de movimento
                tabela.AddCell((movimento.Tipo_movimento == ETipoMovimento.ENTRADA ? "+" : "-") + movimento.Valor.ToString()); // Total, indicando se é entrada (+) ou saída (-)
            }

            // Calcula o total final
            double totalFinal = totalEntradas - totalSaidas;

            // Adiciona a tabela ao documento
            document.Add(tabela);

            // Adiciona os totais ao documento
            document.Add(new Paragraph($"\nTotal Entradas: {totalEntradas}\nTotal Saídas: {totalSaidas}\nTotal Final: {totalFinal}"));

            // Fecha o documento
            document.Close();

            MessageBox.Show("Relatório de caixa impresso com sucesso!");
        }


        private void dataViewMovimentoCaixa_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void btn_filtrar_Click(object sender, EventArgs e) {
            MovimentoCaixaRepository repository = new MovimentoCaixaRepository();

            int dia = inicio_datetime.Value.Day;
            int mes = inicio_datetime.Value.Month;
            int ano = inicio_datetime.Value.Year;

            // Limpa a tabela antes de aplicar o filtro
            _tabela.Clear();

            // Obtém as movimento filtradas com base nas datas selecionadas
            var movimentos = repository.Get(dia, mes, ano);

            // Adiciona as movimento filtradas à tabela
            foreach (var movimento in movimentos) {
                _tabela.Incluir(movimento);
            }
        }
    }
}
