using PDV.Entities;
using PDV.Enums;
using PDV.Infrastructure.Repositories;
using PDV.Tables;

namespace PDV.Forms.Venda
{
    public partial class JanelaContasReceber : Form
    {
        List<ContaReceber> contas = new List<ContaReceber>();
        List<Cliente> clientes = [];
        TabelaContaReceber _tabela;

        public JanelaContasReceber()
        {
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
            dataViewContaReceber.Columns[7].Width = 200;


            //txt_pesquisar.TextChanged += txt_pesquisar_TextChanged;

            ObterContaReceber();

        }
        public void ObterContaReceber(string nomePesquisa = null)
        {
            var repository = new ContaReceberRepository();
            contas = repository.Get();
            foreach (var item in contas)
            {
                _tabela.Incluir(item);
            }
        }

        public ContaReceber ObterContaReceber(int id)
        {
            var repository = new ContaReceberRepository();
            contas = repository.Get();
            ContaReceber cont = new ContaReceber();
            foreach (var item in contas)
            {
                if (id == item.Id_conta_receber)
                {
                    cont = item;
                    break;
                }
            }
            return cont;
        }

        public Cliente ObterClientes(int id)
        {
            var repository = new ClienteRepository();
            clientes = repository.Get();
            Cliente clie = new Cliente();
            foreach (var item in clientes)
            {
                if (id == item.Id_cliente)
                {
                    clie = item;
                    break;
                }
            }
            return clie;
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btn_baixar_conta_Click(object sender, EventArgs e)
        {
            ContaReceber conta = _tabela.ObterContaReceberNaLinhaSelecionada(dataViewContaReceber.CurrentRow.Index);

            if (conta.Descricao.Equals(EStatusConta.PAGO.ToString()))
            {
                MessageBox.Show("Esta conta já foi paga.");
                return;
            }
            else if (conta.Data_vencimento < DateTime.Now)
            {
                MessageBox.Show("Esta conta já venceu. Seu nome está no Serasa");
            }
            else
            {
                var movimentoCaixaRepository = new MovimentoCaixaRepository();
                ContaReceberRepository con = new ContaReceberRepository();

                var movimentoCaixa = CriarMovimentoCaixa(conta.Valor_estimado, ETipoMovimento.ENTRADA, true);
                movimentoCaixaRepository.Add(movimentoCaixa);

                //update EStatusConta
                MessageBox.Show("Baixa de conta concluída com sucesso!");
                con.UpdateDescricaoAndValorRecebido(conta.Id_conta_receber, EStatusConta.PAGO.ToString(), conta.Valor_estimado, DateTime.Now);
                _tabela.Clear();
                ObterContaReceber();
            }
        }

        private MovimentoCaixa CriarMovimentoCaixa(double valor, ETipoMovimento tipoMovimento, bool efetuarVenda)
        {
            // Obtém o ID do último caixa disponível
            var caixaRepository = new CaixaRepository();
            int idCaixa = caixaRepository.GetLastId();

            // Obtém o saldo atual do caixa
            var saldoAtual = caixaRepository.GetSaldo(idCaixa);

            // Calcula o novo saldo do caixa com base na situação da venda
            double novoSaldo = saldoAtual;
            if (efetuarVenda)
            {
                novoSaldo += valor; // Aumenta o saldo caso a venda seja efetuada
                bool sucessoAtualizacaoSaldo = caixaRepository.UpdateSaldo(idCaixa, novoSaldo);

                if (!sucessoAtualizacaoSaldo)
                {
                    throw new Exception("Falha ao atualizar o saldo do caixa.");
                }
            }

            MovimentoCaixa movimentoCaixa = new MovimentoCaixa(idCaixa, valor, tipoMovimento, DateTime.Now, tipoMovimento.ToString());

            return movimentoCaixa;
        }

        private void JanelaContasReceber_Load(object sender, EventArgs e)
        {

        }
    }
}
