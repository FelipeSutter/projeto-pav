using PDV.Entities;
using PDV.Infrastructure.Repositories;
using PDV.Tabelas;
using PDV.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDV.Forms.Venda
{
    public partial class JanelaContasReceber : Form {
        List<ContaReceber> contas = new List<ContaReceber>();
        TabelaContaReceber _tabela;


        public JanelaContasReceber() {
            InitializeComponent();
            _tabela = new TabelaContaReceber(); // Instanciação da tabela
            dataViewContaReceber.DataSource = _tabela;
            dataViewContaReceber.Columns[0].Width = 200;
            dataViewContaReceber.Columns[1].Width = 200;
            dataViewContaReceber.Columns[2].Width = 200;
            dataViewContaReceber.Columns[3].Width = 200;
            dataViewContaReceber.Columns[4].Width = 200;
            dataViewContaReceber.Columns[5].Width = 200;
            dataViewContaReceber.Columns[6].Width = 200;


            //txt_pesquisar.TextChanged += txt_pesquisar_TextChanged;

            ObterContaReceber();

        }
        public void ObterContaReceber(string nomePesquisa = null) {
            var repository = new ContaReceberRepository();
            contas = repository.Get();
            foreach (var item in contas) {
                _tabela.Incluir(item);
            }
        }

        private void btn_voltar_Click(object sender, EventArgs e) {
            Dispose();
        }

        private void btn_baixar_conta_Click(object sender, EventArgs e) {

        }

        private void JanelaContasReceber_Load(object sender, EventArgs e) {

        }
    }
}
