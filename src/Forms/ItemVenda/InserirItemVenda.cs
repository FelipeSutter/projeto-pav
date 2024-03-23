using PDV.Entities;
using PDV.Infrastructure.Repositories;

namespace PDV.Forms;
public partial class InserirItemVenda : Form {

    ItemVenda item;
    Venda venda;

    public ItemVenda GetItem() => item;

    public InserirItemVenda(Venda venda = null) { // Aceita uma instância de Venda opcionalmente
        InitializeComponent();
        var clienteRepository = new ClienteRepository();

        var clientes = clienteRepository.Get();

        cb_cliente.Items.Clear();

        cb_cliente.DataSource = clientes;
        cb_cliente.DisplayMember = "nome";
        cb_cliente.ValueMember = "id_cliente";

        if (venda == null) {
            venda = new Venda();
        }

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
        string idProduto = cb_produto.Text;
        string qtdItem = nm_qtd.Value.ToString();

        if (cb_cliente.Items.Count > 0) {
            cb_cliente.SelectedIndex = 0; // Seleciona o primeiro cliente na lista, se houver algum

            int idCliente = ObterIdClienteSelecionado();

            item = new ItemVenda(Convert.ToInt32(idProduto), venda.Id_venda, Convert.ToInt32(qtdItem), idCliente);

            venda.CalcularTotalVenda(new List<ItemVenda> { item });

            var repository = new ItemVendaRepository();
            repository.EfetuarVenda(venda, item);

        } else {
            MessageBox.Show("Não foram encontrados clientes.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return; // Saia do método, pois não é possível prosseguir sem os clientes
        }
    }

    private int ObterIdClienteSelecionado() {
        string nomeClienteSelecionado = cb_cliente.SelectedItem.ToString();
        var clienteRepository = new ClienteRepository();
        Cliente clienteSelecionado = clienteRepository.GetClientePorNome(nomeClienteSelecionado);

        return clienteSelecionado.Id_cliente;
    }


}
