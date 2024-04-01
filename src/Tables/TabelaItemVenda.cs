using PDV.Entities;
using System.Data;

namespace PDV.Tables {
    public class TabelaItemVenda : DataTable {
        private const string COLUNA_CODIGO = "Codigo";
        private const string COLUNA_NOME_PRODUTO = "NomeProduto";
        private const string COLUNA_QUANTIDADE = "Quantidade";
        private const string COLUNA_PRECO = "Preco";
        private const string COLUNA_TOTAL = "Total";

        public TabelaItemVenda() {
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
            Columns.Add(CriarColuna("Código", COLUNA_CODIGO, typeof(int)));
            Columns.Add(CriarColuna("Nome do Produto", COLUNA_NOME_PRODUTO, typeof(string)));
            Columns.Add(CriarColuna("Quantidade", COLUNA_QUANTIDADE, typeof(int)));
            Columns.Add(CriarColuna("Preço", COLUNA_PRECO, typeof(double)));
            Columns.Add(CriarColuna("Total", COLUNA_TOTAL, typeof(double)));
        }

        public void Incluir(ItemVenda itemVenda) {
            Rows.Add(itemVenda.Id_produto, itemVenda.Produto.Nome, itemVenda.Qtd_item, itemVenda.Valor_unitario, itemVenda.Total_item);
        }

        public void Alterar(int indice, ItemVenda itemVenda) {
            Rows[indice][COLUNA_CODIGO] = itemVenda.Id_produto;
            Rows[indice][COLUNA_NOME_PRODUTO] = itemVenda.Produto.Nome;
            Rows[indice][COLUNA_QUANTIDADE] = itemVenda.Qtd_item;
            Rows[indice][COLUNA_PRECO] = itemVenda.Valor_unitario;
            Rows[indice][COLUNA_TOTAL] = itemVenda.Total_item;
        }

        public void Excluir(int indice) {
            Rows.RemoveAt(indice);
        }

        public ItemVenda ObterItemVendaNaLinhaSelecionada(int indiceLinha) {
            var item = new ItemVenda {
                Id_produto = Convert.ToInt32(Rows[indiceLinha][COLUNA_CODIGO]),
                Produto = new Produto {
                    Nome = Rows[indiceLinha][COLUNA_NOME_PRODUTO].ToString()
                },
                Qtd_item = Convert.ToInt32(Rows[indiceLinha][COLUNA_QUANTIDADE]),
                Valor_unitario = Convert.ToDouble(Rows[indiceLinha][COLUNA_PRECO]),
                Total_item = Convert.ToDouble(Rows[indiceLinha][COLUNA_TOTAL])
            };

            return item;
        }

    }

}
