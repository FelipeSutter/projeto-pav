using PDV.Entities;
using PDV.Forms;
using PDV.Infrastructure.Repositories;
using PDV.Tabelas;

namespace PDV
{
    public partial class JanelaProduto : Form
    {
        List<Produto> produtos = new List<Produto>(); // Correção aqui

        TabelaProduto _tabela;

        public JanelaProduto()
        {
            InitializeComponent();
            _tabela = new TabelaProduto(); // Instanciação da tabela
            dataViewProduto.DataSource = _tabela;
            dataViewProduto.Columns[0].Width = 200;
            dataViewProduto.Columns[1].Width = 200;
            dataViewProduto.Columns[2].Width = 200;
            dataViewProduto.Columns[3].Width = 200;
            dataViewProduto.Columns[4].Width = 200;
            dataViewProduto.Columns[5].Width = 200;
            dataViewProduto.Columns[6].Width = 200;
            ObterProdutos();
        }


        public void ObterProdutos()
        {
            var repository = new ProdutoRepository();
            produtos = repository.Get();
            foreach (var item in produtos)
            {
                _tabela.Incluir(item);
            }

        }

        private void JanelaProduto_Load(object sender, EventArgs e)
        {
            // Carregar dados, se necessário
        }

        private void btn_incluir_Click(object sender, EventArgs e)
        {
            InserirProduto form = new InserirProduto();
            DialogResult response = form.ShowDialog();
            if (response == DialogResult.OK)
            {
                _tabela.Clear();
                ObterProdutos();
            }
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            var repository = new ProdutoRepository();
            Produto produto = _tabela.ObterProdutoNaLinhaSelecionada(dataViewProduto.CurrentRow.Index);
            repository.Delete(produto.Id_produto);

            _tabela.Excluir(dataViewProduto.CurrentRow.Index);
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            Produto produto = _tabela.ObterProdutoNaLinhaSelecionada(dataViewProduto.CurrentRow.Index);
            ConsultarProduto frm = new ConsultarProduto(produto);
            frm.Show();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
