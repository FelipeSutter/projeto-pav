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
        private void InitializeComponent() {
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            dataViewFornecedor = new DataGridView();
            ((System.ComponentModel.ISupportInitialize) dataViewFornecedor).BeginInit();
            SuspendLayout();
            // 
            // button5
            // 
            button5.BackColor = SystemColors.GradientActiveCaption;
            button5.Location = new Point(1155, 207);
            button5.Margin = new Padding(2);
            button5.Name = "button5";
            button5.Size = new Size(176, 42);
            button5.TabIndex = 11;
            button5.Text = "Consultar";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.GradientActiveCaption;
            button4.Location = new Point(1155, 271);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(176, 42);
            button4.TabIndex = 10;
            button4.Text = "Voltar";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.GradientActiveCaption;
            button3.Location = new Point(1155, 143);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(176, 42);
            button3.TabIndex = 9;
            button3.Text = "Excluir";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.GradientActiveCaption;
            button2.Location = new Point(1155, 79);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(176, 42);
            button2.TabIndex = 8;
            button2.Text = "Alterar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Location = new Point(1155, 15);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(176, 42);
            button1.TabIndex = 7;
            button1.Text = "Incluir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataViewFornecedor
            // 
            dataViewFornecedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataViewFornecedor.Location = new Point(10, 17);
            dataViewFornecedor.Margin = new Padding(2);
            dataViewFornecedor.MultiSelect = false;
            dataViewFornecedor.Name = "dataViewFornecedor";
            dataViewFornecedor.ReadOnly = true;
            dataViewFornecedor.RowHeadersWidth = 62;
            dataViewFornecedor.Size = new Size(1125, 438);
            dataViewFornecedor.TabIndex = 6;
            dataViewFornecedor.CellContentClick += dataViewFornecedor_CellContentClick;
            // 
            // JanelaFornecedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1354, 655);
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
            ((System.ComponentModel.ISupportInitialize) dataViewFornecedor).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridView dataViewFornecedor;
    }
}