using PDV.Entities;
using System.Data;

namespace PDV.Tabelas {
    public class TabelaItemVenda : DataTable {

        private const string COLUNA_NOME_PRODUTO = "Nome Produto";
        private const string COLUNA_QTD_ITEM = "Quantidade do Item";
        private const string COLUNA_VALOR_UNITARIO = "Valor Unitário";
        private const string COLUNA_TOTAL_ITEM = "Total do Item";
        private const string COLUNA_SITUACAO_VENDA = "Situação da Venda";

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
            Columns.Add(CriarColuna("Nome Produto", COLUNA_NOME_PRODUTO, typeof(string)));
            Columns.Add(CriarColuna("Quantidade do Item", COLUNA_QTD_ITEM, typeof(int)));
            Columns.Add(CriarColuna("Valor Unitário", COLUNA_VALOR_UNITARIO, typeof(double)));
            Columns.Add(CriarColuna("Total do Item", COLUNA_TOTAL_ITEM, typeof(double)));
            Columns.Add(CriarColuna("Situação da Venda", COLUNA_SITUACAO_VENDA, typeof(string)));
        }

        public void Incluir(ItemVenda itemVenda) {
            Rows.Add(itemVenda.IdVenda, itemVenda.Produto.Nome, itemVenda.QtdItem,
                     itemVenda.ValorUnitario, itemVenda.TotalItem, itemVenda.Venda.SituacaoVenda);
        }

        public void Alterar(int indice, ItemVenda itemVenda) {
            Rows[indice][COLUNA_NOME_PRODUTO] = itemVenda.Produto.Nome;
            Rows[indice][COLUNA_QTD_ITEM] = itemVenda.QtdItem;
            Rows[indice][COLUNA_VALOR_UNITARIO] = itemVenda.ValorUnitario;
            Rows[indice][COLUNA_TOTAL_ITEM] = itemVenda.TotalItem;
            Rows[indice][COLUNA_SITUACAO_VENDA] = itemVenda.Venda.SituacaoVenda;
        }

        public void Excluir(int indice) {
            Rows.RemoveAt(indice);
        }

        public ItemVenda ObterItemVendaNaLinhaSelecionada(int indiceLinha) {
            var itemVenda = new ItemVenda {
                QtdItem = Convert.ToInt32(Rows[indiceLinha][COLUNA_QTD_ITEM]),
                ValorUnitario = Convert.ToDouble(Rows[indiceLinha][COLUNA_VALOR_UNITARIO])
            };

            return itemVenda;
        }
    }
}
