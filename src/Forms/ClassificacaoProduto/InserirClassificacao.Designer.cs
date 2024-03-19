namespace PDV.Forms
{
    partial class InserirClassificacao
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
            label1 = new Label();
            nomeBox = new TextBox();
            btn_voltar = new Button();
            btn_criar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(91, 41);
            label1.Name = "label1";
            label1.Size = new Size(61, 25);
            label1.TabIndex = 12;
            label1.Text = "Nome";
            // 
            // nomeBox
            // 
            nomeBox.Location = new Point(265, 41);
            nomeBox.Name = "nomeBox";
            nomeBox.Size = new Size(444, 31);
            nomeBox.TabIndex = 11;
            // 
            // btn_voltar
            // 
            btn_voltar.DialogResult = DialogResult.Cancel;
            btn_voltar.Location = new Point(414, 114);
            btn_voltar.Name = "btn_voltar";
            btn_voltar.Size = new Size(191, 52);
            btn_voltar.TabIndex = 25;
            btn_voltar.Text = "Voltar";
            btn_voltar.UseVisualStyleBackColor = true;
            btn_voltar.Click += btn_voltar_Click;
            // 
            // btn_criar
            // 
            btn_criar.DialogResult = DialogResult.OK;
            btn_criar.Location = new Point(149, 114);
            btn_criar.Name = "btn_criar";
            btn_criar.Size = new Size(191, 52);
            btn_criar.TabIndex = 24;
            btn_criar.Text = "Criar";
            btn_criar.UseVisualStyleBackColor = true;
            btn_criar.Click += btn_criar_Click;
            // 
            // InserirClassificacao
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 201);
            Controls.Add(btn_voltar);
            Controls.Add(btn_criar);
            Controls.Add(label1);
            Controls.Add(nomeBox);
            Name = "InserirClassificacao";
            Text = "InserirClassificacao";
            Load += InserirClassificacao_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox nomeBox;
        private Button btn_voltar;
        private Button btn_criar;
    }
}