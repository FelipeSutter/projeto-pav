namespace PDV.Entities
{
    public class ContaReceber
    {

        public int Id_conta_receber { get; set; }
        public int Id_cliente { get; set; }
        public Cliente Cliente { get; set; }
        public string Descricao { get; set; } = string.Empty;
        public double Valor_Recebido { get; set; } // o valor que foi recebido.
        public double Valor_Estimado { get; set; } // o valor que deve receber
        public DateTime Data_Lancamento { get; set; }
        public DateTime Data_Vencimento { get; set; }
        public DateTime Data_Recebimento { get; set; }

        public ContaReceber() { }
        public ContaReceber(int id_cliente, double valorRecebido, double valorEstimado, DateTime dataLancamento, DateTime dataVencimento, DateTime dataRecebimento) {
            Id_cliente = id_cliente;
            Valor_Recebido = valorRecebido;
            Valor_Estimado = valorEstimado;
            Data_Lancamento = dataLancamento;
            Data_Vencimento = dataVencimento;
            Data_Recebimento = dataRecebimento;
        }
    }
}
