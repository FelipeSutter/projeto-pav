using PDV.Entities;

namespace PDV;

public partial class ConsultarProduto : Form
{
    public ConsultarProduto()
    {
        InitializeComponent();
    }

    public ConsultarProduto(Produto produto)
    {
        InitializeComponent();
        nomeLabel.Text = produto.Nome;
        qtdLabel.Text = produto.Qtd_estoque.ToString();
        unidadeLabel.Text = produto.Unidade;
        precoLabel.Text = produto.Preco.ToString();
        idFornecedorLabel.Text = produto.Id_fornecedor.ToString();
        idClassificacaoLabel.Text = produto.Id_classificacao.ToString();
    }

    private void ConsultarProduto_Load(object sender, EventArgs e)
    {

    }

    private void btn_voltar_Click(object sender, EventArgs e)
    {
        Close();
    }
}
