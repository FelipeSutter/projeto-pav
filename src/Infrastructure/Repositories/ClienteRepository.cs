using Dapper;
using PDV.Entities;
using PDV.Infrastructure.Database;

namespace PDV.Infrastructure.Repositories {
    public class ClienteRepository
    {

        public bool Add(Cliente client)
        {
            using var conn = new DbConnection();
            string query = @"INSERT INTO public.cliente(
        nome, logradouro, numero, complemento, bairro, cidade, estado, cep, cpf_cnpj, telefone, email)
        VALUES (@nome, @logradouro, @numero, @complemento, @bairro, @cidade, @estado, @cep, @cpf_cnpj, @telefone, @email)";

            var parameters = new
            {
                nome = client.Nome,
                logradouro = client.Logradouro,
                numero = client.Numero,
                complemento = client.Complemento,
                bairro = client.Bairro,
                cidade = client.Cidade,
                estado = client.Estado,
                cep = client.Cep,
                cpf_cnpj = client.Cpf_cnpj,
                telefone = client.Telefone,
                email = client.Email
            };

            var result = conn.Connection.Execute(query, parameters);

            return result == 1;
        }

        public List<Cliente> Get(string? nomePesquisa = null)
        {
            using var conn = new DbConnection();
            string query = @"SELECT * FROM cliente";

            if (!string.IsNullOrEmpty(nomePesquisa))
            {
                query += " WHERE nome LIKE @nome";
            }

            var clientes = conn.Connection.Query<Cliente>(sql: query, new { nome = "%" + nomePesquisa + "%" });

            return clientes.ToList();
        }

        public Cliente GetClientePorNome(string nome) {
            using (var conn = new DbConnection()) {
                string query = "SELECT * FROM cliente WHERE nome = @Nome";
                var parameters = new { Nome = nome };
                return conn.Connection.QueryFirstOrDefault<Cliente>(query, parameters);
            }
        }

        public bool Delete(int clientId)
        {
            using var conn = new DbConnection();
            string query = @"DELETE FROM public.cliente
                     WHERE id_cliente = @id";

            var parameters = new { id = clientId };

            var result = conn.Connection.Execute(query, parameters);

            return result > 0;
        }

        public bool Update(Cliente client)
        {
            using var conn = new DbConnection();
            string query = @"UPDATE public.cliente
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
                    WHERE id_cliente = @id";

            var parameters = new
            {
                id = client.Id_cliente,
                nome = client.Nome,
                logradouro = client.Logradouro,
                numero = client.Numero,
                complemento = client.Complemento,
                bairro = client.Bairro,
                cidade = client.Cidade,
                estado = client.Estado,
                cep = client.Cep,
                cpf_cnpj = client.Cpf_cnpj,
                telefone = client.Telefone,
                email = client.Email
            };

            var result = conn.Connection.Execute(query, parameters);

            return result == 1;
        }



    }
}
