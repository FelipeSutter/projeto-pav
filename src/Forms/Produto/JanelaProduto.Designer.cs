namespace PDV;

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
    private void InitializeComponent()
    {
        btn_consultar = new Button();
        btn_voltar = new Button();
        btn_excluir = new Button();
        btn_alterar = new Button();
        btn_incluir = new Button();
        dataViewProduto = new DataGridView();
        txt_pesquisar = new TextBox();
        label1 = new Label();
        btn_pesquisar = new Button();
        ((System.ComponentModel.ISupportInitialize)dataViewProduto).BeginInit();
        SuspendLayout();
        // 
        // btn_consultar
        // 
        btn_consultar.BackColor = SystemColors.GradientActiveCaption;
        btn_consultar.Location = new Point(1298, 317);
        btn_consultar.Margin = new Padding(2);
        btn_consultar.Name = "btn_consultar";
        btn_consultar.Size = new Size(220, 52);
        btn_consultar.TabIndex = 11;
        btn_consultar.Text = "Consultar";
        btn_consultar.UseVisualStyleBackColor = false;
        btn_consultar.Click += btn_consultar_Click;
        // 
        // btn_voltar
        // 
        btn_voltar.BackColor = SystemColors.GradientActiveCaption;
        btn_voltar.Location = new Point(1298, 574);
        btn_voltar.Margin = new Padding(2);
        btn_voltar.Name = "btn_voltar";
        btn_voltar.Size = new Size(220, 52);
        btn_voltar.TabIndex = 10;
        btn_voltar.Text = "Voltar";
        btn_voltar.UseVisualStyleBackColor = false;
        btn_voltar.Click += btn_voltar_Click;
        // 
        // btn_excluir
        // 
        btn_excluir.BackColor = SystemColors.GradientActiveCaption;
        btn_excluir.Location = new Point(1298, 236);
        btn_excluir.Margin = new Padding(2);
        btn_excluir.Name = "btn_excluir";
        btn_excluir.Size = new Size(220, 52);
        btn_excluir.TabIndex = 9;
        btn_excluir.Text = "Excluir";
        btn_excluir.UseVisualStyleBackColor = false;
        btn_excluir.Click += btn_excluir_Click;
        // 
        // btn_alterar
        // 
        btn_alterar.BackColor = SystemColors.GradientActiveCaption;
        btn_alterar.Location = new Point(1298, 156);
        btn_alterar.Margin = new Padding(2);
        btn_alterar.Name = "btn_alterar";
        btn_alterar.Size = new Size(220, 52);
        btn_alterar.TabIndex = 8;
        btn_alterar.Text = "Alterar";
        btn_alterar.UseVisualStyleBackColor = false;
        btn_alterar.Click += btn_alterar_Click;
        // 
        // btn_incluir
        // 
        btn_incluir.BackColor = SystemColors.GradientActiveCaption;
        btn_incluir.Location = new Point(1298, 82);
        btn_incluir.Margin = new Padding(2);
        btn_incluir.Name = "btn_incluir";
        btn_incluir.Size = new Size(220, 52);
        btn_incluir.TabIndex = 7;
        btn_incluir.Text = "Incluir";
        btn_incluir.UseVisualStyleBackColor = false;
        btn_incluir.Click += btn_incluir_Click;
        // 
        // dataViewProduto
        // 
        dataViewProduto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataViewProduto.Location = new Point(29, 78);
        dataViewProduto.Margin = new Padding(2);
        dataViewProduto.MultiSelect = false;
        dataViewProduto.Name = "dataViewProduto";
        dataViewProduto.ReadOnly = true;
        dataViewProduto.RowHeadersWidth = 62;
        dataViewProduto.Size = new Size(1184, 548);
        dataViewProduto.TabIndex = 6;
        // 
        // txt_pesquisar
        // 
        txt_pesquisar.Location = new Point(201, 29);
        txt_pesquisar.Name = "txt_pesquisar";
        txt_pesquisar.Size = new Size(373, 31);
        txt_pesquisar.TabIndex = 12;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label1.Location = new Point(61, 28);
        label1.Name = "label1";
        label1.Size = new Size(118, 32);
        label1.TabIndex = 13;
        label1.Text = "Pesquisar:";
        // 
        // btn_pesquisar
        // 
        btn_pesquisar.Location = new Point(611, 27);
        btn_pesquisar.Name = "btn_pesquisar";
        btn_pesquisar.Size = new Size(112, 34);
        btn_pesquisar.TabIndex = 14;
        btn_pesquisar.Text = "Buscar";
        btn_pesquisar.UseVisualStyleBackColor = true;
        btn_pesquisar.Click += btn_pesquisar_Click;
        // 
        // JanelaProduto
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.ActiveCaption;
        ClientSize = new Size(1609, 685);
        Controls.Add(btn_pesquisar);
        Controls.Add(label1);
        Controls.Add(txt_pesquisar);
        Controls.Add(btn_consultar);
        Controls.Add(btn_voltar);
        Controls.Add(btn_excluir);
        Controls.Add(btn_alterar);
        Controls.Add(btn_incluir);
        Controls.Add(dataViewProduto);
        Margin = new Padding(4);
        Name = "JanelaProduto";
        Text = "JanelaProduto";
        Load += JanelaProduto_Load;
        ((System.ComponentModel.ISupportInitialize)dataViewProduto).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button btn_consultar;
    private Button btn_voltar;
    private Button btn_excluir;
    private Button btn_alterar;
    private Button btn_incluir;
    private DataGridView dataViewProduto;
    private TextBox txt_pesquisar;
    private Label label1;
    private Button btn_pesquisar;
}