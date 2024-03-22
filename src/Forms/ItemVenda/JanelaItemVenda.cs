using PDV.Entities;
using PDV.Forms;
using PDV.Infrastructure.Repositories;
using PDV.Tabelas;

namespace PDV.Forms;

public partial class JanelaItemVenda : Form {

    List<ItemVenda> itens = [];
    private readonly TabelaItemVenda _tabela;
    private Venda vendaAtual; // Adicione um campo para armazenar a venda atual

    public JanelaItemVenda() {
        InitializeComponent();

        _tabela = new TabelaItemVenda();
        dataViewItemVenda.DataSource = _tabela;
        dataViewItemVenda.Columns[0].Width = 200;
        dataViewItemVenda.Columns[1].Width = 200;
        dataViewItemVenda.Columns[2].Width = 200;
        dataViewItemVenda.Columns[3].Width = 200;
        dataViewItemVenda.Columns[4].Width = 200;

    }

    public void ObterItens() {
        var repository = new ItemVendaRepository();
        itens = repository.Get();
        foreach (var item in itens) {
            _tabela.Incluir(item);
        }
    }

    private void JanelaItemVenda_Load(object sender, EventArgs e) {

    }

    private void btn_pesquisar_Click(object sender, EventArgs e) {

    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {

    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {

    }

    private void cb_cliente_SelectedIndexChanged(object sender, EventArgs e) {

    }

    private void btn_incluir_Click(object sender, EventArgs e) {
        InserirItemVenda form = new InserirItemVenda(); // Passa a venda atual para o formulário
        DialogResult response = form.ShowDialog();
        if (response == DialogResult.OK) {
            _tabela.Clear();
            ObterItens();
        }
    }

    // Método para definir a venda atual
    public void SetVendaAtual(Venda venda) {
        vendaAtual = venda;
    }

    private void btn_alterar_Click(object sender, EventArgs e) {
        /*AlterarItemVenda frm = new AlterarItemVenda(_tabela.ObterItemVendaNaLinhaSelecionada(dataViewItemVenda.CurrentRow.Index));
        DialogResult response = frm.ShowDialog();
        if (response == DialogResult.OK) {
            var repository = new ItemVendaRepository();
            repository.Update(frm.produto);
            _tabela.Alterar(dataViewItemVenda.CurrentRow.Index, frm.produto);

            _tabela.Clear();
            ObterItens();

        } */
    }

    private void btn_excluir_Click(object sender, EventArgs e) {
        /*var repository = new ItemVendaRepository();
        ItemVenda item = _tabela.ObterItemVendaNaLinhaSelecionada(dataViewItemVenda.CurrentRow.Index);
        repository.Delete(item.IdProduto, item.IdVenda);

        MessageBox.Show("Item excluído com sucesso!");

        _tabela.Excluir(dataViewItemVenda.CurrentRow.Index); */
    }

    private void btn_consultar_Click(object sender, EventArgs e) {
        /*ItemVenda item = _tabela.ObterItemVendaNaLinhaSelecionada(dataViewItemVenda.CurrentRow.Index);
        ConsultarItemVenda frm = new ConsultarItemVenda(item);
        frm.Show(); */
    } 

    private void btn_voltar_Click(object sender, EventArgs e) {
        Close();
    }

    private void btn_cancelar_Click(object sender, EventArgs e) {

    }

    private void btn_confirmar_Click(object sender, EventArgs e) {

    }
}
