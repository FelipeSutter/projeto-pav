using Dapper;
using PDV.Entities;
using PDV.Infrastructure.Database;

namespace PDV.Infrastructure.Repositories {
    public class ItemVendaRepository {
        public int Add(Venda venda, List<ItemVenda> itens, bool efetuarVenda) {
            using var conn = new DbConnection();

            // Insere a venda
            string insertVendaQuery = @"INSERT INTO venda (data_hora, total_venda, situacao_venda, id_cliente)
                            VALUES (@Data_Hora, @Total_Venda, @Situacao_Venda, @Id_cliente)
                            RETURNING id_venda;";

            int idVenda = conn.Connection.ExecuteScalar<int>(insertVendaQuery, venda);

            // Atualiza o estoque dos produtos e insere os itens da venda
            foreach (var item in itens) {
                if (efetuarVenda) {
                    // Verifica se há estoque disponível
                    if (!CheckEstoqueDisponivel(item.IdProduto, item.QtdItem)) {
                        MessageBox.Show("Não há estoque suficiente para o produto " + item.Produto.Nome, "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return -1; // Retorna um valor inválido em caso de erro
                    }

                    // Atualiza o estoque do produto
                    string updateEstoqueQuery = @"UPDATE produto SET qtd_estoque = qtd_estoque - @QtdItem WHERE id_produto = @IdProduto";
                    conn.Connection.Execute(updateEstoqueQuery, item);
                }

                // Insere o item da venda
                string insertItemVendaQuery = @"INSERT INTO itemvenda (id_produto, id_venda, qtd_item, valor_unitario, total_item)
                                    VALUES (@IdProduto, @IdVenda, @QtdItem, @ValorUnitario, @TotalItem)";
                conn.Connection.Execute(insertItemVendaQuery, new {
                    item.IdProduto,
                    IdVenda = idVenda,
                    item.QtdItem,
                    ValorUnitario = item.Produto.Preco / double.Parse(item.Produto.Unidade),
                    TotalItem = item.Produto.Preco * item.QtdItem,
                });
            }

            return idVenda;
        }


        public List<ItemVenda> Get() {
            using var conn = new DbConnection();
            string query = @"
                SELECT iv.*, p.* 
                FROM itemvenda iv
                INNER JOIN produto p ON iv.id_produto = p.id_produto";
            var itensVenda = conn.Connection.Query<ItemVenda, Produto, ItemVenda>(
                query,
                (itemVenda, produto) => {
                    itemVenda.Produto = produto;
                    return itemVenda;
                },
                splitOn: "id_produto"
            );

            return itensVenda.ToList();
        }


        public List<ItemVenda> GetByVendaId(int idVenda) {
            using var conn = new DbConnection();
            string query = @"
                SELECT iv.*, p.*, v.*, c.*
                FROM itemvenda iv
                INNER JOIN produto p ON iv.id_produto = p.id_produto
                INNER JOIN venda v ON iv.id_venda = v.id_venda
                INNER JOIN cliente c ON v.id_cliente = c.id_cliente
                WHERE iv.id_venda = @IdVenda";

            var parameters = new { IdVenda = idVenda };

            var itensVenda = conn.Connection.Query<ItemVenda, Produto, Venda, Cliente, ItemVenda>(
                query,
                (itemVenda, produto, venda, cliente) => {
                    itemVenda.Produto = produto;
                    itemVenda.Venda = venda;
                    itemVenda.Venda.Cliente = cliente;
                    return itemVenda;
                },
                splitOn: "id_produto, id_venda, id_cliente",
                param: parameters
            );

            return itensVenda.ToList();
        }


        public bool Update(ItemVenda item) {
            using var conn = new DbConnection();
            string query = @"UPDATE itemvenda
                             SET id_produto = @IdProduto,
                                 id_venda = @IdVenda,
                                 qtd_item = @QtdItem,
                                 valor_unitario = @ValorUnitario,
                                 total_item = @TotalItem
                             WHERE id_produto = @IdProduto AND id_venda = @IdVenda";

            var parameters = new {
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
            string query = @"DELETE FROM itemvenda
                             WHERE id_produto = @IdProduto AND id_venda = @IdVenda";

            var parameters = new { IdProduto = idProduto, IdVenda = idVenda };

            var result = conn.Connection.Execute(query, parameters);

            return result > 0;
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
