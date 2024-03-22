using Dapper;
using PDV.Entities;
using PDV.Infrastructure.Database;

namespace PDV.Infrastructure.Repositories {
    public class ItemVendaRepository {
        public bool EfetuarVenda(Venda venda, List<ItemVenda> itens) {
            // Verifica se o cliente existe no banco de dados
            if (!CheckClienteExists(venda.Id_cliente)) {
                MessageBox.Show("Cliente não existe no banco de dados!", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            using var conn = new DbConnection();
            conn.Connection.Open();
            using var transaction = conn.Connection.BeginTransaction();

            try {
                // Insere a venda
                string insertVendaQuery = @"INSERT INTO venda (data_hora, total_venda, situacao_venda, id_cliente)
                                            VALUES (@DataHora, @TotalVenda, @SituacaoVenda, @Id_cliente);
                                            SELECT LASTVAL();";

                int idVenda = conn.Connection.Query<int>(insertVendaQuery, venda, transaction).FirstOrDefault();

                // Atualiza o estoque dos produtos e insere os itens da venda
                foreach (var item in itens) {
                    // Verifica se há estoque disponível
                    if (!CheckEstoqueDisponivel(item.IdProduto, item.QtdItem)) {
                        transaction.Rollback();
                        MessageBox.Show("Não há estoque suficiente para o produto " + item.Produto.Nome, "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                    // Atualiza o estoque do produto
                    string updateEstoqueQuery = @"UPDATE produto SET qtd_estoque = qtd_estoque - @QtdItem WHERE id_produto = @IdProduto";
                    conn.Connection.Execute(updateEstoqueQuery, item, transaction);

                    // Insere o item da venda
                    string insertItemVendaQuery = @"INSERT INTO item_venda (id_produto, id_venda, qtd_item, valor_unitario, total_item)
                                                    VALUES (@IdProduto, @IdVenda, @QtdItem, @ValorUnitario, @TotalItem)";
                    conn.Connection.Execute(insertItemVendaQuery, new {
                        item.IdProduto,
                        IdVenda = idVenda,
                        item.QtdItem,
                        ValorUnitario = item.Produto.Preco / double.Parse(item.Produto.Unidade),
                        TotalItem = item.Produto.Preco,
                    }, transaction);
                }

                transaction.Commit();
                return true;
            } catch (Exception ex) {
                transaction.Rollback();
                MessageBox.Show("Erro ao efetuar a venda: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public List<ItemVenda> Get() {
            using var conn = new DbConnection();
            string query = @"SELECT * FROM item_venda";

            var itensVenda = conn.Connection.Query<ItemVenda>(query);

            return itensVenda.ToList();
        }

        public bool Update(ItemVenda item) {
            using var conn = new DbConnection();
            string query = @"UPDATE item_venda
                             SET id_produto = @IdProduto,
                                 id_venda = @IdVenda,
                                 qtd_item = @QtdItem,
                                 valor_unitario = @ValorUnitario,
                                 total_item = @TotalItem
                             WHERE id_produto = @IdProduto AND id_venda = @IdVenda";

            var parameters = new 
            {
                item.IdProduto,
                item.IdVenda,
                item.QtdItem,
                ValorUnitario = item.Produto.Preco / double.Parse(item.Produto.Unidade),
                TotalItem = item.Produto.Preco
            };

            var result = conn.Connection.Execute(query, parameters);

            return result == 1;
        }

        public bool Delete(int idProduto, int idVenda) {
            using var conn = new DbConnection();
            string query = @"DELETE FROM item_venda
                             WHERE id_produto = @IdProduto AND id_venda = @IdVenda";

            var parameters = new { IdProduto = idProduto, IdVenda = idVenda };

            var result = conn.Connection.Execute(query, parameters);

            return result > 0;
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
