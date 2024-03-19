using PDV.Entities;

namespace PDV.Forms {
    public partial class ConsultarCliente : Form
    {
        public ConsultarCliente()
        {
            InitializeComponent();
        }

        public ConsultarCliente(Cliente client)
        {
            InitializeComponent();
            nomeL.Text = client.Nome;
            logradouroL.Text = client.Logradouro;
            numeroL.Text = client.Numero;
            complementoL.Text = client.Complemento;
            bairroL.Text = client.Bairro;
            cidadeL.Text = client.Cidade;
            estadoL.Text = client.Estado;
            cepL.Text = client.Cep;
            cpf_cnpjL.Text = client.Cpf_cnpj;
            telefoneL.Text = client.Telefone;
            emailL.Text = client.Email;
        }

        private void ConsultarClientecs_Load(object sender, EventArgs e)
        {

        }

        private void voltarBu_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
