namespace PDV.Entities {
    public class Classificacao
    {
        public int Id_classificacao { get; set; }
        public string Nome { get; set; }

        public Classificacao() { }
        public Classificacao(string Nome)
        {
            
            this.Nome = Nome;
        }

        public Classificacao(int Id, string Nome)
        {
            this.Id_classificacao = Id;
            this.Nome = Nome;
        }
    }
}
