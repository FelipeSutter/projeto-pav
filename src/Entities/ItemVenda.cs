namespace PDV.Entities {
    public class ItemVenda {
        public int IdProduto { get; set; }
        public int IdVenda { get; set; }
        public int QtdItem { get; set; }
        public double ValorUnitario { get; set; }
        public double TotalItem { get; set; }
        public Produto Produto { get; set; }
        public Venda Venda { get; set; }

        public ItemVenda() { }

        public ItemVenda(int qtdItem, double valorUnitario, double totalItem, Produto produto) {
            Produto = produto;

            IdProduto = produto.Id_produto;

            QtdItem = qtdItem;
            ValorUnitario = valorUnitario;
            TotalItem = totalItem;

        }
    }
}
