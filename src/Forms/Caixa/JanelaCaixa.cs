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

namespace PDV
{
    public partial class JanelaCaixa : Form
    {
        List<MovimentoCaixa> movimentos = new List<MovimentoCaixa>();
        TabelaMovimentoCaixa _tabela;

        public JanelaCaixa()
        {
            InitializeComponent();
            _tabela = new TabelaMovimentoCaixa(); // Instanciação da tabela
            dataViewMovimentoCaixa.DataSource = _tabela;
            dataViewMovimentoCaixa.Columns[0].Width = 200;
            dataViewMovimentoCaixa.Columns[1].Width = 200;
            dataViewMovimentoCaixa.Columns[2].Width = 200;
            dataViewMovimentoCaixa.Columns[3].Width = 200;
            dataViewMovimentoCaixa.Columns[4].Width = 200;
            dataViewMovimentoCaixa.Columns[5].Width = 200;

            ObterMovimentoCaixa();
        }

        public void ObterMovimentoCaixa(string nomePesquisa = null)
        {
            var repository = new MovimentoCaixaRepository();
            movimentos = repository.Get();
            foreach (var item in movimentos)
            {
                _tabela.Incluir(item);
            }
        }
    }
}
