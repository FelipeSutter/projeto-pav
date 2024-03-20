namespace PDV.Entities
{
    public class Caixa
    {

        public int Id_caixa { get; set; }
        public string Nome { get; set; }
        public string Saldo { get; set; }

        public Caixa()
        {
            
        }

        public Caixa(string nome, string saldo)
        {
            Nome = nome;
            Saldo = saldo;
        }
    }
}
