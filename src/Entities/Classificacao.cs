namespace PDV.Entities {
    public class Classificacao
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public Classificacao() { }
        public Classificacao(string Nome)
        {
            
            this.Nome = Nome;
        }

        public Classificacao(int Id, string Nome)
        {
            this.Id = Id;
            this.Nome = Nome;
        }
    }
}
