using PDV.Entities;
using System;
using System.Data;

namespace PDV.Tabelas {
    public class TabelaProduto : DataTable {

        private const string COLUNA_ID_PRODUTO = "Id Produto";
        private const string COLUNA_QTD_ESTOQUE = "Quantidade em Estoque";
        private const string COLUNA_NOME = "Nome";
        private const string COLUNA_PRECO = "Preço";
        private const string COLUNA_UNIDADE = "Unidade";
        private const string COLUNA_ID_FORNECEDOR = "Id Fornecedor";
        private const string COLUNA_ID_CLASSIFICACAO = "Id Classificação";

        public TabelaProduto() {
            CriarColunas();
        }

        private DataColumn CriarColuna(string titulo, string nome, Type tipo) {
            DataColumn coluna = new DataColumn();
            coluna.Caption = titulo;
            coluna.ColumnName = nome;
            coluna.DataType = tipo;

            return coluna;
        }

        private void CriarColunas() {
            Columns.Add(CriarColuna("Id Produto", COLUNA_ID_PRODUTO, typeof(int)));
            Columns.Add(CriarColuna("Quantidade em Estoque", COLUNA_QTD_ESTOQUE, typeof(int)));
            Columns.Add(CriarColuna("Nome", COLUNA_NOME, typeof(string)));
            Columns.Add(CriarColuna("Preço", COLUNA_PRECO, typeof(double)));
            Columns.Add(CriarColuna("Unidade", COLUNA_UNIDADE, typeof(string)));
            Columns.Add(CriarColuna("Id Fornecedor", COLUNA_ID_FORNECEDOR, typeof(int)));
            Columns.Add(CriarColuna("Id Classificação", COLUNA_ID_CLASSIFICACAO, typeof(int)));
        }

        public void Incluir(Produto produto) {
            Rows.Add(produto.Id_produto, produto.Qtd_estoque, produto.Nome,
                     produto.Preco, produto.Unidade, produto.Id_fornecedor,
                     produto.Id_classificacao);
        }

        public void Alterar(int indice, Produto produto) {
            Rows[indice][COLUNA_ID_PRODUTO] = produto.Id_produto;
            Rows[indice][COLUNA_QTD_ESTOQUE] = produto.Qtd_estoque;
            Rows[indice][COLUNA_NOME] = produto.Nome;
            Rows[indice][COLUNA_PRECO] = produto.Preco;
            Rows[indice][COLUNA_UNIDADE] = produto.Unidade;
            Rows[indice][COLUNA_ID_FORNECEDOR] = produto.Id_fornecedor;
            Rows[indice][COLUNA_ID_CLASSIFICACAO] = produto.Id_classificacao;
        }

        public void Excluir(int indice) {
            Rows.RemoveAt(indice);
        }

        public Produto ObterProdutoNaLinhaSelecionada(int indiceLinha) {
            var produto = new Produto {
                Id_produto = Convert.ToInt32(Rows[indiceLinha][COLUNA_ID_PRODUTO]),
                Qtd_estoque = Convert.ToInt32(Rows[indiceLinha][COLUNA_QTD_ESTOQUE]),
                Nome = Rows[indiceLinha][COLUNA_NOME].ToString(),
                Preco = Convert.ToDouble(Rows[indiceLinha][COLUNA_PRECO]),
                Unidade = Rows[indiceLinha][COLUNA_UNIDADE].ToString(),
                Id_fornecedor = Convert.ToInt32(Rows[indiceLinha][COLUNA_ID_FORNECEDOR]),
                Id_classificacao = Convert.ToInt32(Rows[indiceLinha][COLUNA_ID_CLASSIFICACAO])
            };

            return produto;
        }
    }
}
