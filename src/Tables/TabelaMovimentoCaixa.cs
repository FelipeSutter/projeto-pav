using PDV.Entities;
using PDV.Enums;
using System.Data;

namespace PDV.Tabelas
{
    public class TabelaMovimentoCaixa : DataTable
    {
        private const string COLUNA_ID_CAIXA = "Id Caixa";
        private const string COLUNA_DESCRICAO = "Descrição";
        private const string COLUNA_VALOR = "Valor";
        private const string COLUNA_DATA_HORA = "Data/Hora";
        private const string COLUNA_TIPO_MOVIMENTO = "Tipo de Movimento";

        public TabelaMovimentoCaixa()
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
            Columns.Add(CriarColuna("Id Caixa", COLUNA_ID_CAIXA, typeof(int)));
            Columns.Add(CriarColuna("Descrição", COLUNA_DESCRICAO, typeof(string)));
            Columns.Add(CriarColuna("Valor", COLUNA_VALOR, typeof(double)));
            Columns.Add(CriarColuna("Data/Hora", COLUNA_DATA_HORA, typeof(DateTime)));
            Columns.Add(CriarColuna("Tipo de Movimento", COLUNA_TIPO_MOVIMENTO, typeof(ETipoMovimento)));
        }

        public void Incluir(MovimentoCaixa movimento)
        {
            Rows.Add(movimento.Id_caixa, movimento.Descricao, movimento.Valor,
                     movimento.DataHora, movimento.Tipo_movimento);
        }

        public void Alterar(int indice, MovimentoCaixa movimento)
        {
            Rows[indice][COLUNA_ID_CAIXA] = movimento.Id_caixa;
            Rows[indice][COLUNA_DESCRICAO] = movimento.Descricao;
            Rows[indice][COLUNA_VALOR] = movimento.Valor;
            Rows[indice][COLUNA_DATA_HORA] = movimento.DataHora;
            Rows[indice][COLUNA_TIPO_MOVIMENTO] = movimento.Tipo_movimento;
        }

        public void Excluir(int indice)
        {
            Rows.RemoveAt(indice);
        }

        public MovimentoCaixa ObterMovimentoNaLinhaSelecionada(int indiceLinha)
        {
            var movimento = new MovimentoCaixa
            {
                Id_caixa = Convert.ToInt32(Rows[indiceLinha][COLUNA_ID_CAIXA]),
                Descricao = Rows[indiceLinha][COLUNA_DESCRICAO].ToString(),
                Valor = Convert.ToDouble(Rows[indiceLinha][COLUNA_VALOR]),
                DataHora = Convert.ToDateTime(Rows[indiceLinha][COLUNA_DATA_HORA]),
                Tipo_movimento = (ETipoMovimento)Rows[indiceLinha][COLUNA_TIPO_MOVIMENTO]
            };

            return movimento;
        }
    }
}
