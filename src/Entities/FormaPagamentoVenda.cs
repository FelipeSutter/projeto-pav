using PDV.Enums;

namespace PDV.Entities;
public class FormaPagamentoVenda {

    public int Id_Forma_Pagamento { get; set; }
    public FormaPagamento FormaPagamento { get; set; }
    public int Id_Venda { get; set; }
    public Venda Venda { get; set; }
    public double Valor { get; set; }

    public FormaPagamentoVenda(int idVenda, int idFormaPagamento, double valor) {
        Id_Venda = idVenda;
        Id_Forma_Pagamento = idFormaPagamento;
        Valor = valor;
    }
}
