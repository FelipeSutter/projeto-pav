namespace PDV;

partial class ConsultarProduto
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
        label6 = new Label();
        label5 = new Label();
        label4 = new Label();
        label3 = new Label();
        label2 = new Label();
        label1 = new Label();
        idClassificacaoLabel = new Label();
        idFornecedorLabel = new Label();
        unidadeLabel = new Label();
        precoLabel = new Label();
        qtdLabel = new Label();
        nomeLabel = new Label();
        SuspendLayout();
        // 
        // btn_voltar
        // 
        btn_voltar.DialogResult = DialogResult.Cancel;
        btn_voltar.Location = new Point(294, 348);
        btn_voltar.Name = "btn_voltar";
        btn_voltar.Size = new Size(191, 52);
        btn_voltar.TabIndex = 61;
        btn_voltar.Text = "Voltar";
        btn_voltar.UseVisualStyleBackColor = true;
        btn_voltar.Click += btn_voltar_Click;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(91, 279);
        label6.Name = "label6";
        label6.Size = new Size(131, 25);
        label6.TabIndex = 59;
        label6.Text = "Id_classificacao";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(91, 229);
        label5.Name = "label5";
        label5.Size = new Size(122, 25);
        label5.TabIndex = 58;
        label5.Text = "Id_fornecedor";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(91, 179);
        label4.Name = "label4";
        label4.Size = new Size(78, 25);
        label4.TabIndex = 57;
        label4.Text = "Unidade";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(91, 129);
        label3.Name = "label3";
        label3.Size = new Size(56, 25);
        label3.TabIndex = 56;
        label3.Text = "Preço";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(91, 79);
        label2.Name = "label2";
        label2.Size = new Size(114, 25);
        label2.TabIndex = 55;
        label2.Text = "Qtd_Estoque";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(91, 29);
        label1.Name = "label1";
        label1.Size = new Size(61, 25);
        label1.TabIndex = 54;
        label1.Text = "Nome";
        // 
        // idClassificacaoLabel
        // 
        idClassificacaoLabel.AutoSize = true;
        idClassificacaoLabel.Location = new Point(501, 279);
        idClassificacaoLabel.Name = "idClassificacaoLabel";
        idClassificacaoLabel.Size = new Size(131, 25);
        idClassificacaoLabel.TabIndex = 67;
        idClassificacaoLabel.Text = "Id_classificacao";
        // 
        // idFornecedorLabel
        // 
        idFornecedorLabel.AutoSize = true;
        idFornecedorLabel.Location = new Point(501, 229);
        idFornecedorLabel.Name = "idFornecedorLabel";
        idFornecedorLabel.Size = new Size(122, 25);
        idFornecedorLabel.TabIndex = 66;
        idFornecedorLabel.Text = "Id_fornecedor";
        // 
        // unidadeLabel
        // 
        unidadeLabel.AutoSize = true;
        unidadeLabel.Location = new Point(501, 179);
        unidadeLabel.Name = "unidadeLabel";
        unidadeLabel.Size = new Size(78, 25);
        unidadeLabel.TabIndex = 65;
        unidadeLabel.Text = "Unidade";
        // 
        // precoLabel
        // 
        precoLabel.AutoSize = true;
        precoLabel.Location = new Point(501, 129);
        precoLabel.Name = "precoLabel";
        precoLabel.Size = new Size(56, 25);
        precoLabel.TabIndex = 64;
        precoLabel.Text = "Preço";
        // 
        // qtdLabel
        // 
        qtdLabel.AutoSize = true;
        qtdLabel.Location = new Point(501, 79);
        qtdLabel.Name = "qtdLabel";
        qtdLabel.Size = new Size(114, 25);
        qtdLabel.TabIndex = 63;
        qtdLabel.Text = "Qtd_Estoque";
        // 
        // nomeLabel
        // 
        nomeLabel.AutoSize = true;
        nomeLabel.Location = new Point(501, 29);
        nomeLabel.Name = "nomeLabel";
        nomeLabel.Size = new Size(61, 25);
        nomeLabel.TabIndex = 62;
        nomeLabel.Text = "Nome";
        // 
        // ConsultarProduto
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.ActiveCaption;
        ClientSize = new Size(800, 450);
        Controls.Add(idClassificacaoLabel);
        Controls.Add(idFornecedorLabel);
        Controls.Add(unidadeLabel);
        Controls.Add(precoLabel);
        Controls.Add(qtdLabel);
        Controls.Add(nomeLabel);
        Controls.Add(btn_voltar);
        Controls.Add(label6);
        Controls.Add(label5);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Name = "ConsultarProduto";
        Text = "ConsultarProduto";
        Load += ConsultarProduto_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button btn_voltar;
    private Label label6;
    private Label label5;
    private Label label4;
    private Label label3;
    private Label label2;
    private Label label1;
    private Label idClassificacaoLabel;
    private Label idFornecedorLabel;
    private Label unidadeLabel;
    private Label precoLabel;
    private Label qtdLabel;
    private Label nomeLabel;
}