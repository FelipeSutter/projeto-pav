using Dapper;
using PDV.Entities;
using PDV.Infrastructure.Database;

namespace PDV.Infrastructure.Repositories {
    public class MovimentoCaixaRepository {
        public bool Add(MovimentoCaixa movimentoCaixa) {
            using var conn = new DbConnection();
            string query = @"INSERT INTO public.movimentocaixa(id_caixa, data_hora_movimento, descricao, valor, tipo_movimento)
                             VALUES (@Id_caixa, @DataHora, @Descricao, @Valor, @Tipo_movimento)";

            var parameters = new {
                movimentoCaixa.Id_caixa,
                DataHora = movimentoCaixa.Data_hora_movimento,
                movimentoCaixa.Descricao,
                movimentoCaixa.Valor,
                movimentoCaixa.Tipo_movimento
            };

            var result = conn.Connection.Execute(query, parameters);

            return result == 1;
        }

        public List<MovimentoCaixa> GetMovimentosByCaixa(int idCaixa) {
            using var conn = new DbConnection();
            string query = @"SELECT * FROM movimentocaixa WHERE id_caixa = @Id_caixa";

            var movimentos = conn.Connection.Query<MovimentoCaixa>(query, new { Id_caixa = idCaixa });

            return movimentos.ToList();
        }
        public List<MovimentoCaixa> Get()
        {
            using var conn = new DbConnection();
            string query = @"SELECT * FROM movimentocaixa";
            var movimentos = conn.Connection.Query<MovimentoCaixa>(query);
            return movimentos.ToList();
        }
        public MovimentoCaixa GetMovimentoById(int idMovimento) {
            using var conn = new DbConnection();
            string query = "SELECT * FROM movimentocaixa WHERE id_movimento = @Id_movimento";
            var parameters = new { Id_movimento = idMovimento };
            return conn.Connection.QueryFirstOrDefault<MovimentoCaixa>(query, parameters);
        }



        public bool Delete(int idMovimento) {
            using var conn = new DbConnection();
            string query = @"DELETE FROM public.movimentocaixa
                             WHERE id_movimento = @id";

            var parameters = new { id = idMovimento };

            var result = conn.Connection.Execute(query, parameters);

            return result > 0;
        }

        public bool Update(MovimentoCaixa movimentoCaixa, int idMovimento) {
            using var conn = new DbConnection();
            string query = @"UPDATE public.movimentocaixa
                             SET id_caixa = @Id_caixa,
                                 descricao = @Descricao,
                                 valor = @Valor,
                                 tipo_movimento = @Tipo_movimento
                             WHERE id_movimento = @Id_movimento";

            var parameters = new {
                movimentoCaixa.Id_caixa,
                movimentoCaixa.Descricao,
                movimentoCaixa.Valor,
                movimentoCaixa.Tipo_movimento,
                idMovimento,
            };

            var result = conn.Connection.Execute(query, parameters);

            return result == 1;
        }
    }
}
