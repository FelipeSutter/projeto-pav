using PDV.Entities;
using PDV.Infrastructure.Repositories;
using PDV.Tabelas;

namespace PDV.Forms {
    public partial class JanelaClassificacao : Form
    {
        List<Classificacao> classificacoes = [];

        private readonly TabelaClassificacao _tabela;
        public JanelaClassificacao()
        {
            InitializeComponent();
            _tabela = new TabelaClassificacao();
            dataViewClassificacao.DataSource = _tabela;
            dataViewClassificacao.Columns[0].Width = 350;
            dataViewClassificacao.Columns[1].Width = 350;

            txt_pesquisar.TextChanged += txt_pesquisar_TextChanged;


            ObterClassificacoes();
        }

        public void ObterClassificacoes(string? nomePesquisa = null)
        {
            var repository = new ClassificacaoRepository();
            classificacoes = repository.Get(nomePesquisa);
            foreach (var item in classificacoes)
            {
                _tabela.Incluir(item);
            }

        }

        private void btn_incluir_Click(object sender, EventArgs e)
        {
            InserirClassificacao frm = new InserirClassificacao();
            DialogResult response = frm.ShowDialog();
            if (response == DialogResult.OK)
            {
                _tabela.Clear();
                ObterClassificacoes();
            }
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            AlterarClassificacao frm = new AlterarClassificacao(_tabela.ObterClassificacaoNaLinhaSelecionada(dataViewClassificacao.CurrentRow.Index));
            DialogResult response = frm.ShowDialog();
            if (response == DialogResult.OK)
            {
                var repository = new ClassificacaoRepository();
                repository.Update(frm.classificacao);
                _tabela.Alterar(dataViewClassificacao.CurrentRow.Index, frm.classificacao);

                _tabela.Clear();
                ObterClassificacoes();

            }
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            Classificacao classificacao = _tabela.ObterClassificacaoNaLinhaSelecionada(dataViewClassificacao.CurrentRow.Index);
            ConsultarClassificacao frm = new ConsultarClassificacao(classificacao);
            frm.Show();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            var repository = new ClassificacaoRepository();
            Classificacao classificacao = _tabela.ObterClassificacaoNaLinhaSelecionada(dataViewClassificacao.CurrentRow.Index);
            repository.Delete(classificacao.Id_classificacao);

            MessageBox.Show("Item excluído com sucesso!");


            _tabela.Clear();
            ObterClassificacoes();
        }

        private void JanelaClassificacao_Load(object sender, EventArgs e)
        {

        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            string termoPesquisa = txt_pesquisar.Text;
            _tabela.Clear();
            ObterClassificacoes(termoPesquisa);
        }

        private void txt_pesquisar_TextChanged(object sender, EventArgs e)
        {
            string termoPesquisa = txt_pesquisar.Text.Trim(); // Remove espaços em branco extras
            if (string.IsNullOrEmpty(termoPesquisa))
            {
                // Se o campo de pesquisa estiver vazio, traga a lista de todos os produtos
                _tabela.Clear();
                ObterClassificacoes();
            }
        }
    }
}
