using PDV.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV.Tables
{
    public class TabelaContaReceber : DataTable
    {

        private const string COLUNA_ID_CONTA_RECEBER = "IdContaReceber";
        private const string COLUNA_ID_CLIENTE = "IdCliente";
        private const string COLUNA_VALOR_RECEBIDO = "ValorRecebido";
        private const string COLUNA_VALOR_ESTIMADO = "ValorEstimado";
        private const string COLUNA_DATA_LANCAMENTO = "DataLancamento";
        private const string COLUNA_DATA_VENCIMENTO = "DataVencimento";
        private const string COLUNA_DATA_RECEBIMENTO = "DataRecebimento";

        public TabelaContaReceber()
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
            Columns.Add(CriarColuna("ID Conta Receber", COLUNA_ID_CONTA_RECEBER, typeof(int)));
            Columns.Add(CriarColuna("ID Cliente", COLUNA_ID_CLIENTE, typeof(int)));
            Columns.Add(CriarColuna("Valor Recebido", COLUNA_VALOR_RECEBIDO, typeof(double)));
            Columns.Add(CriarColuna("Valor Estimado", COLUNA_VALOR_ESTIMADO, typeof(double)));
            Columns.Add(CriarColuna("Data de Lançamento", COLUNA_DATA_LANCAMENTO, typeof(DateTime)));
            Columns.Add(CriarColuna("Data de Vencimento", COLUNA_DATA_VENCIMENTO, typeof(DateTime)));
            Columns.Add(CriarColuna("Data de Recebimento", COLUNA_DATA_RECEBIMENTO, typeof(DateTime)));
        }

        public void Incluir(ContaReceber contaReceber)
        {
            Rows.Add(contaReceber.Id_conta_receber, contaReceber.Id_cliente, contaReceber.Valor_Recebido, contaReceber.Valor_Estimado, contaReceber.Data_Lancamento, contaReceber.Data_Vencimento, contaReceber.Data_Recebimento);
        }

        public void Alterar(int indice, ContaReceber contaReceber)
        {
            Rows[indice][COLUNA_ID_CONTA_RECEBER] = contaReceber.Id_conta_receber;
            Rows[indice][COLUNA_ID_CLIENTE] = contaReceber.Id_cliente;
            Rows[indice][COLUNA_VALOR_RECEBIDO] = contaReceber.Valor_Recebido;
            Rows[indice][COLUNA_VALOR_ESTIMADO] = contaReceber.Valor_Estimado;
            Rows[indice][COLUNA_DATA_LANCAMENTO] = contaReceber.Data_Lancamento;
            Rows[indice][COLUNA_DATA_VENCIMENTO] = contaReceber.Data_Vencimento;
            Rows[indice][COLUNA_DATA_RECEBIMENTO] = contaReceber.Data_Recebimento;
        }

        public void Excluir(int indice)
        {
            Rows.RemoveAt(indice);
        }

        public ContaReceber ObterContaReceberNaLinhaSelecionada(int indiceLinha)
        {
            var contaReceber = new ContaReceber(
                Convert.ToInt32(Rows[indiceLinha][COLUNA_ID_CLIENTE]),
                Convert.ToDouble(Rows[indiceLinha][COLUNA_VALOR_RECEBIDO]),
                Convert.ToDouble(Rows[indiceLinha][COLUNA_VALOR_ESTIMADO]),
                Convert.ToDateTime(Rows[indiceLinha][COLUNA_DATA_LANCAMENTO]),
                Convert.ToDateTime(Rows[indiceLinha][COLUNA_DATA_VENCIMENTO]),
                Convert.ToDateTime(Rows[indiceLinha][COLUNA_DATA_RECEBIMENTO])
            )
            {
                Id_conta_receber = Convert.ToInt32(Rows[indiceLinha][COLUNA_ID_CONTA_RECEBER]),
            };

            return contaReceber;
        }
    }
}
