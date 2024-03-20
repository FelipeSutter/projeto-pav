using PDV.Entities;
using PDV.Infrastructure.Repositories;

namespace PDV {
    public partial class InserirCliente : Form
    {
        Cliente client;

        public Cliente getClient()
        {
            return client;
        }
        public InserirCliente()
        {
            InitializeComponent();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            client = new Cliente(nomeBox.Text, logradouroBox.Text, numeroBox.Text, complementoBox.Text,
                                        bairroBox.Text, cidadeBox.Text, cb_estado.Text, cepBox.Text, cpf_cnpjBox.Text, telefoneBox.Text, emailBox.Text);

            var repository = new ClienteRepository();
            repository.Add(client);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void InserirCliente_Load(object sender, EventArgs e)
        {

        }

        private void cb_estado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
