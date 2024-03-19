﻿using PDV.Entities;
using PDV.Infrastructure.Repositories;
using PDV.Tabelas;

namespace PDV.Forms {
    public partial class JanelaClassificacao : Form {
        List<Classificacao> classificacoes = [];

        private readonly TabelaClassificacao _tabela;
        public JanelaClassificacao() {
            InitializeComponent();
            _tabela = new TabelaClassificacao();
            dataViewClassificacao.DataSource = _tabela;
            dataViewClassificacao.Columns[0].Width = 350;
            dataViewClassificacao.Columns[1].Width = 350;
            ObterClassificacoes();
        }

        public void ObterClassificacoes() {
            var repository = new ClassificacaoRepository();
            classificacoes = repository.Get();
            foreach (var item in classificacoes) {
                _tabela.Incluir(item);
            }

        }

        private void btn_incluir_Click(object sender, EventArgs e) {
            InserirClassificacao frm = new InserirClassificacao();
            DialogResult response = frm.ShowDialog();
            if (response == DialogResult.OK) {
                _tabela.Clear();
                ObterClassificacoes();
            }
        }

        private void btn_alterar_Click(object sender, EventArgs e) {
            AlterarClassificacao frm = new AlterarClassificacao(_tabela.ObterClassificacaoNaLinhaSelecionada(dataViewClassificacao.CurrentRow.Index));
            DialogResult response = frm.ShowDialog();
            if (response == DialogResult.OK) {
                var repository = new ClassificacaoRepository();
                repository.Update(frm.classificacao);
                _tabela.Alterar(dataViewClassificacao.CurrentRow.Index, frm.classificacao);
            }
        }

        private void btn_consultar_Click(object sender, EventArgs e) {
            Classificacao classificacao = _tabela.ObterClassificacaoNaLinhaSelecionada(dataViewClassificacao.CurrentRow.Index);
            ConsultarClassificacao frm = new ConsultarClassificacao(classificacao);
            frm.Show();
        }

        private void btn_voltar_Click(object sender, EventArgs e) {
            Close();
        }

        private void btn_excluir_Click(object sender, EventArgs e) {
            var repository = new ClassificacaoRepository();
            Classificacao classificacao = _tabela.ObterClassificacaoNaLinhaSelecionada(dataViewClassificacao.CurrentRow.Index);
            repository.Delete(classificacao.Id_classificacao);

            //_tabela.excluir(dataViewClassificacao.CurrentRow.Index);

            _tabela.Clear();
            ObterClassificacoes();
        }

        private void JanelaClassificacao_Load(object sender, EventArgs e) {

        }
    }
}