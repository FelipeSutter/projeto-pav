using PDV.Entities;

namespace PDV.Forms {
    public partial class ConsultarFornecedor : Form {
        public ConsultarFornecedor() {
            InitializeComponent();
        }

        public ConsultarFornecedor(Fornecedor forn) {
            InitializeComponent();
            nomeL.Text = forn.Nome;
            logradouroL.Text = forn.Logradouro;
            numeroL.Text = forn.Numero;
            complementoL.Text = forn.Complemento;
            bairroL.Text = forn.Bairro;
            cidadeL.Text = forn.Cidade;
            estadoL.Text = forn.Estado;
            cepL.Text = forn.Cep;
            cpf_cnpjL.Text = forn.Cpf_cnpj;
            telefoneL.Text = forn.Telefone;
            emailL.Text = forn.Email;
        }

        private void voltarBu_Click(object sender, EventArgs e) {
            Close();
        }

        private void ConsultarFornecedor_Load(object sender, EventArgs e) {

        }
    }
}
