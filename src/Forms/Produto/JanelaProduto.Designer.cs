namespace PDV.Forms.Produto;

partial class JanelaProduto {
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
        btn_consultar = new Button();
        btn_voltar = new Button();
        btn_excluir = new Button();
        btn_alterar = new Button();
        btn_incluir = new Button();
        dataViewProduto = new DataGridView();
        ((System.ComponentModel.ISupportInitialize) dataViewProduto).BeginInit();
        SuspendLayout();
        // 
        // btn_consultar
        // 
        btn_consultar.BackColor = SystemColors.GradientActiveCaption;
        btn_consultar.Location = new Point(885, 197);
        btn_consultar.Margin = new Padding(2);
        btn_consultar.Name = "btn_consultar";
        btn_consultar.Size = new Size(176, 42);
        btn_consultar.TabIndex = 11;
        btn_consultar.Text = "Consultar";
        btn_consultar.UseVisualStyleBackColor = false;
        // 
        // btn_voltar
        // 
        btn_voltar.BackColor = SystemColors.GradientActiveCaption;
        btn_voltar.Location = new Point(885, 261);
        btn_voltar.Margin = new Padding(2);
        btn_voltar.Name = "btn_voltar";
        btn_voltar.Size = new Size(176, 42);
        btn_voltar.TabIndex = 10;
        btn_voltar.Text = "Voltar";
        btn_voltar.UseVisualStyleBackColor = false;
        // 
        // btn_excluir
        // 
        btn_excluir.BackColor = SystemColors.GradientActiveCaption;
        btn_excluir.Location = new Point(885, 133);
        btn_excluir.Margin = new Padding(2);
        btn_excluir.Name = "btn_excluir";
        btn_excluir.Size = new Size(176, 42);
        btn_excluir.TabIndex = 9;
        btn_excluir.Text = "Excluir";
        btn_excluir.UseVisualStyleBackColor = false;
        // 
        // btn_alterar
        // 
        btn_alterar.BackColor = SystemColors.GradientActiveCaption;
        btn_alterar.Location = new Point(885, 69);
        btn_alterar.Margin = new Padding(2);
        btn_alterar.Name = "btn_alterar";
        btn_alterar.Size = new Size(176, 42);
        btn_alterar.TabIndex = 8;
        btn_alterar.Text = "Alterar";
        btn_alterar.UseVisualStyleBackColor = false;
        // 
        // btn_incluir
        // 
        btn_incluir.BackColor = SystemColors.GradientActiveCaption;
        btn_incluir.Location = new Point(885, 5);
        btn_incluir.Margin = new Padding(2);
        btn_incluir.Name = "btn_incluir";
        btn_incluir.Size = new Size(176, 42);
        btn_incluir.TabIndex = 7;
        btn_incluir.Text = "Incluir";
        btn_incluir.UseVisualStyleBackColor = false;
        btn_incluir.Click += button1_Click;
        // 
        // dataViewProduto
        // 
        dataViewProduto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataViewProduto.Location = new Point(-260, 7);
        dataViewProduto.Margin = new Padding(2);
        dataViewProduto.MultiSelect = false;
        dataViewProduto.Name = "dataViewProduto";
        dataViewProduto.ReadOnly = true;
        dataViewProduto.RowHeadersWidth = 62;
        dataViewProduto.Size = new Size(1125, 438);
        dataViewProduto.TabIndex = 6;
        // 
        // JanelaProduto
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.ActiveCaption;
        ClientSize = new Size(1083, 548);
        Controls.Add(btn_consultar);
        Controls.Add(btn_voltar);
        Controls.Add(btn_excluir);
        Controls.Add(btn_alterar);
        Controls.Add(btn_incluir);
        Controls.Add(dataViewProduto);
        Name = "JanelaProduto";
        Text = "JanelaProduto";
        Load += JanelaProduto_Load;
        ((System.ComponentModel.ISupportInitialize) dataViewProduto).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private Button btn_consultar;
    private Button btn_voltar;
    private Button btn_excluir;
    private Button btn_alterar;
    private Button btn_incluir;
    private DataGridView dataViewProduto;
}