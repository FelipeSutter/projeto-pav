namespace PDV.Entities
{
    public class ItemVenda
    {
        public int IdProduto { get; set; }
        public int IdVenda { get; set; }
        public int QtdItem { get; set; }
        public double ValorUnitario { get; set; }
        public double TotalItem { get; set; }
        public Produto Produto { get; set; }
        public Venda Venda { get; set; }

        public ItemVenda() { }

        public ItemVenda(int idProduto, int idVenda, int qtdItem, double valorUnitario, double totalItem, Produto produto, Venda venda)
        {
            IdProduto = idProduto;
            IdVenda = idVenda;
            QtdItem = qtdItem;
            ValorUnitario = valorUnitario;
            TotalItem = totalItem;
            Produto = produto;
            Venda = venda;
        }
    }
}
