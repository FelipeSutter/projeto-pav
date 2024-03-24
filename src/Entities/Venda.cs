using PDV.Enums;

namespace PDV.Entities {
    public class Venda {

        public int Id_venda { get; set; }
        public DateTime Data_Hora { get; set; }
        public double Total_Venda { get; set; }
        public EStatus Situacao_Venda { get; set; }
        public int Id_cliente { get; set; }
        public Cliente Cliente { get; set; }

        public Venda() {

        }

        public Venda(double totalVenda, EStatus situacaoVenda, int id_cliente) {
            Total_Venda = totalVenda;
            Situacao_Venda = situacaoVenda;
            Id_cliente = id_cliente;
            Data_Hora = DateTime.Now;
        }
    }
}
