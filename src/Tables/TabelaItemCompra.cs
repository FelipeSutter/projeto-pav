using PDV.Entities;
using System;
using System.Data;

namespace PDV.Tables
{
    public class TabelaItemCompra : DataTable
    {
        private const string COLUNA_CODIGO = "Codigo";
        private const string COLUNA_NOME_PRODUTO = "NomeProduto";
        private const string COLUNA_QUANTIDADE = "Quantidade";
        private const string COLUNA_PRECO = "Preco";
        private const string COLUNA_TOTAL = "Total";

        public TabelaItemCompra()
        {
            CriarColunas();
        }

        private DataColumn CriarColuna(string titulo, string nome, Type tipo)
        {
            DataColumn coluna = new DataColumn();
            coluna.Caption = titulo;
            coluna.ColumnName = nome;
            coluna.DataType = tipo;

            return coluna;
        }

        private void CriarColunas()
        {
            Columns.Add(CriarColuna("Código", COLUNA_CODIGO, typeof(int)));
            Columns.Add(CriarColuna("Nome do Produto", COLUNA_NOME_PRODUTO, typeof(string)));
            Columns.Add(CriarColuna("Quantidade", COLUNA_QUANTIDADE, typeof(int)));
            Columns.Add(CriarColuna("Preço", COLUNA_PRECO, typeof(double)));
            Columns.Add(CriarColuna("Total", COLUNA_TOTAL, typeof(double)));
        }

        public void Incluir(ItemCompra itemCompra)
        {
            Rows.Add(itemCompra.Id_produto, itemCompra.Produto.Nome, itemCompra.Qtd, itemCompra.Valor_unitario, itemCompra.Total_item);
        }

        public void Alterar(int indice, ItemCompra itemCompra)
        {
            Rows[indice][COLUNA_CODIGO] = itemCompra.Id_produto;
            Rows[indice][COLUNA_NOME_PRODUTO] = itemCompra.Produto.Nome;
            Rows[indice][COLUNA_QUANTIDADE] = itemCompra.Qtd;
            Rows[indice][COLUNA_PRECO] = itemCompra.Valor_unitario;
            Rows[indice][COLUNA_TOTAL] = itemCompra.Total_item;
        }

        public void Excluir(int indice)
        {
            Rows.RemoveAt(indice);
        }

        public ItemCompra ObterItemCompraNaLinhaSelecionada(int indiceLinha)
        {
            var item = new ItemCompra
            {
                Id_produto = Convert.ToInt32(Rows[indiceLinha][COLUNA_CODIGO]),
                Produto = new Produto
                {
                    Nome = Rows[indiceLinha][COLUNA_NOME_PRODUTO].ToString()
                },
                Qtd = Convert.ToInt32(Rows[indiceLinha][COLUNA_QUANTIDADE]),
                Valor_unitario = Convert.ToDouble(Rows[indiceLinha][COLUNA_PRECO]),
                Total_item = Convert.ToDouble(Rows[indiceLinha][COLUNA_TOTAL])
            };

            return item;
        }
    }
}
