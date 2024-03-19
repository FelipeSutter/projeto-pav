using PDV.Entities;
using PDV.Infrastructure.Repositories;

namespace PDV.Forms {
    public partial class InserirClassificacao : Form
    {
        Classificacao classificacao;

        public Classificacao getClassificacao()
        {
            return classificacao;
        }
        public InserirClassificacao()
        {
            InitializeComponent();
        }


        private void InserirClassificacao_Load(object sender, EventArgs e)
        {

        }

        private void btn_criar_Click(object sender, EventArgs e)
        {
            classificacao = new Classificacao(nomeBox.Text);

            var repository = new ClassificacaoRepository();
            repository.Add(classificacao);
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
