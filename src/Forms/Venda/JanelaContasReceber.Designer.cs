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
        private void InitializeComponent()
        {
            dataViewContaReceber = new DataGridView();
            btn_voltar = new Button();
            btn_baixar_conta = new Button();
            label1 = new Label();
            cliente_box = new ComboBox();
            btn_filtrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataViewContaReceber).BeginInit();
            SuspendLayout();
            // 
            // dataViewContaReceber
            // 
            dataViewContaReceber.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataViewContaReceber.Location = new Point(14, 88);
            dataViewContaReceber.Margin = new Padding(2);
            dataViewContaReceber.MultiSelect = false;
            dataViewContaReceber.Name = "dataViewContaReceber";
            dataViewContaReceber.ReadOnly = true;
            dataViewContaReceber.RowHeadersWidth = 62;
            dataViewContaReceber.Size = new Size(1168, 452);
            dataViewContaReceber.TabIndex = 8;
            // 
            // btn_voltar
            // 
            btn_voltar.BackColor = SystemColors.GradientActiveCaption;
            btn_voltar.Location = new Point(14, 562);
            btn_voltar.Margin = new Padding(2);
            btn_voltar.Name = "btn_voltar";
            btn_voltar.Size = new Size(220, 52);
            btn_voltar.TabIndex = 10;
            btn_voltar.Text = "Voltar";
            btn_voltar.UseVisualStyleBackColor = false;
            btn_voltar.Click += btn_voltar_Click;
            // 
            // btn_baixar_conta
            // 
            btn_baixar_conta.BackColor = SystemColors.GradientActiveCaption;
            btn_baixar_conta.Location = new Point(976, 562);
            btn_baixar_conta.Margin = new Padding(2);
            btn_baixar_conta.Name = "btn_baixar_conta";
            btn_baixar_conta.Size = new Size(205, 52);
            btn_baixar_conta.TabIndex = 11;
            btn_baixar_conta.Text = "Baixar conta";
            btn_baixar_conta.UseVisualStyleBackColor = false;
            btn_baixar_conta.Click += btn_baixar_conta_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 21);
            label1.Name = "label1";
            label1.Size = new Size(109, 38);
            label1.TabIndex = 12;
            label1.Text = "Cliente:";
            // 
            // cliente_box
            // 
            cliente_box.DropDownStyle = ComboBoxStyle.DropDownList;
            cliente_box.FormattingEnabled = true;
            cliente_box.Location = new Point(129, 29);
            cliente_box.Name = "cliente_box";
            cliente_box.Size = new Size(182, 33);
            cliente_box.TabIndex = 13;
            // 
            // btn_filtrar
            // 
            btn_filtrar.Location = new Point(329, 29);
            btn_filtrar.Name = "btn_filtrar";
            btn_filtrar.Size = new Size(112, 34);
            btn_filtrar.TabIndex = 14;
            btn_filtrar.Text = "Filtrar";
            btn_filtrar.UseVisualStyleBackColor = true;
            btn_filtrar.Click += btn_filtrar_Click;
            // 
            // JanelaContasReceber
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1195, 629);
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
            ((System.ComponentModel.ISupportInitialize)dataViewContaReceber).EndInit();
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
    }
}