namespace PDV;

partial class JanelaItemVenda {
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
        btn_pesquisar = new Button();
        label1 = new Label();
        txt_pesquisar = new TextBox();
        btn_consultar = new Button();
        btn_voltar = new Button();
        btn_excluir = new Button();
        btn_alterar = new Button();
        btn_incluir = new Button();
        dataViewItemVenda = new DataGridView();
        btn_finalizar = new Button();
        ((System.ComponentModel.ISupportInitialize) dataViewItemVenda).BeginInit();
        SuspendLayout();
        // 
        // btn_pesquisar
        // 
        btn_pesquisar.Location = new Point(501, 35);
        btn_pesquisar.Margin = new Padding(2);
        btn_pesquisar.Name = "btn_pesquisar";
        btn_pesquisar.Size = new Size(90, 27);
        btn_pesquisar.TabIndex = 23;
        btn_pesquisar.Text = "Buscar";
        btn_pesquisar.UseVisualStyleBackColor = true;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point,  0);
        label1.Location = new Point(61, 35);
        label1.Margin = new Padding(2, 0, 2, 0);
        label1.Name = "label1";
        label1.Size = new Size(97, 28);
        label1.TabIndex = 22;
        label1.Text = "Pesquisar:";
        // 
        // txt_pesquisar
        // 
        txt_pesquisar.Location = new Point(173, 36);
        txt_pesquisar.Margin = new Padding(2);
        txt_pesquisar.Name = "txt_pesquisar";
        txt_pesquisar.Size = new Size(299, 27);
        txt_pesquisar.TabIndex = 21;
        // 
        // btn_consultar
        // 
        btn_consultar.BackColor = SystemColors.GradientActiveCaption;
        btn_consultar.Location = new Point(1030, 263);
        btn_consultar.Margin = new Padding(2);
        btn_consultar.Name = "btn_consultar";
        btn_consultar.Size = new Size(176, 42);
        btn_consultar.TabIndex = 20;
        btn_consultar.Text = "Consultar";
        btn_consultar.UseVisualStyleBackColor = false;
        btn_consultar.Click += btn_consultar_Click;
        // 
        // btn_voltar
        // 
        btn_voltar.BackColor = SystemColors.GradientActiveCaption;
        btn_voltar.Location = new Point(1030, 468);
        btn_voltar.Margin = new Padding(2);
        btn_voltar.Name = "btn_voltar";
        btn_voltar.Size = new Size(176, 42);
        btn_voltar.TabIndex = 19;
        btn_voltar.Text = "Voltar";
        btn_voltar.UseVisualStyleBackColor = false;
        btn_voltar.Click += btn_voltar_Click;
        // 
        // btn_excluir
        // 
        btn_excluir.BackColor = SystemColors.GradientActiveCaption;
        btn_excluir.Location = new Point(1030, 198);
        btn_excluir.Margin = new Padding(2);
        btn_excluir.Name = "btn_excluir";
        btn_excluir.Size = new Size(176, 42);
        btn_excluir.TabIndex = 18;
        btn_excluir.Text = "Excluir";
        btn_excluir.UseVisualStyleBackColor = false;
        btn_excluir.Click += btn_excluir_Click;
        // 
        // btn_alterar
        // 
        btn_alterar.BackColor = SystemColors.GradientActiveCaption;
        btn_alterar.Location = new Point(1030, 134);
        btn_alterar.Margin = new Padding(2);
        btn_alterar.Name = "btn_alterar";
        btn_alterar.Size = new Size(176, 42);
        btn_alterar.TabIndex = 17;
        btn_alterar.Text = "Alterar";
        btn_alterar.UseVisualStyleBackColor = false;
        btn_alterar.Click += btn_alterar_Click;
        // 
        // btn_incluir
        // 
        btn_incluir.BackColor = SystemColors.GradientActiveCaption;
        btn_incluir.Location = new Point(1030, 75);
        btn_incluir.Margin = new Padding(2);
        btn_incluir.Name = "btn_incluir";
        btn_incluir.Size = new Size(176, 42);
        btn_incluir.TabIndex = 16;
        btn_incluir.Text = "Incluir";
        btn_incluir.UseVisualStyleBackColor = false;
        btn_incluir.Click += btn_incluir_Click;
        // 
        // dataViewItemVenda
        // 
        dataViewItemVenda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataViewItemVenda.Location = new Point(35, 75);
        dataViewItemVenda.Margin = new Padding(2);
        dataViewItemVenda.MultiSelect = false;
        dataViewItemVenda.Name = "dataViewItemVenda";
        dataViewItemVenda.ReadOnly = true;
        dataViewItemVenda.RowHeadersWidth = 62;
        dataViewItemVenda.Size = new Size(947, 438);
        dataViewItemVenda.TabIndex = 15;
        dataViewItemVenda.CellContentClick += dataViewVenda_CellContentClick;
        // 
        // btn_finalizar
        // 
        btn_finalizar.BackColor = SystemColors.GradientActiveCaption;
        btn_finalizar.Location = new Point(1030, 365);
        btn_finalizar.Margin = new Padding(2);
        btn_finalizar.Name = "btn_finalizar";
        btn_finalizar.Size = new Size(176, 42);
        btn_finalizar.TabIndex = 24;
        btn_finalizar.Text = "Finalizar";
        btn_finalizar.UseVisualStyleBackColor = false;
        btn_finalizar.Click += btn_finalizar_Click;
        // 
        // JanelaVenda
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.ActiveCaption;
        ClientSize = new Size(1261, 548);
        Controls.Add(btn_finalizar);
        Controls.Add(btn_pesquisar);
        Controls.Add(label1);
        Controls.Add(txt_pesquisar);
        Controls.Add(btn_consultar);
        Controls.Add(btn_voltar);
        Controls.Add(btn_excluir);
        Controls.Add(btn_alterar);
        Controls.Add(btn_incluir);
        Controls.Add(dataViewItemVenda);
        Name = "JanelaVenda";
        Text = "JanelaVenda";
        Load += JanelaVenda_Load;
        ((System.ComponentModel.ISupportInitialize) dataViewItemVenda).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button btn_pesquisar;
    private Label label1;
    private TextBox txt_pesquisar;
    private Button btn_consultar;
    private Button btn_voltar;
    private Button btn_excluir;
    private Button btn_alterar;
    private Button btn_incluir;
    private DataGridView dataViewItemVenda;
    private Button btn_finalizar;
}