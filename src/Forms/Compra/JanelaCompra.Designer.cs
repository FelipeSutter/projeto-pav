namespace PDV
{
    partial class JanelaCompra
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
            btn_filtrar = new Button();
            label2 = new Label();
            label1 = new Label();
            final_datetime = new DateTimePicker();
            inicio_datetime = new DateTimePicker();
            btn_imprimir = new Button();
            btn_consultar_venda = new Button();
            btn_voltar = new Button();
            btn_incluir = new Button();
            dataViewCompra = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataViewCompra).BeginInit();
            SuspendLayout();
            // 
            // btn_filtrar
            // 
            btn_filtrar.Location = new Point(967, 19);
            btn_filtrar.Margin = new Padding(4);
            btn_filtrar.Name = "btn_filtrar";
            btn_filtrar.Size = new Size(118, 36);
            btn_filtrar.TabIndex = 28;
            btn_filtrar.Text = "Filtrar";
            btn_filtrar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(485, 20);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(55, 32);
            label2.TabIndex = 27;
            label2.Text = "Até:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 20);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(49, 32);
            label1.TabIndex = 26;
            label1.Text = "De:";
            // 
            // final_datetime
            // 
            final_datetime.Location = new Point(545, 22);
            final_datetime.Margin = new Padding(4);
            final_datetime.Name = "final_datetime";
            final_datetime.Size = new Size(380, 31);
            final_datetime.TabIndex = 25;
            // 
            // inicio_datetime
            // 
            inicio_datetime.Location = new Point(82, 22);
            inicio_datetime.Margin = new Padding(4);
            inicio_datetime.Name = "inicio_datetime";
            inicio_datetime.Size = new Size(380, 31);
            inicio_datetime.TabIndex = 24;
            // 
            // btn_imprimir
            // 
            btn_imprimir.BackColor = SystemColors.GradientActiveCaption;
            btn_imprimir.Location = new Point(1119, 212);
            btn_imprimir.Margin = new Padding(2);
            btn_imprimir.Name = "btn_imprimir";
            btn_imprimir.Size = new Size(220, 52);
            btn_imprimir.TabIndex = 23;
            btn_imprimir.Text = "Imprimir compras";
            btn_imprimir.UseVisualStyleBackColor = false;
            // 
            // btn_consultar_venda
            // 
            btn_consultar_venda.BackColor = SystemColors.GradientActiveCaption;
            btn_consultar_venda.Location = new Point(1119, 142);
            btn_consultar_venda.Margin = new Padding(2);
            btn_consultar_venda.Name = "btn_consultar_venda";
            btn_consultar_venda.Size = new Size(220, 52);
            btn_consultar_venda.TabIndex = 22;
            btn_consultar_venda.Text = "Consultar compra";
            btn_consultar_venda.UseVisualStyleBackColor = false;
            // 
            // btn_voltar
            // 
            btn_voltar.BackColor = SystemColors.GradientActiveCaption;
            btn_voltar.Location = new Point(1119, 404);
            btn_voltar.Margin = new Padding(2);
            btn_voltar.Name = "btn_voltar";
            btn_voltar.Size = new Size(220, 52);
            btn_voltar.TabIndex = 20;
            btn_voltar.Text = "Voltar";
            btn_voltar.UseVisualStyleBackColor = false;
            btn_voltar.Click += btn_voltar_Click;
            // 
            // btn_incluir
            // 
            btn_incluir.BackColor = SystemColors.GradientActiveCaption;
            btn_incluir.Location = new Point(1119, 74);
            btn_incluir.Margin = new Padding(2);
            btn_incluir.Name = "btn_incluir";
            btn_incluir.Size = new Size(220, 52);
            btn_incluir.TabIndex = 19;
            btn_incluir.Text = "Criar compra";
            btn_incluir.UseVisualStyleBackColor = false;
            btn_incluir.Click += btn_incluir_Click;
            // 
            // dataViewCompra
            // 
            dataViewCompra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataViewCompra.Location = new Point(22, 74);
            dataViewCompra.Margin = new Padding(2);
            dataViewCompra.MultiSelect = false;
            dataViewCompra.Name = "dataViewCompra";
            dataViewCompra.ReadOnly = true;
            dataViewCompra.RowHeadersWidth = 62;
            dataViewCompra.Size = new Size(1062, 382);
            dataViewCompra.TabIndex = 18;
            // 
            // JanelaCompra
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1385, 517);
            Controls.Add(btn_filtrar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(final_datetime);
            Controls.Add(inicio_datetime);
            Controls.Add(btn_imprimir);
            Controls.Add(btn_consultar_venda);
            Controls.Add(btn_voltar);
            Controls.Add(btn_incluir);
            Controls.Add(dataViewCompra);
            Name = "JanelaCompra";
            Text = "JanelaCompra";
            ((System.ComponentModel.ISupportInitialize)dataViewCompra).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_filtrar;
        private Label label2;
        private Label label1;
        private DateTimePicker final_datetime;
        private DateTimePicker inicio_datetime;
        private Button btn_imprimir;
        private Button btn_consultar_venda;
        private Button btn_voltar;
        private Button btn_incluir;
        private DataGridView dataViewCompra;
    }
}