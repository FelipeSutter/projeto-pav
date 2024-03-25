using Dapper;
using PDV.Entities;
using PDV.Infrastructure.Database;

namespace PDV.Infrastructure.Repositories;
public class FormaPagamentoVendaRepository {
    public bool Add(FormaPagamentoVenda formaPagamentoVenda, Venda venda) {
        using var conn = new DbConnection();

        // Verifica se o id_forma_pagamento existe na tabela formapagamento
        string checkFormaPagamentoQuery = @"SELECT COUNT(*) 
                                        FROM formapagamento 
                                        WHERE id_forma_pagamento = @Id_Forma_Pagamento";

        var formaPagamentoExistente = conn.Connection.QueryFirstOrDefault<int>(checkFormaPagamentoQuery, new { formaPagamentoVenda.Id_Forma_Pagamento });

        // Verifica se o id_forma_pagamento existe na tabela formapagamento
        if (formaPagamentoExistente == 0) {
            throw new Exception("ID de Forma de Pagamento inválido.");
        }

        // Se o id_forma_pagamento for válido, insere o registro na tabela formapagamentovenda
        string insertQuery = @"INSERT INTO formapagamentovenda (id_forma_pagamento, id_venda, valor)
                            VALUES (@Id_Forma_Pagamento, @Id_Venda, @Valor)";

        var result = conn.Connection.Execute(insertQuery, new {
            formaPagamentoVenda.Id_Forma_Pagamento,
            Id_Venda = venda.Id_venda, // Usando o ID da venda fornecido
            formaPagamentoVenda.Valor
        });

        return result == 1;
    }


    public List<FormaPagamentoVenda> Get() {
        using var conn = new DbConnection();
        string query = @"SELECT * FROM formapagamentovenda";

        var formasPagamentoVenda = conn.Connection.Query<FormaPagamentoVenda>(query);

        return formasPagamentoVenda.ToList();
    }

    public bool Update(FormaPagamentoVenda formaPagamentoVenda) {
        using var conn = new DbConnection();
        string updateQuery = @"UPDATE formapagamentovenda
                                    SET id_forma_pagamento = @Id_Forma_Pagamento,
                                        id_venda = @Id_Venda,
                                        valor = @Valor
                                    WHERE id_forma_pagamento = @Id_Forma_Pagamento AND id_venda = @Id_Venda";

        var result = conn.Connection.Execute(updateQuery, formaPagamentoVenda);

        return result == 1;
    }

    public bool Delete(int idFormaPagamento, int idVenda) {
        using var conn = new DbConnection();
        string deleteQuery = @"DELETE FROM formapagamentovenda
                                    WHERE id_forma_pagamento = @Id_Forma_Pagamento AND id_venda = @Id_Venda";

        var parameters = new { Id_Forma_Pagamento = idFormaPagamento, Id_Venda = idVenda };

        var result = conn.Connection.Execute(deleteQuery, parameters);

        return result > 0;
    }
}
