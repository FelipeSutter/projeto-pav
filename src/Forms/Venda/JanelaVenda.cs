using iTextSharp.text;
using iTextSharp.text.pdf;
using PDV.Entities;
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
            List<ItemVenda> itens = repository.Get();

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


    }
}
