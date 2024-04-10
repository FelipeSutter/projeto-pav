using Dapper;
using PDV.Entities;
using PDV.Enums;
using PDV.Infrastructure.Database;

namespace PDV.Infrastructure.Repositories;
public class FormaPagamentoCompraRepository
{
    public bool Add(FormaPagamentoCompra formaPagamentoCompra)
    {
        using var conn = new DbConnection();

        // Verifica se o id_forma_pagamento existe na tabela formapagamento
        string checkFormaPagamentoQuery = @"SELECT COUNT(*) 
                                        FROM formapagamento 
                                        WHERE id_forma_pagamento = @Id_Forma_Pagamento";

        var formaPagamentoExistente = conn.Connection.QueryFirstOrDefault<int>(checkFormaPagamentoQuery, new { formaPagamentoCompra.Id_Forma_Pagamento });

        // Verifica se o id_forma_pagamento existe na tabela formapagamento
        if (formaPagamentoExistente == 0)
        {
            throw new Exception("ID de Forma de Pagamento inválido.");
        }

        // Se o id_forma_pagamento for válido, insere o registro na tabela formapagamentocompra
        string insertQuery = @"INSERT INTO formapagamentocompra (id_forma_pagamento, id_compra, valor)
                            VALUES (@Id_Forma_Pagamento, @Id_Compra, @Valor)";

        var result = conn.Connection.Execute(insertQuery, new
        {
            formaPagamentoCompra.Id_Forma_Pagamento,
            formaPagamentoCompra.Id_Compra, // Usando o ID da compra fornecido
            formaPagamentoCompra.Valor
        });

        return result == 1;
    }

    public List<FormaPagamentoCompra> Get()
    {
        using var conn = new DbConnection();
        string query = @"SELECT * FROM formapagamentocompra";

        var formasPagamentoCompra = conn.Connection.Query<FormaPagamentoCompra>(query);

        return formasPagamentoCompra.ToList();
    }

    public int GetById(EFormaPagamento formaPagamento)
    {
        using var conn = new DbConnection();
        string query = @"SELECT id_forma_pagamento
                     FROM formapagamento
                     WHERE nome = @Nome";

        var parameters = new { Nome = formaPagamento.ToString() };
        return conn.Connection.QueryFirstOrDefault<int>(query, parameters);
    }

    public bool Update(FormaPagamentoCompra formaPagamentoCompra)
    {
        using var conn = new DbConnection();
        string updateQuery = @"UPDATE formapagamentocompra
                                    SET id_forma_pagamento = @Id_Forma_Pagamento,
                                        id_compra = @Id_Compra,
                                        valor = @Valor
                                    WHERE id_forma_pagamento = @Id_Forma_Pagamento AND id_compra = @Id_Compra";

        var result = conn.Connection.Execute(updateQuery, formaPagamentoCompra);

        return result == 1;
    }

    public bool Delete(int idFormaPagamento, int idCompra)
    {
        using var conn = new DbConnection();
        string deleteQuery = @"DELETE FROM formapagamentocompra
                                    WHERE id_forma_pagamento = @Id_Forma_Pagamento AND id_compra = @Id_Compra";

        var parameters = new { Id_Forma_Pagamento = idFormaPagamento, Id_Compra = idCompra };

        var result = conn.Connection.Execute(deleteQuery, parameters);

        return result > 0;
    }
}
