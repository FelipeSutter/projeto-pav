using PDV.Forms;

namespace PDV {
    public partial class Menu : Form
    {


        public Menu()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            JanelaProduto frm = new JanelaProduto();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            JanelaCliente frm = new JanelaCliente();
            frm.Show();



        }

        private void button3_Click(object sender, EventArgs e)
        {
            JanelaFornecedor frm = new JanelaFornecedor();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            JanelaClassificacao frm = new JanelaClassificacao();
            frm.Show();
        }
    }
}
