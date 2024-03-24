using Dapper;
using PDV.Entities;
using PDV.Infrastructure.Database;

namespace PDV.Infrastructure.Repositories {
    public class VendaRepository {
        public bool Add(Venda venda) {
            using var conn = new DbConnection();
            string query = @"INSERT INTO public.venda(
        data_hora, total_venda, situacao_venda, id_cliente)
        VALUES (@dataHora, @totalVenda, @situacaoVenda, @idCliente)";

            var parameters = new {
                dataHora = venda.Data_Hora,
                totalVenda = venda.Total_Venda,
                situacaoVenda = venda.Situacao_Venda,
                idCliente = venda.Id_cliente
            };

            var result = conn.Connection.Execute(query, parameters);

            return result == 1;
        }

        public List<Venda> Get() {
            using var conn = new DbConnection();
            string query = @"SELECT * FROM venda";
            var vendas = conn.Connection.Query<Venda>(query);
            return vendas.ToList();
        }

        // Método para verificar se o cliente existe no banco de dados
        private bool CheckClienteExists(int clienteId) {
            using var conn = new DbConnection();
            string query = @"SELECT COUNT(*) FROM cliente WHERE id_cliente = @id";
            var parameters = new { id = clienteId };
            var count = conn.Connection.ExecuteScalar<int>(query, parameters);
            return count > 0;
        }

        // Método para verificar se há estoque disponível para um produto
        private bool CheckEstoqueDisponivel(int produtoId, int qtdRequerida) {
            using var conn = new DbConnection();
            string query = @"SELECT qtd_estoque FROM produto WHERE id_produto = @id";
            var parameters = new { id = produtoId };
            var qtdEstoque = conn.Connection.ExecuteScalar<int>(query, parameters);
            return qtdEstoque >= qtdRequerida;
        }
    }
}
