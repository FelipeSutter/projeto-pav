namespace PDV.Entities
{
    public class ContaReceber
    {

        public int Id_conta_receber { get; set; }
        public int Id_cliente { get; set; }
        public Cliente Cliente { get; set; }
        public string Descricao { get; set; }
        public double ValorRecebido { get; set; } // o valor que foi recebido.
        public double ValorEstimado { get; set; } // o valor que deve receber
        public DateTime DataLancamento { get; set; }
        public DateTime DataVencimento { get; set; }
        public DateTime DataRecebimento { get; set; }

        public ContaReceber(int id_cliente, string descricao, double valorRecebido, double valorEstimado, DateTime dataLancamento, DateTime dataVencimento, DateTime dataRecebimento) {
            Id_cliente = id_cliente;
            Descricao = descricao;
            ValorRecebido = valorRecebido;
            ValorEstimado = valorEstimado;
            DataLancamento = dataLancamento;
            DataVencimento = dataVencimento;
            DataRecebimento = dataRecebimento;
        }
    }
}
