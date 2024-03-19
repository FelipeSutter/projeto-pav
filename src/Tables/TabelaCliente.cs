using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PDV.Entities;

namespace PDV.Tabelas
{
    public class TabelaCliente : DataTable
    {
        private const string COLUNA_IDCLIENTE = "Id cliente";
        private const string COLUNA_NOME = "Nome";
        private const string COLUNA_CPF_CNPJ = "CPF/CNPJ";
        private const string COLUNA_LOGRADOURO = "Logradouro";
        private const string COLUNA_NUMERO = "Numero";
        private const string COLUNA_COMPLEMENTO = "Complemento";
        private const string COLUNA_BAIRRO = "Bairro";
        private const string COLUNA_CIDADE = "Cidade";
        private const string COLUNA_ESTADO = "Estado";
        private const string COLUNA_CEP = "CEP";
        private const string COLUNA_TELEFONE = "Telefone";
        private const string COLUNA_EMAIL = "Email";

        public TabelaCliente()
        {
            CriarColunas();
        }

        private DataColumn CriarColuna(string titulo, string nome, Type tipo)
        {
            DataColumn coluna = new DataColumn();
            coluna.Caption = titulo;
            coluna.ColumnName = nome;
            coluna.DataType = tipo;

            return coluna;
        }


        private void CriarColunas()
        {
            Columns.Add(CriarColuna("Id cliente", COLUNA_IDCLIENTE, typeof(string)));
            Columns.Add(CriarColuna("Nome", COLUNA_NOME, typeof(string)));
            Columns.Add(CriarColuna("CPF/CNPJ", COLUNA_CPF_CNPJ, typeof(string)));
            Columns.Add(CriarColuna("Logradouro", COLUNA_LOGRADOURO, typeof(string)));
            Columns.Add(CriarColuna("Numero", COLUNA_NUMERO, typeof(string)));
            Columns.Add(CriarColuna("Complemento", COLUNA_COMPLEMENTO, typeof(string)));
            Columns.Add(CriarColuna("Bairro", COLUNA_BAIRRO, typeof(string)));
            Columns.Add(CriarColuna("Cidade", COLUNA_CIDADE, typeof(string)));
            Columns.Add(CriarColuna("Estado", COLUNA_ESTADO, typeof(string)));
            Columns.Add(CriarColuna("CEP", COLUNA_CEP, typeof(string)));
            Columns.Add(CriarColuna("Telefone", COLUNA_TELEFONE, typeof(string)));
            Columns.Add(CriarColuna("Email", COLUNA_EMAIL, typeof(string)));
        }

        public void Incluir(Cliente client)
        {
            Rows.Add(client.Id, client.Nome, client.Cpf_cnpj,
                     client.Logradouro, client.Numero, client.Complemento,
                     client.Bairro, client.Cidade, client.Estado, client.Cep,
                     client.Telefone, client.Email);

        }

        public void Alterar(int indice, Cliente client)
        {
            Rows[indice][COLUNA_IDCLIENTE] = client.Id;
            Rows[indice][COLUNA_NOME] = client.Nome;
            Rows[indice][COLUNA_CPF_CNPJ] = client.Cpf_cnpj;
            Rows[indice][COLUNA_LOGRADOURO] = client.Logradouro;
            Rows[indice][COLUNA_NUMERO] = client.Numero;
            Rows[indice][COLUNA_COMPLEMENTO] = client.Complemento;
            Rows[indice][COLUNA_BAIRRO] = client.Bairro;
            Rows[indice][COLUNA_CIDADE] = client.Cidade;
            Rows[indice][COLUNA_ESTADO] = client.Estado;
            Rows[indice][COLUNA_CEP] = client.Cep;
            Rows[indice][COLUNA_TELEFONE] = client.Telefone;
            Rows[indice][COLUNA_EMAIL] = client.Email;
        }

        public void Excluir(int indice)
        {
            Rows.RemoveAt(indice);
        }

        public Cliente ObterClienteNaLinhaSelecionada(int indiceLinha)
        {
            var cliente = new Cliente
            {
                Id = Convert.ToInt32(Rows[indiceLinha][COLUNA_IDCLIENTE]),
                Nome = Rows[indiceLinha][COLUNA_NOME].ToString(),
                Cpf_cnpj = Rows[indiceLinha][COLUNA_CPF_CNPJ].ToString(),
                Logradouro = Rows[indiceLinha][COLUNA_LOGRADOURO].ToString(),
                Numero = Rows[indiceLinha][COLUNA_NUMERO].ToString(),
                Complemento = Rows[indiceLinha][COLUNA_COMPLEMENTO].ToString(),
                Bairro = Rows[indiceLinha][COLUNA_BAIRRO].ToString(),
                Cidade = Rows[indiceLinha][COLUNA_CIDADE].ToString(),
                Estado = Rows[indiceLinha][COLUNA_ESTADO].ToString(),
                Cep = Rows[indiceLinha][COLUNA_CEP].ToString(),
                Telefone = Rows[indiceLinha][COLUNA_TELEFONE].ToString(),
                Email = Rows[indiceLinha][COLUNA_EMAIL].ToString()
            };

            return cliente;
        }


    }
}
