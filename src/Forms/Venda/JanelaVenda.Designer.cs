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
            ((System.ComponentModel.ISupportInitialize) dataViewVenda).BeginInit();
            SuspendLayout();
            // 
            // dataViewVenda
            // 
            dataViewVenda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataViewVenda.Location = new Point(22, 26);
            dataViewVenda.Margin = new Padding(2);
            dataViewVenda.MultiSelect = false;
            dataViewVenda.Name = "dataViewVenda";
            dataViewVenda.ReadOnly = true;
            dataViewVenda.RowHeadersWidth = 62;
            dataViewVenda.Size = new Size(850, 267);
            dataViewVenda.TabIndex = 7;
            // 
            // btn_incluir
            // 
            btn_incluir.BackColor = SystemColors.GradientActiveCaption;
            btn_incluir.Location = new Point(898, 26);
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
            btn_voltar.Location = new Point(898, 251);
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
            btn_contas.Location = new Point(898, 86);
            btn_contas.Margin = new Padding(2, 2, 2, 2);
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
            btn_consultar_venda.Location = new Point(898, 152);
            btn_consultar_venda.Margin = new Padding(2);
            btn_consultar_venda.Name = "btn_consultar_venda";
            btn_consultar_venda.Size = new Size(176, 42);
            btn_consultar_venda.TabIndex = 11;
            btn_consultar_venda.Text = "Consultar venda";
            btn_consultar_venda.UseVisualStyleBackColor = false;
            btn_consultar_venda.Click += btn_consultar_venda_Click;
            // 
            // JanelaVenda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1088, 398);
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
        }

        #endregion

        private DataGridView dataViewVenda;
        private Button btn_incluir;
        private Button btn_voltar;
        private Button btn_contas;
        private Button btn_consultar_venda;
    }
}