using Dapper;
using PDV.Entities;
using PDV.Infrastructure.Database;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PDV.Infrastructure.Repositories
{
    public class CompraRepository
    {
        public bool Add(Compra compra)
        {
            using var conn = new DbConnection();
            string query = @"INSERT INTO public.compra(
                                data_hora, total_compra, situacao_compra, id_fornecedor)
                             VALUES (@dataHora, @totalCompra, @situacaoCompra, @idFornecedor)";

            var parameters = new
            {
                dataHora = compra.Data_Hora,
                totalCompra = compra.Total_Compra,
                situacaoCompra = compra.Situacao_Compra,
                idFornecedor = compra.Id_fornecedor
            };

            var result = conn.Connection.Execute(query, parameters);

            return result == 1;
        }

        public List<Compra> Get()
        {
            using var conn = new DbConnection();
            string query = @"SELECT * FROM compra";
            var compras = conn.Connection.Query<Compra>(query);
            return compras.ToList();
        }

        public List<Compra> Get(DateTime dataInicio, DateTime dataFim)
        {
            using var conn = new DbConnection();
            string query = @"SELECT * 
                             FROM compra 
                             WHERE data_hora BETWEEN @DataInicio AND @DataFim";

            var parameters = new { DataInicio = dataInicio, DataFim = dataFim };

            var compras = conn.Connection.Query<Compra>(query, parameters);
            return compras.ToList();
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
    }
}
