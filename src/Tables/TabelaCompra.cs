using PDV.Entities;
using PDV.Enums;
using PDV.Infrastructure.Repositories;
using System;
using System.Data;

namespace PDV.Tabelas
{
    public class TabelaCompra : DataTable
    {
        FornecedorRepository fornecedorRepository = new FornecedorRepository();

        private const string COLUNA_ID_COMPRA = "IdCompra";
        private const string COLUNA_DATA = "Data";
        private const string COLUNA_NOME_FORNECEDOR = "Nome Fornecedor";
        private const string COLUNA_TOTAL_COMPRA = "Total Compra";
        private const string COLUNA_SITUACAO_COMPRA = "Situacao Compra";

        public TabelaCompra()
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
            Columns.Add(CriarColuna("IdCompra", COLUNA_ID_COMPRA, typeof(int)));
            Columns.Add(CriarColuna("Data", COLUNA_DATA, typeof(string)));
            Columns.Add(CriarColuna("Nome Fornecedor", COLUNA_NOME_FORNECEDOR, typeof(string)));
            Columns.Add(CriarColuna("Total Compra", COLUNA_TOTAL_COMPRA, typeof(double)));
            Columns.Add(CriarColuna("Situacao Compra", COLUNA_SITUACAO_COMPRA, typeof(string)));
        }

        public void Incluir(Compra compra)
        {
            Fornecedor fornecedor = fornecedorRepository.GetByCompraId(compra.Id_compra);
            Rows.Add(compra.Id_compra, compra.Data_Hora, fornecedor.Nome, compra.Total_Compra, compra.Situacao_Compra);
        }

        public void Excluir(int indice)
        {
            Rows.RemoveAt(indice);
        }

        public Compra ObterCompraNaLinhaSelecionada(int indiceLinha)
        {
            var compra = new Compra
            {
                Id_compra = Convert.ToInt32(Rows[indiceLinha][COLUNA_ID_COMPRA]),
                Data_Hora = Convert.ToDateTime(Rows[indiceLinha][COLUNA_DATA]),
                Total_Compra = Convert.ToDouble(Rows[indiceLinha][COLUNA_TOTAL_COMPRA]),
                Situacao_Compra = (EStatus)Enum.Parse(typeof(EStatus), Rows[indiceLinha][COLUNA_SITUACAO_COMPRA].ToString())
            };

            compra.fornecedor = new Fornecedor
            {
                Nome = Rows[indiceLinha][COLUNA_NOME_FORNECEDOR].ToString(),
            };

            return compra;
        }
    }
}
