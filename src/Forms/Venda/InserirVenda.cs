using PDV.Entities;
using PDV.Enums;
using PDV.Infrastructure.Repositories;
using PDV.Tables;

namespace PDV
{
    public partial class InserirVenda : Form {
        List<Produto> produtos = new List<Produto>();
        List<Cliente> clientes = [];
        List<ItemVenda> itens = new List<ItemVenda>();
        TabelaItemVenda _tabela;

        double total = 0;
        public InserirVenda() {
            InitializeComponent();
            ObterProdutos();
            ObterClientes();

            _tabela = new TabelaItemVenda(); // Instanciação da tabela
            dataViewItemVenda.DataSource = _tabela;
            dataViewItemVenda.Columns[0].Width = 200;
            dataViewItemVenda.Columns[1].Width = 200;
            dataViewItemVenda.Columns[2].Width = 200;
            dataViewItemVenda.Columns[3].Width = 200;
            dataViewItemVenda.Columns[4].Width = 200;

            prod_box.DataSource = produtos;
            prod_box.DisplayMember = "Nome";
            prod_box.ValueMember = "Id_produto";

            pessoa_box.DataSource = clientes;
            pessoa_box.DisplayMember = "Nome";
            pessoa_box.ValueMember = "Id_cliente";
        }

        public void ObterProdutos(string nomePesquisa = null) {
            var repository = new ProdutoRepository();
            produtos = repository.Get(nomePesquisa);
        }
        public Produto ObterProdutos(int id) {
            var repository = new ProdutoRepository();
            produtos = repository.Get();
            Produto prod = new Produto();
            foreach (var item in produtos) {
                if (id == item.Id_produto) {
                    prod = item;
                    break;
                }
            }
            return prod;
        }

        public void ObterClientes(string? nomePesquisa = null) {
            var repository = new ClienteRepository();
            clientes = repository.Get();
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

        private void btn_carrinho_Click(object sender, EventArgs e) {
            int qtd = int.Parse(qtd_box.Text);
            Produto prod = new Produto();
            prod = ObterProdutos((int) prod_box.SelectedValue);
            if (prod.Qtd_estoque < qtd) {
                MessageBox.Show("Não há estoque suficiente para o produto " + prod.Nome, "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {
                ItemVenda item = new ItemVenda(qtd, prod.Preco, qtd * prod.Preco, prod);
                itens.Add(item);

                _tabela.Incluir(item);

                total += qtd * prod.Preco;
                lb_total.Text = total.ToString();
            }
        }
        private void btn_venda_Click(object sender, EventArgs e) {
            Cliente cliente = new Cliente();
            cliente = ObterClientes((int) pessoa_box.SelectedValue);



            Venda venda = new Venda(total, EStatus.EFETUADA, cliente.Id_cliente);
            var repository = new ItemVendaRepository();
            repository.Add(venda, itens);
            Close();


        }

        private void btn_cancelar_Click(object sender, EventArgs e) {
            Cliente cliente = new Cliente();
            cliente = ObterClientes((int) pessoa_box.SelectedValue);


            Venda venda = new Venda(total, EStatus.CANCELADA, cliente.Id_cliente);
            var repository = new ItemVendaRepository();
            repository.Add(venda, itens);
            Close();

        }

        private void textBox2_TextChanged(object sender, EventArgs e) {

        }

        private void lb_total_Click(object sender, EventArgs e) {

        }

        private void btn_remover_Click(object sender, EventArgs e) {
            var repository = new ItemVendaRepository();
            ItemVenda item = _tabela.ObterItemVendaNaLinhaSelecionada(dataViewItemVenda.CurrentRow.Index);
            repository.Delete(item.IdProduto, item.IdVenda);

            MessageBox.Show("Item excluído com sucesso!");
            total -= item.TotalItem;
            lb_total.Text = total.ToString();


            _tabela.Excluir(dataViewItemVenda.CurrentRow.Index);
        }

        private void InserirVenda_Load(object sender, EventArgs e) {

        }

        private void btn_alterar_Click(object sender, EventArgs e) {
            ItemVenda item = _tabela.ObterItemVendaNaLinhaSelecionada(dataViewItemVenda.CurrentRow.Index);
            Produto prod = new Produto();

            int novaQuantidade = int.Parse(qtd_box.Text);
            prod = ObterProdutos((int) prod_box.SelectedValue);

            if (prod.Qtd_estoque < novaQuantidade) {
                MessageBox.Show("Não há estoque suficiente para o produto " + prod.Nome, "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else {
                double totalAnterior = item.TotalItem; // Salva o total anterior do item

                // Atualiza o item de venda com a nova quantidade e recalcula o total
                item.QtdItem = novaQuantidade;
                item.TotalItem = novaQuantidade * prod.Preco;

                // Atualiza a linha na tabela
                _tabela.Alterar(dataViewItemVenda.CurrentRow.Index, item);

                // Atualiza o preço total da venda
                total -= totalAnterior; // Remove o total anterior
                total += item.TotalItem; // Adiciona o novo total
                lb_total.Text = total.ToString();
            }
        }
    }
}
