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
        private void InitializeComponent()
        {
            dataViewMovimentoCaixa = new DataGridView();
            btn_voltar = new Button();
            label1 = new Label();
            lb_total_caixa = new Label();
            ((System.ComponentModel.ISupportInitialize)dataViewMovimentoCaixa).BeginInit();
            SuspendLayout();
            // 
            // dataViewMovimentoCaixa
            // 
            dataViewMovimentoCaixa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataViewMovimentoCaixa.Location = new Point(36, 42);
            dataViewMovimentoCaixa.Margin = new Padding(2);
            dataViewMovimentoCaixa.MultiSelect = false;
            dataViewMovimentoCaixa.Name = "dataViewMovimentoCaixa";
            dataViewMovimentoCaixa.ReadOnly = true;
            dataViewMovimentoCaixa.RowHeadersWidth = 62;
            dataViewMovimentoCaixa.Size = new Size(936, 435);
            dataViewMovimentoCaixa.TabIndex = 9;
            // 
            // btn_voltar
            // 
            btn_voltar.BackColor = SystemColors.GradientActiveCaption;
            btn_voltar.Location = new Point(791, 501);
            btn_voltar.Margin = new Padding(2);
            btn_voltar.Name = "btn_voltar";
            btn_voltar.Size = new Size(181, 52);
            btn_voltar.TabIndex = 10;
            btn_voltar.Text = "Voltar";
            btn_voltar.UseVisualStyleBackColor = false;
            btn_voltar.Click += btn_voltar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 491);
            label1.Name = "label1";
            label1.Size = new Size(99, 25);
            label1.TabIndex = 11;
            label1.Text = "Total Caixa:";
            // 
            // lb_total_caixa
            // 
            lb_total_caixa.AutoSize = true;
            lb_total_caixa.Location = new Point(141, 491);
            lb_total_caixa.Name = "lb_total_caixa";
            lb_total_caixa.Size = new Size(59, 25);
            lb_total_caixa.TabIndex = 12;
            lb_total_caixa.Text = "label2";
            // 
            // JanelaCaixa
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1022, 580);
            Controls.Add(lb_total_caixa);
            Controls.Add(label1);
            Controls.Add(btn_voltar);
            Controls.Add(dataViewMovimentoCaixa);
            Margin = new Padding(2);
            Name = "JanelaCaixa";
            Text = "JanelaCaixa";
            Load += JanelaCaixa_Load;
            ((System.ComponentModel.ISupportInitialize)dataViewMovimentoCaixa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataViewMovimentoCaixa;
        private Button btn_voltar;
        private Label label1;
        private Label lb_total_caixa;
    }
}