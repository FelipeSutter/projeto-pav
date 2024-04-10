using PDV.Entities;
using PDV.Forms;
using PDV.Infrastructure.Repositories;
using PDV.Tabelas;

namespace PDV {
    public partial class JanelaCompra : Form {
        List<Compra> compras = new List<Compra>();

        TabelaCompra _tabela;
        String path = "../../../PDFs/";
        public JanelaCompra() {
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
        public void ObterCompras(string? nomePesquisa = null) {
            var repository = new CompraRepository();
            compras = repository.Get();
            foreach (var item in compras) {
                _tabela.Incluir(item);
            }

        }

        private void btn_incluir_Click(object sender, EventArgs e) {
            InserirCompra frm = new InserirCompra();

            DialogResult response = frm.ShowDialog();
            if (response == DialogResult.OK) {
                _tabela.Clear();
                ObterCompras();
            }
        }

        private void btn_voltar_Click(object sender, EventArgs e) {
            Close();
        }

        private void btn_contas_pagar_Click(object sender, EventArgs e) {
            JanelaContasPagar form = new JanelaContasPagar();
            form.Show();
        }
    }
}
