using Dapper;
using PDV.Entities;
using PDV.Infrastructure.Database;

namespace PDV.Infrastructure.Repositories {
    public class ProdutoRepository
    {

        public bool Add(Produto produto)
        {
            // Verifica se o fornecedor e a classificação existem antes de inserir o produto
            if (!CheckFornecedorExists(produto.Id_fornecedor) || !CheckClassificacaoExists(produto.Id_classificacao))
            {
                MessageBox.Show("Fornecedor ou classificação não existem no banco de dados!", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

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
            // Verifica se o fornecedor e a classificação existem antes de inserir o produto
            if (!CheckFornecedorExists(produto.Id_fornecedor) || !CheckClassificacaoExists(produto.Id_classificacao))
            {
                MessageBox.Show("Fornecedor ou classificação não existem no banco de dados!", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            using var conn = new DbConnection();
            string query = @"UPDATE public.produto
                    SET nome = @nome,
                        qtd_estoque = @qtd_estoque,
                        preco = @preco,
                        unidade = @unidade,
                        id_fornecedor = @id_fornecedor,
                        id_classificacao = @id_classificacao
                    WHERE id_produto = @id";

            var parameters = new
            {
                nome = produto.Nome,
                qtd_estoque = produto.Qtd_estoque,
                preco = produto.Preco,
                unidade = produto.Unidade,
                id_fornecedor = produto.Id_fornecedor,
                id_classificacao = produto.Id_classificacao,
                id = produto.Id_produto
            };

            var result = conn.Connection.Execute(query, parameters);

            return result == 1;
        }


        // Método para verificar se o fornecedor existe no banco de dados
        private bool CheckFornecedorExists(int fornecedorId)
        {
            using var conn = new DbConnection();
            string query = @"SELECT COUNT(*) FROM fornecedor WHERE id_fornecedor = @id";
            var parameters = new { id = fornecedorId };
            var count = conn.Connection.ExecuteScalar<int>(query, parameters);
            return count > 0;
        }

        // Método para verificar se a classificação existe no banco de dados
        private bool CheckClassificacaoExists(int classificacaoId)
        {
            using var conn = new DbConnection();
            string query = @"SELECT COUNT(*) FROM classificacao WHERE id_classificacao = @id";
            var parameters = new { id = classificacaoId };
            var count = conn.Connection.ExecuteScalar<int>(query, parameters);
            return count > 0;
        }



    }
}
