using PDV.Entities;
using System.Data;

namespace PDV.Tabelas {
    public class TabelaClassificacao : DataTable
    {
        private const string COLUNA_ID = "Id classificacao";
        private const string COLUNA_NOME = "Nome";
        

        public TabelaClassificacao()
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
            Columns.Add(CriarColuna("Id classificao", COLUNA_ID, typeof(string)));
            Columns.Add(CriarColuna("Nome", COLUNA_NOME, typeof(string)));
            
        }

        public void Incluir(Classificacao classificacao)
        {
            Rows.Add(classificacao.Id, classificacao.Nome);

        }

        public void Alterar(int indice, Classificacao classificacao)
        {
            Rows[indice][COLUNA_ID] = classificacao.Id;
            Rows[indice][COLUNA_NOME] = classificacao.Nome;
            
        }

        public void Excluir(int indice)
        {
            Rows.RemoveAt(indice);
        }
        

        public Classificacao ObterClassificacaoNaLinhaSelecionada(int indiceLinha)
        {
            var classificacao = new Classificacao
            {
                Id = Convert.ToInt32(Rows[indiceLinha][COLUNA_ID]),
                Nome = Rows[indiceLinha][COLUNA_NOME].ToString(),
                
            };

            return classificacao;
        }
    }
}
