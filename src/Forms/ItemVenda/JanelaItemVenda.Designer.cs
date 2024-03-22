
namespace PDV.Forms;

partial class JanelaItemVenda {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
        if (disposing && (components != null)) {
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
        btn_consultar = new Button();
        btn_voltar = new Button();
        btn_excluir = new Button();
        btn_alterar = new Button();
        btn_incluir = new Button();
        dataViewItemVenda = new DataGridView();
        clienteBindingSource = new BindingSource(components);
        btn_cancelar = new Button();
        btn_confirmar = new Button();
        ((System.ComponentModel.ISupportInitialize) dataViewItemVenda).BeginInit();
        ((System.ComponentModel.ISupportInitialize) clienteBindingSource).BeginInit();
        SuspendLayout();
        // 
        // btn_consultar
        // 
        btn_consultar.BackColor = SystemColors.GradientActiveCaption;
        btn_consultar.Location = new Point(678, 233);
        btn_consultar.Margin = new Padding(2);
        btn_consultar.Name = "btn_consultar";
        btn_consultar.Size = new Size(176, 42);
        btn_consultar.TabIndex = 20;
        btn_consultar.Text = "Consultar";
        btn_consultar.UseVisualStyleBackColor = false;
        btn_consultar.Click += btn_consultar_Click;
        // 
        // btn_voltar
        // 
        btn_voltar.BackColor = SystemColors.GradientActiveCaption;
        btn_voltar.Location = new Point(61, 498);
        btn_voltar.Margin = new Padding(2);
        btn_voltar.Name = "btn_voltar";
        btn_voltar.Size = new Size(110, 42);
        btn_voltar.TabIndex = 19;
        btn_voltar.Text = "Voltar";
        btn_voltar.UseVisualStyleBackColor = false;
        btn_voltar.Click += btn_voltar_Click;
        // 
        // btn_excluir
        // 
        btn_excluir.BackColor = SystemColors.GradientActiveCaption;
        btn_excluir.Location = new Point(678, 171);
        btn_excluir.Margin = new Padding(2);
        btn_excluir.Name = "btn_excluir";
        btn_excluir.Size = new Size(176, 42);
        btn_excluir.TabIndex = 18;
        btn_excluir.Text = "Excluir";
        btn_excluir.UseVisualStyleBackColor = false;
        btn_excluir.Click += btn_excluir_Click;
        // 
        // btn_alterar
        // 
        btn_alterar.BackColor = SystemColors.GradientActiveCaption;
        btn_alterar.Location = new Point(678, 107);
        btn_alterar.Margin = new Padding(2);
        btn_alterar.Name = "btn_alterar";
        btn_alterar.Size = new Size(176, 42);
        btn_alterar.TabIndex = 17;
        btn_alterar.Text = "Alterar";
        btn_alterar.UseVisualStyleBackColor = false;
        btn_alterar.Click += btn_alterar_Click;
        // 
        // btn_incluir
        // 
        btn_incluir.BackColor = SystemColors.GradientActiveCaption;
        btn_incluir.Location = new Point(678, 48);
        btn_incluir.Margin = new Padding(2);
        btn_incluir.Name = "btn_incluir";
        btn_incluir.Size = new Size(176, 42);
        btn_incluir.TabIndex = 16;
        btn_incluir.Text = "Incluir";
        btn_incluir.UseVisualStyleBackColor = false;
        btn_incluir.Click += btn_incluir_Click;
        // 
        // dataViewItemVenda
        // 
        dataViewItemVenda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataViewItemVenda.Location = new Point(61, 48);
        dataViewItemVenda.Margin = new Padding(2);
        dataViewItemVenda.MultiSelect = false;
        dataViewItemVenda.Name = "dataViewItemVenda";
        dataViewItemVenda.ReadOnly = true;
        dataViewItemVenda.RowHeadersWidth = 62;
        dataViewItemVenda.Size = new Size(522, 416);
        dataViewItemVenda.TabIndex = 15;
        // 
        // clienteBindingSource
        // 
        clienteBindingSource.DataSource = typeof(Entities.Cliente);
        // 
        // btn_cancelar
        // 
        btn_cancelar.BackColor = SystemColors.GradientActiveCaption;
        btn_cancelar.Location = new Point(772, 422);
        btn_cancelar.Margin = new Padding(2);
        btn_cancelar.Name = "btn_cancelar";
        btn_cancelar.Size = new Size(133, 42);
        btn_cancelar.TabIndex = 21;
        btn_cancelar.Text = "Cancelar venda";
        btn_cancelar.UseVisualStyleBackColor = false;
        btn_cancelar.Click += btn_cancelar_Click;
        // 
        // btn_confirmar
        // 
        btn_confirmar.BackColor = SystemColors.GradientActiveCaption;
        btn_confirmar.Location = new Point(616, 422);
        btn_confirmar.Margin = new Padding(2);
        btn_confirmar.Name = "btn_confirmar";
        btn_confirmar.Size = new Size(133, 42);
        btn_confirmar.TabIndex = 22;
        btn_confirmar.Text = "Confirmar venda";
        btn_confirmar.UseVisualStyleBackColor = false;
        btn_confirmar.Click += btn_confirmar_Click;
        // 
        // JanelaItemVenda
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.ActiveCaption;
        ClientSize = new Size(916, 551);
        Controls.Add(btn_confirmar);
        Controls.Add(btn_cancelar);
        Controls.Add(btn_consultar);
        Controls.Add(btn_voltar);
        Controls.Add(btn_excluir);
        Controls.Add(btn_alterar);
        Controls.Add(btn_incluir);
        Controls.Add(dataViewItemVenda);
        Name = "JanelaItemVenda";
        Text = "JanelaItemVenda";
        Load += JanelaItemVenda_Load;
        ((System.ComponentModel.ISupportInitialize) dataViewItemVenda).EndInit();
        ((System.ComponentModel.ISupportInitialize) clienteBindingSource).EndInit();
        ResumeLayout(false);
    }

    #endregion
    private Button btn_consultar;
    private Button btn_voltar;
    private Button btn_excluir;
    private Button btn_alterar;
    private Button btn_incluir;
    private DataGridView dataViewItemVenda;
    private BindingSource clienteBindingSource;
    private Button btn_cancelar;
    private Button btn_confirmar;
}