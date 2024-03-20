using PDV.Entities;
using PDV.Infrastructure.Repositories;
using PDV.Tabelas;

namespace PDV.Forms {
    public partial class JanelaFornecedor : Form
    {
        List<Fornecedor> fornecedores = [];
        private readonly TabelaFornecedor _tabela;
        public JanelaFornecedor()
        {
            InitializeComponent();
            _tabela = new TabelaFornecedor();
            dataViewFornecedor.DataSource = _tabela;
            dataViewFornecedor.Columns[0].Width = 200;
            dataViewFornecedor.Columns[1].Width = 200;
            dataViewFornecedor.Columns[2].Width = 200;
            dataViewFornecedor.Columns[3].Width = 200;
            dataViewFornecedor.Columns[4].Width = 200;
            dataViewFornecedor.Columns[5].Width = 200;
            dataViewFornecedor.Columns[6].Width = 200;
            dataViewFornecedor.Columns[7].Width = 200;
            dataViewFornecedor.Columns[8].Width = 200;
            dataViewFornecedor.Columns[9].Width = 200;
            dataViewFornecedor.Columns[10].Width = 200;
            dataViewFornecedor.Columns[11].Width = 200;

            txt_pesquisar.TextChanged += txt_pesquisar_TextChanged;


            ObterFornecedores();
        }
        public void ObterFornecedores(string? nomePesquisa = null)
        {
            var repository = new FornecedorRepository();
            fornecedores = repository.Get(nomePesquisa);
            foreach (var item in fornecedores)
            {
                _tabela.Incluir(item);
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            InserirFornecedor frm = new InserirFornecedor();
            DialogResult response = frm.ShowDialog();
            if (response == DialogResult.OK)
            {
                // Serve para atualizar os dados da tabela, dando um refresh nela
                _tabela.Clear();
                ObterFornecedores();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AlterarFornecedor frm = new AlterarFornecedor(_tabela.ObterFornecedorNaLinhaSelecionada(dataViewFornecedor.CurrentRow.Index));
            DialogResult response = frm.ShowDialog();
            if (response == DialogResult.OK)
            {
                var repository = new FornecedorRepository();
                repository.Update(frm.GetFornecedor());
                _tabela.Alterar(dataViewFornecedor.CurrentRow.Index, frm.GetFornecedor());

                _tabela.Clear();
                ObterFornecedores();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var repository = new FornecedorRepository();
            Fornecedor fornecedor = _tabela.ObterFornecedorNaLinhaSelecionada(dataViewFornecedor.CurrentRow.Index);
            repository.Delete(fornecedor.Id_fornecedor);

            MessageBox.Show("Item excluído com sucesso!");


            _tabela.Excluir(dataViewFornecedor.CurrentRow.Index);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Fornecedor fornecedor = _tabela.ObterFornecedorNaLinhaSelecionada(dataViewFornecedor.CurrentRow.Index);
            ConsultarFornecedor frm = new ConsultarFornecedor(fornecedor);
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void JanelaFornecedor_Load(object sender, EventArgs e)
        {

        }

        private void dataViewFornecedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            string termoPesquisa = txt_pesquisar.Text;
            _tabela.Clear();
            ObterFornecedores(termoPesquisa);
        }

        private void txt_pesquisar_TextChanged(object sender, EventArgs e)
        {
            string termoPesquisa = txt_pesquisar.Text.Trim(); // Remove espaços em branco extras
            if (string.IsNullOrEmpty(termoPesquisa))
            {
                // Se o campo de pesquisa estiver vazio, traga a lista de todos os produtos
                _tabela.Clear();
                ObterFornecedores(termoPesquisa);
            }
        }
    }
}
