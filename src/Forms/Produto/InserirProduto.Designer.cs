namespace PDV;

partial class InserirProduto
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        btn_voltar = new Button();
        btn_criar = new Button();
        label6 = new Label();
        label5 = new Label();
        label4 = new Label();
        label3 = new Label();
        label2 = new Label();
        label1 = new Label();
        idClassificacaoBox = new TextBox();
        idFornecedorBox = new TextBox();
        unidadeBox = new TextBox();
        precoBox = new TextBox();
        qtdBox = new TextBox();
        nomeBox = new TextBox();
        SuspendLayout();
        // 
        // btn_voltar
        // 
        btn_voltar.DialogResult = DialogResult.Cancel;
        btn_voltar.Location = new Point(397, 374);
        btn_voltar.Name = "btn_voltar";
        btn_voltar.Size = new Size(191, 52);
        btn_voltar.TabIndex = 47;
        btn_voltar.Text = "Voltar";
        btn_voltar.UseVisualStyleBackColor = true;
        btn_voltar.Click += btn_voltar_Click;
        // 
        // btn_criar
        // 
        btn_criar.DialogResult = DialogResult.OK;
        btn_criar.Location = new Point(66, 374);
        btn_criar.Name = "btn_criar";
        btn_criar.Size = new Size(191, 52);
        btn_criar.TabIndex = 46;
        btn_criar.Text = "Criar";
        btn_criar.UseVisualStyleBackColor = true;
        btn_criar.Click += btn_criar_Click;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(29, 283);
        label6.Name = "label6";
        label6.Size = new Size(131, 25);
        label6.TabIndex = 39;
        label6.Text = "Id_classificacao";
        label6.Click += label6_Click;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(29, 233);
        label5.Name = "label5";
        label5.Size = new Size(122, 25);
        label5.TabIndex = 38;
        label5.Text = "Id_fornecedor";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(29, 183);
        label4.Name = "label4";
        label4.Size = new Size(78, 25);
        label4.TabIndex = 37;
        label4.Text = "Unidade";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(29, 133);
        label3.Name = "label3";
        label3.Size = new Size(56, 25);
        label3.TabIndex = 36;
        label3.Text = "Preço";
        label3.Click += label3_Click;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(29, 83);
        label2.Name = "label2";
        label2.Size = new Size(114, 25);
        label2.TabIndex = 35;
        label2.Text = "Qtd_Estoque";
        label2.Click += label2_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(29, 33);
        label1.Name = "label1";
        label1.Size = new Size(61, 25);
        label1.TabIndex = 34;
        label1.Text = "Nome";
        // 
        // idClassificacaoBox
        // 
        idClassificacaoBox.Location = new Point(203, 283);
        idClassificacaoBox.Name = "idClassificacaoBox";
        idClassificacaoBox.Size = new Size(444, 31);
        idClassificacaoBox.TabIndex = 33;
        // 
        // idFornecedorBox
        // 
        idFornecedorBox.Location = new Point(203, 233);
        idFornecedorBox.Name = "idFornecedorBox";
        idFornecedorBox.Size = new Size(444, 31);
        idFornecedorBox.TabIndex = 32;
        // 
        // unidadeBox
        // 
        unidadeBox.Location = new Point(203, 183);
        unidadeBox.Name = "unidadeBox";
        unidadeBox.Size = new Size(444, 31);
        unidadeBox.TabIndex = 31;
        // 
        // precoBox
        // 
        precoBox.Location = new Point(203, 133);
        precoBox.Name = "precoBox";
        precoBox.Size = new Size(444, 31);
        precoBox.TabIndex = 29;
        // 
        // qtdBox
        // 
        qtdBox.Location = new Point(203, 83);
        qtdBox.Name = "qtdBox";
        qtdBox.Size = new Size(444, 31);
        qtdBox.TabIndex = 28;
        // 
        // nomeBox
        // 
        nomeBox.Location = new Point(203, 33);
        nomeBox.Name = "nomeBox";
        nomeBox.Size = new Size(444, 31);
        nomeBox.TabIndex = 27;
        // 
        // InserirProduto
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.ActiveCaption;
        ClientSize = new Size(672, 459);
        Controls.Add(btn_voltar);
        Controls.Add(btn_criar);
        Controls.Add(label6);
        Controls.Add(label5);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(idClassificacaoBox);
        Controls.Add(idFornecedorBox);
        Controls.Add(unidadeBox);
        Controls.Add(precoBox);
        Controls.Add(qtdBox);
        Controls.Add(nomeBox);
        Name = "InserirProduto";
        Text = "InserirProduto";
        Load += InserirProduto_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button btn_voltar;
    private Button btn_criar;
    private Label label6;
    private Label label5;
    private Label label4;
    private Label label3;
    private Label label2;
    private Label label1;
    private TextBox idClassificacaoBox;
    private TextBox idFornecedorBox;
    private TextBox unidadeBox;
    private TextBox precoBox;
    private TextBox qtdBox;
    private TextBox nomeBox;
}