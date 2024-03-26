using PDV.Enums;

namespace PDV.Entities;
public class MovimentoCaixa {

    public int Id_caixa {  get; set; }
    public Caixa Caixa { get; set; }
    public string Descricao { get; set; } = string.Empty;
    public double Valor {  get; set; }
    public DateTime DataHora { get; set; } = DateTime.Now;
    public ETipoMovimento Tipo_movimento { get; set; }

    public MovimentoCaixa()
    {
        
    }

    public MovimentoCaixa(int id_caixa, double valor, ETipoMovimento tipo_Movimento) {
        Id_caixa = id_caixa;
        Valor = valor;
        Tipo_movimento = tipo_Movimento;
    }
}
