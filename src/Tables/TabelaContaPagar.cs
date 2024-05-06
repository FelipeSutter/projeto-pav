using PDV.Entities;
using PDV.Infrastructure.Repositories;
using System;
using System.Data;

namespace PDV.Tables
{
    public class TabelaContaPagar : DataTable
    {
        FornecedorRepository repository = new FornecedorRepository();

        private const string COLUNA_ID_CONTA_PAGAR = "IdContaPagar";
        private const string COLUNA_NOME_FORNECEDOR = "NomeFornecedor";
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
            Columns.Add(CriarColuna("Nome Fornecedor", COLUNA_NOME_FORNECEDOR, typeof(string)));
            Columns.Add(CriarColuna("Descrição", COLUNA_DESCRICAO, typeof(string)));
            Columns.Add(CriarColuna("Valor Pago", COLUNA_VALOR_PAGO, typeof(double)));
            Columns.Add(CriarColuna("Valor Pagamento", COLUNA_VALOR_PAGAMENTO, typeof(double)));
            Columns.Add(CriarColuna("Data de Lançamento", COLUNA_DATA_LANCAMENTO, typeof(DateTime)));
            Columns.Add(CriarColuna("Data de Vencimento", COLUNA_DATA_VENCIMENTO, typeof(DateTime)));
            Columns.Add(CriarColuna("Data de Pagamento", COLUNA_DATA_PAGAMENTO, typeof(DateTime)));
        }

        public void Incluir(ContaPagar contaPagar)
        {
            Fornecedor fornecedor = repository.GetByContaPagarId(contaPagar.Id_conta_pagar);
            Rows.Add(contaPagar.Id_conta_pagar, fornecedor.Nome, contaPagar.Descricao, contaPagar.Valor_pago, contaPagar.Valor_pagamento, contaPagar.Data_lancamento, contaPagar.Data_vencimento, contaPagar.Data_pagamento);
        }

        public void Alterar(int indice, ContaPagar contaPagar)
        {
            Rows[indice][COLUNA_ID_CONTA_PAGAR] = contaPagar.Id_conta_pagar;
            Rows[indice][COLUNA_NOME_FORNECEDOR] = contaPagar.Id_fornecedor;
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
            ContaPagar contaPagar = new ContaPagar
            {
                Id_conta_pagar = Convert.ToInt32(Rows[indiceLinha][COLUNA_ID_CONTA_PAGAR]),
                Valor_pago = Convert.ToDouble(Rows[indiceLinha][COLUNA_VALOR_PAGO]),
                Descricao = Rows[indiceLinha][COLUNA_DESCRICAO].ToString(),
                Valor_pagamento = Convert.ToDouble(Rows[indiceLinha][COLUNA_VALOR_PAGAMENTO]),
                Data_lancamento = Convert.ToDateTime(Rows[indiceLinha][COLUNA_DATA_LANCAMENTO]),
                Data_vencimento = Convert.ToDateTime(Rows[indiceLinha][COLUNA_DATA_VENCIMENTO]),
                Data_pagamento = Convert.ToDateTime(Rows[indiceLinha][COLUNA_DATA_PAGAMENTO]),
            };

            int idFornecedor;
            if (int.TryParse(Rows[indiceLinha][COLUNA_NOME_FORNECEDOR].ToString(), out idFornecedor))
            {
                contaPagar.Id_fornecedor = idFornecedor;
            }
            else
            {
                // Lidar com o caso em que o ID do fornecedor não é um número
                // Por exemplo, mostrar uma mensagem de erro ou definir um valor padrão
                // Aqui estou definindo como -1 para indicar que o ID do fornecedor não está disponível
                contaPagar.Id_fornecedor = -1;
            }

            return contaPagar;
        }

    }
}
