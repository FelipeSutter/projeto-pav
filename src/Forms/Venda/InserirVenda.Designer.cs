namespace PDV
{
    partial class InserirVenda
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
            components = new System.ComponentModel.Container();
            dataViewItemVenda = new DataGridView();
            btn_carrinho = new Button();
            qtd_box = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lb_total = new Label();
            btn_venda = new Button();
            label4 = new Label();
            prod_box = new ComboBox();
            produtoBindingSource = new BindingSource(components);
            pessoa_box = new ComboBox();
            btn_cancelar = new Button();
            btn_remover = new Button();
            btn_alterar = new Button();
            rb_pix = new RadioButton();
            rb_debito = new RadioButton();
            rb_credito = new RadioButton();
            rb_especie = new RadioButton();
            lb_forma_pagamento = new Label();
            ((System.ComponentModel.ISupportInitialize) dataViewItemVenda).BeginInit();
            ((System.ComponentModel.ISupportInitialize) produtoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataViewItemVenda
            // 
            dataViewItemVenda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataViewItemVenda.Location = new Point(9, 57);
            dataViewItemVenda.Margin = new Padding(2);
            dataViewItemVenda.MultiSelect = false;
            dataViewItemVenda.Name = "dataViewItemVenda";
            dataViewItemVenda.ReadOnly = true;
            dataViewItemVenda.RowHeadersWidth = 62;
            dataViewItemVenda.Size = new Size(846, 372);
            dataViewItemVenda.TabIndex = 8;
            // 
            // btn_carrinho
            // 
            btn_carrinho.BackColor = SystemColors.GradientActiveCaption;
            btn_carrinho.Location = new Point(873, 182);
            btn_carrinho.Margin = new Padding(2);
            btn_carrinho.Name = "btn_carrinho";
            btn_carrinho.Size = new Size(176, 42);
            btn_carrinho.TabIndex = 9;
            btn_carrinho.Text = "Adicionar ao carrinho";
            btn_carrinho.UseVisualStyleBackColor = false;
            btn_carrinho.Click += btn_carrinho_Click;
            // 
            // qtd_box
            // 
            qtd_box.Location = new Point(962, 134);
            qtd_box.Margin = new Padding(2);
            qtd_box.Name = "qtd_box";
            qtd_box.Size = new Size(88, 27);
            qtd_box.TabIndex = 11;
            qtd_box.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(873, 134);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 12;
            label1.Text = "Quantidade";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(873, 93);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 13;
            label2.Text = "Produto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(767, 430);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 14;
            label3.Text = "Total:";
            // 
            // lb_total
            // 
            lb_total.AutoSize = true;
            lb_total.Location = new Point(822, 430);
            lb_total.Margin = new Padding(2, 0, 2, 0);
            lb_total.Name = "lb_total";
            lb_total.Size = new Size(36, 20);
            lb_total.TabIndex = 15;
            lb_total.Text = "0.00";
            lb_total.Click += lb_total_Click;
            // 
            // btn_venda
            // 
            btn_venda.BackColor = SystemColors.GradientActiveCaption;
            btn_venda.DialogResult = DialogResult.OK;
            btn_venda.Location = new Point(1057, 387);
            btn_venda.Margin = new Padding(2);
            btn_venda.Name = "btn_venda";
            btn_venda.Size = new Size(176, 42);
            btn_venda.TabIndex = 16;
            btn_venda.Text = "Finalizar venda";
            btn_venda.UseVisualStyleBackColor = false;
            btn_venda.Click += btn_venda_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(873, 57);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 18;
            label4.Text = "Pessoa";
            // 
            // prod_box
            // 
            prod_box.DropDownStyle = ComboBoxStyle.DropDownList;
            prod_box.FormattingEnabled = true;
            prod_box.Location = new Point(962, 93);
            prod_box.Margin = new Padding(2);
            prod_box.Name = "prod_box";
            prod_box.Size = new Size(204, 28);
            prod_box.TabIndex = 19;
            // 
            // produtoBindingSource
            // 
            produtoBindingSource.DataSource = typeof(Entities.Produto);
            // 
            // pessoa_box
            // 
            pessoa_box.DropDownStyle = ComboBoxStyle.DropDownList;
            pessoa_box.FormattingEnabled = true;
            pessoa_box.Location = new Point(962, 57);
            pessoa_box.Margin = new Padding(2);
            pessoa_box.Name = "pessoa_box";
            pessoa_box.Size = new Size(204, 28);
            pessoa_box.TabIndex = 20;
            // 
            // btn_cancelar
            // 
            btn_cancelar.BackColor = SystemColors.GradientActiveCaption;
            btn_cancelar.Location = new Point(1056, 448);
            btn_cancelar.Margin = new Padding(2);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(176, 42);
            btn_cancelar.TabIndex = 21;
            btn_cancelar.Text = "Cancelar venda";
            btn_cancelar.UseVisualStyleBackColor = false;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // btn_remover
            // 
            btn_remover.BackColor = SystemColors.GradientActiveCaption;
            btn_remover.Location = new Point(873, 240);
            btn_remover.Margin = new Padding(2);
            btn_remover.Name = "btn_remover";
            btn_remover.Size = new Size(176, 42);
            btn_remover.TabIndex = 22;
            btn_remover.Text = "Remover do carrinho";
            btn_remover.UseVisualStyleBackColor = false;
            btn_remover.Click += btn_remover_Click;
            // 
            // btn_alterar
            // 
            btn_alterar.BackColor = SystemColors.GradientActiveCaption;
            btn_alterar.Location = new Point(873, 296);
            btn_alterar.Margin = new Padding(2);
            btn_alterar.Name = "btn_alterar";
            btn_alterar.Size = new Size(176, 42);
            btn_alterar.TabIndex = 23;
            btn_alterar.Text = "Alterar produto";
            btn_alterar.UseVisualStyleBackColor = false;
            btn_alterar.Click += btn_alterar_Click;
            // 
            // rb_pix
            // 
            rb_pix.AutoSize = true;
            rb_pix.Checked = true;
            rb_pix.Location = new Point(1070, 217);
            rb_pix.Margin = new Padding(2);
            rb_pix.Name = "rb_pix";
            rb_pix.Size = new Size(49, 24);
            rb_pix.TabIndex = 24;
            rb_pix.TabStop = true;
            rb_pix.Text = "Pix";
            rb_pix.UseVisualStyleBackColor = true;
            // 
            // rb_debito
            // 
            rb_debito.AutoSize = true;
            rb_debito.Location = new Point(1070, 258);
            rb_debito.Margin = new Padding(2);
            rb_debito.Name = "rb_debito";
            rb_debito.Size = new Size(76, 24);
            rb_debito.TabIndex = 25;
            rb_debito.Text = "Débito";
            rb_debito.UseVisualStyleBackColor = true;
            // 
            // rb_credito
            // 
            rb_credito.AutoSize = true;
            rb_credito.Location = new Point(1070, 303);
            rb_credito.Margin = new Padding(2);
            rb_credito.Name = "rb_credito";
            rb_credito.Size = new Size(79, 24);
            rb_credito.TabIndex = 26;
            rb_credito.Text = "Crédito";
            rb_credito.UseVisualStyleBackColor = true;
            // 
            // rb_especie
            // 
            rb_especie.AutoSize = true;
            rb_especie.Location = new Point(1070, 348);
            rb_especie.Margin = new Padding(2);
            rb_especie.Name = "rb_especie";
            rb_especie.Size = new Size(80, 24);
            rb_especie.TabIndex = 27;
            rb_especie.Text = "Espécie";
            rb_especie.UseVisualStyleBackColor = true;
            // 
            // lb_forma_pagamento
            // 
            lb_forma_pagamento.AutoSize = true;
            lb_forma_pagamento.Location = new Point(1068, 182);
            lb_forma_pagamento.Margin = new Padding(2, 0, 2, 0);
            lb_forma_pagamento.Name = "lb_forma_pagamento";
            lb_forma_pagamento.Size = new Size(153, 20);
            lb_forma_pagamento.TabIndex = 28;
            lb_forma_pagamento.Text = "Forma de pagamento";
            // 
            // InserirVenda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1242, 508);
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
            Controls.Add(btn_venda);
            Controls.Add(lb_total);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(qtd_box);
            Controls.Add(btn_carrinho);
            Controls.Add(dataViewItemVenda);
            Margin = new Padding(2);
            Name = "InserirVenda";
            Text = "InserirVenda";
            Load += InserirVenda_Load;
            ((System.ComponentModel.ISupportInitialize) dataViewItemVenda).EndInit();
            ((System.ComponentModel.ISupportInitialize) produtoBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataViewItemVenda;
        private Button btn_carrinho;
        private TextBox qtd_box;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lb_total;
        private Button btn_venda;
        private Label label4;
        private ComboBox prod_box;
        private BindingSource produtoBindingSource;
        private ComboBox pessoa_box;
        private Button btn_cancelar;
        private Button btn_remover;
        private Button btn_alterar;
        private RadioButton rb_pix;
        private RadioButton rb_debito;
        private RadioButton rb_credito;
        private RadioButton rb_especie;
        private Label lb_forma_pagamento;
    }
}