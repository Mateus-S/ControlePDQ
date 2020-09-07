using ControleProdutosQuimicos;
namespace ControleProdutosQuimicos
   
{
    partial class frm_Cadastro
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Cadastro));
            this.lblProduto = new System.Windows.Forms.Label();
            this.lblNumeroNF = new System.Windows.Forms.Label();
            this.lblPedidoCompra = new System.Windows.Forms.Label();
            this.lblQuantComprada = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.lblEmissaoNF = new System.Windows.Forms.Label();
            this.lblDataPedido = new System.Windows.Forms.Label();
            this.lblQuantUsada = new System.Windows.Forms.Label();
            this.Cx_Numero_NF = new System.Windows.Forms.TextBox();
            this.Cx_Quant_Compra = new System.Windows.Forms.TextBox();
            this.Cx_Pedido_Compra = new System.Windows.Forms.TextBox();
            this.Cx_Quant_Usada = new System.Windows.Forms.TextBox();
            this.Cx_Produto = new System.Windows.Forms.ComboBox();
            this.BotaoSalvar = new System.Windows.Forms.Button();
            this.BotaoLimparDados = new System.Windows.Forms.Button();
            this.BotaoSair = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tab_Produtos = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn166 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn167 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn168 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn169 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn170 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn171 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn172 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn173 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn174 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn175 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn176 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataLancamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdgAcidoCloridrico = new System.Windows.Forms.BindingSource(this.components);
            this.bDPQDataSethome = new ControleProdutosQuimicos.BDPQDataSethome();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Registro_AcidoSulfurico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produto_AcidoSulfurico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desenho_AcidoSulfurico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NF_AcidoSulfurico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_Emissao_NF_AcidoSulfurico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero_Pedido_AcidoSulfurico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_Pedido_AcidoSulfurico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estoque_AcidoSulfurico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quant_Comprada_AcidoSulfurico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quant_Usada_AcidoSulfurico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario_AcidoSulfurico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_Lancamento_AcidoSulfurico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdgAcidoSulfurico = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn177 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn178 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn179 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn180 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn181 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn182 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn183 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn184 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn185 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn186 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn187 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataLancamentoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdgHidroxidoPostasio = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.Registro_Tolueno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produto_Tolueno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desenho_Tolueno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero_NF_Tolueno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_Emissao_NF_Tolueno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pedido_Compra_Tolueno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_Pedido_Tolueno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estoque_Tolueno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quant_Comprada_Tolueno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quant_Usada_Tolueno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario_Tolueno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_Lancamento_Tolueno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdgTolueno = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.Registro_Acetona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produto_Acetona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desenho_Acetona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero_NF_Acetona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emissao_NF_Acetona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pedido_Compra_Acetona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_Pedido_Acetona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estoque_Acetona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quant_Comprada_Acetona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quant_Usada_Acetona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario_Acetona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_Lancamento_Acetona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdgAcetona = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.Registro_Metiletilcetona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produto_Metiletilcetona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desenho_Metiletilcetona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numero_NF_Metiletilcetona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_Emissao_NF_Metiletilcetona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pedido_Compra_Metiletilcetona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_Pedido_Metiletilcetona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estoque_Metiletilcetona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quant_Comprada_Metiletilcetona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quant_Usada_Metiletilcetona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario__Metiletilcetona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_Lancamento_Metiletilcetona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdgMetiletilcetona = new System.Windows.Forms.BindingSource(this.components);
            this.Cx_Item = new System.Windows.Forms.ComboBox();
            this.Cx_Data_Emissao_NF = new System.Windows.Forms.DateTimePicker();
            this.Cx_Data_Pedido = new System.Windows.Forms.DateTimePicker();
            this.Cx_Usuario_Logado = new System.Windows.Forms.TextBox();
            this.tblAcidoCloridricoTableAdapter1 = new ControleProdutosQuimicos.BDPQDataSethomeTableAdapters.tblAcidoCloridricoTableAdapter();
            this.tblAcidoSulfuricoTableAdapter1 = new ControleProdutosQuimicos.BDPQDataSethomeTableAdapters.tblAcidoSulfuricoTableAdapter();
            this.tblToluenoTableAdapter1 = new ControleProdutosQuimicos.BDPQDataSethomeTableAdapters.tblToluenoTableAdapter();
            this.tblAcetonaTableAdapter1 = new ControleProdutosQuimicos.BDPQDataSethomeTableAdapters.tblAcetonaTableAdapter();
            this.tblMetiletilcetonaTableAdapter1 = new ControleProdutosQuimicos.BDPQDataSethomeTableAdapters.tblMetiletilcetonaTableAdapter();
            this.btn_Relatorio = new System.Windows.Forms.Button();
            this.tblHidroxidoPostasioTableAdapter = new ControleProdutosQuimicos.BDPQDataSethomeTableAdapters.tblHidroxidoPostasioTableAdapter();
            this.bDPQServerTSEA = new ControleProdutosQuimicos.BDPQServerTSEA();
            this.bDPQServerTSEABindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tab_Produtos.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgAcidoCloridrico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDPQDataSethome)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgAcidoSulfurico)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgHidroxidoPostasio)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgTolueno)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgAcetona)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgMetiletilcetona)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDPQServerTSEA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDPQServerTSEABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProduto
            // 
            this.lblProduto.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto.Location = new System.Drawing.Point(34, 101);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(68, 23);
            this.lblProduto.TabIndex = 0;
            this.lblProduto.Text = "Produto:";
            // 
            // lblNumeroNF
            // 
            this.lblNumeroNF.AutoSize = true;
            this.lblNumeroNF.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroNF.Location = new System.Drawing.Point(34, 147);
            this.lblNumeroNF.Name = "lblNumeroNF";
            this.lblNumeroNF.Size = new System.Drawing.Size(117, 23);
            this.lblNumeroNF.TabIndex = 1;
            this.lblNumeroNF.Text = "Numero da NF:";
            // 
            // lblPedidoCompra
            // 
            this.lblPedidoCompra.AutoSize = true;
            this.lblPedidoCompra.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedidoCompra.Location = new System.Drawing.Point(34, 193);
            this.lblPedidoCompra.Name = "lblPedidoCompra";
            this.lblPedidoCompra.Size = new System.Drawing.Size(145, 23);
            this.lblPedidoCompra.TabIndex = 2;
            this.lblPedidoCompra.Text = "Pedido de Compra:";
            // 
            // lblQuantComprada
            // 
            this.lblQuantComprada.AutoSize = true;
            this.lblQuantComprada.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantComprada.Location = new System.Drawing.Point(34, 239);
            this.lblQuantComprada.Name = "lblQuantComprada";
            this.lblQuantComprada.Size = new System.Drawing.Size(173, 23);
            this.lblQuantComprada.TabIndex = 3;
            this.lblQuantComprada.Text = "Quantidade Comprada:";
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItem.Location = new System.Drawing.Point(614, 94);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(42, 23);
            this.lblItem.TabIndex = 4;
            this.lblItem.Text = "Item:";
            // 
            // lblEmissaoNF
            // 
            this.lblEmissaoNF.AutoSize = true;
            this.lblEmissaoNF.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmissaoNF.Location = new System.Drawing.Point(614, 143);
            this.lblEmissaoNF.Name = "lblEmissaoNF";
            this.lblEmissaoNF.Size = new System.Drawing.Size(179, 23);
            this.lblEmissaoNF.TabIndex = 5;
            this.lblEmissaoNF.Text = "Data da Emissão da NF:";
            // 
            // lblDataPedido
            // 
            this.lblDataPedido.AutoSize = true;
            this.lblDataPedido.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataPedido.Location = new System.Drawing.Point(614, 189);
            this.lblDataPedido.Name = "lblDataPedido";
            this.lblDataPedido.Size = new System.Drawing.Size(117, 23);
            this.lblDataPedido.TabIndex = 6;
            this.lblDataPedido.Text = "Data do Pedido";
            // 
            // lblQuantUsada
            // 
            this.lblQuantUsada.AutoSize = true;
            this.lblQuantUsada.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantUsada.Location = new System.Drawing.Point(614, 238);
            this.lblQuantUsada.Name = "lblQuantUsada";
            this.lblQuantUsada.Size = new System.Drawing.Size(145, 23);
            this.lblQuantUsada.TabIndex = 7;
            this.lblQuantUsada.Text = "Quantidade Usada:";
            // 
            // Cx_Numero_NF
            // 
            this.Cx_Numero_NF.BackColor = System.Drawing.SystemColors.Menu;
            this.Cx_Numero_NF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Cx_Numero_NF.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cx_Numero_NF.Location = new System.Drawing.Point(266, 150);
            this.Cx_Numero_NF.Name = "Cx_Numero_NF";
            this.Cx_Numero_NF.Size = new System.Drawing.Size(128, 19);
            this.Cx_Numero_NF.TabIndex = 17;
            // 
            // Cx_Quant_Compra
            // 
            this.Cx_Quant_Compra.BackColor = System.Drawing.SystemColors.Menu;
            this.Cx_Quant_Compra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Cx_Quant_Compra.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cx_Quant_Compra.Location = new System.Drawing.Point(266, 242);
            this.Cx_Quant_Compra.Name = "Cx_Quant_Compra";
            this.Cx_Quant_Compra.Size = new System.Drawing.Size(128, 19);
            this.Cx_Quant_Compra.TabIndex = 21;
            // 
            // Cx_Pedido_Compra
            // 
            this.Cx_Pedido_Compra.BackColor = System.Drawing.SystemColors.Menu;
            this.Cx_Pedido_Compra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Cx_Pedido_Compra.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cx_Pedido_Compra.Location = new System.Drawing.Point(266, 196);
            this.Cx_Pedido_Compra.Name = "Cx_Pedido_Compra";
            this.Cx_Pedido_Compra.Size = new System.Drawing.Size(128, 19);
            this.Cx_Pedido_Compra.TabIndex = 19;
            // 
            // Cx_Quant_Usada
            // 
            this.Cx_Quant_Usada.BackColor = System.Drawing.SystemColors.Menu;
            this.Cx_Quant_Usada.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Cx_Quant_Usada.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cx_Quant_Usada.Location = new System.Drawing.Point(918, 238);
            this.Cx_Quant_Usada.Name = "Cx_Quant_Usada";
            this.Cx_Quant_Usada.Size = new System.Drawing.Size(104, 19);
            this.Cx_Quant_Usada.TabIndex = 22;
            // 
            // Cx_Produto
            // 
            this.Cx_Produto.BackColor = System.Drawing.SystemColors.Menu;
            this.Cx_Produto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cx_Produto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cx_Produto.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cx_Produto.FormattingEnabled = true;
            this.Cx_Produto.Items.AddRange(new object[] {
            "Ácido Cloridrico",
            "Ácido Sulfúrico",
            "Hidróxido De Potássio",
            "Tolueno",
            "Acetona",
            "Metiletilcetona"});
            this.Cx_Produto.Location = new System.Drawing.Point(153, 98);
            this.Cx_Produto.Name = "Cx_Produto";
            this.Cx_Produto.Size = new System.Drawing.Size(274, 28);
            this.Cx_Produto.TabIndex = 15;
            this.Cx_Produto.Tag = "{Selecione}";
            this.Cx_Produto.SelectedIndexChanged += new System.EventHandler(this.Cx_Produto_SelectedIndexChanged);
            // 
            // BotaoSalvar
            // 
            this.BotaoSalvar.BackColor = System.Drawing.SystemColors.MenuBar;
            this.BotaoSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BotaoSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotaoSalvar.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.BotaoSalvar.FlatAppearance.BorderSize = 0;
            this.BotaoSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotaoSalvar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotaoSalvar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.BotaoSalvar.Location = new System.Drawing.Point(153, 282);
            this.BotaoSalvar.Name = "BotaoSalvar";
            this.BotaoSalvar.Size = new System.Drawing.Size(105, 28);
            this.BotaoSalvar.TabIndex = 23;
            this.BotaoSalvar.Text = "Salvar";
            this.BotaoSalvar.UseVisualStyleBackColor = false;
            this.BotaoSalvar.Click += new System.EventHandler(this.BotaoSalvar_Click);
            // 
            // BotaoLimparDados
            // 
            this.BotaoLimparDados.BackColor = System.Drawing.SystemColors.MenuBar;
            this.BotaoLimparDados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotaoLimparDados.FlatAppearance.BorderSize = 0;
            this.BotaoLimparDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotaoLimparDados.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotaoLimparDados.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BotaoLimparDados.Location = new System.Drawing.Point(354, 282);
            this.BotaoLimparDados.Name = "BotaoLimparDados";
            this.BotaoLimparDados.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BotaoLimparDados.Size = new System.Drawing.Size(105, 28);
            this.BotaoLimparDados.TabIndex = 24;
            this.BotaoLimparDados.Text = "Deletar";
            this.BotaoLimparDados.UseVisualStyleBackColor = false;
            this.BotaoLimparDados.Click += new System.EventHandler(this.BotaoLimparDados_Click);
            // 
            // BotaoSair
            // 
            this.BotaoSair.BackColor = System.Drawing.SystemColors.MenuBar;
            this.BotaoSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotaoSair.FlatAppearance.BorderSize = 0;
            this.BotaoSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotaoSair.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotaoSair.ForeColor = System.Drawing.SystemColors.Desktop;
            this.BotaoSair.Location = new System.Drawing.Point(555, 282);
            this.BotaoSair.Name = "BotaoSair";
            this.BotaoSair.Size = new System.Drawing.Size(105, 28);
            this.BotaoSair.TabIndex = 25;
            this.BotaoSair.Text = "Sair";
            this.BotaoSair.UseVisualStyleBackColor = false;
            this.BotaoSair.Click += new System.EventHandler(this.BotaoSair_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(153, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(918, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(151, 54);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // tab_Produtos
            // 
            this.tab_Produtos.Controls.Add(this.tabPage1);
            this.tab_Produtos.Controls.Add(this.tabPage2);
            this.tab_Produtos.Controls.Add(this.tabPage3);
            this.tab_Produtos.Controls.Add(this.tabPage4);
            this.tab_Produtos.Controls.Add(this.tabPage5);
            this.tab_Produtos.Controls.Add(this.tabPage6);
            this.tab_Produtos.HotTrack = true;
            this.tab_Produtos.Location = new System.Drawing.Point(12, 327);
            this.tab_Produtos.Name = "tab_Produtos";
            this.tab_Produtos.SelectedIndex = 0;
            this.tab_Produtos.Size = new System.Drawing.Size(1117, 276);
            this.tab_Produtos.TabIndex = 26;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1109, 250);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ácido Cloridrico";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeight = 21;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn166,
            this.dataGridViewTextBoxColumn167,
            this.dataGridViewTextBoxColumn168,
            this.dataGridViewTextBoxColumn169,
            this.dataGridViewTextBoxColumn170,
            this.dataGridViewTextBoxColumn171,
            this.dataGridViewTextBoxColumn172,
            this.dataGridViewTextBoxColumn173,
            this.dataGridViewTextBoxColumn174,
            this.dataGridViewTextBoxColumn175,
            this.dataGridViewTextBoxColumn176,
            this.dataLancamentoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bdgAcidoCloridrico;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1103, 244);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Tag = "";
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // dataGridViewTextBoxColumn166
            // 
            this.dataGridViewTextBoxColumn166.DataPropertyName = "IdProdutosQuimicos";
            this.dataGridViewTextBoxColumn166.HeaderText = "IdProdutosQuimicos";
            this.dataGridViewTextBoxColumn166.Name = "dataGridViewTextBoxColumn166";
            this.dataGridViewTextBoxColumn166.ReadOnly = true;
            this.dataGridViewTextBoxColumn166.Width = 126;
            // 
            // dataGridViewTextBoxColumn167
            // 
            this.dataGridViewTextBoxColumn167.DataPropertyName = "Produto";
            this.dataGridViewTextBoxColumn167.HeaderText = "Produto";
            this.dataGridViewTextBoxColumn167.Name = "dataGridViewTextBoxColumn167";
            this.dataGridViewTextBoxColumn167.Width = 69;
            // 
            // dataGridViewTextBoxColumn168
            // 
            this.dataGridViewTextBoxColumn168.DataPropertyName = "Desenho";
            this.dataGridViewTextBoxColumn168.HeaderText = "Desenho";
            this.dataGridViewTextBoxColumn168.Name = "dataGridViewTextBoxColumn168";
            this.dataGridViewTextBoxColumn168.Width = 75;
            // 
            // dataGridViewTextBoxColumn169
            // 
            this.dataGridViewTextBoxColumn169.DataPropertyName = "Numero_NF";
            this.dataGridViewTextBoxColumn169.HeaderText = "Numero_NF";
            this.dataGridViewTextBoxColumn169.Name = "dataGridViewTextBoxColumn169";
            this.dataGridViewTextBoxColumn169.Width = 89;
            // 
            // dataGridViewTextBoxColumn170
            // 
            this.dataGridViewTextBoxColumn170.DataPropertyName = "Data_Emissao_NF";
            this.dataGridViewTextBoxColumn170.HeaderText = "Data_Emissao_NF";
            this.dataGridViewTextBoxColumn170.Name = "dataGridViewTextBoxColumn170";
            this.dataGridViewTextBoxColumn170.Width = 120;
            // 
            // dataGridViewTextBoxColumn171
            // 
            this.dataGridViewTextBoxColumn171.DataPropertyName = "Numero_Pedido";
            this.dataGridViewTextBoxColumn171.HeaderText = "Numero_Pedido";
            this.dataGridViewTextBoxColumn171.Name = "dataGridViewTextBoxColumn171";
            this.dataGridViewTextBoxColumn171.Width = 108;
            // 
            // dataGridViewTextBoxColumn172
            // 
            this.dataGridViewTextBoxColumn172.DataPropertyName = "Data_Pedido";
            this.dataGridViewTextBoxColumn172.HeaderText = "Data_Pedido";
            this.dataGridViewTextBoxColumn172.Name = "dataGridViewTextBoxColumn172";
            this.dataGridViewTextBoxColumn172.Width = 94;
            // 
            // dataGridViewTextBoxColumn173
            // 
            this.dataGridViewTextBoxColumn173.DataPropertyName = "Estoque";
            this.dataGridViewTextBoxColumn173.HeaderText = "Estoque";
            this.dataGridViewTextBoxColumn173.Name = "dataGridViewTextBoxColumn173";
            this.dataGridViewTextBoxColumn173.Width = 71;
            // 
            // dataGridViewTextBoxColumn174
            // 
            this.dataGridViewTextBoxColumn174.DataPropertyName = "Quant_Comprada";
            this.dataGridViewTextBoxColumn174.HeaderText = "Quant_Comprada";
            this.dataGridViewTextBoxColumn174.Name = "dataGridViewTextBoxColumn174";
            this.dataGridViewTextBoxColumn174.Width = 115;
            // 
            // dataGridViewTextBoxColumn175
            // 
            this.dataGridViewTextBoxColumn175.DataPropertyName = "Quant_Usada";
            this.dataGridViewTextBoxColumn175.HeaderText = "Quant_Usada";
            this.dataGridViewTextBoxColumn175.Name = "dataGridViewTextBoxColumn175";
            this.dataGridViewTextBoxColumn175.Width = 98;
            // 
            // dataGridViewTextBoxColumn176
            // 
            this.dataGridViewTextBoxColumn176.DataPropertyName = "Usuario_Logado";
            this.dataGridViewTextBoxColumn176.HeaderText = "Usuario_Logado";
            this.dataGridViewTextBoxColumn176.Name = "dataGridViewTextBoxColumn176";
            this.dataGridViewTextBoxColumn176.Width = 110;
            // 
            // dataLancamentoDataGridViewTextBoxColumn
            // 
            this.dataLancamentoDataGridViewTextBoxColumn.DataPropertyName = "Data_Lancamento";
            this.dataLancamentoDataGridViewTextBoxColumn.HeaderText = "Data_Lancamento";
            this.dataLancamentoDataGridViewTextBoxColumn.Name = "dataLancamentoDataGridViewTextBoxColumn";
            this.dataLancamentoDataGridViewTextBoxColumn.Width = 120;
            // 
            // bdgAcidoCloridrico
            // 
            this.bdgAcidoCloridrico.DataMember = "tblAcidoCloridrico";
            this.bdgAcidoCloridrico.DataSource = this.bDPQDataSethome;
            // 
            // bDPQDataSethome
            // 
            this.bDPQDataSethome.DataSetName = "BDPQDataSethome";
            this.bDPQDataSethome.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1109, 250);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ácido Sulfurico";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView2.ColumnHeadersHeight = 21;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Registro_AcidoSulfurico,
            this.Produto_AcidoSulfurico,
            this.Desenho_AcidoSulfurico,
            this.NF_AcidoSulfurico,
            this.Data_Emissao_NF_AcidoSulfurico,
            this.Numero_Pedido_AcidoSulfurico,
            this.Data_Pedido_AcidoSulfurico,
            this.Estoque_AcidoSulfurico,
            this.Quant_Comprada_AcidoSulfurico,
            this.Quant_Usada_AcidoSulfurico,
            this.Usuario_AcidoSulfurico,
            this.Data_Lancamento_AcidoSulfurico});
            this.dataGridView2.DataSource = this.bdgAcidoSulfurico;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1103, 244);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView2_UserDeletingRow);
            // 
            // Registro_AcidoSulfurico
            // 
            this.Registro_AcidoSulfurico.DataPropertyName = "IdProdutosQuimicos";
            this.Registro_AcidoSulfurico.HeaderText = "Registro";
            this.Registro_AcidoSulfurico.Name = "Registro_AcidoSulfurico";
            this.Registro_AcidoSulfurico.ReadOnly = true;
            this.Registro_AcidoSulfurico.Width = 71;
            // 
            // Produto_AcidoSulfurico
            // 
            this.Produto_AcidoSulfurico.DataPropertyName = "Produto";
            this.Produto_AcidoSulfurico.HeaderText = "Produto";
            this.Produto_AcidoSulfurico.Name = "Produto_AcidoSulfurico";
            this.Produto_AcidoSulfurico.ReadOnly = true;
            this.Produto_AcidoSulfurico.Width = 69;
            // 
            // Desenho_AcidoSulfurico
            // 
            this.Desenho_AcidoSulfurico.DataPropertyName = "Desenho";
            this.Desenho_AcidoSulfurico.HeaderText = "Desenho";
            this.Desenho_AcidoSulfurico.Name = "Desenho_AcidoSulfurico";
            this.Desenho_AcidoSulfurico.ReadOnly = true;
            this.Desenho_AcidoSulfurico.Width = 75;
            // 
            // NF_AcidoSulfurico
            // 
            this.NF_AcidoSulfurico.DataPropertyName = "Numero_NF";
            this.NF_AcidoSulfurico.HeaderText = "Numero NF";
            this.NF_AcidoSulfurico.Name = "NF_AcidoSulfurico";
            this.NF_AcidoSulfurico.ReadOnly = true;
            this.NF_AcidoSulfurico.Width = 86;
            // 
            // Data_Emissao_NF_AcidoSulfurico
            // 
            this.Data_Emissao_NF_AcidoSulfurico.DataPropertyName = "Data_Emissao_NF";
            this.Data_Emissao_NF_AcidoSulfurico.HeaderText = "Emissão NF";
            this.Data_Emissao_NF_AcidoSulfurico.Name = "Data_Emissao_NF_AcidoSulfurico";
            this.Data_Emissao_NF_AcidoSulfurico.ReadOnly = true;
            this.Data_Emissao_NF_AcidoSulfurico.Width = 88;
            // 
            // Numero_Pedido_AcidoSulfurico
            // 
            this.Numero_Pedido_AcidoSulfurico.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Numero_Pedido_AcidoSulfurico.DataPropertyName = "Numero_Pedido";
            this.Numero_Pedido_AcidoSulfurico.HeaderText = "Pedido Compra";
            this.Numero_Pedido_AcidoSulfurico.Name = "Numero_Pedido_AcidoSulfurico";
            this.Numero_Pedido_AcidoSulfurico.ReadOnly = true;
            this.Numero_Pedido_AcidoSulfurico.Width = 104;
            // 
            // Data_Pedido_AcidoSulfurico
            // 
            this.Data_Pedido_AcidoSulfurico.DataPropertyName = "Data_Pedido";
            this.Data_Pedido_AcidoSulfurico.HeaderText = "Data Pedido";
            this.Data_Pedido_AcidoSulfurico.Name = "Data_Pedido_AcidoSulfurico";
            this.Data_Pedido_AcidoSulfurico.ReadOnly = true;
            this.Data_Pedido_AcidoSulfurico.Width = 91;
            // 
            // Estoque_AcidoSulfurico
            // 
            this.Estoque_AcidoSulfurico.DataPropertyName = "Estoque";
            this.Estoque_AcidoSulfurico.HeaderText = "Estoque";
            this.Estoque_AcidoSulfurico.Name = "Estoque_AcidoSulfurico";
            this.Estoque_AcidoSulfurico.ReadOnly = true;
            this.Estoque_AcidoSulfurico.Width = 71;
            // 
            // Quant_Comprada_AcidoSulfurico
            // 
            this.Quant_Comprada_AcidoSulfurico.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Quant_Comprada_AcidoSulfurico.DataPropertyName = "Quant_Comprada";
            this.Quant_Comprada_AcidoSulfurico.HeaderText = "Quant. Comprada";
            this.Quant_Comprada_AcidoSulfurico.Name = "Quant_Comprada_AcidoSulfurico";
            this.Quant_Comprada_AcidoSulfurico.ReadOnly = true;
            this.Quant_Comprada_AcidoSulfurico.Width = 115;
            // 
            // Quant_Usada_AcidoSulfurico
            // 
            this.Quant_Usada_AcidoSulfurico.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Quant_Usada_AcidoSulfurico.DataPropertyName = "Quant_Usada";
            this.Quant_Usada_AcidoSulfurico.HeaderText = "Quant. Usada";
            this.Quant_Usada_AcidoSulfurico.Name = "Quant_Usada_AcidoSulfurico";
            this.Quant_Usada_AcidoSulfurico.ReadOnly = true;
            this.Quant_Usada_AcidoSulfurico.Width = 98;
            // 
            // Usuario_AcidoSulfurico
            // 
            this.Usuario_AcidoSulfurico.DataPropertyName = "Usuario_Logado";
            this.Usuario_AcidoSulfurico.HeaderText = "Usuario";
            this.Usuario_AcidoSulfurico.Name = "Usuario_AcidoSulfurico";
            this.Usuario_AcidoSulfurico.ReadOnly = true;
            this.Usuario_AcidoSulfurico.Width = 68;
            // 
            // Data_Lancamento_AcidoSulfurico
            // 
            this.Data_Lancamento_AcidoSulfurico.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Data_Lancamento_AcidoSulfurico.DataPropertyName = "Data_Lancamento";
            this.Data_Lancamento_AcidoSulfurico.HeaderText = "Data Lançamento";
            this.Data_Lancamento_AcidoSulfurico.Name = "Data_Lancamento_AcidoSulfurico";
            this.Data_Lancamento_AcidoSulfurico.ReadOnly = true;
            this.Data_Lancamento_AcidoSulfurico.Width = 120;
            // 
            // bdgAcidoSulfurico
            // 
            this.bdgAcidoSulfurico.DataMember = "tblAcidoSulfurico";
            this.bdgAcidoSulfurico.DataSource = this.bDPQDataSethome;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1109, 250);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Hidróxido De Potássio";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView3.ColumnHeadersHeight = 21;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn177,
            this.dataGridViewTextBoxColumn178,
            this.dataGridViewTextBoxColumn179,
            this.dataGridViewTextBoxColumn180,
            this.dataGridViewTextBoxColumn181,
            this.dataGridViewTextBoxColumn182,
            this.dataGridViewTextBoxColumn183,
            this.dataGridViewTextBoxColumn184,
            this.dataGridViewTextBoxColumn185,
            this.dataGridViewTextBoxColumn186,
            this.dataGridViewTextBoxColumn187,
            this.dataLancamentoDataGridViewTextBoxColumn1});
            this.dataGridView3.DataSource = this.bdgHidroxidoPostasio;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(3, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(1103, 244);
            this.dataGridView3.TabIndex = 2;
            this.dataGridView3.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView3_UserDeletingRow);
            // 
            // dataGridViewTextBoxColumn177
            // 
            this.dataGridViewTextBoxColumn177.DataPropertyName = "IdProdutosQuimicos";
            this.dataGridViewTextBoxColumn177.HeaderText = "IdProdutosQuimicos";
            this.dataGridViewTextBoxColumn177.Name = "dataGridViewTextBoxColumn177";
            this.dataGridViewTextBoxColumn177.ReadOnly = true;
            this.dataGridViewTextBoxColumn177.Width = 126;
            // 
            // dataGridViewTextBoxColumn178
            // 
            this.dataGridViewTextBoxColumn178.DataPropertyName = "Produto";
            this.dataGridViewTextBoxColumn178.HeaderText = "Produto";
            this.dataGridViewTextBoxColumn178.Name = "dataGridViewTextBoxColumn178";
            this.dataGridViewTextBoxColumn178.ReadOnly = true;
            this.dataGridViewTextBoxColumn178.Width = 69;
            // 
            // dataGridViewTextBoxColumn179
            // 
            this.dataGridViewTextBoxColumn179.DataPropertyName = "Desenho";
            this.dataGridViewTextBoxColumn179.HeaderText = "Desenho";
            this.dataGridViewTextBoxColumn179.Name = "dataGridViewTextBoxColumn179";
            this.dataGridViewTextBoxColumn179.ReadOnly = true;
            this.dataGridViewTextBoxColumn179.Width = 75;
            // 
            // dataGridViewTextBoxColumn180
            // 
            this.dataGridViewTextBoxColumn180.DataPropertyName = "Numero_NF";
            this.dataGridViewTextBoxColumn180.HeaderText = "Numero_NF";
            this.dataGridViewTextBoxColumn180.Name = "dataGridViewTextBoxColumn180";
            this.dataGridViewTextBoxColumn180.ReadOnly = true;
            this.dataGridViewTextBoxColumn180.Width = 89;
            // 
            // dataGridViewTextBoxColumn181
            // 
            this.dataGridViewTextBoxColumn181.DataPropertyName = "Data_Emissao_NF";
            this.dataGridViewTextBoxColumn181.HeaderText = "Data_Emissao_NF";
            this.dataGridViewTextBoxColumn181.Name = "dataGridViewTextBoxColumn181";
            this.dataGridViewTextBoxColumn181.ReadOnly = true;
            this.dataGridViewTextBoxColumn181.Width = 120;
            // 
            // dataGridViewTextBoxColumn182
            // 
            this.dataGridViewTextBoxColumn182.DataPropertyName = "Numero_Pedido";
            this.dataGridViewTextBoxColumn182.HeaderText = "Numero_Pedido";
            this.dataGridViewTextBoxColumn182.Name = "dataGridViewTextBoxColumn182";
            this.dataGridViewTextBoxColumn182.ReadOnly = true;
            this.dataGridViewTextBoxColumn182.Width = 108;
            // 
            // dataGridViewTextBoxColumn183
            // 
            this.dataGridViewTextBoxColumn183.DataPropertyName = "Data_Pedido";
            this.dataGridViewTextBoxColumn183.HeaderText = "Data_Pedido";
            this.dataGridViewTextBoxColumn183.Name = "dataGridViewTextBoxColumn183";
            this.dataGridViewTextBoxColumn183.ReadOnly = true;
            this.dataGridViewTextBoxColumn183.Width = 94;
            // 
            // dataGridViewTextBoxColumn184
            // 
            this.dataGridViewTextBoxColumn184.DataPropertyName = "Estoque";
            this.dataGridViewTextBoxColumn184.HeaderText = "Estoque";
            this.dataGridViewTextBoxColumn184.Name = "dataGridViewTextBoxColumn184";
            this.dataGridViewTextBoxColumn184.ReadOnly = true;
            this.dataGridViewTextBoxColumn184.Width = 71;
            // 
            // dataGridViewTextBoxColumn185
            // 
            this.dataGridViewTextBoxColumn185.DataPropertyName = "Quant_Comprada";
            this.dataGridViewTextBoxColumn185.HeaderText = "Quant_Comprada";
            this.dataGridViewTextBoxColumn185.Name = "dataGridViewTextBoxColumn185";
            this.dataGridViewTextBoxColumn185.ReadOnly = true;
            this.dataGridViewTextBoxColumn185.Width = 115;
            // 
            // dataGridViewTextBoxColumn186
            // 
            this.dataGridViewTextBoxColumn186.DataPropertyName = "Quant_Usada";
            this.dataGridViewTextBoxColumn186.HeaderText = "Quant_Usada";
            this.dataGridViewTextBoxColumn186.Name = "dataGridViewTextBoxColumn186";
            this.dataGridViewTextBoxColumn186.ReadOnly = true;
            this.dataGridViewTextBoxColumn186.Width = 98;
            // 
            // dataGridViewTextBoxColumn187
            // 
            this.dataGridViewTextBoxColumn187.DataPropertyName = "Usuario_Logado";
            this.dataGridViewTextBoxColumn187.HeaderText = "Usuario_Logado";
            this.dataGridViewTextBoxColumn187.Name = "dataGridViewTextBoxColumn187";
            this.dataGridViewTextBoxColumn187.ReadOnly = true;
            this.dataGridViewTextBoxColumn187.Width = 110;
            // 
            // dataLancamentoDataGridViewTextBoxColumn1
            // 
            this.dataLancamentoDataGridViewTextBoxColumn1.DataPropertyName = "Data_Lancamento";
            this.dataLancamentoDataGridViewTextBoxColumn1.HeaderText = "Data_Lancamento";
            this.dataLancamentoDataGridViewTextBoxColumn1.Name = "dataLancamentoDataGridViewTextBoxColumn1";
            this.dataLancamentoDataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataLancamentoDataGridViewTextBoxColumn1.Width = 120;
            // 
            // bdgHidroxidoPostasio
            // 
            this.bdgHidroxidoPostasio.DataMember = "tblHidroxidoPostasio";
            this.bdgHidroxidoPostasio.DataSource = this.bDPQDataSethome;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridView4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1109, 250);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Tolueno";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView4.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView4.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView4.ColumnHeadersHeight = 21;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Registro_Tolueno,
            this.Produto_Tolueno,
            this.Desenho_Tolueno,
            this.Numero_NF_Tolueno,
            this.Data_Emissao_NF_Tolueno,
            this.Pedido_Compra_Tolueno,
            this.Data_Pedido_Tolueno,
            this.Estoque_Tolueno,
            this.Quant_Comprada_Tolueno,
            this.Quant_Usada_Tolueno,
            this.Usuario_Tolueno,
            this.Data_Lancamento_Tolueno});
            this.dataGridView4.DataSource = this.bdgTolueno;
            this.dataGridView4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView4.Location = new System.Drawing.Point(3, 3);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView4.Size = new System.Drawing.Size(1103, 244);
            this.dataGridView4.TabIndex = 2;
            this.dataGridView4.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView4_UserDeletingRow);
            // 
            // Registro_Tolueno
            // 
            this.Registro_Tolueno.DataPropertyName = "IdProdutosQuimicos";
            this.Registro_Tolueno.HeaderText = "Registro";
            this.Registro_Tolueno.Name = "Registro_Tolueno";
            this.Registro_Tolueno.ReadOnly = true;
            this.Registro_Tolueno.Width = 71;
            // 
            // Produto_Tolueno
            // 
            this.Produto_Tolueno.DataPropertyName = "Produto";
            this.Produto_Tolueno.HeaderText = "Produto";
            this.Produto_Tolueno.Name = "Produto_Tolueno";
            this.Produto_Tolueno.ReadOnly = true;
            this.Produto_Tolueno.Width = 69;
            // 
            // Desenho_Tolueno
            // 
            this.Desenho_Tolueno.DataPropertyName = "Desenho";
            this.Desenho_Tolueno.HeaderText = "Desenho";
            this.Desenho_Tolueno.Name = "Desenho_Tolueno";
            this.Desenho_Tolueno.ReadOnly = true;
            this.Desenho_Tolueno.Width = 75;
            // 
            // Numero_NF_Tolueno
            // 
            this.Numero_NF_Tolueno.DataPropertyName = "Numero_NF";
            this.Numero_NF_Tolueno.HeaderText = "Numero NF";
            this.Numero_NF_Tolueno.Name = "Numero_NF_Tolueno";
            this.Numero_NF_Tolueno.ReadOnly = true;
            this.Numero_NF_Tolueno.Width = 86;
            // 
            // Data_Emissao_NF_Tolueno
            // 
            this.Data_Emissao_NF_Tolueno.DataPropertyName = "Data_Emissao_NF";
            this.Data_Emissao_NF_Tolueno.HeaderText = "Emissão NF";
            this.Data_Emissao_NF_Tolueno.Name = "Data_Emissao_NF_Tolueno";
            this.Data_Emissao_NF_Tolueno.ReadOnly = true;
            this.Data_Emissao_NF_Tolueno.Width = 88;
            // 
            // Pedido_Compra_Tolueno
            // 
            this.Pedido_Compra_Tolueno.DataPropertyName = "Numero_Pedido";
            this.Pedido_Compra_Tolueno.HeaderText = "Pedido Compra";
            this.Pedido_Compra_Tolueno.Name = "Pedido_Compra_Tolueno";
            this.Pedido_Compra_Tolueno.ReadOnly = true;
            this.Pedido_Compra_Tolueno.Width = 104;
            // 
            // Data_Pedido_Tolueno
            // 
            this.Data_Pedido_Tolueno.DataPropertyName = "Data_Pedido";
            this.Data_Pedido_Tolueno.HeaderText = "Data Pedido";
            this.Data_Pedido_Tolueno.Name = "Data_Pedido_Tolueno";
            this.Data_Pedido_Tolueno.ReadOnly = true;
            this.Data_Pedido_Tolueno.Width = 91;
            // 
            // Estoque_Tolueno
            // 
            this.Estoque_Tolueno.DataPropertyName = "Estoque";
            this.Estoque_Tolueno.HeaderText = "Estoque";
            this.Estoque_Tolueno.Name = "Estoque_Tolueno";
            this.Estoque_Tolueno.ReadOnly = true;
            this.Estoque_Tolueno.Width = 71;
            // 
            // Quant_Comprada_Tolueno
            // 
            this.Quant_Comprada_Tolueno.DataPropertyName = "Quant_Comprada";
            this.Quant_Comprada_Tolueno.HeaderText = "Quant. Comprada";
            this.Quant_Comprada_Tolueno.Name = "Quant_Comprada_Tolueno";
            this.Quant_Comprada_Tolueno.ReadOnly = true;
            this.Quant_Comprada_Tolueno.Width = 115;
            // 
            // Quant_Usada_Tolueno
            // 
            this.Quant_Usada_Tolueno.DataPropertyName = "Quant_Usada";
            this.Quant_Usada_Tolueno.HeaderText = "Quant. Usada";
            this.Quant_Usada_Tolueno.Name = "Quant_Usada_Tolueno";
            this.Quant_Usada_Tolueno.ReadOnly = true;
            this.Quant_Usada_Tolueno.Width = 98;
            // 
            // Usuario_Tolueno
            // 
            this.Usuario_Tolueno.DataPropertyName = "Usuario_Logado";
            this.Usuario_Tolueno.HeaderText = "Usuario";
            this.Usuario_Tolueno.Name = "Usuario_Tolueno";
            this.Usuario_Tolueno.ReadOnly = true;
            this.Usuario_Tolueno.Width = 68;
            // 
            // Data_Lancamento_Tolueno
            // 
            this.Data_Lancamento_Tolueno.DataPropertyName = "Data_Lancamento";
            this.Data_Lancamento_Tolueno.HeaderText = "Data Lançamento";
            this.Data_Lancamento_Tolueno.Name = "Data_Lancamento_Tolueno";
            this.Data_Lancamento_Tolueno.ReadOnly = true;
            this.Data_Lancamento_Tolueno.Width = 117;
            // 
            // bdgTolueno
            // 
            this.bdgTolueno.DataMember = "tblTolueno";
            this.bdgTolueno.DataSource = this.bDPQDataSethome;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dataGridView5);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1109, 250);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Acetona";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dataGridView5
            // 
            this.dataGridView5.AllowUserToAddRows = false;
            this.dataGridView5.AutoGenerateColumns = false;
            this.dataGridView5.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView5.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView5.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView5.ColumnHeadersHeight = 21;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Registro_Acetona,
            this.Produto_Acetona,
            this.Desenho_Acetona,
            this.Numero_NF_Acetona,
            this.Emissao_NF_Acetona,
            this.Pedido_Compra_Acetona,
            this.Data_Pedido_Acetona,
            this.Estoque_Acetona,
            this.Quant_Comprada_Acetona,
            this.Quant_Usada_Acetona,
            this.Usuario_Acetona,
            this.Data_Lancamento_Acetona});
            this.dataGridView5.DataSource = this.bdgAcetona;
            this.dataGridView5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView5.Location = new System.Drawing.Point(3, 3);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.ReadOnly = true;
            this.dataGridView5.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView5.Size = new System.Drawing.Size(1103, 244);
            this.dataGridView5.TabIndex = 3;
            this.dataGridView5.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView5_UserDeletingRow);
            // 
            // Registro_Acetona
            // 
            this.Registro_Acetona.DataPropertyName = "IdProdutosQuimicos";
            this.Registro_Acetona.HeaderText = "Registro";
            this.Registro_Acetona.Name = "Registro_Acetona";
            this.Registro_Acetona.ReadOnly = true;
            this.Registro_Acetona.Width = 71;
            // 
            // Produto_Acetona
            // 
            this.Produto_Acetona.DataPropertyName = "Produto";
            this.Produto_Acetona.HeaderText = "Produto";
            this.Produto_Acetona.Name = "Produto_Acetona";
            this.Produto_Acetona.ReadOnly = true;
            this.Produto_Acetona.Width = 69;
            // 
            // Desenho_Acetona
            // 
            this.Desenho_Acetona.DataPropertyName = "Desenho";
            this.Desenho_Acetona.HeaderText = "Desenho";
            this.Desenho_Acetona.Name = "Desenho_Acetona";
            this.Desenho_Acetona.ReadOnly = true;
            this.Desenho_Acetona.Width = 75;
            // 
            // Numero_NF_Acetona
            // 
            this.Numero_NF_Acetona.DataPropertyName = "Numero_NF";
            this.Numero_NF_Acetona.HeaderText = "Numero NF";
            this.Numero_NF_Acetona.Name = "Numero_NF_Acetona";
            this.Numero_NF_Acetona.ReadOnly = true;
            this.Numero_NF_Acetona.Width = 86;
            // 
            // Emissao_NF_Acetona
            // 
            this.Emissao_NF_Acetona.DataPropertyName = "Data_Emissao_NF";
            this.Emissao_NF_Acetona.HeaderText = "Emissão NF";
            this.Emissao_NF_Acetona.Name = "Emissao_NF_Acetona";
            this.Emissao_NF_Acetona.ReadOnly = true;
            this.Emissao_NF_Acetona.Width = 88;
            // 
            // Pedido_Compra_Acetona
            // 
            this.Pedido_Compra_Acetona.DataPropertyName = "Numero_Pedido";
            this.Pedido_Compra_Acetona.HeaderText = "Pedido Compra";
            this.Pedido_Compra_Acetona.Name = "Pedido_Compra_Acetona";
            this.Pedido_Compra_Acetona.ReadOnly = true;
            this.Pedido_Compra_Acetona.Width = 104;
            // 
            // Data_Pedido_Acetona
            // 
            this.Data_Pedido_Acetona.DataPropertyName = "Data_Pedido";
            this.Data_Pedido_Acetona.HeaderText = "Data Pedido";
            this.Data_Pedido_Acetona.Name = "Data_Pedido_Acetona";
            this.Data_Pedido_Acetona.ReadOnly = true;
            this.Data_Pedido_Acetona.Width = 91;
            // 
            // Estoque_Acetona
            // 
            this.Estoque_Acetona.DataPropertyName = "Estoque";
            this.Estoque_Acetona.HeaderText = "Estoque";
            this.Estoque_Acetona.Name = "Estoque_Acetona";
            this.Estoque_Acetona.ReadOnly = true;
            this.Estoque_Acetona.Width = 71;
            // 
            // Quant_Comprada_Acetona
            // 
            this.Quant_Comprada_Acetona.DataPropertyName = "Quant_Comprada";
            this.Quant_Comprada_Acetona.HeaderText = "Quant. Comprada";
            this.Quant_Comprada_Acetona.Name = "Quant_Comprada_Acetona";
            this.Quant_Comprada_Acetona.ReadOnly = true;
            this.Quant_Comprada_Acetona.Width = 115;
            // 
            // Quant_Usada_Acetona
            // 
            this.Quant_Usada_Acetona.DataPropertyName = "Quant_Usada";
            this.Quant_Usada_Acetona.HeaderText = "Quant. Usada";
            this.Quant_Usada_Acetona.Name = "Quant_Usada_Acetona";
            this.Quant_Usada_Acetona.ReadOnly = true;
            this.Quant_Usada_Acetona.Width = 98;
            // 
            // Usuario_Acetona
            // 
            this.Usuario_Acetona.DataPropertyName = "Usuario_Logado";
            this.Usuario_Acetona.HeaderText = "Usuario";
            this.Usuario_Acetona.Name = "Usuario_Acetona";
            this.Usuario_Acetona.ReadOnly = true;
            this.Usuario_Acetona.Width = 68;
            // 
            // Data_Lancamento_Acetona
            // 
            this.Data_Lancamento_Acetona.DataPropertyName = "Data_Lancamento";
            this.Data_Lancamento_Acetona.HeaderText = "Data Lançamento";
            this.Data_Lancamento_Acetona.Name = "Data_Lancamento_Acetona";
            this.Data_Lancamento_Acetona.ReadOnly = true;
            this.Data_Lancamento_Acetona.Width = 117;
            // 
            // bdgAcetona
            // 
            this.bdgAcetona.DataMember = "tblAcetona";
            this.bdgAcetona.DataSource = this.bDPQDataSethome;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.dataGridView6);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(1109, 250);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Metiletilcetona";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // dataGridView6
            // 
            this.dataGridView6.AllowUserToAddRows = false;
            this.dataGridView6.AllowUserToResizeColumns = false;
            this.dataGridView6.AllowUserToResizeRows = false;
            this.dataGridView6.AutoGenerateColumns = false;
            this.dataGridView6.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView6.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView6.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView6.ColumnHeadersHeight = 21;
            this.dataGridView6.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Registro_Metiletilcetona,
            this.Produto_Metiletilcetona,
            this.Desenho_Metiletilcetona,
            this.Numero_NF_Metiletilcetona,
            this.Data_Emissao_NF_Metiletilcetona,
            this.Pedido_Compra_Metiletilcetona,
            this.Data_Pedido_Metiletilcetona,
            this.Estoque_Metiletilcetona,
            this.Quant_Comprada_Metiletilcetona,
            this.Quant_Usada_Metiletilcetona,
            this.Usuario__Metiletilcetona,
            this.Data_Lancamento_Metiletilcetona});
            this.dataGridView6.DataSource = this.bdgMetiletilcetona;
            this.dataGridView6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView6.Location = new System.Drawing.Point(3, 3);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.ReadOnly = true;
            this.dataGridView6.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView6.Size = new System.Drawing.Size(1103, 244);
            this.dataGridView6.TabIndex = 4;
            this.dataGridView6.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView6_UserDeletingRow);
            // 
            // Registro_Metiletilcetona
            // 
            this.Registro_Metiletilcetona.DataPropertyName = "IdProdutosQuimicos";
            this.Registro_Metiletilcetona.HeaderText = "Registro";
            this.Registro_Metiletilcetona.Name = "Registro_Metiletilcetona";
            this.Registro_Metiletilcetona.ReadOnly = true;
            this.Registro_Metiletilcetona.Width = 71;
            // 
            // Produto_Metiletilcetona
            // 
            this.Produto_Metiletilcetona.DataPropertyName = "Produto";
            this.Produto_Metiletilcetona.HeaderText = "Produto";
            this.Produto_Metiletilcetona.Name = "Produto_Metiletilcetona";
            this.Produto_Metiletilcetona.ReadOnly = true;
            this.Produto_Metiletilcetona.Width = 69;
            // 
            // Desenho_Metiletilcetona
            // 
            this.Desenho_Metiletilcetona.DataPropertyName = "Desenho";
            this.Desenho_Metiletilcetona.HeaderText = "Desenho";
            this.Desenho_Metiletilcetona.Name = "Desenho_Metiletilcetona";
            this.Desenho_Metiletilcetona.ReadOnly = true;
            this.Desenho_Metiletilcetona.Width = 75;
            // 
            // Numero_NF_Metiletilcetona
            // 
            this.Numero_NF_Metiletilcetona.DataPropertyName = "Numero_NF";
            this.Numero_NF_Metiletilcetona.HeaderText = "Numero NF";
            this.Numero_NF_Metiletilcetona.Name = "Numero_NF_Metiletilcetona";
            this.Numero_NF_Metiletilcetona.ReadOnly = true;
            this.Numero_NF_Metiletilcetona.Width = 86;
            // 
            // Data_Emissao_NF_Metiletilcetona
            // 
            this.Data_Emissao_NF_Metiletilcetona.DataPropertyName = "Data_Emissao_NF";
            this.Data_Emissao_NF_Metiletilcetona.HeaderText = "Emissão NF";
            this.Data_Emissao_NF_Metiletilcetona.Name = "Data_Emissao_NF_Metiletilcetona";
            this.Data_Emissao_NF_Metiletilcetona.ReadOnly = true;
            this.Data_Emissao_NF_Metiletilcetona.Width = 88;
            // 
            // Pedido_Compra_Metiletilcetona
            // 
            this.Pedido_Compra_Metiletilcetona.DataPropertyName = "Numero_Pedido";
            this.Pedido_Compra_Metiletilcetona.HeaderText = "Pedido Compra";
            this.Pedido_Compra_Metiletilcetona.Name = "Pedido_Compra_Metiletilcetona";
            this.Pedido_Compra_Metiletilcetona.ReadOnly = true;
            this.Pedido_Compra_Metiletilcetona.Width = 104;
            // 
            // Data_Pedido_Metiletilcetona
            // 
            this.Data_Pedido_Metiletilcetona.DataPropertyName = "Data_Pedido";
            this.Data_Pedido_Metiletilcetona.HeaderText = "Data Pedido";
            this.Data_Pedido_Metiletilcetona.Name = "Data_Pedido_Metiletilcetona";
            this.Data_Pedido_Metiletilcetona.ReadOnly = true;
            this.Data_Pedido_Metiletilcetona.Width = 91;
            // 
            // Estoque_Metiletilcetona
            // 
            this.Estoque_Metiletilcetona.DataPropertyName = "Estoque";
            this.Estoque_Metiletilcetona.HeaderText = "Estoque";
            this.Estoque_Metiletilcetona.Name = "Estoque_Metiletilcetona";
            this.Estoque_Metiletilcetona.ReadOnly = true;
            this.Estoque_Metiletilcetona.Width = 71;
            // 
            // Quant_Comprada_Metiletilcetona
            // 
            this.Quant_Comprada_Metiletilcetona.DataPropertyName = "Quant_Comprada";
            this.Quant_Comprada_Metiletilcetona.HeaderText = "Quant. Comprada";
            this.Quant_Comprada_Metiletilcetona.Name = "Quant_Comprada_Metiletilcetona";
            this.Quant_Comprada_Metiletilcetona.ReadOnly = true;
            this.Quant_Comprada_Metiletilcetona.Width = 115;
            // 
            // Quant_Usada_Metiletilcetona
            // 
            this.Quant_Usada_Metiletilcetona.DataPropertyName = "Quant_Usada";
            this.Quant_Usada_Metiletilcetona.HeaderText = "Quant. Usada";
            this.Quant_Usada_Metiletilcetona.Name = "Quant_Usada_Metiletilcetona";
            this.Quant_Usada_Metiletilcetona.ReadOnly = true;
            this.Quant_Usada_Metiletilcetona.Width = 98;
            // 
            // Usuario__Metiletilcetona
            // 
            this.Usuario__Metiletilcetona.DataPropertyName = "Usuario_Logado";
            this.Usuario__Metiletilcetona.HeaderText = "Usuario";
            this.Usuario__Metiletilcetona.Name = "Usuario__Metiletilcetona";
            this.Usuario__Metiletilcetona.ReadOnly = true;
            this.Usuario__Metiletilcetona.Width = 68;
            // 
            // Data_Lancamento_Metiletilcetona
            // 
            this.Data_Lancamento_Metiletilcetona.DataPropertyName = "Data_Lancamento";
            this.Data_Lancamento_Metiletilcetona.HeaderText = "Data Lançamento";
            this.Data_Lancamento_Metiletilcetona.Name = "Data_Lancamento_Metiletilcetona";
            this.Data_Lancamento_Metiletilcetona.ReadOnly = true;
            this.Data_Lancamento_Metiletilcetona.Width = 117;
            // 
            // bdgMetiletilcetona
            // 
            this.bdgMetiletilcetona.DataMember = "tblMetiletilcetona";
            this.bdgMetiletilcetona.DataSource = this.bDPQDataSethome;
            // 
            // Cx_Item
            // 
            this.Cx_Item.BackColor = System.Drawing.SystemColors.Menu;
            this.Cx_Item.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cx_Item.Enabled = false;
            this.Cx_Item.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cx_Item.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cx_Item.FormattingEnabled = true;
            this.Cx_Item.Items.AddRange(new object[] {
            "N4981917P012",
            "Z40981302P025",
            "Z40981302P003",
            "Z40981302P017",
            "Z40981302P006",
            "Z40981302P005"});
            this.Cx_Item.Location = new System.Drawing.Point(756, 94);
            this.Cx_Item.Name = "Cx_Item";
            this.Cx_Item.Size = new System.Drawing.Size(364, 28);
            this.Cx_Item.TabIndex = 16;
            // 
            // Cx_Data_Emissao_NF
            // 
            this.Cx_Data_Emissao_NF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cx_Data_Emissao_NF.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Cx_Data_Emissao_NF.Location = new System.Drawing.Point(918, 150);
            this.Cx_Data_Emissao_NF.Name = "Cx_Data_Emissao_NF";
            this.Cx_Data_Emissao_NF.Size = new System.Drawing.Size(104, 20);
            this.Cx_Data_Emissao_NF.TabIndex = 27;
            // 
            // Cx_Data_Pedido
            // 
            this.Cx_Data_Pedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cx_Data_Pedido.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Cx_Data_Pedido.Location = new System.Drawing.Point(918, 189);
            this.Cx_Data_Pedido.Name = "Cx_Data_Pedido";
            this.Cx_Data_Pedido.Size = new System.Drawing.Size(104, 20);
            this.Cx_Data_Pedido.TabIndex = 28;
            // 
            // Cx_Usuario_Logado
            // 
            this.Cx_Usuario_Logado.AcceptsReturn = true;
            this.Cx_Usuario_Logado.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Cx_Usuario_Logado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Cx_Usuario_Logado.Cursor = System.Windows.Forms.Cursors.Default;
            this.Cx_Usuario_Logado.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cx_Usuario_Logado.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Cx_Usuario_Logado.Location = new System.Drawing.Point(1031, 313);
            this.Cx_Usuario_Logado.Name = "Cx_Usuario_Logado";
            this.Cx_Usuario_Logado.ReadOnly = true;
            this.Cx_Usuario_Logado.Size = new System.Drawing.Size(98, 19);
            this.Cx_Usuario_Logado.TabIndex = 29;
            this.Cx_Usuario_Logado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tblAcidoCloridricoTableAdapter1
            // 
            this.tblAcidoCloridricoTableAdapter1.ClearBeforeFill = true;
            // 
            // tblAcidoSulfuricoTableAdapter1
            // 
            this.tblAcidoSulfuricoTableAdapter1.ClearBeforeFill = true;
            // 
            // tblToluenoTableAdapter1
            // 
            this.tblToluenoTableAdapter1.ClearBeforeFill = true;
            // 
            // tblAcetonaTableAdapter1
            // 
            this.tblAcetonaTableAdapter1.ClearBeforeFill = true;
            // 
            // tblMetiletilcetonaTableAdapter1
            // 
            this.tblMetiletilcetonaTableAdapter1.ClearBeforeFill = true;
            // 
            // btn_Relatorio
            // 
            this.btn_Relatorio.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btn_Relatorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Relatorio.FlatAppearance.BorderSize = 0;
            this.btn_Relatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Relatorio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Relatorio.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_Relatorio.Location = new System.Drawing.Point(756, 282);
            this.btn_Relatorio.Name = "btn_Relatorio";
            this.btn_Relatorio.Size = new System.Drawing.Size(105, 28);
            this.btn_Relatorio.TabIndex = 30;
            this.btn_Relatorio.Text = "Relatorio";
            this.btn_Relatorio.UseVisualStyleBackColor = false;
            this.btn_Relatorio.Click += new System.EventHandler(this.btn_Relatorio_Click_1);
            // 
            // tblHidroxidoPostasioTableAdapter
            // 
            this.tblHidroxidoPostasioTableAdapter.ClearBeforeFill = true;
            // 
            // bDPQServerTSEA
            // 
            this.bDPQServerTSEA.DataSetName = "BDPQServerTSEA";
            this.bDPQServerTSEA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bDPQServerTSEABindingSource
            // 
            this.bDPQServerTSEABindingSource.DataSource = this.bDPQServerTSEA;
            this.bDPQServerTSEABindingSource.Position = 0;
            // 
            // frm_Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1332, 623);
            this.Controls.Add(this.btn_Relatorio);
            this.Controls.Add(this.Cx_Usuario_Logado);
            this.Controls.Add(this.Cx_Data_Pedido);
            this.Controls.Add(this.Cx_Data_Emissao_NF);
            this.Controls.Add(this.Cx_Item);
            this.Controls.Add(this.tab_Produtos);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BotaoSair);
            this.Controls.Add(this.BotaoLimparDados);
            this.Controls.Add(this.BotaoSalvar);
            this.Controls.Add(this.Cx_Produto);
            this.Controls.Add(this.Cx_Quant_Usada);
            this.Controls.Add(this.Cx_Pedido_Compra);
            this.Controls.Add(this.Cx_Quant_Compra);
            this.Controls.Add(this.Cx_Numero_NF);
            this.Controls.Add(this.lblQuantUsada);
            this.Controls.Add(this.lblDataPedido);
            this.Controls.Add(this.lblEmissaoNF);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.lblQuantComprada);
            this.Controls.Add(this.lblPedidoCompra);
            this.Controls.Add(this.lblNumeroNF);
            this.Controls.Add(this.lblProduto);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "frm_Cadastro";
            this.ShowIcon = false;
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.Cadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tab_Produtos.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgAcidoCloridrico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDPQDataSethome)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgAcidoSulfurico)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgHidroxidoPostasio)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgTolueno)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgAcetona)).EndInit();
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgMetiletilcetona)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDPQServerTSEA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDPQServerTSEABindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Label lblNumeroNF;
        private System.Windows.Forms.Label lblPedidoCompra;
        private System.Windows.Forms.Label lblQuantComprada;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Label lblEmissaoNF;
        private System.Windows.Forms.Label lblDataPedido;
        private System.Windows.Forms.Label lblQuantUsada;
        private System.Windows.Forms.TextBox Cx_Numero_NF;
        private System.Windows.Forms.TextBox Cx_Quant_Compra;
        private System.Windows.Forms.TextBox Cx_Pedido_Compra;
        private System.Windows.Forms.TextBox Cx_Quant_Usada;
        private System.Windows.Forms.ComboBox Cx_Produto;
        private System.Windows.Forms.Button BotaoSalvar;
        private System.Windows.Forms.Button BotaoLimparDados;
        private System.Windows.Forms.Button BotaoSair;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TabControl tab_Produtos;
        public System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox Cx_Item;
        private System.Windows.Forms.DateTimePicker Cx_Data_Emissao_NF;
        private System.Windows.Forms.DateTimePicker Cx_Data_Pedido;
        public System.Windows.Forms.TabPage tabPage4;
        public System.Windows.Forms.TabPage tabPage5;
        public System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProdutosQuimicosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn produtoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn desenhoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroNFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataEmissaoNFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroPedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataPedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estoqueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantCompradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantUsadaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioLogadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn33;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProdutosQuimicosDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn produtoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn desenhoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroNFDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataEmissaoNFDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroPedidoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataPedidoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn estoqueDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantCompradaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantUsadaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioLogadoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn34;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn35;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn36;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn37;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn38;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn39;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn40;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn41;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn42;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn43;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn44;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn45;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn46;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn47;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn48;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn49;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn50;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn51;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn52;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn53;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn54;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn55;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn56;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn57;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn58;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn59;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn60;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn61;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn62;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn63;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn64;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn65;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn66;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn67;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn68;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn69;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn70;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn71;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn72;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn73;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn74;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn75;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn76;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn77;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn78;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn79;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn80;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn81;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn82;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn83;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn84;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn85;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn86;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn87;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn88;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn89;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn90;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn91;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn92;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn93;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn94;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn95;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn96;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn97;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn98;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn99;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.DataGridView dataGridView2;
        public System.Windows.Forms.TabPage tabPage3;
        public System.Windows.Forms.DataGridView dataGridView3;
        public System.Windows.Forms.DataGridView dataGridView4;
        public System.Windows.Forms.DataGridView dataGridView5;
        public System.Windows.Forms.DataGridView dataGridView6;
        public System.Windows.Forms.TextBox Cx_Usuario_Logado;
        private System.Windows.Forms.BindingSource tblAcidoCloridricoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn100;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn101;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn102;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn103;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn104;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn105;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn106;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn107;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn108;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn109;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn110;
        private System.Windows.Forms.BindingSource tblAcidoSulfuricoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn111;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn112;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn113;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn114;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn115;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn116;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn117;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn118;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn119;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn120;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn121;
        private System.Windows.Forms.BindingSource tblHidroxidoPostasioBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn122;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn123;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn124;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn125;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn126;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn127;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn128;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn129;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn130;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn131;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn132;
        private System.Windows.Forms.BindingSource tblToluenoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn133;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn134;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn135;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn136;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn137;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn138;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn139;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn140;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn141;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn142;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn143;
        private System.Windows.Forms.BindingSource tblAcetonaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn144;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn145;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn146;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn147;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn148;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn149;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn150;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn151;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn152;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn153;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn154;
        private System.Windows.Forms.BindingSource tblMetiletilcetonaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn155;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn156;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn157;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn158;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn159;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn160;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn161;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn162;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn163;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn164;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn165;
        public BDPQDataSethome bDPQDataSethome;
        public System.Windows.Forms.BindingSource bdgAcidoCloridrico;
        public BDPQDataSethomeTableAdapters.tblAcidoCloridricoTableAdapter tblAcidoCloridricoTableAdapter1;
        public System.Windows.Forms.BindingSource bdgAcidoSulfurico;
        public BDPQDataSethomeTableAdapters.tblAcidoSulfuricoTableAdapter tblAcidoSulfuricoTableAdapter1;
        public System.Windows.Forms.BindingSource bdgTolueno;
        public BDPQDataSethomeTableAdapters.tblToluenoTableAdapter tblToluenoTableAdapter1;
        public System.Windows.Forms.BindingSource bdgAcetona;
        public BDPQDataSethomeTableAdapters.tblAcetonaTableAdapter tblAcetonaTableAdapter1;
        public System.Windows.Forms.BindingSource bdgMetiletilcetona;
        public BDPQDataSethomeTableAdapters.tblMetiletilcetonaTableAdapter tblMetiletilcetonaTableAdapter1;
        public System.Windows.Forms.BindingSource bdgHidroxidoPostasio;
        public BDPQDataSethomeTableAdapters.tblHidroxidoPostasioTableAdapter tblHidroxidoPostasioTableAdapter;
        public System.Windows.Forms.DataGridViewTextBoxColumn Registro_AcidoSulfurico;
        public System.Windows.Forms.DataGridViewTextBoxColumn Produto_AcidoSulfurico;
        public System.Windows.Forms.DataGridViewTextBoxColumn Desenho_AcidoSulfurico;
        public System.Windows.Forms.DataGridViewTextBoxColumn NF_AcidoSulfurico;
        public System.Windows.Forms.DataGridViewTextBoxColumn Data_Emissao_NF_AcidoSulfurico;
        public System.Windows.Forms.DataGridViewTextBoxColumn Numero_Pedido_AcidoSulfurico;
        public System.Windows.Forms.DataGridViewTextBoxColumn Data_Pedido_AcidoSulfurico;
        public System.Windows.Forms.DataGridViewTextBoxColumn Estoque_AcidoSulfurico;
        public System.Windows.Forms.DataGridViewTextBoxColumn Quant_Comprada_AcidoSulfurico;
        public System.Windows.Forms.DataGridViewTextBoxColumn Quant_Usada_AcidoSulfurico;
        public System.Windows.Forms.DataGridViewTextBoxColumn Usuario_AcidoSulfurico;
        public System.Windows.Forms.DataGridViewTextBoxColumn Data_Lancamento_AcidoSulfurico;
        public System.Windows.Forms.DataGridViewTextBoxColumn Registro_Tolueno;
        public System.Windows.Forms.DataGridViewTextBoxColumn Produto_Tolueno;
        public System.Windows.Forms.DataGridViewTextBoxColumn Desenho_Tolueno;
        public System.Windows.Forms.DataGridViewTextBoxColumn Numero_NF_Tolueno;
        public System.Windows.Forms.DataGridViewTextBoxColumn Data_Emissao_NF_Tolueno;
        public System.Windows.Forms.DataGridViewTextBoxColumn Pedido_Compra_Tolueno;
        public System.Windows.Forms.DataGridViewTextBoxColumn Data_Pedido_Tolueno;
        public System.Windows.Forms.DataGridViewTextBoxColumn Estoque_Tolueno;
        public System.Windows.Forms.DataGridViewTextBoxColumn Quant_Comprada_Tolueno;
        public System.Windows.Forms.DataGridViewTextBoxColumn Quant_Usada_Tolueno;
        public System.Windows.Forms.DataGridViewTextBoxColumn Usuario_Tolueno;
        public System.Windows.Forms.DataGridViewTextBoxColumn Data_Lancamento_Tolueno;
        public System.Windows.Forms.DataGridViewTextBoxColumn Registro_Acetona;
        public System.Windows.Forms.DataGridViewTextBoxColumn Produto_Acetona;
        public System.Windows.Forms.DataGridViewTextBoxColumn Desenho_Acetona;
        public System.Windows.Forms.DataGridViewTextBoxColumn Numero_NF_Acetona;
        public System.Windows.Forms.DataGridViewTextBoxColumn Emissao_NF_Acetona;
        public System.Windows.Forms.DataGridViewTextBoxColumn Pedido_Compra_Acetona;
        public System.Windows.Forms.DataGridViewTextBoxColumn Data_Pedido_Acetona;
        public System.Windows.Forms.DataGridViewTextBoxColumn Estoque_Acetona;
        public System.Windows.Forms.DataGridViewTextBoxColumn Quant_Comprada_Acetona;
        public System.Windows.Forms.DataGridViewTextBoxColumn Quant_Usada_Acetona;
        public System.Windows.Forms.DataGridViewTextBoxColumn Usuario_Acetona;
        public System.Windows.Forms.DataGridViewTextBoxColumn Data_Lancamento_Acetona;
        public System.Windows.Forms.DataGridViewTextBoxColumn Registro_Metiletilcetona;
        public System.Windows.Forms.DataGridViewTextBoxColumn Produto_Metiletilcetona;
        public System.Windows.Forms.DataGridViewTextBoxColumn Desenho_Metiletilcetona;
        public System.Windows.Forms.DataGridViewTextBoxColumn Numero_NF_Metiletilcetona;
        public System.Windows.Forms.DataGridViewTextBoxColumn Data_Emissao_NF_Metiletilcetona;
        public System.Windows.Forms.DataGridViewTextBoxColumn Pedido_Compra_Metiletilcetona;
        public System.Windows.Forms.DataGridViewTextBoxColumn Data_Pedido_Metiletilcetona;
        public System.Windows.Forms.DataGridViewTextBoxColumn Estoque_Metiletilcetona;
        public System.Windows.Forms.DataGridViewTextBoxColumn Quant_Comprada_Metiletilcetona;
        public System.Windows.Forms.DataGridViewTextBoxColumn Quant_Usada_Metiletilcetona;
        public System.Windows.Forms.DataGridViewTextBoxColumn Usuario__Metiletilcetona;
        public System.Windows.Forms.DataGridViewTextBoxColumn Data_Lancamento_Metiletilcetona;
        private System.Windows.Forms.Button btn_Relatorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn166;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn167;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn168;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn169;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn170;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn171;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn172;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn173;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn174;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn175;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn176;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataLancamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn177;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn178;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn179;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn180;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn181;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn182;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn183;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn184;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn185;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn186;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn187;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataLancamentoDataGridViewTextBoxColumn1;
        private BDPQServerTSEA bDPQServerTSEA;
        private System.Windows.Forms.BindingSource bDPQServerTSEABindingSource;
    }
}