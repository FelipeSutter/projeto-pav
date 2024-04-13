using iTextSharp.text.pdf;
using iTextSharp.text;
using PDV.Entities;
using PDV.Forms;
using PDV.Infrastructure.Repositories;
using PDV.Tabelas;
using PDV.Enums;

namespace PDV {
    public partial class JanelaCompra : Form
    {
        List<Compra> compras = new List<Compra>();

        TabelaCompra _tabela;
        String path = "../../../PDFs/";
        public JanelaCompra()
        {
            InitializeComponent();
            _tabela = new TabelaCompra(); // Instanciação da tabela
            dataViewCompra.DataSource = _tabela;
            dataViewCompra.Columns[0].Width = 200;
            dataViewCompra.Columns[1].Width = 200;
            dataViewCompra.Columns[2].Width = 200;
            dataViewCompra.Columns[3].Width = 200;
            dataViewCompra.Columns[4].Width = 200;


            //txt_pesquisar.TextChanged += txt_pesquisar_TextChanged;

            ObterCompras();

        }
        public void ObterCompras(string? nomePesquisa = null)
        {
            var repository = new CompraRepository();
            compras = repository.Get();
            foreach (var item in compras)
            {
                _tabela.Incluir(item);
            }

        }

        private void btn_incluir_Click(object sender, EventArgs e)
        {
            InserirCompra frm = new InserirCompra();

            DialogResult response = frm.ShowDialog();
            if (response == DialogResult.OK)
            {
                _tabela.Clear();
                ObterCompras();
            }
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_contas_pagar_Click(object sender, EventArgs e)
        {
            JanelaContasPagar form = new JanelaContasPagar();
            form.Show();
        }

        private void JanelaCompra_Load(object sender, EventArgs e)
        {

        }

        private void btn_filtrar_Click(object sender, EventArgs e)
        {
            CompraRepository compraRepository = new CompraRepository();

            DateTime dataInicio = inicio_datetime.Value.Date;
            DateTime dataFim = final_datetime.Value.Date.AddDays(1).AddSeconds(-1); // Ajuste para incluir até o fim do dia selecionado

            // Limpa a tabela antes de aplicar o filtro
            _tabela.Clear();

            // Obtém as compras filtradas com base nas datas selecionadas
            var comprasFiltradas = compraRepository.Get(dataInicio, dataFim);

            // Adiciona as compras filtradas à tabela
            foreach (var compra in comprasFiltradas)
            {
                _tabela.Incluir(compra);
            }
        }

        private void btn_imprimir_Click(object sender, EventArgs e) {
            // Obtem as compras no período especificado
            CompraRepository compraRepository = new CompraRepository();
            FornecedorRepository fornecedorRepository = new FornecedorRepository();

            DateTime dataInicio = inicio_datetime.Value.Date;
            DateTime dataFim = final_datetime.Value.Date.AddDays(1).AddSeconds(-1);

            var comprasFiltradas = compraRepository.Get(dataInicio, dataFim);

            // Cria um novo documento PDF para o relatório de compras
            string nomeArquivo = path + "Relatorio_Compras.pdf";
            FileStream arquivoPDF = new FileStream(nomeArquivo, FileMode.Create);
            Document document = new Document(PageSize.A4);
            PdfWriter writer = PdfWriter.GetInstance(document, arquivoPDF);

            document.Open();

            // Adiciona o título do relatório
            Paragraph titulo = new Paragraph($"Relatório de Compras de {dataInicio.ToShortDateString()} a {dataFim.ToShortDateString()}\n\n");
            titulo.Alignment = Element.ALIGN_CENTER;
            document.Add(titulo);

            // Adiciona o cabeçalho da tabela
            PdfPTable tabela = new PdfPTable(6);
            tabela.AddCell("Código");
            tabela.AddCell("Data");
            tabela.AddCell("Hora");
            tabela.AddCell("Fornecedor");
            tabela.AddCell("Situação");
            tabela.AddCell("Total");

            // Variáveis para calcular os totais
            double totalComprasCanceladas = 0;
            double totalComprasAtivas = 0;

            // Adiciona as compras à tabela
            foreach (var compra in comprasFiltradas) {
                // Calcula o total de compras canceladas e ativas
                if (compra.Situacao_Compra == EStatus.CANCELADA) {
                    totalComprasCanceladas += compra.Total_Compra;
                } else {
                    totalComprasAtivas += compra.Total_Compra;
                }

                Fornecedor fornecedor = fornecedorRepository.GetByCompraId(compra.Id_compra);

                // Adiciona os dados da compra à tabela
                tabela.AddCell(compra.Id_compra.ToString());
                tabela.AddCell(compra.Data_Hora.ToShortDateString());
                tabela.AddCell(compra.Data_Hora.ToShortTimeString());
                tabela.AddCell(fornecedor.Nome);
                tabela.AddCell(compra.Situacao_Compra.ToString());
                tabela.AddCell(compra.Total_Compra.ToString("0.00"));
            }

            // Adiciona a tabela ao documento
            document.Add(tabela);

            // Adiciona os totais ao documento
            document.Add(new Paragraph("\n"));
            document.Add(new Paragraph($"Total de compras canceladas: {totalComprasCanceladas.ToString("0.00")}"));
            document.Add(new Paragraph($"Total de compras ativas: {totalComprasAtivas.ToString("0.00")}"));
            document.Add(new Paragraph($"Total final: {(totalComprasCanceladas + totalComprasAtivas).ToString("0.00")}"));

            // Fecha o documento
            document.Close();

            MessageBox.Show("Relatório de compras impresso com sucesso!");
        }

        // Método de impressão de compra
        private void btn_consultar_compra_Click(object sender, EventArgs e)
        {
            Compra compra = _tabela.ObterCompraNaLinhaSelecionada(dataViewCompra.CurrentRow.Index);
            ItemCompraRepository repository = new ItemCompraRepository();
            List<ItemCompra> itens = repository.GetByCompraId(compra.Id_compra);

            string nomeArquivo = path + "Compra.pdf";
            using (FileStream arquivoPDF = new FileStream(nomeArquivo, FileMode.Create))
            {
                Document document = new Document(PageSize.A4);
                PdfWriter writer = PdfWriter.GetInstance(document, arquivoPDF);

                document.Open();

                // Criação e formatação do cabeçalho
                Paragraph cabecalho = new Paragraph();
                cabecalho.Alignment = Element.ALIGN_CENTER;
                cabecalho.Font = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.COURIER, 20, (int)FontStyle.Bold);
                cabecalho.Add($"Compra {compra.Id_compra:D3} Data: {compra.Data_Hora.ToShortDateString()} Hora: {compra.Data_Hora.ToShortTimeString()}\n");
                if (compra.Fornecedor != null)
                    cabecalho.Add($"Fornecedor: {compra.Fornecedor.Nome}\n");
                document.Add(cabecalho);


                Paragraph paragrafo = new Paragraph();
                paragrafo.Alignment = Element.ALIGN_LEFT;
                paragrafo.Font = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.COURIER, 14, (int)FontStyle.Bold);
                paragrafo.Add($"\nItem      Descrição      Qtd      Preço/U       Total\n");
                document.Add(paragrafo);

                // Adiciona os itens da compra formatados
                foreach (var item in itens)
                {
                    Paragraph paragrafoItem = new Paragraph();
                    paragrafoItem.Font = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.COURIER, 12);
                    paragrafoItem.Add($"{item.Produto.Id_produto:D4}        {item.Produto.Nome,-10}          {item.Qtd,-1}        {item.Valor_unitario,7:0.00}       {item.Total_item,7:0.00}\n");
                    document.Add(paragrafoItem);
                }

                // Adiciona o total
                double totalCompra = itens.Sum(item => item.Total_item);
                Paragraph total = new Paragraph();
                total.Alignment = Element.ALIGN_RIGHT;
                total.Font = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.COURIER, 14);
                total.Add($"\nTotal Compra: {totalCompra,6:0.00}");
                document.Add(total);

                document.Close();

                MessageBox.Show("Compra impressa com sucesso!");

            }
        }
    }
}
