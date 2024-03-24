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
            Rows.Add(itemVenda.IdProduto, itemVenda.Produto.Nome, itemVenda.QtdItem, itemVenda.ValorUnitario, itemVenda.TotalItem);
        }

        public void Alterar(int indice, ItemVenda itemVenda) {
            Rows[indice][COLUNA_CODIGO] = itemVenda.IdProduto;
            Rows[indice][COLUNA_NOME_PRODUTO] = itemVenda.Produto.Nome;
            Rows[indice][COLUNA_QUANTIDADE] = itemVenda.QtdItem;
            Rows[indice][COLUNA_PRECO] = itemVenda.ValorUnitario;
            Rows[indice][COLUNA_TOTAL] = itemVenda.TotalItem;
        }

        public void Excluir(int indice) {
            Rows.RemoveAt(indice);
        }
    }

}
