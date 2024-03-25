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

        public int GetLastId() {
            using var conn = new DbConnection();
            string query = "Select id_caixa from caixa order by id_caixa DESC LIMIT 1";
            return conn.Connection.QueryFirstOrDefault<int>(query);
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

        // Método para obter o saldo atual do caixa com o ID fornecido
        public double GetSaldo(int idCaixa) {
            using var conn = new DbConnection();
            string query = "SELECT saldo FROM caixa WHERE id_caixa = @IdCaixa";
            return conn.Connection.QueryFirstOrDefault<double>(query, new { IdCaixa = idCaixa });
        }

        // Método para atualizar o saldo do caixa com o ID fornecido
        public bool UpdateSaldo(int idCaixa, double novoSaldo) {
            using var conn = new DbConnection();
            string query = "UPDATE caixa SET saldo = @NovoSaldo WHERE id_caixa = @IdCaixa";
            int linhasAfetadas = conn.Connection.Execute(query, new { IdCaixa = idCaixa, NovoSaldo = novoSaldo });
            return linhasAfetadas > 0;
        }

    }
}
