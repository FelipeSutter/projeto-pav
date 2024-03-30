namespace PDV
{
    partial class JanelaVenda
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
            dataViewVenda = new DataGridView();
            btn_incluir = new Button();
            btn_voltar = new Button();
            btn_contas = new Button();
            btn_consultar_venda = new Button();
            btn_imprimir = new Button();
            inicio_datetime = new DateTimePicker();
            final_datetime = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            btn_filtrar = new Button();
            ((System.ComponentModel.ISupportInitialize) dataViewVenda).BeginInit();
            SuspendLayout();
            // 
            // dataViewVenda
            // 
            dataViewVenda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataViewVenda.Location = new Point(23, 67);
            dataViewVenda.Margin = new Padding(2);
            dataViewVenda.MultiSelect = false;
            dataViewVenda.Name = "dataViewVenda";
            dataViewVenda.ReadOnly = true;
            dataViewVenda.RowHeadersWidth = 62;
            dataViewVenda.Size = new Size(850, 306);
            dataViewVenda.TabIndex = 7;
            // 
            // btn_incluir
            // 
            btn_incluir.BackColor = SystemColors.GradientActiveCaption;
            btn_incluir.Location = new Point(901, 67);
            btn_incluir.Margin = new Padding(2);
            btn_incluir.Name = "btn_incluir";
            btn_incluir.Size = new Size(176, 42);
            btn_incluir.TabIndex = 8;
            btn_incluir.Text = "Criar venda";
            btn_incluir.UseVisualStyleBackColor = false;
            btn_incluir.Click += btn_incluir_Click;
            // 
            // btn_voltar
            // 
            btn_voltar.BackColor = SystemColors.GradientActiveCaption;
            btn_voltar.Location = new Point(901, 331);
            btn_voltar.Margin = new Padding(2);
            btn_voltar.Name = "btn_voltar";
            btn_voltar.Size = new Size(176, 42);
            btn_voltar.TabIndex = 9;
            btn_voltar.Text = "Voltar";
            btn_voltar.UseVisualStyleBackColor = false;
            btn_voltar.Click += btn_voltar_Click;
            // 
            // btn_contas
            // 
            btn_contas.BackColor = SystemColors.GradientActiveCaption;
            btn_contas.Location = new Point(901, 127);
            btn_contas.Margin = new Padding(2);
            btn_contas.Name = "btn_contas";
            btn_contas.Size = new Size(176, 42);
            btn_contas.TabIndex = 10;
            btn_contas.Text = "Contas a receber";
            btn_contas.UseVisualStyleBackColor = false;
            btn_contas.Click += btn_contas_Click;
            // 
            // btn_consultar_venda
            // 
            btn_consultar_venda.BackColor = SystemColors.GradientActiveCaption;
            btn_consultar_venda.Location = new Point(901, 185);
            btn_consultar_venda.Margin = new Padding(2);
            btn_consultar_venda.Name = "btn_consultar_venda";
            btn_consultar_venda.Size = new Size(176, 42);
            btn_consultar_venda.TabIndex = 11;
            btn_consultar_venda.Text = "Consultar venda";
            btn_consultar_venda.UseVisualStyleBackColor = false;
            btn_consultar_venda.Click += btn_consultar_venda_Click;
            // 
            // btn_imprimir
            // 
            btn_imprimir.BackColor = SystemColors.GradientActiveCaption;
            btn_imprimir.Location = new Point(901, 241);
            btn_imprimir.Margin = new Padding(2);
            btn_imprimir.Name = "btn_imprimir";
            btn_imprimir.Size = new Size(176, 42);
            btn_imprimir.TabIndex = 12;
            btn_imprimir.Text = "Imprimir vendas";
            btn_imprimir.UseVisualStyleBackColor = false;
            btn_imprimir.Click += btn_imprimir_Click;
            // 
            // inicio_datetime
            // 
            inicio_datetime.Location = new Point(71, 26);
            inicio_datetime.Name = "inicio_datetime";
            inicio_datetime.Size = new Size(305, 27);
            inicio_datetime.TabIndex = 13;
            inicio_datetime.ValueChanged += inicio_datetime_ValueChanged;
            // 
            // final_datetime
            // 
            final_datetime.Location = new Point(442, 26);
            final_datetime.Name = "final_datetime";
            final_datetime.Size = new Size(305, 27);
            final_datetime.TabIndex = 14;
            final_datetime.ValueChanged += final_datetime_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point,  0);
            label1.Location = new Point(23, 24);
            label1.Name = "label1";
            label1.Size = new Size(40, 28);
            label1.TabIndex = 15;
            label1.Text = "De:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point,  0);
            label2.Location = new Point(394, 24);
            label2.Name = "label2";
            label2.Size = new Size(46, 28);
            label2.TabIndex = 16;
            label2.Text = "Até:";
            // 
            // btn_filtrar
            // 
            btn_filtrar.Location = new Point(779, 23);
            btn_filtrar.Name = "btn_filtrar";
            btn_filtrar.Size = new Size(94, 29);
            btn_filtrar.TabIndex = 17;
            btn_filtrar.Text = "Filtrar";
            btn_filtrar.UseVisualStyleBackColor = true;
            btn_filtrar.Click += btn_filtrar_Click;
            // 
            // JanelaVenda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1088, 398);
            Controls.Add(btn_filtrar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(final_datetime);
            Controls.Add(inicio_datetime);
            Controls.Add(btn_imprimir);
            Controls.Add(btn_consultar_venda);
            Controls.Add(btn_contas);
            Controls.Add(btn_voltar);
            Controls.Add(btn_incluir);
            Controls.Add(dataViewVenda);
            Margin = new Padding(2);
            Name = "JanelaVenda";
            Text = "JanelaVenda";
            Load += JanelaVenda_Load;
            ((System.ComponentModel.ISupportInitialize) dataViewVenda).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataViewVenda;
        private Button btn_incluir;
        private Button btn_voltar;
        private Button btn_contas;
        private Button btn_consultar_venda;
        private Button btn_imprimir;
        private DateTimePicker inicio_datetime;
        private DateTimePicker final_datetime;
        private Label label1;
        private Label label2;
        private Button btn_filtrar;
    }
}