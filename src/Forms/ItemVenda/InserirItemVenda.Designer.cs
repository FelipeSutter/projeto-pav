namespace PDV.Forms;

partial class InserirItemVenda {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
        if (disposing && (components != null)) {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
        components = new System.ComponentModel.Container();
        btn_voltar = new Button();
        btn_criar = new Button();
        label4 = new Label();
        label3 = new Label();
        label2 = new Label();
        label1 = new Label();
        cb_cliente = new ComboBox();
        clienteBindingSource = new BindingSource(components);
        cb_produto = new ComboBox();
        nm_qtd = new NumericUpDown();
        rb_credito = new RadioButton();
        rb_debito = new RadioButton();
        rb_pix = new RadioButton();
        rb_dinheiro = new RadioButton();
        ((System.ComponentModel.ISupportInitialize) clienteBindingSource).BeginInit();
        ((System.ComponentModel.ISupportInitialize) nm_qtd).BeginInit();
        SuspendLayout();
        // 
        // btn_voltar
        // 
        btn_voltar.DialogResult = DialogResult.Cancel;
        btn_voltar.Location = new Point(341, 365);
        btn_voltar.Margin = new Padding(2);
        btn_voltar.Name = "btn_voltar";
        btn_voltar.Size = new Size(153, 42);
        btn_voltar.TabIndex = 61;
        btn_voltar.Text = "Voltar";
        btn_voltar.UseVisualStyleBackColor = true;
        btn_voltar.Click += btn_voltar_Click;
        // 
        // btn_criar
        // 
        btn_criar.DialogResult = DialogResult.OK;
        btn_criar.Location = new Point(38, 365);
        btn_criar.Margin = new Padding(2);
        btn_criar.Name = "btn_criar";
        btn_criar.Size = new Size(153, 42);
        btn_criar.TabIndex = 60;
        btn_criar.Text = "Criar";
        btn_criar.UseVisualStyleBackColor = true;
        btn_criar.Click += btn_criar_Click;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(127, 230);
        label4.Margin = new Padding(2, 0, 2, 0);
        label4.Name = "label4";
        label4.Size = new Size(151, 20);
        label4.TabIndex = 57;
        label4.Text = "Forma de Pagamento";
        label4.Click += label4_Click;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(129, 177);
        label3.Margin = new Padding(2, 0, 2, 0);
        label3.Name = "label3";
        label3.Size = new Size(70, 20);
        label3.TabIndex = 56;
        label3.Text = "Qtd_Item";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(129, 118);
        label2.Margin = new Padding(2, 0, 2, 0);
        label2.Name = "label2";
        label2.Size = new Size(62, 20);
        label2.TabIndex = 55;
        label2.Text = "Produto";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(129, 56);
        label1.Margin = new Padding(2, 0, 2, 0);
        label1.Name = "label1";
        label1.Size = new Size(55, 20);
        label1.TabIndex = 54;
        label1.Text = "Cliente";
        // 
        // cb_cliente
        // 
        cb_cliente.FlatStyle = FlatStyle.System;
        cb_cliente.FormattingEnabled = true;
        cb_cliente.Location = new Point(209, 53);
        cb_cliente.Name = "cb_cliente";
        cb_cliente.Size = new Size(177, 28);
        cb_cliente.TabIndex = 62;
        cb_cliente.SelectedIndexChanged += cb_cliente_SelectedIndexChanged;
        // 
        // clienteBindingSource
        // 
        clienteBindingSource.DataSource = typeof(Entities.Cliente);
        // 
        // cb_produto
        // 
        cb_produto.FormattingEnabled = true;
        cb_produto.Location = new Point(209, 118);
        cb_produto.Name = "cb_produto";
        cb_produto.Size = new Size(177, 28);
        cb_produto.TabIndex = 63;
        cb_produto.SelectedIndexChanged += cb_produto_SelectedIndexChanged;
        // 
        // nm_qtd
        // 
        nm_qtd.Location = new Point(210, 175);
        nm_qtd.Name = "nm_qtd";
        nm_qtd.Size = new Size(41, 27);
        nm_qtd.TabIndex = 64;
        nm_qtd.Value = new decimal(new int[] { 1, 0, 0, 0 });
        nm_qtd.ValueChanged += nm_qtd_ValueChanged;
        // 
        // rb_credito
        // 
        rb_credito.AutoSize = true;
        rb_credito.Checked = true;
        rb_credito.Location = new Point(299, 226);
        rb_credito.Name = "rb_credito";
        rb_credito.Size = new Size(79, 24);
        rb_credito.TabIndex = 65;
        rb_credito.TabStop = true;
        rb_credito.Text = "Crédito";
        rb_credito.UseVisualStyleBackColor = true;
        rb_credito.CheckedChanged += rb_credito_CheckedChanged;
        // 
        // rb_debito
        // 
        rb_debito.AutoSize = true;
        rb_debito.Location = new Point(299, 256);
        rb_debito.Name = "rb_debito";
        rb_debito.Size = new Size(76, 24);
        rb_debito.TabIndex = 66;
        rb_debito.Text = "Débito";
        rb_debito.UseVisualStyleBackColor = true;
        rb_debito.CheckedChanged += rb_debito_CheckedChanged;
        // 
        // rb_pix
        // 
        rb_pix.AutoSize = true;
        rb_pix.Location = new Point(299, 286);
        rb_pix.Name = "rb_pix";
        rb_pix.Size = new Size(49, 24);
        rb_pix.TabIndex = 67;
        rb_pix.Text = "Pix";
        rb_pix.UseVisualStyleBackColor = true;
        rb_pix.CheckedChanged += rb_pix_CheckedChanged;
        // 
        // rb_dinheiro
        // 
        rb_dinheiro.AutoSize = true;
        rb_dinheiro.Location = new Point(299, 316);
        rb_dinheiro.Name = "rb_dinheiro";
        rb_dinheiro.Size = new Size(87, 24);
        rb_dinheiro.TabIndex = 68;
        rb_dinheiro.Text = "Dinheiro";
        rb_dinheiro.UseVisualStyleBackColor = true;
        rb_dinheiro.CheckedChanged += rb_dinheiro_CheckedChanged;
        // 
        // InserirItemVenda
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.ActiveCaption;
        ClientSize = new Size(541, 433);
        Controls.Add(rb_dinheiro);
        Controls.Add(rb_pix);
        Controls.Add(rb_debito);
        Controls.Add(rb_credito);
        Controls.Add(nm_qtd);
        Controls.Add(cb_produto);
        Controls.Add(cb_cliente);
        Controls.Add(btn_voltar);
        Controls.Add(btn_criar);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Name = "InserirItemVenda";
        Text = "InserirItemVenda";
        Load += InserirItemVenda_Load;
        ((System.ComponentModel.ISupportInitialize) clienteBindingSource).EndInit();
        ((System.ComponentModel.ISupportInitialize) nm_qtd).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button btn_voltar;
    private Button btn_criar;
    private Label label4;
    private Label label3;
    private Label label2;
    private Label label1;
    private ComboBox cb_cliente;
    private ComboBox cb_produto;
    private NumericUpDown nm_qtd;
    private RadioButton rb_credito;
    private RadioButton rb_debito;
    private RadioButton rb_pix;
    private RadioButton rb_dinheiro;
    private BindingSource clienteBindingSource;
}