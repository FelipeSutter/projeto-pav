namespace PDV.Forms.Venda
{
    partial class JanelaContasReceber
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
            dataViewContaReceber = new DataGridView();
            btn_voltar = new Button();
            btn_baixar_conta = new Button();
            ((System.ComponentModel.ISupportInitialize) dataViewContaReceber).BeginInit();
            SuspendLayout();
            // 
            // dataViewContaReceber
            // 
            dataViewContaReceber.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataViewContaReceber.Location = new Point(11, 70);
            dataViewContaReceber.Margin = new Padding(2);
            dataViewContaReceber.MultiSelect = false;
            dataViewContaReceber.Name = "dataViewContaReceber";
            dataViewContaReceber.ReadOnly = true;
            dataViewContaReceber.RowHeadersWidth = 62;
            dataViewContaReceber.Size = new Size(934, 362);
            dataViewContaReceber.TabIndex = 8;
            // 
            // btn_voltar
            // 
            btn_voltar.BackColor = SystemColors.GradientActiveCaption;
            btn_voltar.Location = new Point(11, 450);
            btn_voltar.Margin = new Padding(2);
            btn_voltar.Name = "btn_voltar";
            btn_voltar.Size = new Size(176, 42);
            btn_voltar.TabIndex = 10;
            btn_voltar.Text = "Voltar";
            btn_voltar.UseVisualStyleBackColor = false;
            btn_voltar.Click += btn_voltar_Click;
            // 
            // btn_baixar_conta
            // 
            btn_baixar_conta.BackColor = SystemColors.GradientActiveCaption;
            btn_baixar_conta.Location = new Point(781, 450);
            btn_baixar_conta.Margin = new Padding(2);
            btn_baixar_conta.Name = "btn_baixar_conta";
            btn_baixar_conta.Size = new Size(164, 42);
            btn_baixar_conta.TabIndex = 11;
            btn_baixar_conta.Text = "Baixar conta";
            btn_baixar_conta.UseVisualStyleBackColor = false;
            btn_baixar_conta.Click += btn_baixar_conta_Click;
            // 
            // JanelaContasReceber
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(956, 503);
            Controls.Add(btn_baixar_conta);
            Controls.Add(btn_voltar);
            Controls.Add(dataViewContaReceber);
            Margin = new Padding(2);
            Name = "JanelaContasReceber";
            Text = "JanelaContasReceber";
            Load += JanelaContasReceber_Load;
            ((System.ComponentModel.ISupportInitialize) dataViewContaReceber).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataViewContaReceber;
        private Button btn_voltar;
        private Button btn_baixar_conta;
    }
}