using Dapper;
using PDV.Entities;
using PDV.Infrastructure.Database;

namespace PDV.Infrastructure.Repositories {
    public class ProdutoRepository
    {

        public bool Add(Produto produto)
        {
            using var conn = new DbConnection();
            string query = @"INSERT INTO public.produto(
        nome, qtd_estoque, preco, unidade, id_fornecedor, id_classificacao)
        VALUES (@nome, @qtd_estoque, @preco, @unidade, @id_fornecedor, @id_classificacao)";

            var parameters = new
            {
                nome = produto.Nome,
                qtd_estoque = produto.Qtd_estoque,
                preco = produto.Preco,
                unidade = produto.Unidade,
                id_fornecedor = produto.Id_fornecedor,
                id_classificacao = produto.Id_classificacao,
            };

            var result = conn.Connection.Execute(query, parameters);

            return result == 1;
        }

        public List<Produto> Get()
        {
            using var conn = new DbConnection();
            string query = @"SELECT * FROM produto;";

            var produtos = conn.Connection.Query<Produto>(sql: query);

            return produtos.ToList();
        }

        public bool Delete(int produtoId)
        {
            using var conn = new DbConnection();
            string query = @"DELETE FROM public.produto
                     WHERE id_produto = @id";

            var parameters = new { id = produtoId };

            var result = conn.Connection.Execute(query, parameters);

            return result > 0;
        }

        public bool Update(Produto produto)
        {
            using var conn = new DbConnection();
            string query = @"UPDATE public.fornecedor
                    SET nome = @nome,
                        qtd_estoque = @qtd_estoque,
                        preco = @preco,
                        unidade = @unidade,
                        id_fornecedor = @id_fornecedor
                        id_classificacao = @id_classificacao
                    WHERE id_produto = @id";

            var parameters = new {
                nome = produto.Nome,
                qtd_estoque = produto.Qtd_estoque,
                preco = produto.Preco,
                unidade = produto.Unidade,
                id_fornecedor = produto.Id_fornecedor,
                id_classificacao = produto.Id_classificacao,
            };

            var result = conn.Connection.Execute(query, parameters);

            return result == 1;
        }



    }
}
