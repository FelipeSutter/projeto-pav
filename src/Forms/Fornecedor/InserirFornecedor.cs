using PDV.Entities;
using PDV.Infrastructure.Repositories;

namespace PDV.Forms {
    public partial class InserirFornecedor : Form {
        Fornecedor fornecedor;

        public Fornecedor getFornecedor() {
            return fornecedor;
        }
        public InserirFornecedor() {
            InitializeComponent();
        }

        private void criarBu_Click(object sender, EventArgs e) {
            fornecedor = new Fornecedor(nomeBox.Text, logradouroBox.Text, numeroBox.Text, complementoBox.Text,
                            bairroBox.Text, cidadeBox.Text, estadoBox.Text, cepBox.Text, cpf_cnpjBox.Text, telefoneBox.Text, emailBox.Text);

            var repository = new FornecedorRepository();
            repository.Add(fornecedor);
        }

        private void button2_Click(object sender, EventArgs e) {
            Close();
        }

        private void InserirFornecedor_Load(object sender, EventArgs e) {

        }
    }
}
