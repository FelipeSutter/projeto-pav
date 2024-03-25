using Dapper;
using PDV.Entities;
using PDV.Infrastructure.Database;

namespace PDV.Infrastructure.Repositories {
    public class CaixaRepository {
        public bool Add(Caixa caixa) {
            using var conn = new DbConnection();
            string query = @"INSERT INTO public.caixa(saldo)
                             VALUES (@saldo)";

            var parameters = new {
                saldo = caixa.Saldo
            };

            var result = conn.Connection.Execute(query, parameters);

            return result == 1;
        }

        public List<Caixa> Get() {
            using var conn = new DbConnection();
            string query = @"SELECT * FROM caixa";

            var caixas = conn.Connection.Query<Caixa>(query);

            return caixas.ToList();
        }

        public Caixa GetCaixaById(int id) {
            using var conn = new DbConnection();
            string query = "SELECT * FROM caixa WHERE id_caixa = @Id";
            var parameters = new { Id = id };
            return conn.Connection.QueryFirstOrDefault<Caixa>(query, parameters);
        }

        public bool Delete(int caixaId) {
            using var conn = new DbConnection();
            string query = @"DELETE FROM public.caixa
                             WHERE id_caixa = @id";

            var parameters = new { id = caixaId };

            var result = conn.Connection.Execute(query, parameters);

            return result > 0;
        }

        public bool Update(Caixa caixa) {
            using var conn = new DbConnection();
            string query = @"UPDATE public.caixa
                             SET saldo = @saldo
                             WHERE id_caixa = @id";

            var parameters = new {
                id = caixa.Id_caixa,
                saldo = caixa.Saldo
            };

            var result = conn.Connection.Execute(query, parameters);

            return result == 1;
        }
    }
}
