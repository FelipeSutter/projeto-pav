using PDV.Entities;
using PDV.Infrastructure.Repositories;
using PDV.Tables;

namespace PDV.Forms;
public partial class JanelaContasPagar : Form {
    List<ContaPagar> contas = new List<ContaPagar>();
    TabelaContaPagar _tabela;


    public JanelaContasPagar() {
        InitializeComponent();
        _tabela = new TabelaContaPagar(); // Instanciação da tabela
        dataViewContaPagar.DataSource = _tabela;
        dataViewContaPagar.Columns[0].Width = 200;
        dataViewContaPagar.Columns[1].Width = 200;
        dataViewContaPagar.Columns[2].Width = 200;
        dataViewContaPagar.Columns[3].Width = 200;
        dataViewContaPagar.Columns[4].Width = 200;
        dataViewContaPagar.Columns[5].Width = 200;
        dataViewContaPagar.Columns[6].Width = 200;


        //txt_pesquisar.TextChanged += txt_pesquisar_TextChanged;

        ObterContaPagar();

    }
    public void ObterContaPagar(string nomePesquisa = null) {
        var repository = new ContaPagarRepository();
        contas = repository.Get();
        foreach (var item in contas) {
            _tabela.Incluir(item);
        }
    }

    private void dataViewContsPagar_CellContentClick(object sender, DataGridViewCellEventArgs e) {

    }

    private void JanelaContasPagar_Load(object sender, EventArgs e) {

    }

    private void btn_voltar_Click(object sender, EventArgs e) {
        Close();
    }
}
