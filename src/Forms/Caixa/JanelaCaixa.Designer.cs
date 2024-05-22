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
            label1 = new Label();
            lb_total_caixa = new Label();
            btn_imprimir = new Button();
            label3 = new Label();
            inicio_datetime = new DateTimePicker();
            btn_filtrar = new Button();
            ((System.ComponentModel.ISupportInitialize) dataViewMovimentoCaixa).BeginInit();
            SuspendLayout();
            // 
            // dataViewMovimentoCaixa
            // 
            dataViewMovimentoCaixa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataViewMovimentoCaixa.Location = new Point(36, 75);
            dataViewMovimentoCaixa.Margin = new Padding(2);
            dataViewMovimentoCaixa.MultiSelect = false;
            dataViewMovimentoCaixa.Name = "dataViewMovimentoCaixa";
            dataViewMovimentoCaixa.ReadOnly = true;
            dataViewMovimentoCaixa.RowHeadersWidth = 62;
            dataViewMovimentoCaixa.Size = new Size(936, 435);
            dataViewMovimentoCaixa.TabIndex = 9;
            dataViewMovimentoCaixa.CellContentClick += dataViewMovimentoCaixa_CellContentClick;
            // 
            // btn_voltar
            // 
            btn_voltar.BackColor = SystemColors.GradientActiveCaption;
            btn_voltar.Location = new Point(791, 514);
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
            label1.Location = new Point(36, 528);
            label1.Name = "label1";
            label1.Size = new Size(99, 25);
            label1.TabIndex = 11;
            label1.Text = "Total Caixa:";
            // 
            // lb_total_caixa
            // 
            lb_total_caixa.AutoSize = true;
            lb_total_caixa.Location = new Point(141, 528);
            lb_total_caixa.Name = "lb_total_caixa";
            lb_total_caixa.Size = new Size(59, 25);
            lb_total_caixa.TabIndex = 12;
            lb_total_caixa.Text = "label2";
            // 
            // btn_imprimir
            // 
            btn_imprimir.BackColor = SystemColors.GradientActiveCaption;
            btn_imprimir.Location = new Point(584, 514);
            btn_imprimir.Margin = new Padding(2);
            btn_imprimir.Name = "btn_imprimir";
            btn_imprimir.Size = new Size(181, 52);
            btn_imprimir.TabIndex = 13;
            btn_imprimir.Text = "Imprimir ";
            btn_imprimir.UseVisualStyleBackColor = false;
            btn_imprimir.Click += btn_imprimir_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point,  0);
            label3.Location = new Point(38, 19);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(68, 32);
            label3.TabIndex = 27;
            label3.Text = "Data:";
            // 
            // inicio_datetime
            // 
            inicio_datetime.Location = new Point(114, 20);
            inicio_datetime.Margin = new Padding(4);
            inicio_datetime.Name = "inicio_datetime";
            inicio_datetime.Size = new Size(380, 31);
            inicio_datetime.TabIndex = 26;
            // 
            // btn_filtrar
            // 
            btn_filtrar.Location = new Point(530, 19);
            btn_filtrar.Margin = new Padding(2);
            btn_filtrar.Name = "btn_filtrar";
            btn_filtrar.Size = new Size(112, 34);
            btn_filtrar.TabIndex = 28;
            btn_filtrar.Text = "Filtrar";
            btn_filtrar.UseVisualStyleBackColor = true;
            btn_filtrar.Click += btn_filtrar_Click;
            // 
            // JanelaCaixa
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1022, 580);
            Controls.Add(btn_filtrar);
            Controls.Add(label3);
            Controls.Add(inicio_datetime);
            Controls.Add(btn_imprimir);
            Controls.Add(lb_total_caixa);
            Controls.Add(label1);
            Controls.Add(btn_voltar);
            Controls.Add(dataViewMovimentoCaixa);
            Margin = new Padding(2);
            Name = "JanelaCaixa";
            Text = "JanelaCaixa";
            Load += JanelaCaixa_Load;
            ((System.ComponentModel.ISupportInitialize) dataViewMovimentoCaixa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataViewMovimentoCaixa;
        private Button btn_voltar;
        private Label label1;
        private Label lb_total_caixa;
        private Button btn_imprimir;
        private Label label3;
        private DateTimePicker inicio_datetime;
        private Button btn_filtrar;
    }
}