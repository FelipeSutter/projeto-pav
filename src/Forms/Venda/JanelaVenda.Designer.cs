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
        private void InitializeComponent()
        {
            dataViewVenda = new DataGridView();
            btn_incluir = new Button();
            ((System.ComponentModel.ISupportInitialize)dataViewVenda).BeginInit();
            SuspendLayout();
            // 
            // dataViewVenda
            // 
            dataViewVenda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataViewVenda.Location = new Point(27, 33);
            dataViewVenda.Margin = new Padding(2);
            dataViewVenda.MultiSelect = false;
            dataViewVenda.Name = "dataViewVenda";
            dataViewVenda.ReadOnly = true;
            dataViewVenda.RowHeadersWidth = 62;
            dataViewVenda.Size = new Size(1063, 334);
            dataViewVenda.TabIndex = 7;
            // 
            // btn_incluir
            // 
            btn_incluir.BackColor = SystemColors.GradientActiveCaption;
            btn_incluir.Location = new Point(1123, 33);
            btn_incluir.Name = "btn_incluir";
            btn_incluir.Size = new Size(220, 52);
            btn_incluir.TabIndex = 8;
            btn_incluir.Text = "Criar venda";
            btn_incluir.UseVisualStyleBackColor = false;
            btn_incluir.Click += btn_incluir_Click;
            // 
            // JanelaVenda
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1360, 497);
            Controls.Add(btn_incluir);
            Controls.Add(dataViewVenda);
            Name = "JanelaVenda";
            Text = "JanelaVenda";
            ((System.ComponentModel.ISupportInitialize)dataViewVenda).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataViewVenda;
        private Button btn_incluir;
    }
}