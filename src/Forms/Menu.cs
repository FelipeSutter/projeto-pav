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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btn_Venda_Click(object sender, EventArgs e)
        {
            JanelaVenda frm = new JanelaVenda();
            frm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_caixa_Click(object sender, EventArgs e)
        {
            JanelaCaixa frm = new JanelaCaixa();
            frm.Show();
        }

        private void btn_compras_Click(object sender, EventArgs e)
        {
            JanelaCompra frm = new JanelaCompra();
            frm.Show();
        }
    }
}
