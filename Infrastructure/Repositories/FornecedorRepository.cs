using Dapper;
using PDV.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public List<Fornecedor> Get()
        {
            using var conn = new DbConnection();
            string query = @"SELECT * FROM fornecedor;";

            var fornecedores = conn.Connection.Query<Fornecedor>(sql: query);

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
                id = fornecedor.Id,
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



    }
}
