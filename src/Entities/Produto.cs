namespace PDV.Entities {
    public class Produto {

        public int Id_produto { get; set; }
        public int Qtd_estoque { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public string Unidade { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public int Id_fornecedor { get; set; }
        public Classificacao Classificacao { get; set; }

        public int Id_classificacao { get; set; }

        public Produto() { }

        public Produto(string qtd_estoque, string nome, string preco, string unidade, string id_fornecedor, string id_classificacao)
        {
            Qtd_estoque = int.Parse(qtd_estoque);
            Nome = nome;
            Preco = double.Parse(preco);
            Unidade = unidade;
            Id_fornecedor = int.Parse(id_fornecedor);
            Id_classificacao = int.Parse(id_classificacao);
        }

        public Produto(int id_produto, int qtd_estoque, string nome, double preco, string unidade, Fornecedor fornecedor, int id_fornecedor, Classificacao classificacao, int id_classificacao) {
            Id_produto = id_produto;
            Qtd_estoque = qtd_estoque;
            Nome = nome;
            Preco = preco;
            Unidade = unidade;
            Fornecedor = fornecedor;
            Id_fornecedor = id_fornecedor;
            Classificacao = classificacao;
            Id_classificacao = id_classificacao;
        }
    }
}
