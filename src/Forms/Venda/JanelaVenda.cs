using iTextSharp.text;
using iTextSharp.text.pdf;
using PDV.Entities;
using PDV.Enums;
using PDV.Forms.Venda;
using PDV.Infrastructure.Repositories;
using PDV.Tabelas;

namespace PDV
{
    public partial class JanelaVenda : Form {

        List<Venda> vendas = new List<Venda>();

        TabelaVenda _tabela;
        String path = "../../../PDFs/";

        public JanelaVenda() {
            InitializeComponent();
            _tabela = new TabelaVenda(); // Instanciação da tabela
            dataViewVenda.DataSource = _tabela;
            dataViewVenda.Columns[0].Width = 200;
            dataViewVenda.Columns[1].Width = 200;
            dataViewVenda.Columns[2].Width = 200;
            dataViewVenda.Columns[3].Width = 200;
            dataViewVenda.Columns[4].Width = 200;


            //txt_pesquisar.TextChanged += txt_pesquisar_TextChanged;

            ObterVendas();
        }

        public void ObterVendas(string? nomePesquisa = null) {
            var repository = new VendaRepository();
            vendas = repository.Get();
            foreach (var item in vendas) {
                _tabela.Incluir(item);
            }

        }

        private void btn_incluir_Click(object sender, EventArgs e) {
            InserirVenda frm = new InserirVenda();

            DialogResult response = frm.ShowDialog();
            if (response == DialogResult.OK) {
                _tabela.Clear();
                ObterVendas();
            }


        }

        private void btn_voltar_Click(object sender, EventArgs e) {
            Close();
        }


        private void btn_contas_Click(object sender, EventArgs e) {
            JanelaContasReceber frm = new JanelaContasReceber();
            frm.Show();
        }
        private void JanelaVenda_Load(object sender, EventArgs e) {


        }

        // Método de impressão de venda
        private void btn_consultar_venda_Click(object sender, EventArgs e) {

            // TODO: Verificar pq as informaçoes de item venda estão vindo zeradas

            Venda venda = _tabela.ObterVendaNaLinhaSelecionada(dataViewVenda.CurrentRow.Index);
            ItemVendaRepository repository = new ItemVendaRepository();
            List<ItemVenda> itens = repository.GetByVendaId(venda.Id_venda);

            string nomeArquivo = path + "Venda.pdf";
            FileStream arquivoPDF = new FileStream(nomeArquivo, FileMode.Create);
            Document document = new Document(PageSize.A4);
            PdfWriter writer = PdfWriter.GetInstance(document, arquivoPDF);

            document.Open();

            // Criação e formatação do cabeçalho
            Paragraph cabecalho = new Paragraph();
            cabecalho.Alignment = Element.ALIGN_CENTER;
            cabecalho.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 20, (int) FontStyle.Bold);
            cabecalho.Add($"Venda {venda.Id_venda} Data: {venda.Data_Hora.ToShortDateString()} Hora: {venda.Data_Hora.ToShortTimeString()}\n");
            if (venda.Cliente != null)
                cabecalho.Add($"Cliente: {venda.Cliente.Nome}\n");
            cabecalho.Add("\nItem   Descrição   Qtd    Preço    Total\n");
            document.Add(cabecalho);

            // Adiciona os itens da venda formatados
            foreach (var item in itens) {
                Paragraph paragrafoItem = new Paragraph();
                paragrafoItem.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12);
                paragrafoItem.Add($"{item.Produto.Id_produto}   {item.Produto.Nome}    {item.QtdItem}   {item.ValorUnitario:0.00}   {item.TotalItem:0.00}\n");
                document.Add(paragrafoItem);
            }

