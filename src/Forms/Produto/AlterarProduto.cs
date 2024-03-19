using PDV.Entities;

namespace PDV;

public partial class AlterarProduto : Form
{
    public Produto produto;

    public AlterarProduto()
    {
        InitializeComponent();
    }

    public AlterarProduto(Produto produto)
    {
        InitializeComponent();
        this.produto = produto;
        nomeBox.Text = produto.Nome;
        qtdBox.Text = produto.Qtd_estoque.ToString();
        precoBox.Text = produto.Preco.ToString();
        unidadeBox.Text = produto.Unidade;
        idFornecedorBox.Text = produto.Id_fornecedor.ToString();
        idClassificacaoBox.Text = produto.Id_classificacao.ToString();
    }

    private void btn_alterar_Click(object sender, EventArgs e)
    {
        produto.Nome = nomeBox.Text;
        produto.Qtd_estoque = int.Parse(qtdBox.Text);
        produto.Preco = double.Parse(precoBox.Text);
        produto.Unidade = unidadeBox.Text;
        produto.Id_fornecedor = int.Parse(idFornecedorBox.Text);
        produto.Id_classificacao = int.Parse(idClassificacaoBox.Text);
    }

    private void btn_voltar_Click(object sender, EventArgs e)
    {
        Close();
    }
}
