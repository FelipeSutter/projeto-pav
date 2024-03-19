using PDV.Entities;
using PDV.Infrastructure.Repositories;
using PDV.Tabelas;

namespace PDV.Forms {
    public partial class JanelaFornecedor : Form {
        List<Fornecedor> fornecedores = [];
        private readonly TabelaFornecedor _tabela;
        public JanelaFornecedor() {
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
            ObterFornecedores();
        }
        public void ObterFornecedores() {
            var repository = new FornecedorRepository();
            fornecedores = repository.Get();
            foreach (var item in fornecedores) {
                _tabela.Incluir(item);
            }

        }
        private void button1_Click(object sender, EventArgs e) {
            InserirFornecedor frm = new InserirFornecedor();
            DialogResult response = frm.ShowDialog();
            if (response == DialogResult.OK) {

                _tabela.Clear();
                ObterFornecedores();
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            AlterarFornecedor frm = new AlterarFornecedor(_tabela.ObterFornecedorNaLinhaSelecionada(dataViewFornecedor.CurrentRow.Index));
            DialogResult response = frm.ShowDialog();
            if (response == DialogResult.OK) {
                var repository = new FornecedorRepository();
                repository.Update(frm.GetFornecedor());
                _tabela.Alterar(dataViewFornecedor.CurrentRow.Index, frm.GetFornecedor());


            }

        }

        private void button3_Click(object sender, EventArgs e) {
            var repository = new FornecedorRepository();
            Fornecedor fornecedor = _tabela.ObterFornecedorNaLinhaSelecionada(dataViewFornecedor.CurrentRow.Index);
            repository.Delete(fornecedor.Id);

            _tabela.Excluir(dataViewFornecedor.CurrentRow.Index);
        }
        private void button5_Click(object sender, EventArgs e) {
            Fornecedor fornecedor = _tabela.ObterFornecedorNaLinhaSelecionada(dataViewFornecedor.CurrentRow.Index);
            ConsultarFornecedor frm = new ConsultarFornecedor(fornecedor);
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e) {
            Close();
        }

        private void JanelaFornecedor_Load(object sender, EventArgs e) {

        }

        private void dataViewFornecedor_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }
    }
}