            // Adiciona o total da venda
            Paragraph total = new Paragraph();
            total.Alignment = Element.ALIGN_RIGHT;
            total.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14);
            total.Add($"Total: {venda.Total_Venda:0.00}\n\n");
            document.Add(total);

            document.Close();

            MessageBox.Show("Histórico de vendas impresso com sucesso!");
        }

        // Método para imprimir uma venda em um documento PDF
        private void ImprimirVendaPDF(Document document, Venda venda) {
            // Obtém os itens da venda
            ItemVendaRepository repository = new ItemVendaRepository();
            List<ItemVenda> itens = repository.GetByVendaId(venda.Id_venda);

            // Criação e formatação do cabeçalho
            Paragraph cabecalho = new Paragraph();
            cabecalho.Alignment = Element.ALIGN_CENTER;
            cabecalho.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 20, (int) FontStyle.Bold);
            cabecalho.Add($"Venda {venda.Id_venda} Data: {venda.Data_Hora.ToShortDateString()} Hora: {venda.Data_Hora.ToShortTimeString()}\n");
            if (venda.Cliente != null)
                cabecalho.Add($"Cliente: {venda.Cliente.Nome}\n");
            cabecalho.Add("\nItem   Descrição   Qtd    Preço    Total\n");
            document.Add(cabecalho);

            // Adiciona os itens da venda formatados
            foreach (var item in itens) {
                Paragraph paragrafoItem = new Paragraph();
                paragrafoItem.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 12);
                paragrafoItem.Add($"{item.Produto.Id_produto}   {item.Produto.Nome}    {item.QtdItem}   {item.ValorUnitario:0.00}   {item.TotalItem:0.00}\n");
                document.Add(paragrafoItem);
            }

            // Adiciona o total da venda
            Paragraph total = new Paragraph();
            total.Alignment = Element.ALIGN_RIGHT;
            total.Font = new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 14);
            total.Add($"Total: {venda.Total_Venda:0.00}\n\n");
            document.Add(total);

            // Adiciona uma quebra de página entre as vendas
            document.NewPage();
        }

        private void btn_imprimir_Click(object sender, EventArgs e) {
            // Obtem as vendas no período especificado
            VendaRepository vendaRepository = new VendaRepository();
            ClienteRepository clienteRepository = new ClienteRepository();

            DateTime dataInicio = inicio_datetime.Value.Date;
            DateTime dataFim = final_datetime.Value.Date.AddDays(1).AddSeconds(-1);

            var vendasFiltradas = vendaRepository.Get(dataInicio, dataFim);

            // Cria um novo documento PDF para o relatório de vendas
            string nomeArquivo = path + "Relatorio_Vendas.pdf";
            FileStream arquivoPDF = new FileStream(nomeArquivo, FileMode.Create);
            Document document = new Document(PageSize.A4);
            PdfWriter writer = PdfWriter.GetInstance(document, arquivoPDF);

            document.Open();

            // Adiciona o título do relatório
            Paragraph titulo = new Paragraph($"Relatório de Vendas de {dataInicio.ToShortDateString()} a {dataFim.ToShortDateString()}\n\n");
            titulo.Alignment = Element.ALIGN_CENTER;
            document.Add(titulo);

            // Adiciona o cabeçalho da tabela
            PdfPTable tabela = new PdfPTable(6);
            tabela.AddCell("Código");
            tabela.AddCell("Data");
            tabela.AddCell("Hora");
            tabela.AddCell("Cliente");
            tabela.AddCell("Situação");
            tabela.AddCell("Total");

            // Variáveis para calcular os totais
            double totalVendasCanceladas = 0;
            double totalVendasAtivas = 0;

            // Adiciona as vendas à tabela
            foreach (var venda in vendasFiltradas) {
                // Calcula o total de vendas canceladas e ativas
                if (venda.Situacao_Venda == EStatus.CANCELADA) {
                    totalVendasCanceladas += venda.Total_Venda;
                } else {
                    totalVendasAtivas += venda.Total_Venda;
                }

                Cliente cliente = clienteRepository.GetByVendaId(venda.Id_venda);

                // Adiciona os dados da venda à tabela
                tabela.AddCell(venda.Id_venda.ToString());
                tabela.AddCell(venda.Data_Hora.ToShortDateString());
                tabela.AddCell(venda.Data_Hora.ToShortTimeString());
                tabela.AddCell(cliente.Nome);
                tabela.AddCell(venda.Situacao_Venda.ToString());
                tabela.AddCell(venda.Total_Venda.ToString("0.00"));
            }

            // Adiciona a tabela ao documento
            document.Add(tabela);

            // Adiciona os totais ao documento
            document.Add(new Paragraph("\n"));
            document.Add(new Paragraph($"Total de vendas canceladas: {totalVendasCanceladas.ToString("0.00")}"));
            document.Add(new Paragraph($"Total de vendas ativas: {totalVendasAtivas.ToString("0.00")}"));
            document.Add(new Paragraph($"Total final: {(totalVendasCanceladas + totalVendasAtivas).ToString("0.00")}"));

            // Fecha o documento
            document.Close();

            MessageBox.Show("Relatório de vendas impresso com sucesso!");
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e) {

        }

        private void inicio_datetime_ValueChanged(object sender, EventArgs e) {

        }

        private void final_datetime_ValueChanged(object sender, EventArgs e) {

        }

        private void btn_filtrar_Click(object sender, EventArgs e) {
            VendaRepository vendaRepository = new VendaRepository();

            DateTime dataInicio = inicio_datetime.Value.Date;
            DateTime dataFim = final_datetime.Value.Date.AddDays(1).AddSeconds(-1); // Ajuste para incluir até o fim do dia selecionado

            // Limpa a tabela antes de aplicar o filtro
            _tabela.Clear();

            // Obtém as vendas filtradas com base nas datas selecionadas
            var vendasFiltradas = vendaRepository.Get(dataInicio, dataFim);

            // Adiciona as vendas filtradas à tabela
            foreach (var venda in vendasFiltradas) {
                _tabela.Incluir(venda);
            }
        }

    }
}
