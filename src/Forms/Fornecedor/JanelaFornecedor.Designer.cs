namespace PDV.Forms
{
    partial class JanelaFornecedor
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
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            dataViewFornecedor = new DataGridView();
            btn_pesquisar = new Button();
            label1 = new Label();
            txt_pesquisar = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataViewFornecedor).BeginInit();
            SuspendLayout();
            // 
            // button5
            // 
            button5.BackColor = SystemColors.GradientActiveCaption;
            button5.Location = new Point(1442, 358);
            button5.Margin = new Padding(2);
            button5.Name = "button5";
            button5.Size = new Size(220, 52);
            button5.TabIndex = 11;
            button5.Text = "Consultar";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.GradientActiveCaption;
            button4.Location = new Point(1442, 616);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(220, 52);
            button4.TabIndex = 10;
            button4.Text = "Voltar";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.GradientActiveCaption;
            button3.Location = new Point(1442, 278);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(220, 52);
            button3.TabIndex = 9;
            button3.Text = "Excluir";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.GradientActiveCaption;
            button2.Location = new Point(1442, 198);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(220, 52);
            button2.TabIndex = 8;
            button2.Text = "Alterar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Location = new Point(1442, 118);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(220, 52);
            button1.TabIndex = 7;
            button1.Text = "Incluir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataViewFornecedor
            // 
            dataViewFornecedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataViewFornecedor.Location = new Point(29, 120);
            dataViewFornecedor.Margin = new Padding(2);
            dataViewFornecedor.MultiSelect = false;
            dataViewFornecedor.Name = "dataViewFornecedor";
            dataViewFornecedor.ReadOnly = true;
            dataViewFornecedor.RowHeadersWidth = 62;
            dataViewFornecedor.Size = new Size(1376, 548);
            dataViewFornecedor.TabIndex = 6;
            dataViewFornecedor.CellContentClick += dataViewFornecedor_CellContentClick;
            // 
            // btn_pesquisar
            // 
            btn_pesquisar.Location = new Point(568, 45);
            btn_pesquisar.Name = "btn_pesquisar";
            btn_pesquisar.Size = new Size(112, 34);
            btn_pesquisar.TabIndex = 20;
            btn_pesquisar.Text = "Buscar";
            btn_pesquisar.UseVisualStyleBackColor = true;
            btn_pesquisar.Click += btn_pesquisar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 47);
            label1.Name = "label1";
            label1.Size = new Size(118, 32);
            label1.TabIndex = 19;
            label1.Text = "Pesquisar:";
            // 
            // txt_pesquisar
            // 
            txt_pesquisar.Location = new Point(158, 47);
            txt_pesquisar.Name = "txt_pesquisar";
            txt_pesquisar.Size = new Size(373, 31);
            txt_pesquisar.TabIndex = 18;
            txt_pesquisar.TextChanged += txt_pesquisar_TextChanged;
            // 
            // JanelaFornecedor
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1692, 819);
            Controls.Add(btn_pesquisar);
            Controls.Add(label1);
            Controls.Add(txt_pesquisar);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataViewFornecedor);
            Margin = new Padding(2);
            Name = "JanelaFornecedor";
            Text = "JanelaFornecedor";
            Load += JanelaFornecedor_Load;
            ((System.ComponentModel.ISupportInitialize)dataViewFornecedor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridView dataViewFornecedor;
        private Button btn_pesquisar;
        private Label label1;
        private TextBox txt_pesquisar;
    }
}