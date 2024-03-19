using PDV.Tabelas;
using PDV.Entities;

namespace PDV.Forms.Produto
{
    public partial class JanelaProduto : Form
{
    private List<Produto> produtos = new List<Produto>(); // Correção aqui

    private readonly TabelaProduto _tabela;

    public JanelaProduto()
    {
        InitializeComponent();
        _tabela = new TabelaProduto(); // Instanciação da tabela
    }

    private void JanelaProduto_Load(object sender, EventArgs e)
    {
        // Carregar dados, se necessário
    }

    private void button1_Click(object sender, EventArgs e)
    {
        // Lógica do botão
    }
}
}
