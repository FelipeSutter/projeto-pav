namespace PDV.Forms;

partial class JanelaContasPagar {
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
        dataViewContaPagar = new DataGridView();
        btn_voltar = new Button();
        button1 = new Button();
        btn_filtrar = new Button();
        fornecedor_box = new ComboBox();
        label1 = new Label();
        ((System.ComponentModel.ISupportInitialize)dataViewContaPagar).BeginInit();
        SuspendLayout();
        // 
        // dataViewContaPagar
        // 
        dataViewContaPagar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataViewContaPagar.Location = new Point(14, 89);
        dataViewContaPagar.Margin = new Padding(2);
        dataViewContaPagar.MultiSelect = false;
        dataViewContaPagar.Name = "dataViewContaPagar";
        dataViewContaPagar.ReadOnly = true;
        dataViewContaPagar.RowHeadersWidth = 62;
        dataViewContaPagar.Size = new Size(1164, 447);
        dataViewContaPagar.TabIndex = 9;
        dataViewContaPagar.CellContentClick += dataViewContsPagar_CellContentClick;
        // 
        // btn_voltar
        // 
        btn_voltar.BackColor = SystemColors.GradientActiveCaption;
        btn_voltar.DialogResult = DialogResult.OK;
        btn_voltar.Location = new Point(14, 566);
        btn_voltar.Margin = new Padding(2);
        btn_voltar.Name = "btn_voltar";
        btn_voltar.Size = new Size(220, 52);
        btn_voltar.TabIndex = 17;
        btn_voltar.Text = "Voltar";
        btn_voltar.UseVisualStyleBackColor = false;
        btn_voltar.Click += btn_voltar_Click;
        // 
        // button1
        // 
        button1.BackColor = SystemColors.GradientActiveCaption;
        button1.DialogResult = DialogResult.OK;
        button1.Location = new Point(958, 566);
        button1.Margin = new Padding(2);
        button1.Name = "button1";
        button1.Size = new Size(220, 52);
        button1.TabIndex = 18;
        button1.Text = "Baixar conta";
        button1.UseVisualStyleBackColor = false;
        button1.Click += button1_Click;
        // 
        // btn_filtrar
        // 
        btn_filtrar.Location = new Point(400, 40);
        btn_filtrar.Name = "btn_filtrar";
        btn_filtrar.Size = new Size(112, 34);
        btn_filtrar.TabIndex = 21;
        btn_filtrar.Text = "Filtrar";
        btn_filtrar.UseVisualStyleBackColor = true;
        btn_filtrar.Click += btn_filtrar_Click;
        // 
        // fornecedor_box
        // 
        fornecedor_box.DropDownStyle = ComboBoxStyle.DropDownList;
        fornecedor_box.FormattingEnabled = true;
        fornecedor_box.Location = new Point(184, 41);
        fornecedor_box.Name = "fornecedor_box";
        fornecedor_box.Size = new Size(182, 33);
        fornecedor_box.TabIndex = 20;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
        label1.Location = new Point(14, 33);
        label1.Name = "label1";
        label1.Size = new Size(164, 38);
        label1.TabIndex = 19;
        label1.Text = "Fornecedor:";
        // 
        // JanelaContasPagar
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.ActiveCaption;
        ClientSize = new Size(1189, 632);
        Controls.Add(btn_filtrar);
        Controls.Add(fornecedor_box);
        Controls.Add(label1);
        Controls.Add(button1);
        Controls.Add(btn_voltar);
        Controls.Add(dataViewContaPagar);
        Margin = new Padding(4);
        Name = "JanelaContasPagar";
        Text = "JanelaContasPagar";
        Load += JanelaContasPagar_Load;
        ((System.ComponentModel.ISupportInitialize)dataViewContaPagar).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private DataGridView dataViewContaPagar;
    private Button btn_voltar;
    private Button button1;
    private Button btn_filtrar;
    private ComboBox fornecedor_box;
    private Label label1;
}