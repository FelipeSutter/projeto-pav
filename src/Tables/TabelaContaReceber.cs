using PDV.Entities;
using PDV.Infrastructure.Repositories;
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

        private ClienteRepository repository = new ClienteRepository();

        private const string COLUNA_ID_CONTA_RECEBER = "IdContaReceber";
        private const string COLUNA_NOME_CLIENTE = "NomeCliente";
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
            Columns.Add(CriarColuna("Nome Cliente", COLUNA_NOME_CLIENTE, typeof(string)));
            Columns.Add(CriarColuna("Valor Recebido", COLUNA_VALOR_RECEBIDO, typeof(double)));
            Columns.Add(CriarColuna("Valor Estimado", COLUNA_VALOR_ESTIMADO, typeof(double)));
            Columns.Add(CriarColuna("Data de Lançamento", COLUNA_DATA_LANCAMENTO, typeof(DateTime)));
            Columns.Add(CriarColuna("Data de Vencimento", COLUNA_DATA_VENCIMENTO, typeof(DateTime)));
            Columns.Add(CriarColuna("Data de Recebimento", COLUNA_DATA_RECEBIMENTO, typeof(DateTime)));
        }

        public void Incluir(ContaReceber contaReceber)
        {
            Cliente cliente = repository.GetByContaReceberId(contaReceber.Id_conta_receber);
            Rows.Add(contaReceber.Id_conta_receber, cliente.Nome, contaReceber.Valor_recebido, contaReceber.Valor_estimado, contaReceber.Data_lancamento, contaReceber.Data_vencimento, contaReceber.Data_recebimento);
        }

        public void Alterar(int indice, ContaReceber contaReceber)
        {
            Rows[indice][COLUNA_ID_CONTA_RECEBER] = contaReceber.Id_conta_receber;
            Rows[indice][COLUNA_NOME_CLIENTE] = contaReceber.Id_cliente;
            Rows[indice][COLUNA_VALOR_RECEBIDO] = contaReceber.Valor_recebido;
            Rows[indice][COLUNA_VALOR_ESTIMADO] = contaReceber.Valor_estimado;
            Rows[indice][COLUNA_DATA_LANCAMENTO] = contaReceber.Data_lancamento;
            Rows[indice][COLUNA_DATA_VENCIMENTO] = contaReceber.Data_vencimento;
            Rows[indice][COLUNA_DATA_RECEBIMENTO] = contaReceber.Data_recebimento;
        }

        public void Excluir(int indice)
        {
            Rows.RemoveAt(indice);
        }

        public ContaReceber ObterContaReceberNaLinhaSelecionada(int indiceLinha)
        {
            var contaReceber = new ContaReceber(
                Convert.ToInt32(Rows[indiceLinha][COLUNA_NOME_CLIENTE]),
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
