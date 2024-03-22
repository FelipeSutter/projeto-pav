using PDV.Enums;

namespace PDV.Entities
{
    public class Venda
    {

        public int Id_venda { get; set; }
        public DateTime DataHora { get; set; }
        public double TotalVenda { get; set; }
        public EStatus SituacaoVenda { get; set; }
        public int Id_cliente { get; set; }
        public Cliente Cliente { get; set; }

        public Venda()
        {
          
        }

        public Venda(int id_cliente) {
            SituacaoVenda = EStatus.ATIVO;
            Id_cliente = id_cliente;
            DataHora = DateTime.Now;
            TotalVenda = 0;
        }

        public void CalcularTotalVenda(List<ItemVenda> itens) {
            TotalVenda = 0;
            foreach (var item in itens) {
                TotalVenda += item.TotalItem;
            }
        }

    }
}
