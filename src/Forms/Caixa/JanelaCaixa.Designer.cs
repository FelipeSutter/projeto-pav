namespace PDV
{
    partial class JanelaCaixa
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
        private void InitializeComponent() {
            dataViewMovimentoCaixa = new DataGridView();
            btn_voltar = new Button();
            ((System.ComponentModel.ISupportInitialize) dataViewMovimentoCaixa).BeginInit();
            SuspendLayout();
            // 
            // dataViewMovimentoCaixa
            // 
            dataViewMovimentoCaixa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataViewMovimentoCaixa.Location = new Point(29, 34);
            dataViewMovimentoCaixa.Margin = new Padding(2);
            dataViewMovimentoCaixa.MultiSelect = false;
            dataViewMovimentoCaixa.Name = "dataViewMovimentoCaixa";
            dataViewMovimentoCaixa.ReadOnly = true;
            dataViewMovimentoCaixa.RowHeadersWidth = 62;
            dataViewMovimentoCaixa.Size = new Size(749, 348);
            dataViewMovimentoCaixa.TabIndex = 9;
            // 
            // btn_voltar
            // 
            btn_voltar.BackColor = SystemColors.GradientActiveCaption;
            btn_voltar.Location = new Point(633, 401);
            btn_voltar.Margin = new Padding(2);
            btn_voltar.Name = "btn_voltar";
            btn_voltar.Size = new Size(145, 42);
            btn_voltar.TabIndex = 10;
            btn_voltar.Text = "Voltar";
            btn_voltar.UseVisualStyleBackColor = false;
            btn_voltar.Click += btn_voltar_Click;
            // 
            // JanelaCaixa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(818, 464);
            Controls.Add(btn_voltar);
            Controls.Add(dataViewMovimentoCaixa);
            Margin = new Padding(2, 2, 2, 2);
            Name = "JanelaCaixa";
            Text = "JanelaCaixa";
            ((System.ComponentModel.ISupportInitialize) dataViewMovimentoCaixa).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataViewMovimentoCaixa;
        private Button btn_voltar;
    }
}