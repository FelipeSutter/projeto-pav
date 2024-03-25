namespace PDV.Entities
{
    public class Caixa
    {

        public int Id_caixa { get; set; }
        public string Saldo { get; set; }

        public Caixa()
        {
            
        }

        public Caixa(string saldo)
        {
            Saldo = saldo;
        }
    }
}
