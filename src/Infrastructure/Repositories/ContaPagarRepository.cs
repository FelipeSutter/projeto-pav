using Dapper;
using PDV.Entities;
using PDV.Infrastructure.Database;

namespace PDV.Infrastructure.Repositories
{
    public class ContaPagarRepository
    {
        public bool Add(ContaPagar contaPagar)
        {
            using var conn = new DbConnection();
            string query = @"INSERT INTO public.contapagar(id_fornecedor, descricao, valor_pago, valor_pagamento, data_lancamento, data_vencimento, data_pagamento)
                             VALUES (@Id_fornecedor, @Descricao, @Valor_pago, @Valor_pagamento, @Data_lancamento, @Data_vencimento, @Data_pagamento)";

            var parameters = new
            {
                contaPagar.Id_fornecedor,
                contaPagar.Descricao,
                contaPagar.Valor_pago,
                contaPagar.Valor_pagamento,
                contaPagar.Data_lancamento,
                contaPagar.Data_vencimento,
                contaPagar.Data_pagamento
            };

            var result = conn.Connection.Execute(query, parameters);

            return result == 1;
        }

        public List<ContaPagar> GetContasPagarByFornecedor(int idFornecedor)
        {
            using var conn = new DbConnection();
            string query = @"SELECT * FROM contapagar WHERE id_fornecedor = @Id_fornecedor";

            var contasPagar = conn.Connection.Query<ContaPagar>(query, new { Id_fornecedor = idFornecedor });

            return contasPagar.ToList();
        }

        public List<ContaPagar> Get()
        {
            using var conn = new DbConnection();
            string query = @"SELECT * FROM contapagar";
            var contasPagar = conn.Connection.Query<ContaPagar>(query);
            return contasPagar.ToList();
        }

        public ContaPagar GetContaPagarById(int idContaPagar)
        {
            using var conn = new DbConnection();
            string query = "SELECT * FROM contapagar WHERE id_conta_pagar = @Id_conta_pagar";
            var parameters = new { Id_conta_pagar = idContaPagar };
            return conn.Connection.QueryFirstOrDefault<ContaPagar>(query, parameters);
        }

        public bool Delete(int idContaPagar)
        {
            using var conn = new DbConnection();
            string query = @"DELETE FROM public.contapagar
                             WHERE id_conta_pagar = @id";

            var parameters = new { id = idContaPagar };

            var result = conn.Connection.Execute(query, parameters);

            return result > 0;
        }

        public bool Update(ContaPagar contaPagar)
        {
            using var conn = new DbConnection();
            string query = @"UPDATE public.contapagar
                             SET id_fornecedor = @Id_fornecedor,
                                 descricao = @Descricao,
                                 valor_pago = @ValorPago,
                                 valor_pagamento = @ValorPagamento,
                                 data_lancamento = @DataLancamento,
                                 data_vencimento = @DataVencimento,
                                 data_pagamento = @DataPagamento
                             WHERE id_conta_pagar = @Id_conta_pagar";

            var parameters = new
            {
                contaPagar.Id_fornecedor,
                contaPagar.Descricao,
                contaPagar.Valor_pago,
                contaPagar.Valor_pagamento,
                contaPagar.Data_lancamento,
                contaPagar.Data_vencimento,
                contaPagar.Data_pagamento,
                contaPagar.Id_conta_pagar
            };

            var result = conn.Connection.Execute(query, parameters);

            return result == 1;
        }
    }
}
