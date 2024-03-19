namespace PDV.Entities {
    public class Fornecedor {

        public int Id { get; set; }
        public string Nome { get; set; }

        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }
        public string Cpf_cnpj { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }


        public Fornecedor() { }

        public Fornecedor(string nome, string logradouro, string numero, string complemento, string bairro, string cidade, string estado, string cep, string cpf_cnpj, string telefone, string email) {
            this.Nome = nome;
            this.Logradouro = logradouro;
            this.Numero = numero;
            this.Complemento = complemento;
            this.Bairro = bairro;
            this.Cidade = cidade;
            this.Estado = estado;
            this.Cep = cep;
            this.Cpf_cnpj = cpf_cnpj;
            this.Telefone = telefone;
            this.Email = email;
        }
    }
}
