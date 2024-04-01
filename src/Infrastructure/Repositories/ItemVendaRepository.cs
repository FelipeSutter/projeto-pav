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
                    if (!CheckEstoqueDisponivel(item.Id_produto, item.Qtd_item)) {
                        MessageBox.Show("Não há estoque suficiente para o produto " + item.Produto.Nome, "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return -1; // Retorna um valor inválido em caso de erro
                    }

                    // Atualiza o estoque do produto
                    string updateEstoqueQuery = @"UPDATE produto SET qtd_estoque = qtd_estoque - @Qtd_item WHERE id_produto = @Id_produto";
                    conn.Connection.Execute(updateEstoqueQuery, item);
                }

                // Insere o item da venda
                string insertItemVendaQuery = @"INSERT INTO itemvenda (id_produto, id_venda, qtd_item, valor_unitario, total_item)
                                    VALUES (@IdProduto, @IdVenda, @QtdItem, @ValorUnitario, @TotalItem)";
                conn.Connection.Execute(insertItemVendaQuery, new {
                    IdProduto = item.Id_produto,
                    IdVenda = idVenda,
                    QtdItem = item.Qtd_item,
                    ValorUnitario = item.Produto.Preco / double.Parse(item.Produto.Unidade),
                    TotalItem = item.Produto.Preco * item.Qtd_item,
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
select c.*, iv.*, p.*, v.*
FROM cliente c
INNER JOIN venda v ON 
c.id_cliente = v.id_cliente
INNER JOIN itemvenda iv ON 
v.id_venda = iv.id_venda
INNER JOIN produto p ON 
iv.id_produto = p.id_produto
WHERE v.id_venda = @IdVenda";

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
                IdProduto = item.Id_produto,
                IdVenda = item.Id_venda,
                QtdItem = item.Qtd_item,
                ValorUnitario = item.Produto.Preco / double.Parse(item.Produto.Unidade),
                TotalItem = item.Produto.Preco
            };

            var result = conn.Connection.Execute(query, parameters);

            return result == 1;
        }

        public bool Delete(int idProduto, int idVenda) {
            using var conn = new DbConnection();
            string query = @"DELETE FROM itemvenda
                             WHERE id_produto = @Id_produto AND id_venda = @Id_venda";

            var parameters = new { Id_produto = idProduto, Id_venda = idVenda };

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
