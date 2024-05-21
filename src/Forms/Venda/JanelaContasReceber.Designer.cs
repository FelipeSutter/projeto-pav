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
            label1 = new Label();
            cliente_box = new ComboBox();
            btn_filtrar = new Button();
            btn_filtrar_data = new Button();
            label2 = new Label();
            label3 = new Label();
            final_datetime = new DateTimePicker();
            inicio_datetime = new DateTimePicker();
            btn_imprimir = new Button();
            ((System.ComponentModel.ISupportInitialize) dataViewContaReceber).BeginInit();
            SuspendLayout();
            // 
            // dataViewContaReceber
            // 
            dataViewContaReceber.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataViewContaReceber.Location = new Point(13, 115);
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
            btn_voltar.Location = new Point(955, 430);
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
            btn_baixar_conta.Location = new Point(955, 115);
            btn_baixar_conta.Margin = new Padding(2);
            btn_baixar_conta.Name = "btn_baixar_conta";
            btn_baixar_conta.Size = new Size(176, 42);
            btn_baixar_conta.TabIndex = 11;
            btn_baixar_conta.Text = "Baixar conta";
            btn_baixar_conta.UseVisualStyleBackColor = false;
            btn_baixar_conta.Click += btn_baixar_conta_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point,  0);
            label1.Location = new Point(11, 17);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(94, 32);
            label1.TabIndex = 12;
            label1.Text = "Cliente:";
            // 
            // cliente_box
            // 
            cliente_box.DropDownStyle = ComboBoxStyle.DropDownList;
            cliente_box.FormattingEnabled = true;
            cliente_box.Location = new Point(103, 23);
            cliente_box.Margin = new Padding(2);
            cliente_box.Name = "cliente_box";
            cliente_box.Size = new Size(146, 28);
            cliente_box.TabIndex = 13;
            // 
            // btn_filtrar
            // 
            btn_filtrar.Location = new Point(263, 23);
            btn_filtrar.Margin = new Padding(2);
            btn_filtrar.Name = "btn_filtrar";
            btn_filtrar.Size = new Size(90, 27);
            btn_filtrar.TabIndex = 14;
            btn_filtrar.Text = "Filtrar";
            btn_filtrar.UseVisualStyleBackColor = true;
            btn_filtrar.Click += btn_filtrar_Click;
            // 
            // btn_filtrar_data
            // 
            btn_filtrar_data.Location = new Point(769, 69);
            btn_filtrar_data.Name = "btn_filtrar_data";
            btn_filtrar_data.Size = new Size(128, 29);
            btn_filtrar_data.TabIndex = 22;
            btn_filtrar_data.Text = "Filtrar por data";
            btn_filtrar_data.UseVisualStyleBackColor = true;
            btn_filtrar_data.Click += btn_filtrar_data_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point,  0);
            label2.Location = new Point(384, 70);
            label2.Name = "label2";
            label2.Size = new Size(46, 28);
            label2.TabIndex = 21;
            label2.Text = "Até:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point,  0);
            label3.Location = new Point(13, 70);
            label3.Name = "label3";
            label3.Size = new Size(40, 28);
            label3.TabIndex = 20;
            label3.Text = "De:";
            // 
            // final_datetime
            // 
            final_datetime.Location = new Point(432, 72);
            final_datetime.Name = "final_datetime";
            final_datetime.Size = new Size(305, 27);
            final_datetime.TabIndex = 19;
            // 
            // inicio_datetime
            // 
            inicio_datetime.Location = new Point(61, 72);
            inicio_datetime.Name = "inicio_datetime";
            inicio_datetime.Size = new Size(305, 27);
            inicio_datetime.TabIndex = 18;
            // 
            // btn_imprimir
            // 
            btn_imprimir.BackColor = SystemColors.GradientActiveCaption;
            btn_imprimir.Location = new Point(955, 179);
            btn_imprimir.Margin = new Padding(2);
            btn_imprimir.Name = "btn_imprimir";
            btn_imprimir.Size = new Size(176, 42);
            btn_imprimir.TabIndex = 23;
            btn_imprimir.Text = "Imprimir Contas";
            btn_imprimir.UseVisualStyleBackColor = false;
            btn_imprimir.Click += btn_imprimir_Click;
            // 
            // JanelaContasReceber
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1142, 483);
            Controls.Add(btn_imprimir);
            Controls.Add(btn_filtrar_data);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(final_datetime);
            Controls.Add(inicio_datetime);
            Controls.Add(btn_filtrar);
            Controls.Add(cliente_box);
            Controls.Add(label1);
            Controls.Add(btn_baixar_conta);
            Controls.Add(btn_voltar);
            Controls.Add(dataViewContaReceber);
            Margin = new Padding(2);
            Name = "JanelaContasReceber";
            Text = "JanelaContasReceber";
            Load += JanelaContasReceber_Load;
            ((System.ComponentModel.ISupportInitialize) dataViewContaReceber).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataViewContaReceber;
        private Button btn_voltar;
        private Button btn_baixar_conta;
        private Label label1;
        private ComboBox cliente_box;
        private Button btn_filtrar;
        private Button btn_filtrar_data;
        private Label label2;
        private Label label3;
        private DateTimePicker final_datetime;
        private DateTimePicker inicio_datetime;
        private Button btn_imprimir;
    }
}