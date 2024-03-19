using PDV.Entities;
using PDV.Forms;
using PDV.Infrastructure.Repositories;
using PDV.Tabelas;

namespace PDV {
    public partial class JanelaCliente : Form
    {
        List<Cliente> clientes = [];

        readonly TabelaCliente _tabela;
        public JanelaCliente()
        {
            InitializeComponent();

            _tabela = new TabelaCliente();
            dataViewClient.DataSource = _tabela;
            dataViewClient.Columns[0].Width = 200;
            dataViewClient.Columns[1].Width = 200;
            dataViewClient.Columns[2].Width = 200;
            dataViewClient.Columns[3].Width = 200;
            dataViewClient.Columns[4].Width = 200;
            dataViewClient.Columns[5].Width = 200;
            dataViewClient.Columns[6].Width = 200;
            dataViewClient.Columns[7].Width = 200;
            dataViewClient.Columns[8].Width = 200;
            dataViewClient.Columns[9].Width = 200;
            dataViewClient.Columns[10].Width = 200;
            dataViewClient.Columns[11].Width = 200;

            txt_pesquisar.TextChanged += txt_pesquisar_TextChanged;


            ObterClientes();

        }

        public void ObterClientes(string? nomePesquisa = null)
        {
            var repository = new ClienteRepository();
            clientes = repository.Get(nomePesquisa);
            foreach (var item in clientes)
            {
                _tabela.Incluir(item);
            }

        }


        private void button1_Click(object sender, EventArgs e)//adcionar
        {
            InserirCliente frm = new InserirCliente();
            DialogResult response = frm.ShowDialog();
            if (response == DialogResult.OK)
            {
                _tabela.Clear();
                ObterClientes();
            }


        }

        private void button2_Click(object sender, EventArgs e)//alterar
        {
            AlterarCliente frm = new AlterarCliente(_tabela.ObterClienteNaLinhaSelecionada(dataViewClient.CurrentRow.Index));
            DialogResult response = frm.ShowDialog();
            if (response == DialogResult.OK)
            {
                var repository = new ClienteRepository();
                repository.Update(frm.cliente);
                _tabela.Alterar(dataViewClient.CurrentRow.Index, frm.cliente);

                _tabela.Clear();
                ObterClientes();

            }


        }

        private void button3_Click(object sender, EventArgs e)//remover
        {
            var repository = new ClienteRepository();
            Cliente client = _tabela.ObterClienteNaLinhaSelecionada(dataViewClient.CurrentRow.Index);
            repository.Delete(client.Id_cliente);

            _tabela.Excluir(dataViewClient.CurrentRow.Index);
        }
        private void button5_Click(object sender, EventArgs e)//consultar
        {
            Cliente client = _tabela.ObterClienteNaLinhaSelecionada(dataViewClient.CurrentRow.Index);
            ConsultarCliente frm = new ConsultarCliente(client);
            frm.Show();

        }

        private void button4_Click(object sender, EventArgs e)//sair
        {
            Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            string termoPesquisa = txt_pesquisar.Text;
            _tabela.Clear();
            ObterClientes(termoPesquisa);
        }

        private void txt_pesquisar_TextChanged(object sender, EventArgs e)
        {
            string termoPesquisa = txt_pesquisar.Text.Trim(); // Remove espaços em branco extras
            if (string.IsNullOrEmpty(termoPesquisa))
            {
                // Se o campo de pesquisa estiver vazio, traga a lista de todos os produtos
                _tabela.Clear();
                ObterClientes();
            }
        }
    }
}
