namespace PDV.Entities
{
    public class ContaReceber
    {

        public int IdContaReceber { get; set; }
        public int Id_cliente { get; set; }
        public Cliente Cliente { get; set; }
        public string Descricao { get; set; }
        public double ValorRecebido { get; set; }
        public DateTime DataLancamento { get; set; }
        public DateTime DataVencimento { get; set; }
        public DateTime DataRecebimento { get; set; }

        public ContaReceber(int id_cliente, string descricao, double valorRecebido, DateTime dataLancamento, DateTime dataVencimento, DateTime dataRecebimento)
        {
            Id_cliente = id_cliente;
            Descricao = descricao;
            ValorRecebido = valorRecebido;
            DataLancamento = dataLancamento;
            DataVencimento = dataVencimento;
            DataRecebimento = dataRecebimento;
        }
    }
}
