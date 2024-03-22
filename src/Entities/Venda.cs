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

        public Venda(double totalVenda, EStatus situacaoVenda, int id_cliente)
        {
            TotalVenda = totalVenda;
            SituacaoVenda = situacaoVenda;
            Id_cliente = id_cliente;
            DataHora = DateTime.Now;
        }
    }
}
