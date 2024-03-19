namespace PDV
{
    partial class JanelaCliente
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
            dataViewClient = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataViewClient).BeginInit();
            SuspendLayout();
            // 
            // dataViewClient
            // 
            dataViewClient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataViewClient.Location = new Point(22, 22);
            dataViewClient.MultiSelect = false;
            dataViewClient.Name = "dataViewClient";
            dataViewClient.ReadOnly = true;
            dataViewClient.RowHeadersWidth = 62;
            dataViewClient.Size = new Size(1406, 548);
            dataViewClient.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Location = new Point(1454, 20);
            button1.Name = "button1";
            button1.Size = new Size(220, 52);
            button1.TabIndex = 1;
            button1.Text = "Incluir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.GradientActiveCaption;
            button2.Location = new Point(1454, 100);
            button2.Name = "button2";
            button2.Size = new Size(220, 52);
            button2.TabIndex = 2;
            button2.Text = "Alterar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.GradientActiveCaption;
            button3.Location = new Point(1454, 180);
            button3.Name = "button3";
            button3.Size = new Size(220, 52);
            button3.TabIndex = 3;
            button3.Text = "Excluir";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.GradientActiveCaption;
            button4.Location = new Point(1454, 340);
            button4.Name = "button4";
            button4.Size = new Size(220, 52);
            button4.TabIndex = 4;
            button4.Text = "Voltar";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.GradientActiveCaption;
            button5.Location = new Point(1454, 260);
            button5.Name = "button5";
            button5.Size = new Size(220, 52);
            button5.TabIndex = 5;
            button5.Text = "Consultar";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1693, 819);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataViewClient);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataViewClient).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataViewClient;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}