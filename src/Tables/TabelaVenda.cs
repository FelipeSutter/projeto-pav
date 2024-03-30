using PDV.Entities;
using PDV.Enums;
using System.Data;

namespace PDV.Tabelas {
    public class TabelaVenda : DataTable {

        private const string COLUNA_ID_VENDA = "IdVenda";
        private const string COLUNA_DATA = "Data";
        private const string COLUNA_ID_CLIENTE = "ID cliente";
        private const string COLUNA_TOTAL_VENDA = "Total venda";
        private const string COLUNA_SITUACAO_VENDA = "Situacao Venda";


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
            Columns.Add(CriarColuna("IdVenda", COLUNA_ID_VENDA, typeof(int)));
            Columns.Add(CriarColuna("Data", COLUNA_DATA, typeof(string)));
            Columns.Add(CriarColuna("ID cliente", COLUNA_ID_CLIENTE, typeof(int)));
            Columns.Add(CriarColuna("Total venda", COLUNA_TOTAL_VENDA, typeof(double)));
            Columns.Add(CriarColuna("Situacao Venda", COLUNA_SITUACAO_VENDA, typeof(string)));
        }

        public void Incluir(Venda venda) {
            Rows.Add(venda.Id_venda, venda.Data_Hora, venda.Id_cliente, venda.Total_Venda, venda.Situacao_Venda);
        }

        public void Excluir(int indice) {
            Rows.RemoveAt(indice);
        }

        public Venda ObterVendaNaLinhaSelecionada(int indiceLinha) {
            var venda = new Venda {
                Id_venda = Convert.ToInt32(Rows[indiceLinha][COLUNA_ID_VENDA]),
                Data_Hora = Convert.ToDateTime(Rows[indiceLinha][COLUNA_DATA]),
                Id_cliente = Convert.ToInt32(Rows[indiceLinha][COLUNA_ID_CLIENTE]),
                Total_Venda = Convert.ToDouble(Rows[indiceLinha][COLUNA_TOTAL_VENDA]),
                Situacao_Venda = (EStatus) Enum.Parse(typeof(EStatus), Rows[indiceLinha][COLUNA_SITUACAO_VENDA].ToString())
            };

            return venda;
        }

    }
}
