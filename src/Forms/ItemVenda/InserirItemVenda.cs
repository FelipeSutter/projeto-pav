using PDV.Entities;
using PDV.Infrastructure.Repositories;

namespace PDV.Forms;
public partial class InserirItemVenda : Form {

    ItemVenda item;
    Venda venda;

    public ItemVenda GetItem() => item;

    public InserirItemVenda(Venda venda) {
        InitializeComponent();

        this.venda = venda;
    
    }

    private void InserirItemVenda_Load(object sender, EventArgs e) {

    }

    private void label4_Click(object sender, EventArgs e) {

    }

    private void btn_voltar_Click(object sender, EventArgs e) {
        Close();
    }

    private void cb_cliente_SelectedIndexChanged(object sender, EventArgs e) {

    }

    private void cb_produto_SelectedIndexChanged(object sender, EventArgs e) {

    }

    private void nm_qtd_ValueChanged(object sender, EventArgs e) {

    }

    private void rb_credito_CheckedChanged(object sender, EventArgs e) {

    }

    private void rb_debito_CheckedChanged(object sender, EventArgs e) {

    }

    private void rb_pix_CheckedChanged(object sender, EventArgs e) {

    }

    private void rb_dinheiro_CheckedChanged(object sender, EventArgs e) {

    }

    private void btn_criar_Click(object sender, EventArgs e) {
        string idCliente = cb_cliente.Text;
        string idProduto = cb_produto.Text;
        string qtdItem = nm_qtd.Value.ToString();

        // Cria o novo item de venda associado à venda atual
        item = new ItemVenda(Convert.ToInt32(idProduto), venda.Id_venda, Convert.ToInt32(qtdItem), Convert.ToInt32(idCliente));

        var repository = new ItemVendaRepository();
        repository.EfetuarVenda(venda, item);
    }
}
