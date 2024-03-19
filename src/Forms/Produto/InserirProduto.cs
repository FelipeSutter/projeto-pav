using PDV.Entities;
using PDV.Infrastructure.Repositories;

namespace PDV
{
    public partial class InserirProduto : Form
    {
        Produto produto;

        public Produto GetProduto() => produto;

        public InserirProduto()
        {
            InitializeComponent();
        }

        private void InserirProduto_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_criar_Click(object sender, EventArgs e)
        {

            string qtd = qtdBox.Text;
            string nome = nomeBox.Text;
            string preco = precoBox.Text;
            string unidade = unidadeBox.Text;
            string idFornecedor = idFornecedorBox.Text;
            string idClassificacao = idClassificacaoBox.Text;


            produto = new Produto(qtd, nome, preco, unidade, idFornecedor, idClassificacao);

            var repository = new ProdutoRepository();
            repository.Add(produto);

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
