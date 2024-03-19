using PDV.Entities;

namespace PDV.Forms {
    public partial class ConsultarClassificacao : Form {
        public ConsultarClassificacao() {
            InitializeComponent();
        }

        public ConsultarClassificacao(Classificacao classificacao) {
            InitializeComponent();
            nomeL.Text = classificacao.Nome;

        }

        private void voltarBu_Click(object sender, EventArgs e) {
            Close();
        }

        private void ConsultarClassificacao_Load(object sender, EventArgs e) {

        }
    }
}
