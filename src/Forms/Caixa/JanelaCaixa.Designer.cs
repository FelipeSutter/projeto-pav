namespace PDV
{
    partial class JanelaCaixa
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
            dataViewMovimentoCaixa = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataViewMovimentoCaixa).BeginInit();
            SuspendLayout();
            // 
            // dataViewMovimentoCaixa
            // 
            dataViewMovimentoCaixa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataViewMovimentoCaixa.Location = new Point(36, 43);
            dataViewMovimentoCaixa.Margin = new Padding(2);
            dataViewMovimentoCaixa.MultiSelect = false;
            dataViewMovimentoCaixa.Name = "dataViewMovimentoCaixa";
            dataViewMovimentoCaixa.ReadOnly = true;
            dataViewMovimentoCaixa.RowHeadersWidth = 62;
            dataViewMovimentoCaixa.Size = new Size(936, 435);
            dataViewMovimentoCaixa.TabIndex = 9;
            // 
            // JanelaCaixa
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1022, 580);
            Controls.Add(dataViewMovimentoCaixa);
            Name = "JanelaCaixa";
            Text = "JanelaCaixa";
            ((System.ComponentModel.ISupportInitialize)dataViewMovimentoCaixa).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataViewMovimentoCaixa;
    }
}