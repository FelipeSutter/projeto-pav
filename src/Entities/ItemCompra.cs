using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDV.Entities
{
    public class ItemCompra
    {
        public int Id_produto { get; set; }
        public int Id_compra { get; set; }
        public int Qtd { get; set; }
        public double Valor_unitario { get; set; }
        public double Total_item { get; set; }
        public Produto Produto { get; set; }
        public Compra compra { get; set; }

        public ItemCompra() { }

        public ItemCompra(int qtdItem, double valorUnitario, double totalItem, Produto produto)
        {
            Produto = produto;
            Id_produto = produto.Id_produto;
            Qtd = qtdItem;
            Valor_unitario = valorUnitario;
            Total_item = totalItem;

        }
    }
}
