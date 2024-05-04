using Dapper;
using PDV.Entities;
using PDV.Infrastructure.Database;
using System.Collections.Generic;
using System.Linq;

namespace PDV.Infrastructure.Repositories
{
    public class FornecedorRepository
    {
        public bool Add(Fornecedor fornecedor)
        {
            using var conn = new DbConnection();
            string query = @"INSERT INTO public.fornecedor(
                            nome, logradouro, numero, complemento, bairro, cidade, estado, cep, cpf_cnpj, telefone, email)
                            VALUES (@nome, @logradouro, @numero, @complemento, @bairro, @cidade, @estado, @cep, @cpf_cnpj, @telefone, @email)";

            var parameters = new
            {
                nome = fornecedor.Nome,
                logradouro = fornecedor.Logradouro,
                numero = fornecedor.Numero,
                complemento = fornecedor.Complemento,
                bairro = fornecedor.Bairro,
                cidade = fornecedor.Cidade,
                estado = fornecedor.Estado,
                cep = fornecedor.Cep,
                cpf_cnpj = fornecedor.Cpf_cnpj,
                telefone = fornecedor.Telefone,
                email = fornecedor.Email
            };

            var result = conn.Connection.Execute(query, parameters);

            return result == 1;
        }

        public List<Fornecedor> Get(string? nomePesquisa = null)
        {
            using var conn = new DbConnection();
            string query = @"SELECT * FROM fornecedor";

            if (!string.IsNullOrEmpty(nomePesquisa))
            {
                query += " WHERE nome LIKE @nome";
            }

            var fornecedores = conn.Connection.Query<Fornecedor>(sql: query, new { nome = "%" + nomePesquisa + "%" });

            return fornecedores.ToList();
        }

        public bool Delete(int fornecedorId)
        {
            using var conn = new DbConnection();
            string query = @"DELETE FROM public.fornecedor
                            WHERE id_fornecedor = @id";

            var parameters = new { id = fornecedorId };

            var result = conn.Connection.Execute(query, parameters);

            return result > 0;
        }

        public bool Update(Fornecedor fornecedor)
        {
            using var conn = new DbConnection();
            string query = @"UPDATE public.fornecedor
                            SET nome = @nome,
                                logradouro = @logradouro,
                                numero = @numero,
                                complemento = @complemento,
                                bairro = @bairro,
                                cidade = @cidade,
                                estado = @estado,
                                cep = @cep,
                                cpf_cnpj = @cpf_cnpj,
                                telefone = @telefone,
                                email = @email
                            WHERE id_fornecedor = @id";

            var parameters = new
            {
                id = fornecedor.Id_fornecedor,
                nome = fornecedor.Nome,
                logradouro = fornecedor.Logradouro,
                numero = fornecedor.Numero,
                complemento = fornecedor.Complemento,
                bairro = fornecedor.Bairro,
                cidade = fornecedor.Cidade,
                estado = fornecedor.Estado,
                cep = fornecedor.Cep,
                cpf_cnpj = fornecedor.Cpf_cnpj,
                telefone = fornecedor.Telefone,
                email = fornecedor.Email
            };

            var result = conn.Connection.Execute(query, parameters);

            return result == 1;
        }

        public Fornecedor GetByCompraId(int idCompra)
        {
            using var conn = new DbConnection();
            string query = @"SELECT f.nome FROM fornecedor f
                            INNER JOIN compra c on f.id_fornecedor = c.id_fornecedor WHERE c.id_compra = @idCompra";
            var parameters = new { idCompra };
            return conn.Connection.QueryFirstOrDefault<Fornecedor>(query, parameters);
        }

        public Fornecedor GetByContaPagarId(int idContaPagar) {
            using var conn = new DbConnection();
            string query = @"SELECT f.nome FROM fornecedor f
                            INNER JOIN contapagar cp on f.id_fornecedor = cp.id_fornecedor WHERE cp.id_conta_pagar = @idContaPagar";
            var parameters = new { idContaPagar };
            return conn.Connection.QueryFirstOrDefault<Fornecedor>(query, parameters);
        }

    }
}
