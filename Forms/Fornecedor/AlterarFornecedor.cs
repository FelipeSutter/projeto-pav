using PDV.Entities;

namespace PDV.Forms {
    public partial class AlterarFornecedor : Form {
        Fornecedor fornecedor;

        public AlterarFornecedor() {
            InitializeComponent();
        }

        public AlterarFornecedor(Fornecedor forn) {
            InitializeComponent();
            fornecedor = forn;
            nomeBox.Text = forn.Nome;
            logradouroBox.Text = forn.Logradouro;
            numeroBox.Text = forn.Numero;
            complementoBox.Text = forn.Complemento;
            bairroBox.Text = forn.Bairro;
            cidadeBox.Text = forn.Cidade;
            estadoBox.Text = forn.Estado;
            cepBox.Text = forn.Cep;
            cpf_cnpjBox.Text = forn.Cpf_cnpj;
            telefoneBox.Text = forn.Telefone;
            emailBox.Text = forn.Email;
        }

        public Fornecedor GetFornecedor() {
            return fornecedor;
        }

        private void button1_Click(object sender, EventArgs e) {
            fornecedor.Nome = nomeBox.Text;
            fornecedor.Logradouro = logradouroBox.Text;
            fornecedor.Numero = numeroBox.Text;
            fornecedor.Complemento = complementoBox.Text;
            fornecedor.Bairro = bairroBox.Text;
            fornecedor.Cidade = cidadeBox.Text;
            fornecedor.Estado = estadoBox.Text;
            fornecedor.Cep = cepBox.Text;
            fornecedor.Cpf_cnpj = cpf_cnpjBox.Text;
            fornecedor.Telefone = telefoneBox.Text;
            fornecedor.Email = emailBox.Text;
        }

        private void AlterarFornecedor_Load(object sender, EventArgs e) {

        }
    }
}
