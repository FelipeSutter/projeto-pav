using PDV.Enums;

namespace PDV.Entities;
public class FormaPagamento {

    public int Id_Forma_Pagamento {  get; set; }
    public EFormaPagamento Nome { get; set; }

    public FormaPagamento(EFormaPagamento nome) {
        Nome = nome;
    }
}
