using iTextSharp.text.pdf;
using iTextSharp.text;
using PDV.Entities;
using PDV.Enums;
using PDV.Infrastructure.Repositories;
using PDV.Tables;

namespace PDV.Forms.Venda
{
    public partial class JanelaContasReceber : Form {
        List<ContaReceber> contas = new List<ContaReceber>();
        List<Cliente> clientes = [];
        TabelaContaReceber _tabela;
        String path = "../../../PDFs/";

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
            dataViewContaReceber.Columns[7].Width = 200;

            ObterContaReceber();
            ObterClientes();

            cliente_box.DataSource = clientes;
            cliente_box.DisplayMember = "Nome";
            cliente_box.ValueMember = "Id_cliente";


            //txt_pesquisar.TextChanged += txt_pesquisar_TextChanged;


        }
        public void ObterContaReceber(string nomePesquisa = null) {
            var repository = new ContaReceberRepository();
            contas = repository.Get();
            foreach (var item in contas) {
                _tabela.Incluir(item);
            }
        }

        public Cliente ObterClientes(int id) {
            var repository = new ClienteRepository();
            clientes = repository.Get();
            Cliente clie = new Cliente();
            foreach (var item in clientes) {
                if (id == item.Id_cliente) {
                    clie = item;
                    break;
                }
            }
            return clie;
        }

        public void ObterClientes(string? nomePesquisa = null) {
            var repository = new ClienteRepository();
            clientes = repository.Get();
        }

        private void btn_voltar_Click(object sender, EventArgs e) {
            Dispose();
        }

        private void btn_baixar_conta_Click(object sender, EventArgs e) {
            ContaReceber conta = _tabela.ObterContaReceberNaLinhaSelecionada(dataViewContaReceber.CurrentRow.Index);

            if (conta.Descricao.Equals(EStatusConta.PAGO.ToString())) {
                MessageBox.Show("Esta conta já foi paga.");
                return;
            } else if (conta.Data_vencimento < DateTime.Now) {
                MessageBox.Show("Esta conta já venceu. Seu nome está no Serasa");
            } else {
                var movimentoCaixaRepository = new MovimentoCaixaRepository();
                ContaReceberRepository con = new ContaReceberRepository();

                var movimentoCaixa = CriarMovimentoCaixa(conta.Valor_estimado, ETipoMovimento.ENTRADA, true);
                movimentoCaixaRepository.Add(movimentoCaixa);

                //update EStatusConta
                MessageBox.Show("Baixa de conta paga com sucesso!");
                con.UpdateDescricaoAndValorRecebido(conta.Id_conta_receber, EStatusConta.PAGO.ToString(), conta.Valor_estimado, DateTime.Now);
                _tabela.Clear();
                ObterContaReceber();
            }
        }

        private MovimentoCaixa CriarMovimentoCaixa(double valor, ETipoMovimento tipoMovimento, bool efetuarVenda) {
            // Obtém o ID do último caixa disponível
            var caixaRepository = new CaixaRepository();
            int idCaixa = caixaRepository.GetLastId();

            // Obtém o saldo atual do caixa
            var saldoAtual = caixaRepository.GetSaldo(idCaixa);

            // Calcula o novo saldo do caixa com base na situação da conta
            double novoSaldo = saldoAtual;
            if (efetuarVenda) {
                novoSaldo += valor; // Aumenta o saldo caso a conta seja efetuada
                bool sucessoAtualizacaoSaldo = caixaRepository.UpdateSaldo(idCaixa, novoSaldo);

                if (!sucessoAtualizacaoSaldo) {
                    throw new Exception("Falha ao atualizar o saldo do caixa.");
                }
            }

            MovimentoCaixa movimentoCaixa = new MovimentoCaixa(idCaixa, valor, tipoMovimento, DateTime.Now, tipoMovimento.ToString());

            return movimentoCaixa;
        }

        private void JanelaContasReceber_Load(object sender, EventArgs e) {

        }

        private void btn_filtrar_Click(object sender, EventArgs e) {
            ContaReceberRepository repository = new ContaReceberRepository();
            Cliente cliente = ObterClientes((int) cliente_box.SelectedValue);

            _tabela.Clear();

            var contas = repository.GetContasReceberByCliente(cliente.Id_cliente);

            foreach (var item in contas) {
                _tabela.Incluir(item);
            }
        }

        private void btn_filtrar_data_Click(object sender, EventArgs e) {
            ContaReceberRepository repository = new ContaReceberRepository();

            DateTime dataInicio = inicio_datetime.Value.Date;
            DateTime dataFim = final_datetime.Value.Date.AddDays(1).AddSeconds(-1); // Ajuste para incluir até o fim do dia selecionado

            // Limpa a tabela antes de aplicar o filtro
            _tabela.Clear();

            // Obtém as contas filtradas com base nas datas selecionadas
            var contasFiltradas = repository.Get(dataInicio, dataFim);

            // Adiciona as contas filtradas à tabela
            foreach (var conta in contasFiltradas) {
                _tabela.Incluir(conta);
            }
        }

        private void btn_imprimir_Click(object sender, EventArgs e) {
            // Obtem as contas no período especificado
            ContaReceberRepository contaRepository = new ContaReceberRepository();
            ClienteRepository clienteRepository = new ClienteRepository();

            DateTime dataInicio = inicio_datetime.Value.Date;
            DateTime dataFim = final_datetime.Value.Date.AddDays(1).AddSeconds(-1);

            var contasFiltradas = contaRepository.Get(dataInicio, dataFim);

            // Cria um novo documento PDF para o relatório de contas
            string nomeArquivo = path + "Relatorio_ContaReceber.pdf";
            FileStream arquivoPDF = new FileStream(nomeArquivo, FileMode.Create);
            Document document = new Document(PageSize.A4);
            PdfWriter writer = PdfWriter.GetInstance(document, arquivoPDF);

            document.Open();

            // Adiciona o título do relatório
            Paragraph titulo = new Paragraph($"Relatório de ContaReceber de {dataInicio.ToShortDateString()} a {dataFim.ToShortDateString()}\n\n");
            titulo.Alignment = Element.ALIGN_CENTER;
            document.Add(titulo);

            // Adiciona o cabeçalho da tabela
            PdfPTable tabela = new PdfPTable(6);
            tabela.AddCell("Cliente");
            tabela.AddCell("Código");
            tabela.AddCell("Data Lançamento");
            tabela.AddCell("Data Vencimento");
            tabela.AddCell("Status da Conta");
            tabela.AddCell("Valor Recebido");

            // Adiciona as contas à tabela
            foreach (var conta in contasFiltradas) {

                Cliente cliente = clienteRepository.GetByContaReceberId(conta.Id_conta_receber);

                // Adiciona os dados da conta à tabela
                tabela.AddCell(cliente.Nome);
                tabela.AddCell(conta.Id_conta_receber.ToString());
                tabela.AddCell(conta.Data_lancamento.ToString());
                tabela.AddCell(conta.Data_vencimento.ToString());
                tabela.AddCell(conta.Descricao.ToString());
                tabela.AddCell(conta.Valor_recebido.ToString());
            }

            // Adiciona a tabela ao documento
            document.Add(tabela);

            // Adiciona os totais ao documento
            document.Add(new Paragraph("\n"));

            // Fecha o documento
            document.Close();

            MessageBox.Show("Relatório de contas impresso com sucesso!");
        }
    }
}
