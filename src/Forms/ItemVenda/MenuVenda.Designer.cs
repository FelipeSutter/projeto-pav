namespace PDV.Forms;

partial class MenuVenda {
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
        label1 = new Label();
        btn_incluir_venda = new Button();
        btn_consultar_venda = new Button();
        btn_voltar = new Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point,  0);
        label1.Location = new Point(205, 43);
        label1.Name = "label1";
        label1.Size = new Size(241, 41);
        label1.TabIndex = 0;
        label1.Text = "Menu de Vendas";
        // 
        // btn_incluir_venda
        // 
        btn_incluir_venda.BackColor = SystemColors.GradientActiveCaption;
        btn_incluir_venda.Location = new Point(185, 144);
        btn_incluir_venda.Margin = new Padding(2);
        btn_incluir_venda.Name = "btn_incluir_venda";
        btn_incluir_venda.Size = new Size(273, 57);
        btn_incluir_venda.TabIndex = 6;
        btn_incluir_venda.Text = "Incluir venda";
        btn_incluir_venda.UseVisualStyleBackColor = false;
        btn_incluir_venda.Click += btn_incluir_venda_Click;
        // 
        // btn_consultar_venda
        // 
        btn_consultar_venda.BackColor = SystemColors.GradientActiveCaption;
        btn_consultar_venda.Location = new Point(185, 221);
        btn_consultar_venda.Margin = new Padding(2);
        btn_consultar_venda.Name = "btn_consultar_venda";
        btn_consultar_venda.Size = new Size(273, 57);
        btn_consultar_venda.TabIndex = 7;
        btn_consultar_venda.Text = "Consultar venda";
        btn_consultar_venda.UseVisualStyleBackColor = false;
        btn_consultar_venda.Click += btn_consultar_venda_Click;
        // 
        // btn_voltar
        // 
        btn_voltar.BackColor = SystemColors.GradientActiveCaption;
        btn_voltar.Location = new Point(24, 347);
        btn_voltar.Margin = new Padding(2);
        btn_voltar.Name = "btn_voltar";
        btn_voltar.Size = new Size(110, 38);
        btn_voltar.TabIndex = 8;
        btn_voltar.Text = "Voltar";
        btn_voltar.UseVisualStyleBackColor = false;
        btn_voltar.Click += btn_voltar_Click;
        // 
        // MenuVenda
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.ActiveCaption;
        ClientSize = new Size(675, 396);
        Controls.Add(btn_voltar);
        Controls.Add(btn_consultar_venda);
        Controls.Add(btn_incluir_venda);
        Controls.Add(label1);
        Name = "MenuVenda";
        Text = "MenuVenda";
        Load += MenuVenda_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private Button btn_incluir_venda;
    private Button btn_consultar_venda;
    private Button btn_voltar;
}