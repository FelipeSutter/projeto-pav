namespace PDV
{
    partial class InserirCompra
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
            label5 = new Label();
            cb_parcela = new ComboBox();
            lb_forma_pagamento = new Label();
            rb_especie = new RadioButton();
            rb_credito = new RadioButton();
            rb_debito = new RadioButton();
            rb_pix = new RadioButton();
            btn_alterar = new Button();
            btn_remover = new Button();
            btn_cancelar = new Button();
            pessoa_box = new ComboBox();
            prod_box = new ComboBox();
            label4 = new Label();
            btn_compra = new Button();
            lb_total = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            qtd_box = new TextBox();
            btn_carrinho = new Button();
            dataViewItemVenda = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataViewItemVenda).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1104, 178);
            label5.Name = "label5";
            label5.Size = new Size(74, 25);
            label5.TabIndex = 51;
            label5.Text = "Parcelas";
            // 
            // cb_parcela
            // 
            cb_parcela.FormattingEnabled = true;
            cb_parcela.Items.AddRange(new object[] { "À vista", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            cb_parcela.Location = new Point(1215, 175);
            cb_parcela.Name = "cb_parcela";
            cb_parcela.Size = new Size(109, 33);
            cb_parcela.TabIndex = 50;
            cb_parcela.Text = "À vista";
            // 
            // lb_forma_pagamento
            // 
            lb_forma_pagamento.AutoSize = true;
            lb_forma_pagamento.Location = new Point(1348, 183);
            lb_forma_pagamento.Margin = new Padding(2, 0, 2, 0);
            lb_forma_pagamento.Name = "lb_forma_pagamento";
            lb_forma_pagamento.Size = new Size(185, 25);
            lb_forma_pagamento.TabIndex = 49;
            lb_forma_pagamento.Text = "Forma de pagamento";
            // 
            // rb_especie
            // 
            rb_especie.AutoSize = true;
            rb_especie.Location = new Point(1351, 390);
            rb_especie.Margin = new Padding(2);
            rb_especie.Name = "rb_especie";
            rb_especie.Size = new Size(95, 29);
            rb_especie.TabIndex = 48;
            rb_especie.Text = "Espécie";
            rb_especie.UseVisualStyleBackColor = true;
            // 
            // rb_credito
            // 
            rb_credito.AutoSize = true;
            rb_credito.Location = new Point(1351, 334);
            rb_credito.Margin = new Padding(2);
            rb_credito.Name = "rb_credito";
            rb_credito.Size = new Size(95, 29);
            rb_credito.TabIndex = 47;
            rb_credito.Text = "Crédito";
            rb_credito.UseVisualStyleBackColor = true;
            // 
            // rb_debito
            // 
            rb_debito.AutoSize = true;
            rb_debito.Location = new Point(1351, 277);
            rb_debito.Margin = new Padding(2);
            rb_debito.Name = "rb_debito";
            rb_debito.Size = new Size(91, 29);
            rb_debito.TabIndex = 46;
            rb_debito.Text = "Débito";
            rb_debito.UseVisualStyleBackColor = true;
            // 
            // rb_pix
            // 
            rb_pix.AutoSize = true;
            rb_pix.Checked = true;
            rb_pix.Location = new Point(1351, 226);
            rb_pix.Margin = new Padding(2);
            rb_pix.Name = "rb_pix";
            rb_pix.Size = new Size(59, 29);
            rb_pix.TabIndex = 45;
            rb_pix.TabStop = true;
            rb_pix.Text = "Pix";
            rb_pix.UseVisualStyleBackColor = true;
            // 
            // btn_alterar
            // 
            btn_alterar.BackColor = SystemColors.GradientActiveCaption;
            btn_alterar.Location = new Point(1104, 368);
            btn_alterar.Margin = new Padding(2);
            btn_alterar.Name = "btn_alterar";
            btn_alterar.Size = new Size(220, 52);
            btn_alterar.TabIndex = 44;
            btn_alterar.Text = "Alterar produto";
            btn_alterar.UseVisualStyleBackColor = false;
            // 
            // btn_remover
            // 
            btn_remover.BackColor = SystemColors.GradientActiveCaption;
            btn_remover.Location = new Point(1104, 298);
            btn_remover.Margin = new Padding(2);
            btn_remover.Name = "btn_remover";
            btn_remover.Size = new Size(220, 52);
            btn_remover.TabIndex = 43;
            btn_remover.Text = "Remover do carrinho";
            btn_remover.UseVisualStyleBackColor = false;
            // 
            // btn_cancelar
            // 
            btn_cancelar.BackColor = SystemColors.GradientActiveCaption;
            btn_cancelar.Location = new Point(1333, 515);
            btn_cancelar.Margin = new Padding(2);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(220, 52);
            btn_cancelar.TabIndex = 42;
            btn_cancelar.Text = "Cancelar compra";
            btn_cancelar.UseVisualStyleBackColor = false;
            // 
            // pessoa_box
            // 
            pessoa_box.DropDownStyle = ComboBoxStyle.DropDownList;
            pessoa_box.FormattingEnabled = true;
            pessoa_box.Location = new Point(1215, 26);
            pessoa_box.Margin = new Padding(2);
            pessoa_box.Name = "pessoa_box";
            pessoa_box.Size = new Size(254, 33);
            pessoa_box.TabIndex = 41;
            // 
            // prod_box
            // 
            prod_box.DropDownStyle = ComboBoxStyle.DropDownList;
            prod_box.FormattingEnabled = true;
            prod_box.Location = new Point(1215, 71);
            prod_box.Margin = new Padding(2);
            prod_box.Name = "prod_box";
            prod_box.Size = new Size(254, 33);
            prod_box.TabIndex = 40;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1104, 26);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(102, 25);
            label4.TabIndex = 39;
            label4.Text = "Fornecedor";
            // 
            // btn_compra
            // 
            btn_compra.BackColor = SystemColors.GradientActiveCaption;
            btn_compra.DialogResult = DialogResult.OK;
            btn_compra.Location = new Point(1334, 439);
            btn_compra.Margin = new Padding(2);
            btn_compra.Name = "btn_compra";
            btn_compra.Size = new Size(220, 52);
            btn_compra.TabIndex = 38;
            btn_compra.Text = "Finalizar compra";
            btn_compra.UseVisualStyleBackColor = false;
            btn_compra.Click += btn_compra_Click;
            // 
            // lb_total
            // 
            lb_total.AutoSize = true;
            lb_total.Location = new Point(1041, 493);
            lb_total.Margin = new Padding(2, 0, 2, 0);
            lb_total.Name = "lb_total";
            lb_total.Size = new Size(46, 25);
            lb_total.TabIndex = 37;
            lb_total.Text = "0.00";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(972, 493);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(53, 25);
            label3.TabIndex = 36;
            label3.Text = "Total:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1104, 71);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(77, 25);
            label2.TabIndex = 35;
            label2.Text = "Produto";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1104, 123);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(105, 25);
            label1.TabIndex = 34;
            label1.Text = "Quantidade";
            // 
            // qtd_box
            // 
            qtd_box.Location = new Point(1215, 123);
            qtd_box.Margin = new Padding(2);
            qtd_box.Name = "qtd_box";
            qtd_box.Size = new Size(109, 31);
            qtd_box.TabIndex = 33;
            // 
            // btn_carrinho
            // 
            btn_carrinho.BackColor = SystemColors.GradientActiveCaption;
            btn_carrinho.Location = new Point(1104, 226);
            btn_carrinho.Margin = new Padding(2);
            btn_carrinho.Name = "btn_carrinho";
            btn_carrinho.Size = new Size(220, 52);
            btn_carrinho.TabIndex = 32;
            btn_carrinho.Text = "Adicionar ao carrinho";
            btn_carrinho.UseVisualStyleBackColor = false;
            btn_carrinho.Click += btn_carrinho_Click;
            // 
            // dataViewItemVenda
            // 
            dataViewItemVenda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataViewItemVenda.Location = new Point(24, 26);
            dataViewItemVenda.Margin = new Padding(2);
            dataViewItemVenda.MultiSelect = false;
            dataViewItemVenda.Name = "dataViewItemVenda";
            dataViewItemVenda.ReadOnly = true;
            dataViewItemVenda.RowHeadersWidth = 62;
            dataViewItemVenda.Size = new Size(1058, 465);
            dataViewItemVenda.TabIndex = 31;
            // 
            // InserirCompra
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1577, 588);
            Controls.Add(label5);
            Controls.Add(cb_parcela);
            Controls.Add(lb_forma_pagamento);
            Controls.Add(rb_especie);
            Controls.Add(rb_credito);
            Controls.Add(rb_debito);
            Controls.Add(rb_pix);
            Controls.Add(btn_alterar);
            Controls.Add(btn_remover);
            Controls.Add(btn_cancelar);
            Controls.Add(pessoa_box);
            Controls.Add(prod_box);
            Controls.Add(label4);
            Controls.Add(btn_compra);
            Controls.Add(lb_total);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(qtd_box);
            Controls.Add(btn_carrinho);
            Controls.Add(dataViewItemVenda);
            Name = "InserirCompra";
            Text = "InserirCompra";
            ((System.ComponentModel.ISupportInitialize)dataViewItemVenda).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private ComboBox cb_parcela;
        private Label lb_forma_pagamento;
        private RadioButton rb_especie;
        private RadioButton rb_credito;
        private RadioButton rb_debito;
        private RadioButton rb_pix;
        private Button btn_alterar;
        private Button btn_remover;
        private Button btn_cancelar;
        private ComboBox pessoa_box;
        private ComboBox prod_box;
        private Label label4;
        private Button btn_compra;
        private Label lb_total;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox qtd_box;
        private Button btn_carrinho;
        private DataGridView dataViewItemVenda;
    }
}