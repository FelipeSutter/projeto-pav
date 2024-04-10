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
        ((System.ComponentModel.ISupportInitialize) dataViewContaPagar).BeginInit();
        SuspendLayout();
        // 
        // dataViewContaPagar
        // 
        dataViewContaPagar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataViewContaPagar.Location = new Point(11, 11);
        dataViewContaPagar.Margin = new Padding(2);
        dataViewContaPagar.MultiSelect = false;
        dataViewContaPagar.Name = "dataViewContaPagar";
        dataViewContaPagar.ReadOnly = true;
        dataViewContaPagar.RowHeadersWidth = 62;
        dataViewContaPagar.Size = new Size(850, 438);
        dataViewContaPagar.TabIndex = 9;
        dataViewContaPagar.CellContentClick += dataViewContsPagar_CellContentClick;
        // 
        // btn_voltar
        // 
        btn_voltar.BackColor = SystemColors.GradientActiveCaption;
        btn_voltar.DialogResult = DialogResult.OK;
        btn_voltar.Location = new Point(11, 453);
        btn_voltar.Margin = new Padding(2);
        btn_voltar.Name = "btn_voltar";
        btn_voltar.Size = new Size(176, 42);
        btn_voltar.TabIndex = 17;
        btn_voltar.Text = "Voltar";
        btn_voltar.UseVisualStyleBackColor = false;
        btn_voltar.Click += btn_voltar_Click;
        // 
        // JanelaContasPagar
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.ActiveCaption;
        ClientSize = new Size(876, 506);
        Controls.Add(btn_voltar);
        Controls.Add(dataViewContaPagar);
        Name = "JanelaContasPagar";
        Text = "JanelaContasPagar";
        Load += JanelaContasPagar_Load;
        ((System.ComponentModel.ISupportInitialize) dataViewContaPagar).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private DataGridView dataViewContaPagar;
    private Button btn_voltar;
}