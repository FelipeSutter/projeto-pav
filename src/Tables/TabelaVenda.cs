using PDV.Entities;
using PDV.Enums;
using System;
using System.Data;

namespace PDV.Tabelas {
    public class TabelaVenda : DataTable {

        private const string COLUNA_ID_VENDA = "Id Venda";
        private const string COLUNA_DATA_HORA = "Data e Hora";
        private const string COLUNA_TOTAL_VENDA = "Total da Venda";
        private const string COLUNA_SITUACAO = "Situação da Venda";
        private const string COLUNA_ID_CLIENTE = "Id Cliente";

        public TabelaVenda() {
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
            Columns.Add(CriarColuna("Id Venda", COLUNA_ID_VENDA, typeof(int)));
            Columns.Add(CriarColuna("Data e Hora", COLUNA_DATA_HORA, typeof(DateTime)));
            Columns.Add(CriarColuna("Total da Venda", COLUNA_TOTAL_VENDA, typeof(double)));
            Columns.Add(CriarColuna("Situação da Venda", COLUNA_SITUACAO, typeof(EStatus)));
            Columns.Add(CriarColuna("Id Cliente", COLUNA_ID_CLIENTE, typeof(int)));
        }

        public void Incluir(Venda venda) {
            Rows.Add(venda.Id_venda, venda.DataHora, venda.TotalVenda, venda.SituacaoVenda, venda.Id_cliente);
        }

        public void Alterar(int indice, Venda venda) {
            Rows[indice][COLUNA_ID_VENDA] = venda.Id_venda;
            Rows[indice][COLUNA_DATA_HORA] = venda.DataHora;
            Rows[indice][COLUNA_TOTAL_VENDA] = venda.TotalVenda;
            Rows[indice][COLUNA_SITUACAO] = venda.SituacaoVenda;
            Rows[indice][COLUNA_ID_CLIENTE] = venda.Id_cliente;
        }

        public void Excluir(int indice) {
            Rows.RemoveAt(indice);
        }

        public Venda ObterVendaNaLinhaSelecionada(int indiceLinha) {
            var venda = new Venda {
                Id_venda = Convert.ToInt32(Rows[indiceLinha][COLUNA_ID_VENDA]),
                DataHora = Convert.ToDateTime(Rows[indiceLinha][COLUNA_DATA_HORA]),
                TotalVenda = Convert.ToDouble(Rows[indiceLinha][COLUNA_TOTAL_VENDA]),
                SituacaoVenda = (EStatus) Rows[indiceLinha][COLUNA_SITUACAO],
                Id_cliente = Convert.ToInt32(Rows[indiceLinha][COLUNA_ID_CLIENTE])
            };

            return venda;
        }

    }
}
