using PDV.Entities;
using System.Data;

namespace PDV.Tables
{
    public class TabelaContaPagar : DataTable
    {
        private const string COLUNA_ID_CONTA_PAGAR = "IdContaPagar";
        private const string COLUNA_ID_FORNECEDOR = "IdFornecedor";
        private const string COLUNA_DESCRICAO = "Descricao";
        private const string COLUNA_VALOR_PAGO = "ValorPago";
        private const string COLUNA_VALOR_PAGAMENTO = "ValorPagamento";
        private const string COLUNA_DATA_LANCAMENTO = "DataLancamento";
        private const string COLUNA_DATA_VENCIMENTO = "DataVencimento";
        private const string COLUNA_DATA_PAGAMENTO = "DataPagamento";

        public TabelaContaPagar()
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
            Columns.Add(CriarColuna("ID Conta Pagar", COLUNA_ID_CONTA_PAGAR, typeof(int)));
            Columns.Add(CriarColuna("ID Fornecedor", COLUNA_ID_FORNECEDOR, typeof(int)));
            Columns.Add(CriarColuna("Descrição", COLUNA_DESCRICAO, typeof(string)));
            Columns.Add(CriarColuna("Valor Pago", COLUNA_VALOR_PAGO, typeof(double)));
            Columns.Add(CriarColuna("Valor Pagamento", COLUNA_VALOR_PAGAMENTO, typeof(double)));
            Columns.Add(CriarColuna("Data de Lançamento", COLUNA_DATA_LANCAMENTO, typeof(DateTime)));
            Columns.Add(CriarColuna("Data de Vencimento", COLUNA_DATA_VENCIMENTO, typeof(DateTime)));
            Columns.Add(CriarColuna("Data de Pagamento", COLUNA_DATA_PAGAMENTO, typeof(DateTime)));
        }

        public void Incluir(ContaPagar contaPagar)
        {
            Rows.Add(contaPagar.Id_conta_pagar, contaPagar.Id_fornecedor, contaPagar.Descricao, contaPagar.Valor_pago, contaPagar.Valor_pagamento, contaPagar.Data_lancamento, contaPagar.Data_vencimento, contaPagar.Data_pagamento);
        }

        public void Alterar(int indice, ContaPagar contaPagar)
        {
            Rows[indice][COLUNA_ID_CONTA_PAGAR] = contaPagar.Id_conta_pagar;
            Rows[indice][COLUNA_ID_FORNECEDOR] = contaPagar.Id_fornecedor;
            Rows[indice][COLUNA_DESCRICAO] = contaPagar.Descricao;
            Rows[indice][COLUNA_VALOR_PAGO] = contaPagar.Valor_pago;
            Rows[indice][COLUNA_VALOR_PAGAMENTO] = contaPagar.Valor_pagamento;
            Rows[indice][COLUNA_DATA_LANCAMENTO] = contaPagar.Data_lancamento;
            Rows[indice][COLUNA_DATA_VENCIMENTO] = contaPagar.Data_vencimento;
            Rows[indice][COLUNA_DATA_PAGAMENTO] = contaPagar.Data_pagamento;
        }

        public void Excluir(int indice)
        {
            Rows.RemoveAt(indice);
        }

        public ContaPagar ObterContaPagarNaLinhaSelecionada(int indiceLinha)
        {
            var contaPagar = new ContaPagar(
                Convert.ToInt32(Rows[indiceLinha][COLUNA_ID_FORNECEDOR]),
                Convert.ToDouble(Rows[indiceLinha][COLUNA_VALOR_PAGO]),
                Convert.ToDouble(Rows[indiceLinha][COLUNA_VALOR_PAGAMENTO]),
                Convert.ToDateTime(Rows[indiceLinha][COLUNA_DATA_LANCAMENTO]),
                Convert.ToDateTime(Rows[indiceLinha][COLUNA_DATA_VENCIMENTO]),
                Convert.ToDateTime(Rows[indiceLinha][COLUNA_DATA_PAGAMENTO])
            )
            {
                Id_conta_pagar = Convert.ToInt32(Rows[indiceLinha][COLUNA_ID_CONTA_PAGAR]),
                Descricao = Convert.ToString(Rows[indiceLinha][COLUNA_DESCRICAO])
            };

            return contaPagar;
        }
    }
}
