using Dapper;
using PDV.Entities;

namespace PDV.Infrastructure.Repositories {
    public class ClassificacaoRepository
    {
        public bool Add(Classificacao classificacao)
        {
            using var conn = new DbConnection();
            string query = @"INSERT INTO public.classificacao(
        nome)
        VALUES (@nome)";

            var parameters = new
            {
                nome = classificacao.Nome,
            };

            var result = conn.Connection.Execute(query, parameters);

            return result == 1;
        }

        public List<Classificacao> Get()
        {
            using var conn = new DbConnection();
            string query = @"SELECT * FROM classificacao;";

            var classificacoes = conn.Connection.Query<Classificacao>(sql: query);

            return classificacoes.ToList();
        }

        public bool Delete(int classificacaoId)
        {
            using var conn = new DbConnection();
            string query = @"DELETE FROM public.classificacao
                     WHERE id_classificacao = @id";

            var parameters = new { id = classificacaoId };

            var result = conn.Connection.Execute(query, parameters);

            return result > 0;
        }

        public bool Update(Classificacao classificacao)
        {
            using var conn = new DbConnection();
            string query = @"UPDATE public.classificacao
                    SET nome = @nome
                    WHERE id_classificacao = @id";

            var parameters = new
            {
                id = classificacao.Id,
                nome = classificacao.Nome,

            };

            var result = conn.Connection.Execute(query, parameters);

            return result == 1;
        }
    }
}
