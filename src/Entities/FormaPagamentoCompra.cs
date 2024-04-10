namespace PDV.Entities
{
    public class FormaPagamentoCompra
    {
        public int Id_Forma_Pagamento { get; set; }
        public FormaPagamento FormaPagamento { get; set; }
        public int Id_Compra { get; set; }
        public Compra Compra { get; set; }
        public double Valor { get; set; }

        public FormaPagamentoCompra(int idCompra, int idFormaPagamento, double valor)
        {
            Id_Compra = idCompra;
            Id_Forma_Pagamento = idFormaPagamento;
            Valor = valor;
        }
    }
}
