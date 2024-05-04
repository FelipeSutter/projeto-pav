using Dapper;
using PDV.Entities;
using PDV.Infrastructure.Database;

namespace PDV.Infrastructure.Repositories {
    public class ContaReceberRepository {
        public bool Add(ContaReceber contaReceber) {
            using var conn = new DbConnection();
            string query = @"INSERT INTO public.contareceber(id_cliente, descricao, valor_recebido, valor_estimado, data_lancamento, data_vencimento, data_recebimento)
                             VALUES (@Id_cliente, @Descricao, @Valor_recebido, @Valor_estimado, @Data_lancamento, @Data_vencimento, @Data_recebimento)";

            var parameters = new {
                contaReceber.Id_cliente,
                contaReceber.Descricao,
                contaReceber.Valor_recebido,
                contaReceber.Valor_estimado,
                contaReceber.Data_lancamento,
                contaReceber.Data_vencimento,
                contaReceber.Data_recebimento
            };

            var result = conn.Connection.Execute(query, parameters);

            return result == 1;
        }

        public List<ContaReceber> GetContasReceberByCliente(int idCliente) {
            using var conn = new DbConnection();
            string query = @"SELECT * FROM contareceber WHERE id_cliente = @Id_cliente";

            var contasReceber = conn.Connection.Query<ContaReceber>(query, new { Id_cliente = idCliente });

            return contasReceber.ToList();
        }
        public List<ContaReceber> Get()
        {
            using var conn = new DbConnection();
            string query = @"SELECT * FROM contareceber";
            var contasReceber = conn.Connection.Query<ContaReceber>(query);
            return contasReceber.ToList();
        }

        public ContaReceber GetContaReceberById(int idContaReceber) {
            using var conn = new DbConnection();
            string query = "SELECT * FROM contareceber WHERE id_conta_receber = @Id_conta_receber";
            var parameters = new { Id_conta_receber = idContaReceber };
            return conn.Connection.QueryFirstOrDefault<ContaReceber>(query, parameters);
        }

        public bool Delete(int idContaReceber) {
            using var conn = new DbConnection();
            string query = @"DELETE FROM public.contareceber
                             WHERE id_conta_receber = @id";

            var parameters = new { id = idContaReceber };

            var result = conn.Connection.Execute(query, parameters);

            return result > 0;
        }

        public bool Update(ContaReceber contaReceber) {
            using var conn = new DbConnection();
            string query = @"UPDATE public.contareceber
                             SET id_cliente = @Id_cliente,
                                 descricao = @Descricao,
                                 valor_recebido = @ValorRecebido,
                                 valor_estimado = @ValorEstimado,
                                 data_lancamento = @DataLancamento,
                                 data_vencimento = @DataVencimento,
                                 data_recebimento = @DataRecebimento
                             WHERE id_conta_receber = @Id_conta_receber";

            var parameters = new {
                contaReceber.Id_cliente,
                contaReceber.Descricao,
                contaReceber.Valor_recebido,
                contaReceber.Valor_estimado,
                contaReceber.Data_lancamento,
                contaReceber.Data_vencimento,
                contaReceber.Data_recebimento,
                contaReceber.Id_conta_receber
            };

            var result = conn.Connection.Execute(query, parameters);

            return result == 1;
        }

        public bool UpdateDescricao(int idContaReceber, string novaDescricao)
        {
            using var conn = new DbConnection();
            string query = @"UPDATE public.contareceber
                     SET descricao = @NovaDescricao
                     WHERE id_conta_receber = @IdContaReceber";

            var parameters = new
            {
                NovaDescricao = novaDescricao,
                IdContaReceber = idContaReceber
            };

            var result = conn.Connection.Execute(query, parameters);

            return result == 1;
        }
    }
}
