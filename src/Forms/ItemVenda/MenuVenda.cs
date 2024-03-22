namespace PDV.Forms;
public partial class MenuVenda : Form {
    public MenuVenda() {
        InitializeComponent();
    }

    private void MenuVenda_Load(object sender, EventArgs e) {

    }

    private void btn_voltar_Click(object sender, EventArgs e) {

        Close();
    }

    private void btn_incluir_venda_Click(object sender, EventArgs e) {
        JanelaItemVenda janela = new JanelaItemVenda();
        janela.Show();
    }

    private void btn_consultar_venda_Click(object sender, EventArgs e) {

    }
}
