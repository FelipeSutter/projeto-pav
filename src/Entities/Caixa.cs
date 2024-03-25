namespace PDV.Entities
{
    public class Caixa
    {
        public int Id_caixa { get; set; }
        public double Saldo { get; set; }

        public Caixa()
        {
            
        }

        public Caixa(int id_caixa, double saldo)
        {
            Id_caixa = id_caixa;
            Saldo = saldo;
        }
    }
}
