using PDV.Entities;

namespace PDV.Forms {
    public partial class AlterarClassificacao : Form {
        public Classificacao classificacao;
        public AlterarClassificacao() {
            InitializeComponent();
        }

        public AlterarClassificacao(Classificacao classificacao) {
            InitializeComponent();
            this.classificacao = classificacao;
            nomeBox.Text = classificacao.Nome;
        }

        public Classificacao getClassificacao() {
            return classificacao;
        }

        private void button1_Click(object sender, EventArgs e) {
            classificacao.Nome = nomeBox.Text;
        }

        private void AlterarClassificacao_Load(object sender, EventArgs e) {

        }
    }
}
