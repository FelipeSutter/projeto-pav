namespace PDV.Forms
{
    partial class AlterarClassificacao
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
            btn_voltar = new Button();
            nomeBox = new TextBox();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // btn_voltar
            // 
            btn_voltar.DialogResult = DialogResult.Cancel;
            btn_voltar.Location = new Point(374, 97);
            btn_voltar.Margin = new Padding(2, 2, 2, 2);
            btn_voltar.Name = "btn_voltar";
            btn_voltar.Size = new Size(153, 42);
            btn_voltar.TabIndex = 26;
            btn_voltar.Text = "Voltar";
            btn_voltar.UseVisualStyleBackColor = true;
            // 
            // nomeBox
            // 
            nomeBox.Location = new Point(211, 56);
            nomeBox.Margin = new Padding(2, 2, 2, 2);
            nomeBox.Name = "nomeBox";
            nomeBox.Size = new Size(356, 27);
            nomeBox.TabIndex = 28;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 56);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 27;
            label1.Text = "Nome";
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(134, 97);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(153, 42);
            button1.TabIndex = 29;
            button1.Text = "Alterar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AlterarClassificacao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(640, 161);
            Controls.Add(button1);
            Controls.Add(nomeBox);
            Controls.Add(label1);
            Controls.Add(btn_voltar);
            Margin = new Padding(2, 2, 2, 2);
            Name = "AlterarClassificacao";
            Text = "AlterarClassificacao";
            Load += AlterarClassificacao_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_voltar;
        private TextBox nomeBox;
        private Label label1;
        private Button button1;
    }
}