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
    private void InitializeComponent() {
        dataViewContaPagar = new DataGridView();
        btn_voltar = new Button();
        button1 = new Button();
        btn_filtrar = new Button();
        fornecedor_box = new ComboBox();
        label1 = new Label();
        btn_filtrar_data = new Button();
        label2 = new Label();
        label3 = new Label();
        final_datetime = new DateTimePicker();
        inicio_datetime = new DateTimePicker();
        btn_imprimir = new Button();
        ((System.ComponentModel.ISupportInitialize) dataViewContaPagar).BeginInit();
        SuspendLayout();
        // 
        // dataViewContaPagar
        // 
        dataViewContaPagar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataViewContaPagar.Location = new Point(11, 137);
        dataViewContaPagar.Margin = new Padding(2);
        dataViewContaPagar.MultiSelect = false;
        dataViewContaPagar.Name = "dataViewContaPagar";
        dataViewContaPagar.ReadOnly = true;
        dataViewContaPagar.RowHeadersWidth = 62;
        dataViewContaPagar.Size = new Size(931, 358);
        dataViewContaPagar.TabIndex = 9;
        dataViewContaPagar.CellContentClick += dataViewContsPagar_CellContentClick;
        // 
        // btn_voltar
        // 
        btn_voltar.BackColor = SystemColors.GradientActiveCaption;
        btn_voltar.DialogResult = DialogResult.OK;
        btn_voltar.Location = new Point(958, 453);
        btn_voltar.Margin = new Padding(2);
        btn_voltar.Name = "btn_voltar";
        btn_voltar.Size = new Size(176, 42);
        btn_voltar.TabIndex = 17;
        btn_voltar.Text = "Voltar";
        btn_voltar.UseVisualStyleBackColor = false;
        btn_voltar.Click += btn_voltar_Click;
        // 
        // button1
        // 
        button1.BackColor = SystemColors.GradientActiveCaption;
        button1.DialogResult = DialogResult.OK;
        button1.Location = new Point(958, 137);
        button1.Margin = new Padding(2);
        button1.Name = "button1";
        button1.Size = new Size(176, 42);
        button1.TabIndex = 18;
        button1.Text = "Baixar conta";
        button1.UseVisualStyleBackColor = false;
        button1.Click += button1_Click;
        // 
        // btn_filtrar
        // 
        btn_filtrar.Location = new Point(320, 32);
        btn_filtrar.Margin = new Padding(2, 2, 2, 2);
        btn_filtrar.Name = "btn_filtrar";
        btn_filtrar.Size = new Size(90, 27);
        btn_filtrar.TabIndex = 21;
        btn_filtrar.Text = "Filtrar";
        btn_filtrar.UseVisualStyleBackColor = true;
        btn_filtrar.Click += btn_filtrar_Click;
        // 
        // fornecedor_box
        // 
        fornecedor_box.DropDownStyle = ComboBoxStyle.DropDownList;
        fornecedor_box.FormattingEnabled = true;
        fornecedor_box.Location = new Point(147, 33);
        fornecedor_box.Margin = new Padding(2, 2, 2, 2);
        fornecedor_box.Name = "fornecedor_box";
        fornecedor_box.Size = new Size(146, 28);
        fornecedor_box.TabIndex = 20;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point,  0);
        label1.Location = new Point(11, 26);
        label1.Margin = new Padding(2, 0, 2, 0);
        label1.Name = "label1";
        label1.Size = new Size(140, 32);
        label1.TabIndex = 19;
        label1.Text = "Fornecedor:";
        // 
        // btn_filtrar_data
        // 
        btn_filtrar_data.Location = new Point(769, 84);
        btn_filtrar_data.Name = "btn_filtrar_data";
        btn_filtrar_data.Size = new Size(128, 29);
        btn_filtrar_data.TabIndex = 27;
        btn_filtrar_data.Text = "Filtrar por data";
        btn_filtrar_data.UseVisualStyleBackColor = true;
        btn_filtrar_data.Click += btn_filtrar_data_Click;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point,  0);
        label2.Location = new Point(386, 84);
        label2.Name = "label2";
        label2.Size = new Size(46, 28);
        label2.TabIndex = 26;
        label2.Text = "Até:";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point,  0);
        label3.Location = new Point(15, 84);
        label3.Name = "label3";
        label3.Size = new Size(40, 28);
        label3.TabIndex = 25;
        label3.Text = "De:";
        // 
        // final_datetime
        // 
        final_datetime.Location = new Point(434, 86);
        final_datetime.Name = "final_datetime";
        final_datetime.Size = new Size(305, 27);
        final_datetime.TabIndex = 24;
        // 
        // inicio_datetime
        // 
        inicio_datetime.Location = new Point(63, 86);
        inicio_datetime.Name = "inicio_datetime";
        inicio_datetime.Size = new Size(305, 27);
        inicio_datetime.TabIndex = 23;
        // 
        // btn_imprimir
        // 
        btn_imprimir.BackColor = SystemColors.GradientActiveCaption;
        btn_imprimir.Location = new Point(958, 203);
        btn_imprimir.Margin = new Padding(2);
        btn_imprimir.Name = "btn_imprimir";
        btn_imprimir.Size = new Size(176, 42);
        btn_imprimir.TabIndex = 28;
        btn_imprimir.Text = "Imprimir Contas";
        btn_imprimir.UseVisualStyleBackColor = false;
        btn_imprimir.Click += btn_imprimir_Click;
        // 
        // JanelaContasPagar
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.ActiveCaption;
        ClientSize = new Size(1145, 506);
        Controls.Add(btn_imprimir);
        Controls.Add(btn_filtrar_data);
        Controls.Add(label2);
        Controls.Add(label3);
        Controls.Add(final_datetime);
        Controls.Add(inicio_datetime);
        Controls.Add(btn_filtrar);
        Controls.Add(fornecedor_box);
        Controls.Add(label1);
        Controls.Add(button1);
        Controls.Add(btn_voltar);
        Controls.Add(dataViewContaPagar);
        Name = "JanelaContasPagar";
        Text = "JanelaContasPagar";
        Load += JanelaContasPagar_Load;
        ((System.ComponentModel.ISupportInitialize) dataViewContaPagar).EndInit();
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
    private Button btn_filtrar_data;
    private Label label2;
    private Label label3;
    private DateTimePicker final_datetime;
    private DateTimePicker inicio_datetime;
    private Button btn_imprimir;
}