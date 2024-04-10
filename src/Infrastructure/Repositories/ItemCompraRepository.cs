using Dapper;
using PDV.Entities;
using PDV.Infrastructure.Database;

namespace PDV.Infrastructure.Repositories
{
    public class ItemCompraRepository
    {
        public int Add(Compra compra, List<ItemCompra> itens, bool efetuarCompra)
        {
            using var conn = new DbConnection();

            // Insere a compra
            string insertCompraQuery = @"INSERT INTO compra (data_hora, total_compra, situacao_compra, id_fornecedor)
                            VALUES (@Data_Hora, @Total_Compra, @Situacao_Compra, @Id_fornecedor)
                            RETURNING id_compra;";

            int idCompra = conn.Connection.ExecuteScalar<int>(insertCompraQuery, compra);

            // Atualiza o estoque dos produtos e insere os itens da compra
            foreach (var item in itens)
            {
                if (efetuarCompra)
                {

                    // Atualiza o estoque do produto
                    string updateEstoqueQuery = @"UPDATE produto SET qtd_estoque = qtd_estoque + @Qtd_item WHERE id_produto = @Id_produto";
                    conn.Connection.Execute(updateEstoqueQuery, item);
                }

                // Insere o item da compra
                string insertItemCompraQuery = @"INSERT INTO itemcompra (id_produto, id_compra, qtd, valor_unitario, total_item)
                                    VALUES (@IdProduto, @IdCompra, @QtdItem, @ValorUnitario, @TotalItem)";
                conn.Connection.Execute(insertItemCompraQuery, new
                {
                    IdProduto = item.Id_produto,
                    IdCompra = idCompra,
                    QtdItem = item.Qtd_item,
                    ValorUnitario = item.Valor_unitario,
                    TotalItem = item.Total_item,
                });
            }

            return idCompra;
        }

        public List<ItemCompra> Get()
        {
            using var conn = new DbConnection();
            string query = @"
                SELECT ic.*, p.* 
                FROM itemcompra ic
                INNER JOIN produto p ON ic.id_produto = p.id_produto";
            var itensCompra = conn.Connection.Query<ItemCompra, Produto, ItemCompra>(
                query,
                (itemCompra, produto) => {
                    itemCompra.Produto = produto;
                    return itemCompra;
                },
                splitOn: "id_produto"
            );

            return itensCompra.ToList();
        }

        public List<ItemCompra> GetByCompraId(int idCompra)
        {
            using var conn = new DbConnection();
            string query = @"
select c.*, ic.*, p.*, v.*
FROM fornecedor c
INNER JOIN compra v ON 
c.id_fornecedor = v.id_fornecedor
INNER JOIN itemcompra ic ON 
v.id_compra = ic.id_compra
INNER JOIN produto p ON 
ic.id_produto = p.id_produto
WHERE v.id_compra = @IdCompra";

            var parameters = new { IdCompra = idCompra };

            var itensCompra = conn.Connection.Query<ItemCompra, Produto, Compra, Fornecedor, ItemCompra>(
                query,
                (itemCompra, produto, compra, fornecedor) => {
                    itemCompra.Produto = produto;
                    itemCompra.compra = compra;
                    itemCompra.compra.fornecedor = fornecedor;
                    return itemCompra;
                },
                splitOn: "id_produto, id_compra, id_fornecedor",
                param: parameters
            );

            return itensCompra.ToList();
        }

        public bool Update(ItemCompra item)
        {
            using var conn = new DbConnection();
            string query = @"UPDATE itemcompra
                             SET id_produto = @IdProduto,
                                 id_compra = @IdCompra,
                                 qtd_item = @QtdItem,
                                 valor_unitario = @ValorUnitario,
                                 total_item = @TotalItem
                             WHERE id_produto = @IdProduto AND id_compra = @IdCompra";

            var parameters = new
            {
                IdProduto = item.Id_produto,
                IdCompra = item.Id_compra,
                QtdItem = item.Qtd_item,
                ValorUnitario = item.Valor_unitario,
                TotalItem = item.Total_item
            };

            var result = conn.Connection.Execute(query, parameters);

            return result == 1;
        }

        public bool Delete(int idProduto, int idCompra)
        {
            using var conn = new DbConnection();
            string query = @"DELETE FROM itemcompra
                             WHERE id_produto = @Id_produto AND id_compra = @Id_compra";

            var parameters = new { Id_produto = idProduto, Id_compra = idCompra };

            var result = conn.Connection.Execute(query, parameters);

            return result > 0;
        }

        // Método para verificar se há estoque disponível para um produto
        private bool CheckEstoqueDisponivel(int produtoId, int qtdRequerida)
        {
            using var conn = new DbConnection();
            string query = @"SELECT qtd_estoque FROM produto WHERE id_produto = @id";
            var parameters = new { id = produtoId };
            var qtdEstoque = conn.Connection.ExecuteScalar<int>(query, parameters);
            return qtdEstoque >= qtdRequerida;
        }
    }
}