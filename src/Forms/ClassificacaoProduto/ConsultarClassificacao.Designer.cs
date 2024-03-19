namespace PDV.Forms
{
    partial class ConsultarClassificacao
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
            nomeL = new Label();
            label1 = new Label();
            voltarBu = new Button();
            SuspendLayout();
            // 
            // nomeL
            // 
            nomeL.AutoSize = true;
            nomeL.Location = new Point(322, 50);
            nomeL.Margin = new Padding(2, 0, 2, 0);
            nomeL.Name = "nomeL";
            nomeL.Size = new Size(50, 20);
            nomeL.TabIndex = 34;
            nomeL.Text = "Nome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(97, 50);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 33;
            label1.Text = "Nome";
            // 
            // voltarBu
            // 
            voltarBu.BackColor = SystemColors.GradientActiveCaption;
            voltarBu.Location = new Point(155, 102);
            voltarBu.Margin = new Padding(2, 2, 2, 2);
            voltarBu.Name = "voltarBu";
            voltarBu.Size = new Size(153, 42);
            voltarBu.TabIndex = 44;
            voltarBu.Text = "Voltar";
            voltarBu.UseVisualStyleBackColor = false;
            voltarBu.Click += voltarBu_Click;
            // 
            // ConsultarClassificacao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(473, 161);
            Controls.Add(voltarBu);
            Controls.Add(nomeL);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "ConsultarClassificacao";
            Text = "ConsultarClassificacao";
            Load += ConsultarClassificacao_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nomeL;
        private Label label1;
        private Button voltarBu;
    }
}