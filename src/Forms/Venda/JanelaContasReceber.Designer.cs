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
            ((System.ComponentModel.ISupportInitialize)dataViewContaReceber).BeginInit();
            SuspendLayout();
            // 
            // dataViewContaReceber
            // 
            dataViewContaReceber.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataViewContaReceber.Location = new Point(61, 36);
            dataViewContaReceber.Margin = new Padding(2);
            dataViewContaReceber.MultiSelect = false;
            dataViewContaReceber.Name = "dataViewContaReceber";
            dataViewContaReceber.ReadOnly = true;
            dataViewContaReceber.RowHeadersWidth = 62;
            dataViewContaReceber.Size = new Size(1062, 548);
            dataViewContaReceber.TabIndex = 8;
            // 
            // JanelaContasReceber
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1195, 629);
            Controls.Add(dataViewContaReceber);
            Name = "JanelaContasReceber";
            Text = "JanelaContasReceber";
            ((System.ComponentModel.ISupportInitialize)dataViewContaReceber).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataViewContaReceber;
    }
}