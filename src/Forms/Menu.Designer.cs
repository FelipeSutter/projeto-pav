namespace PDV
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            btn_Venda = new Button();
            btn_caixa = new Button();
            btn_compras = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(82, 177);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(341, 71);
            button1.TabIndex = 0;
            button1.Text = "Clientes";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.GradientActiveCaption;
            button2.Location = new Point(82, 284);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(341, 71);
            button2.TabIndex = 1;
            button2.Text = "Produtos";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.GradientActiveCaption;
            button3.Location = new Point(462, 177);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(341, 71);
            button3.TabIndex = 2;
            button3.Text = "Fornecedores";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.GradientActiveCaption;
            button4.Location = new Point(462, 284);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(341, 71);
            button4.TabIndex = 3;
            button4.Text = "Classificação Produtos";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(253, 59);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(376, 48);
            label1.TabIndex = 4;
            label1.Text = "Comércio de Produtos";
            label1.Click += label1_Click;
            // 
            // btn_Venda
            // 
            btn_Venda.BackColor = SystemColors.GradientActiveCaption;
            btn_Venda.Location = new Point(82, 391);
            btn_Venda.Margin = new Padding(2);
            btn_Venda.Name = "btn_Venda";
            btn_Venda.Size = new Size(341, 71);
            btn_Venda.TabIndex = 5;
            btn_Venda.Text = "Vendas";
            btn_Venda.UseVisualStyleBackColor = false;
            btn_Venda.Click += btn_Venda_Click;
            // 
            // btn_caixa
            // 
            btn_caixa.BackColor = SystemColors.GradientActiveCaption;
            btn_caixa.Location = new Point(267, 487);
            btn_caixa.Margin = new Padding(2);
            btn_caixa.Name = "btn_caixa";
            btn_caixa.Size = new Size(341, 71);
            btn_caixa.TabIndex = 6;
            btn_caixa.Text = "Caixa";
            btn_caixa.UseVisualStyleBackColor = false;
            btn_caixa.Click += btn_caixa_Click;
            // 
            // btn_compras
            // 
            btn_compras.BackColor = SystemColors.GradientActiveCaption;
            btn_compras.Location = new Point(462, 391);
            btn_compras.Margin = new Padding(2);
            btn_compras.Name = "btn_compras";
            btn_compras.Size = new Size(341, 71);
            btn_compras.TabIndex = 7;
            btn_compras.Text = "Compras";
            btn_compras.UseVisualStyleBackColor = false;
            btn_compras.Click += btn_compras_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(882, 577);
            Controls.Add(btn_compras);
            Controls.Add(btn_caixa);
            Controls.Add(btn_Venda);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(2);
            Name = "Menu";
            Text = "Menu Principal";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
        private Button btn_Venda;
        private Button btn_caixa;
        private Button btn_compras;
    }
}
