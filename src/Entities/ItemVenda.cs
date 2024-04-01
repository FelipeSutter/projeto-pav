namespace PDV.Entities {
    public class ItemVenda {
        public int Id_produto { get; set; }
        public int Id_venda { get; set; }
        public int Qtd_item { get; set; }
        public double Valor_unitario { get; set; }
        public double Total_item { get; set; }
        public Produto Produto { get; set; }
        public Venda Venda { get; set; }

        public ItemVenda() { }

        public ItemVenda(int qtdItem, double valorUnitario, double totalItem, Produto produto) {
            Produto = produto;

            Id_produto = produto.Id_produto;

            Qtd_item = qtdItem;
            Valor_unitario = valorUnitario;
            Total_item = totalItem;

        }
    }
}
