using PDV.Enums;

namespace PDV.Entities;
public class MovimentoCaixa {

    public int Id_caixa {  get; set; }
    public Caixa Caixa { get; set; }
    public int Id_movimento { get; set; }
    public string Descricao { get; set; }
    public double Valor {  get; set; }
    public ETipoMovimento Tipo_Movimento { get; set; }

    public MovimentoCaixa(int id_caixa, int id_movimento, string descricao, double valor, ETipoMovimento tipo_Movimento) {
        Id_caixa = id_caixa;
        Id_movimento = id_movimento;
        Descricao = descricao;
        Valor = valor;
        Tipo_Movimento = tipo_Movimento;
    }
}
