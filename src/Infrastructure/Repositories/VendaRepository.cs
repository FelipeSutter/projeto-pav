using Dapper;
using PDV.Entities;
using PDV.Infrastructure.Database;

namespace PDV.Infrastructure.Repositories {
    public class VendaRepository {
        public bool Add(Venda venda) {
            using var conn = new DbConnection();
            string query = @"INSERT INTO venda (data_hora, total_venda, situacao_venda, id_cliente)
                             VALUES (@DataHora, @TotalVenda, @SituacaoVenda, @IdCliente)";

            var parameters = new {
                DataHora = venda.DataHora,
                TotalVenda = venda.TotalVenda,
                SituacaoVenda = venda.SituacaoVenda,
                IdCliente = venda.Id_cliente
            };

            try {
                var result = conn.Connection.Execute(query, parameters);
                return result == 1;
            } catch (Exception ex) {
                MessageBox.Show($"Erro ao adicionar venda: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public List<Venda> Get(DateTime dataInicio, DateTime dataFim) {
            using var conn = new DbConnection();
            string query = @"SELECT * FROM venda WHERE data_hora BETWEEN @DataInicio AND @DataFim";

            var parameters = new { DataInicio = dataInicio, DataFim = dataFim };

            var vendas = conn.Connection.Query<Venda>(query, parameters);
            return vendas.ToList();
        }

        public bool Delete(int vendaId) {
            using var conn = new DbConnection();
            string query = @"DELETE FROM venda WHERE id_venda = @IdVenda";

            var parameters = new { IdVenda = vendaId };

            try {
                var result = conn.Connection.Execute(query, parameters);
                return result > 0;
            } catch (Exception ex) {
                MessageBox.Show($"Erro ao excluir venda: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool Update(Venda venda) {
            using var conn = new DbConnection();
            string query = @"UPDATE venda
                             SET total_venda = @TotalVenda,
                                 situacao_venda = @SituacaoVenda,
                                 id_cliente = @IdCliente
                             WHERE id_venda = @IdVenda";

            var parameters = new {
                TotalVenda = venda.TotalVenda,
                SituacaoVenda = venda.SituacaoVenda,
                IdCliente = venda.Id_cliente,
                IdVenda = venda.Id_venda
            };

            try {
                var result = conn.Connection.Execute(query, parameters);
                return result == 1;
            } catch (Exception ex) {
                MessageBox.Show($"Erro ao atualizar venda: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

    }
}