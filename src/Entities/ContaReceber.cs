namespace PDV.Entities
{
    public class ContaReceber
    {

        public int Id_conta_receber { get; set; }
        public int Id_cliente { get; set; }
        public Cliente Cliente { get; set; }
        public string Descricao { get; set; } = string.Empty;
        public double Valor_recebido { get; set; } // o valor que foi recebido.
        public double Valor_estimado { get; set; } // o valor que deve receber
        public DateTime Data_lancamento { get; set; }
        public DateTime Data_vencimento { get; set; }
        public DateTime Data_recebimento { get; set; }

        public ContaReceber() { }
        public ContaReceber(int id_cliente, double valorRecebido, double valorEstimado, DateTime dataLancamento, DateTime dataVencimento, DateTime dataRecebimento) {
            Id_cliente = id_cliente;
            Valor_recebido = valorRecebido;
            Valor_estimado = valorEstimado;
            Data_lancamento = dataLancamento;
            Data_vencimento = dataVencimento;
            Data_recebimento = dataRecebimento;
        }
    }
}
