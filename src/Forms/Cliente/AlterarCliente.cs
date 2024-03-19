using PDV.Entities;

namespace PDV.Forms {
    public partial class AlterarCliente : Form
    {

        public Cliente cliente;
        public AlterarCliente()
        {
            InitializeComponent();
        }

        public AlterarCliente(Cliente client)
        {
            InitializeComponent();
            cliente = client;
            nomeBox.Text = client.Nome;
            logradouroBox.Text = client.Logradouro;
            numeroBox.Text = client.Numero;
            complementoBox.Text = client.Complemento;
            bairroBox.Text = client.Bairro;
            cidadeBox.Text = client.Cidade;
            estadoBox.Text = client.Estado;
            cepBox.Text = client.Cep;
            cpf_cnpjBox.Text = client.Cpf_cnpj;
            telefoneBox.Text = client.Telefone;
            emailBox.Text = client.Email;

        }

        public Cliente getCliente()
        {
            return cliente;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void AlterarCliente_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            cliente.Nome = nomeBox.Text;
            cliente.Logradouro = logradouroBox.Text;
            cliente.Numero = numeroBox.Text;
            cliente.Complemento = complementoBox.Text;
            cliente.Bairro = bairroBox.Text;
            cliente.Cidade = cidadeBox.Text;
            cliente.Estado = estadoBox.Text;
            cliente.Cep = cepBox.Text;
            cliente.Cpf_cnpj = cpf_cnpjBox.Text;
            cliente.Telefone = telefoneBox.Text;
            cliente.Email = emailBox.Text;
        }
    }
}
