using PDV.Entities;
using PDV.Forms.Venda;
using PDV.Infrastructure.Repositories;
using PDV.Tabelas;

namespace PDV
{
    public partial class JanelaVenda : Form
    {

        List<Venda> vendas = new List<Venda>();

        TabelaVenda _tabela;


        public JanelaVenda()
        {
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

        public void ObterVendas(string? nomePesquisa = null)
        {
            var repository = new VendaRepository();
            vendas = repository.Get();
            foreach (var item in vendas)
            {
                _tabela.Incluir(item);
            }

        }

        private void btn_incluir_Click(object sender, EventArgs e)
        {
            InserirVenda frm = new InserirVenda();

            DialogResult response = frm.ShowDialog();
            if (response == DialogResult.OK)
            {
                _tabela.Clear();
                ObterVendas();
            }


        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void btn_consultar_Click(object sender, EventArgs e)
        {
            JanelaContasReceber frm = new JanelaContasReceber();
            frm.Show();
        }
        private void JanelaVenda_Load(object sender, EventArgs e)
        {


        }
    }
}
