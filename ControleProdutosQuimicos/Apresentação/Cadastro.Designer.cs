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
            this.TabPage_AcidoCloridrico = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TabPage_AcidoSulfurico = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.TabPage_HidroxidoPotassio = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.TabPage_Tolueno = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.TabPage_Acetona = new System.Windows.Forms.TabPage();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.Data_Lancamento_Acetona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TabPage_Metiletilcetona = new System.Windows.Forms.TabPage();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.Data_Lancamento_Metiletilcetona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cx_Item = new System.Windows.Forms.ComboBox();
            this.Cx_Data_Emissao_NF = new System.Windows.Forms.DateTimePicker();
            this.Cx_Data_Pedido = new System.Windows.Forms.DateTimePicker();
            this.Cx_Usuario_Logado = new System.Windows.Forms.TextBox();
            this.btn_Relatorio = new System.Windows.Forms.Button();
            this.bDPQDataSet = new ControleProdutosQuimicos.BDPQDataSet();
            this.tblAcidoCloridricoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblAcidoCloridricoTableAdapter = new ControleProdutosQuimicos.BDPQDataSetTableAdapters.tblAcidoCloridricoTableAdapter();
            this.idProdutosQuimicosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desenhoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroNFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataEmissaoNFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroPedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataPedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estoqueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantCompradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantUsadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioLogadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblAcidoSulfuricoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblAcidoSulfuricoTableAdapter = new ControleProdutosQuimicos.BDPQDataSetTableAdapters.tblAcidoSulfuricoTableAdapter();
            this.idProdutosQuimicosDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desenhoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroNFDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataEmissaoNFDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroPedidoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataPedidoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estoqueDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantCompradaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantUsadaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioLogadoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblHidroxidoPostasioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblHidroxidoPostasioTableAdapter = new ControleProdutosQuimicos.BDPQDataSetTableAdapters.tblHidroxidoPostasioTableAdapter();
            this.idProdutosQuimicosDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtoDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desenhoDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroNFDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataEmissaoNFDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroPedidoDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataPedidoDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estoqueDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantCompradaDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantUsadaDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioLogadoDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblToluenoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblToluenoTableAdapter = new ControleProdutosQuimicos.BDPQDataSetTableAdapters.tblToluenoTableAdapter();
            this.idProdutosQuimicosDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtoDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desenhoDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroNFDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataEmissaoNFDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroPedidoDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataPedidoDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estoqueDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantCompradaDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantUsadaDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioLogadoDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblToluenoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idProdutosQuimicosDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtoDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desenhoDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroNFDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataEmissaoNFDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroPedidoDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataPedidoDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estoqueDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantCompradaDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantUsadaDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioLogadoDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblMetiletilcetonaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblMetiletilcetonaTableAdapter = new ControleProdutosQuimicos.BDPQDataSetTableAdapters.tblMetiletilcetonaTableAdapter();
            this.idProdutosQuimicosDataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produtoDataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desenhoDataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroNFDataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataEmissaoNFDataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroPedidoDataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataPedidoDataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estoqueDataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantCompradaDataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantUsadaDataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioLogadoDataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblAcetonaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblAcetonaTableAdapter = new ControleProdutosQuimicos.BDPQDataSetTableAdapters.tblAcetonaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tab_Produtos.SuspendLayout();
            this.TabPage_AcidoCloridrico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.TabPage_AcidoSulfurico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.TabPage_HidroxidoPotassio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.TabPage_Tolueno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.TabPage_Acetona.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.TabPage_Metiletilcetona.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDPQDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAcidoCloridricoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAcidoSulfuricoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHidroxidoPostasioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblToluenoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblToluenoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMetiletilcetonaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAcetonaBindingSource)).BeginInit();
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
            this.tab_Produtos.Controls.Add(this.TabPage_AcidoCloridrico);
            this.tab_Produtos.Controls.Add(this.TabPage_AcidoSulfurico);
            this.tab_Produtos.Controls.Add(this.TabPage_HidroxidoPotassio);
            this.tab_Produtos.Controls.Add(this.TabPage_Tolueno);
            this.tab_Produtos.Controls.Add(this.TabPage_Acetona);
            this.tab_Produtos.Controls.Add(this.TabPage_Metiletilcetona);
            this.tab_Produtos.HotTrack = true;
            this.tab_Produtos.Location = new System.Drawing.Point(12, 327);
            this.tab_Produtos.Name = "tab_Produtos";
            this.tab_Produtos.SelectedIndex = 0;
            this.tab_Produtos.Size = new System.Drawing.Size(1117, 276);
            this.tab_Produtos.TabIndex = 26;
            // 
            // TabPage_AcidoCloridrico
            // 
            this.TabPage_AcidoCloridrico.Controls.Add(this.dataGridView1);
            this.TabPage_AcidoCloridrico.Location = new System.Drawing.Point(4, 22);
            this.TabPage_AcidoCloridrico.Name = "TabPage_AcidoCloridrico";
            this.TabPage_AcidoCloridrico.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_AcidoCloridrico.Size = new System.Drawing.Size(1109, 250);
            this.TabPage_AcidoCloridrico.TabIndex = 0;
            this.TabPage_AcidoCloridrico.Text = "Ácido Cloridrico";
            this.TabPage_AcidoCloridrico.UseVisualStyleBackColor = true;
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
            this.idProdutosQuimicosDataGridViewTextBoxColumn,
            this.produtoDataGridViewTextBoxColumn,
            this.desenhoDataGridViewTextBoxColumn,
            this.numeroNFDataGridViewTextBoxColumn,
            this.dataEmissaoNFDataGridViewTextBoxColumn,
            this.numeroPedidoDataGridViewTextBoxColumn,
            this.dataPedidoDataGridViewTextBoxColumn,
            this.estoqueDataGridViewTextBoxColumn,
            this.quantCompradaDataGridViewTextBoxColumn,
            this.quantUsadaDataGridViewTextBoxColumn,
            this.usuarioLogadoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblAcidoCloridricoBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1103, 244);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Tag = "";
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // TabPage_AcidoSulfurico
            // 
            this.TabPage_AcidoSulfurico.Controls.Add(this.dataGridView2);
            this.TabPage_AcidoSulfurico.Location = new System.Drawing.Point(4, 22);
            this.TabPage_AcidoSulfurico.Name = "TabPage_AcidoSulfurico";
            this.TabPage_AcidoSulfurico.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_AcidoSulfurico.Size = new System.Drawing.Size(1109, 250);
            this.TabPage_AcidoSulfurico.TabIndex = 1;
            this.TabPage_AcidoSulfurico.Text = "Ácido Sulfurico";
            this.TabPage_AcidoSulfurico.UseVisualStyleBackColor = true;
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
            this.idProdutosQuimicosDataGridViewTextBoxColumn1,
            this.produtoDataGridViewTextBoxColumn1,
            this.desenhoDataGridViewTextBoxColumn1,
            this.numeroNFDataGridViewTextBoxColumn1,
            this.dataEmissaoNFDataGridViewTextBoxColumn1,
            this.numeroPedidoDataGridViewTextBoxColumn1,
            this.dataPedidoDataGridViewTextBoxColumn1,
            this.estoqueDataGridViewTextBoxColumn1,
            this.quantCompradaDataGridViewTextBoxColumn1,
            this.quantUsadaDataGridViewTextBoxColumn1,
            this.usuarioLogadoDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.tblAcidoSulfuricoBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1103, 244);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView2_UserDeletingRow);
            // 
            // TabPage_HidroxidoPotassio
            // 
            this.TabPage_HidroxidoPotassio.Controls.Add(this.dataGridView3);
            this.TabPage_HidroxidoPotassio.Location = new System.Drawing.Point(4, 22);
            this.TabPage_HidroxidoPotassio.Name = "TabPage_HidroxidoPotassio";
            this.TabPage_HidroxidoPotassio.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_HidroxidoPotassio.Size = new System.Drawing.Size(1109, 250);
            this.TabPage_HidroxidoPotassio.TabIndex = 2;
            this.TabPage_HidroxidoPotassio.Text = "Hidróxido De Potássio";
            this.TabPage_HidroxidoPotassio.UseVisualStyleBackColor = true;
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
            this.idProdutosQuimicosDataGridViewTextBoxColumn2,
            this.produtoDataGridViewTextBoxColumn2,
            this.desenhoDataGridViewTextBoxColumn2,
            this.numeroNFDataGridViewTextBoxColumn2,
            this.dataEmissaoNFDataGridViewTextBoxColumn2,
            this.numeroPedidoDataGridViewTextBoxColumn2,
            this.dataPedidoDataGridViewTextBoxColumn2,
            this.estoqueDataGridViewTextBoxColumn2,
            this.quantCompradaDataGridViewTextBoxColumn2,
            this.quantUsadaDataGridViewTextBoxColumn2,
            this.usuarioLogadoDataGridViewTextBoxColumn2});
            this.dataGridView3.DataSource = this.tblHidroxidoPostasioBindingSource;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(3, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(1103, 244);
            this.dataGridView3.TabIndex = 2;
            this.dataGridView3.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView3_UserDeletingRow);
            // 
            // TabPage_Tolueno
            // 
            this.TabPage_Tolueno.Controls.Add(this.dataGridView4);
            this.TabPage_Tolueno.Location = new System.Drawing.Point(4, 22);
            this.TabPage_Tolueno.Name = "TabPage_Tolueno";
            this.TabPage_Tolueno.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_Tolueno.Size = new System.Drawing.Size(1109, 250);
            this.TabPage_Tolueno.TabIndex = 3;
            this.TabPage_Tolueno.Text = "Tolueno";
            this.TabPage_Tolueno.UseVisualStyleBackColor = true;
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
            this.idProdutosQuimicosDataGridViewTextBoxColumn3,
            this.produtoDataGridViewTextBoxColumn3,
            this.desenhoDataGridViewTextBoxColumn3,
            this.numeroNFDataGridViewTextBoxColumn3,
            this.dataEmissaoNFDataGridViewTextBoxColumn3,
            this.numeroPedidoDataGridViewTextBoxColumn3,
            this.dataPedidoDataGridViewTextBoxColumn3,
            this.estoqueDataGridViewTextBoxColumn3,
            this.quantCompradaDataGridViewTextBoxColumn3,
            this.quantUsadaDataGridViewTextBoxColumn3,
            this.usuarioLogadoDataGridViewTextBoxColumn3});
            this.dataGridView4.DataSource = this.tblToluenoBindingSource;
            this.dataGridView4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView4.Location = new System.Drawing.Point(3, 3);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView4.Size = new System.Drawing.Size(1103, 244);
            this.dataGridView4.TabIndex = 2;
            this.dataGridView4.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView4_UserDeletingRow);
            // 
            // TabPage_Acetona
            // 
            this.TabPage_Acetona.Controls.Add(this.dataGridView5);
            this.TabPage_Acetona.Location = new System.Drawing.Point(4, 22);
            this.TabPage_Acetona.Name = "TabPage_Acetona";
            this.TabPage_Acetona.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_Acetona.Size = new System.Drawing.Size(1109, 250);
            this.TabPage_Acetona.TabIndex = 4;
            this.TabPage_Acetona.Text = "Acetona";
            this.TabPage_Acetona.UseVisualStyleBackColor = true;
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
            this.Data_Lancamento_Acetona,
            this.idProdutosQuimicosDataGridViewTextBoxColumn4,
            this.produtoDataGridViewTextBoxColumn4,
            this.desenhoDataGridViewTextBoxColumn4,
            this.numeroNFDataGridViewTextBoxColumn4,
            this.dataEmissaoNFDataGridViewTextBoxColumn4,
            this.numeroPedidoDataGridViewTextBoxColumn4,
            this.dataPedidoDataGridViewTextBoxColumn4,
            this.estoqueDataGridViewTextBoxColumn4,
            this.quantCompradaDataGridViewTextBoxColumn4,
            this.quantUsadaDataGridViewTextBoxColumn4,
            this.usuarioLogadoDataGridViewTextBoxColumn4});
            this.dataGridView5.DataSource = this.tblAcetonaBindingSource;
            this.dataGridView5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView5.Location = new System.Drawing.Point(3, 3);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.ReadOnly = true;
            this.dataGridView5.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView5.Size = new System.Drawing.Size(1103, 244);
            this.dataGridView5.TabIndex = 3;
            this.dataGridView5.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView5_UserDeletingRow);
            // 
            // Data_Lancamento_Acetona
            // 
            this.Data_Lancamento_Acetona.DataPropertyName = "Data_Lancamento";
            this.Data_Lancamento_Acetona.HeaderText = "Data Lançamento";
            this.Data_Lancamento_Acetona.Name = "Data_Lancamento_Acetona";
            this.Data_Lancamento_Acetona.ReadOnly = true;
            this.Data_Lancamento_Acetona.Width = 117;
            // 
            // TabPage_Metiletilcetona
            // 
            this.TabPage_Metiletilcetona.Controls.Add(this.dataGridView6);
            this.TabPage_Metiletilcetona.Location = new System.Drawing.Point(4, 22);
            this.TabPage_Metiletilcetona.Name = "TabPage_Metiletilcetona";
            this.TabPage_Metiletilcetona.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage_Metiletilcetona.Size = new System.Drawing.Size(1109, 250);
            this.TabPage_Metiletilcetona.TabIndex = 5;
            this.TabPage_Metiletilcetona.Text = "Metiletilcetona";
            this.TabPage_Metiletilcetona.UseVisualStyleBackColor = true;
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
            this.Data_Lancamento_Metiletilcetona,
            this.idProdutosQuimicosDataGridViewTextBoxColumn5,
            this.produtoDataGridViewTextBoxColumn5,
            this.desenhoDataGridViewTextBoxColumn5,
            this.numeroNFDataGridViewTextBoxColumn5,
            this.dataEmissaoNFDataGridViewTextBoxColumn5,
            this.numeroPedidoDataGridViewTextBoxColumn5,
            this.dataPedidoDataGridViewTextBoxColumn5,
            this.estoqueDataGridViewTextBoxColumn5,
            this.quantCompradaDataGridViewTextBoxColumn5,
            this.quantUsadaDataGridViewTextBoxColumn5,
            this.usuarioLogadoDataGridViewTextBoxColumn5});
            this.dataGridView6.DataSource = this.tblMetiletilcetonaBindingSource;
            this.dataGridView6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView6.Location = new System.Drawing.Point(3, 3);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.ReadOnly = true;
            this.dataGridView6.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView6.Size = new System.Drawing.Size(1103, 244);
            this.dataGridView6.TabIndex = 4;
            this.dataGridView6.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView6_UserDeletingRow);
            // 
            // Data_Lancamento_Metiletilcetona
            // 
            this.Data_Lancamento_Metiletilcetona.DataPropertyName = "Data_Lancamento";
            this.Data_Lancamento_Metiletilcetona.HeaderText = "Data Lançamento";
            this.Data_Lancamento_Metiletilcetona.Name = "Data_Lancamento_Metiletilcetona";
            this.Data_Lancamento_Metiletilcetona.ReadOnly = true;
            this.Data_Lancamento_Metiletilcetona.Width = 117;
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
            // bDPQDataSet
            // 
            this.bDPQDataSet.DataSetName = "BDPQDataSet";
            this.bDPQDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblAcidoCloridricoBindingSource
            // 
            this.tblAcidoCloridricoBindingSource.DataMember = "tblAcidoCloridrico";
            this.tblAcidoCloridricoBindingSource.DataSource = this.bDPQDataSet;
            // 
            // tblAcidoCloridricoTableAdapter
            // 
            this.tblAcidoCloridricoTableAdapter.ClearBeforeFill = true;
            // 
            // idProdutosQuimicosDataGridViewTextBoxColumn
            // 
            this.idProdutosQuimicosDataGridViewTextBoxColumn.DataPropertyName = "IdProdutosQuimicos";
            this.idProdutosQuimicosDataGridViewTextBoxColumn.HeaderText = "IdProdutosQuimicos";
            this.idProdutosQuimicosDataGridViewTextBoxColumn.Name = "idProdutosQuimicosDataGridViewTextBoxColumn";
            this.idProdutosQuimicosDataGridViewTextBoxColumn.ReadOnly = true;
            this.idProdutosQuimicosDataGridViewTextBoxColumn.Width = 126;
            // 
            // produtoDataGridViewTextBoxColumn
            // 
            this.produtoDataGridViewTextBoxColumn.DataPropertyName = "Produto";
            this.produtoDataGridViewTextBoxColumn.HeaderText = "Produto";
            this.produtoDataGridViewTextBoxColumn.Name = "produtoDataGridViewTextBoxColumn";
            this.produtoDataGridViewTextBoxColumn.Width = 69;
            // 
            // desenhoDataGridViewTextBoxColumn
            // 
            this.desenhoDataGridViewTextBoxColumn.DataPropertyName = "Desenho";
            this.desenhoDataGridViewTextBoxColumn.HeaderText = "Desenho";
            this.desenhoDataGridViewTextBoxColumn.Name = "desenhoDataGridViewTextBoxColumn";
            this.desenhoDataGridViewTextBoxColumn.Width = 75;
            // 
            // numeroNFDataGridViewTextBoxColumn
            // 
            this.numeroNFDataGridViewTextBoxColumn.DataPropertyName = "Numero_NF";
            this.numeroNFDataGridViewTextBoxColumn.HeaderText = "Numero_NF";
            this.numeroNFDataGridViewTextBoxColumn.Name = "numeroNFDataGridViewTextBoxColumn";
            this.numeroNFDataGridViewTextBoxColumn.Width = 89;
            // 
            // dataEmissaoNFDataGridViewTextBoxColumn
            // 
            this.dataEmissaoNFDataGridViewTextBoxColumn.DataPropertyName = "Data_Emissao_NF";
            this.dataEmissaoNFDataGridViewTextBoxColumn.HeaderText = "Data_Emissao_NF";
            this.dataEmissaoNFDataGridViewTextBoxColumn.Name = "dataEmissaoNFDataGridViewTextBoxColumn";
            this.dataEmissaoNFDataGridViewTextBoxColumn.Width = 120;
            // 
            // numeroPedidoDataGridViewTextBoxColumn
            // 
            this.numeroPedidoDataGridViewTextBoxColumn.DataPropertyName = "Numero_Pedido";
            this.numeroPedidoDataGridViewTextBoxColumn.HeaderText = "Numero_Pedido";
            this.numeroPedidoDataGridViewTextBoxColumn.Name = "numeroPedidoDataGridViewTextBoxColumn";
            this.numeroPedidoDataGridViewTextBoxColumn.Width = 108;
            // 
            // dataPedidoDataGridViewTextBoxColumn
            // 
            this.dataPedidoDataGridViewTextBoxColumn.DataPropertyName = "Data_Pedido";
            this.dataPedidoDataGridViewTextBoxColumn.HeaderText = "Data_Pedido";
            this.dataPedidoDataGridViewTextBoxColumn.Name = "dataPedidoDataGridViewTextBoxColumn";
            this.dataPedidoDataGridViewTextBoxColumn.Width = 94;
            // 
            // estoqueDataGridViewTextBoxColumn
            // 
            this.estoqueDataGridViewTextBoxColumn.DataPropertyName = "Estoque";
            this.estoqueDataGridViewTextBoxColumn.HeaderText = "Estoque";
            this.estoqueDataGridViewTextBoxColumn.Name = "estoqueDataGridViewTextBoxColumn";
            this.estoqueDataGridViewTextBoxColumn.Width = 71;
            // 
            // quantCompradaDataGridViewTextBoxColumn
            // 
            this.quantCompradaDataGridViewTextBoxColumn.DataPropertyName = "Quant_Comprada";
            this.quantCompradaDataGridViewTextBoxColumn.HeaderText = "Quant_Comprada";
            this.quantCompradaDataGridViewTextBoxColumn.Name = "quantCompradaDataGridViewTextBoxColumn";
            this.quantCompradaDataGridViewTextBoxColumn.Width = 115;
            // 
            // quantUsadaDataGridViewTextBoxColumn
            // 
            this.quantUsadaDataGridViewTextBoxColumn.DataPropertyName = "Quant_Usada";
            this.quantUsadaDataGridViewTextBoxColumn.HeaderText = "Quant_Usada";
            this.quantUsadaDataGridViewTextBoxColumn.Name = "quantUsadaDataGridViewTextBoxColumn";
            this.quantUsadaDataGridViewTextBoxColumn.Width = 98;
            // 
            // usuarioLogadoDataGridViewTextBoxColumn
            // 
            this.usuarioLogadoDataGridViewTextBoxColumn.DataPropertyName = "Usuario_Logado";
            this.usuarioLogadoDataGridViewTextBoxColumn.HeaderText = "Usuario_Logado";
            this.usuarioLogadoDataGridViewTextBoxColumn.Name = "usuarioLogadoDataGridViewTextBoxColumn";
            this.usuarioLogadoDataGridViewTextBoxColumn.Width = 110;
            // 
            // tblAcidoSulfuricoBindingSource
            // 
            this.tblAcidoSulfuricoBindingSource.DataMember = "tblAcidoSulfurico";
            this.tblAcidoSulfuricoBindingSource.DataSource = this.bDPQDataSet;
            // 
            // tblAcidoSulfuricoTableAdapter
            // 
            this.tblAcidoSulfuricoTableAdapter.ClearBeforeFill = true;
            // 
            // idProdutosQuimicosDataGridViewTextBoxColumn1
            // 
            this.idProdutosQuimicosDataGridViewTextBoxColumn1.DataPropertyName = "IdProdutosQuimicos";
            this.idProdutosQuimicosDataGridViewTextBoxColumn1.HeaderText = "IdProdutosQuimicos";
            this.idProdutosQuimicosDataGridViewTextBoxColumn1.Name = "idProdutosQuimicosDataGridViewTextBoxColumn1";
            this.idProdutosQuimicosDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idProdutosQuimicosDataGridViewTextBoxColumn1.Width = 126;
            // 
            // produtoDataGridViewTextBoxColumn1
            // 
            this.produtoDataGridViewTextBoxColumn1.DataPropertyName = "Produto";
            this.produtoDataGridViewTextBoxColumn1.HeaderText = "Produto";
            this.produtoDataGridViewTextBoxColumn1.Name = "produtoDataGridViewTextBoxColumn1";
            this.produtoDataGridViewTextBoxColumn1.ReadOnly = true;
            this.produtoDataGridViewTextBoxColumn1.Width = 69;
            // 
            // desenhoDataGridViewTextBoxColumn1
            // 
            this.desenhoDataGridViewTextBoxColumn1.DataPropertyName = "Desenho";
            this.desenhoDataGridViewTextBoxColumn1.HeaderText = "Desenho";
            this.desenhoDataGridViewTextBoxColumn1.Name = "desenhoDataGridViewTextBoxColumn1";
            this.desenhoDataGridViewTextBoxColumn1.ReadOnly = true;
            this.desenhoDataGridViewTextBoxColumn1.Width = 75;
            // 
            // numeroNFDataGridViewTextBoxColumn1
            // 
            this.numeroNFDataGridViewTextBoxColumn1.DataPropertyName = "Numero_NF";
            this.numeroNFDataGridViewTextBoxColumn1.HeaderText = "Numero_NF";
            this.numeroNFDataGridViewTextBoxColumn1.Name = "numeroNFDataGridViewTextBoxColumn1";
            this.numeroNFDataGridViewTextBoxColumn1.ReadOnly = true;
            this.numeroNFDataGridViewTextBoxColumn1.Width = 89;
            // 
            // dataEmissaoNFDataGridViewTextBoxColumn1
            // 
            this.dataEmissaoNFDataGridViewTextBoxColumn1.DataPropertyName = "Data_Emissao_NF";
            this.dataEmissaoNFDataGridViewTextBoxColumn1.HeaderText = "Data_Emissao_NF";
            this.dataEmissaoNFDataGridViewTextBoxColumn1.Name = "dataEmissaoNFDataGridViewTextBoxColumn1";
            this.dataEmissaoNFDataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataEmissaoNFDataGridViewTextBoxColumn1.Width = 120;
            // 
            // numeroPedidoDataGridViewTextBoxColumn1
            // 
            this.numeroPedidoDataGridViewTextBoxColumn1.DataPropertyName = "Numero_Pedido";
            this.numeroPedidoDataGridViewTextBoxColumn1.HeaderText = "Numero_Pedido";
            this.numeroPedidoDataGridViewTextBoxColumn1.Name = "numeroPedidoDataGridViewTextBoxColumn1";
            this.numeroPedidoDataGridViewTextBoxColumn1.ReadOnly = true;
            this.numeroPedidoDataGridViewTextBoxColumn1.Width = 108;
            // 
            // dataPedidoDataGridViewTextBoxColumn1
            // 
            this.dataPedidoDataGridViewTextBoxColumn1.DataPropertyName = "Data_Pedido";
            this.dataPedidoDataGridViewTextBoxColumn1.HeaderText = "Data_Pedido";
            this.dataPedidoDataGridViewTextBoxColumn1.Name = "dataPedidoDataGridViewTextBoxColumn1";
            this.dataPedidoDataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataPedidoDataGridViewTextBoxColumn1.Width = 94;
            // 
            // estoqueDataGridViewTextBoxColumn1
            // 
            this.estoqueDataGridViewTextBoxColumn1.DataPropertyName = "Estoque";
            this.estoqueDataGridViewTextBoxColumn1.HeaderText = "Estoque";
            this.estoqueDataGridViewTextBoxColumn1.Name = "estoqueDataGridViewTextBoxColumn1";
            this.estoqueDataGridViewTextBoxColumn1.ReadOnly = true;
            this.estoqueDataGridViewTextBoxColumn1.Width = 71;
            // 
            // quantCompradaDataGridViewTextBoxColumn1
            // 
            this.quantCompradaDataGridViewTextBoxColumn1.DataPropertyName = "Quant_Comprada";
            this.quantCompradaDataGridViewTextBoxColumn1.HeaderText = "Quant_Comprada";
            this.quantCompradaDataGridViewTextBoxColumn1.Name = "quantCompradaDataGridViewTextBoxColumn1";
            this.quantCompradaDataGridViewTextBoxColumn1.ReadOnly = true;
            this.quantCompradaDataGridViewTextBoxColumn1.Width = 115;
            // 
            // quantUsadaDataGridViewTextBoxColumn1
            // 
            this.quantUsadaDataGridViewTextBoxColumn1.DataPropertyName = "Quant_Usada";
            this.quantUsadaDataGridViewTextBoxColumn1.HeaderText = "Quant_Usada";
            this.quantUsadaDataGridViewTextBoxColumn1.Name = "quantUsadaDataGridViewTextBoxColumn1";
            this.quantUsadaDataGridViewTextBoxColumn1.ReadOnly = true;
            this.quantUsadaDataGridViewTextBoxColumn1.Width = 98;
            // 
            // usuarioLogadoDataGridViewTextBoxColumn1
            // 
            this.usuarioLogadoDataGridViewTextBoxColumn1.DataPropertyName = "Usuario_Logado";
            this.usuarioLogadoDataGridViewTextBoxColumn1.HeaderText = "Usuario_Logado";
            this.usuarioLogadoDataGridViewTextBoxColumn1.Name = "usuarioLogadoDataGridViewTextBoxColumn1";
            this.usuarioLogadoDataGridViewTextBoxColumn1.ReadOnly = true;
            this.usuarioLogadoDataGridViewTextBoxColumn1.Width = 110;
            // 
            // tblHidroxidoPostasioBindingSource
            // 
            this.tblHidroxidoPostasioBindingSource.DataMember = "tblHidroxidoPostasio";
            this.tblHidroxidoPostasioBindingSource.DataSource = this.bDPQDataSet;
            // 
            // tblHidroxidoPostasioTableAdapter
            // 
            this.tblHidroxidoPostasioTableAdapter.ClearBeforeFill = true;
            // 
            // idProdutosQuimicosDataGridViewTextBoxColumn2
            // 
            this.idProdutosQuimicosDataGridViewTextBoxColumn2.DataPropertyName = "IdProdutosQuimicos";
            this.idProdutosQuimicosDataGridViewTextBoxColumn2.HeaderText = "IdProdutosQuimicos";
            this.idProdutosQuimicosDataGridViewTextBoxColumn2.Name = "idProdutosQuimicosDataGridViewTextBoxColumn2";
            this.idProdutosQuimicosDataGridViewTextBoxColumn2.ReadOnly = true;
            this.idProdutosQuimicosDataGridViewTextBoxColumn2.Width = 126;
            // 
            // produtoDataGridViewTextBoxColumn2
            // 
            this.produtoDataGridViewTextBoxColumn2.DataPropertyName = "Produto";
            this.produtoDataGridViewTextBoxColumn2.HeaderText = "Produto";
            this.produtoDataGridViewTextBoxColumn2.Name = "produtoDataGridViewTextBoxColumn2";
            this.produtoDataGridViewTextBoxColumn2.ReadOnly = true;
            this.produtoDataGridViewTextBoxColumn2.Width = 69;
            // 
            // desenhoDataGridViewTextBoxColumn2
            // 
            this.desenhoDataGridViewTextBoxColumn2.DataPropertyName = "Desenho";
            this.desenhoDataGridViewTextBoxColumn2.HeaderText = "Desenho";
            this.desenhoDataGridViewTextBoxColumn2.Name = "desenhoDataGridViewTextBoxColumn2";
            this.desenhoDataGridViewTextBoxColumn2.ReadOnly = true;
            this.desenhoDataGridViewTextBoxColumn2.Width = 75;
            // 
            // numeroNFDataGridViewTextBoxColumn2
            // 
            this.numeroNFDataGridViewTextBoxColumn2.DataPropertyName = "Numero_NF";
            this.numeroNFDataGridViewTextBoxColumn2.HeaderText = "Numero_NF";
            this.numeroNFDataGridViewTextBoxColumn2.Name = "numeroNFDataGridViewTextBoxColumn2";
            this.numeroNFDataGridViewTextBoxColumn2.ReadOnly = true;
            this.numeroNFDataGridViewTextBoxColumn2.Width = 89;
            // 
            // dataEmissaoNFDataGridViewTextBoxColumn2
            // 
            this.dataEmissaoNFDataGridViewTextBoxColumn2.DataPropertyName = "Data_Emissao_NF";
            this.dataEmissaoNFDataGridViewTextBoxColumn2.HeaderText = "Data_Emissao_NF";
            this.dataEmissaoNFDataGridViewTextBoxColumn2.Name = "dataEmissaoNFDataGridViewTextBoxColumn2";
            this.dataEmissaoNFDataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataEmissaoNFDataGridViewTextBoxColumn2.Width = 120;
            // 
            // numeroPedidoDataGridViewTextBoxColumn2
            // 
            this.numeroPedidoDataGridViewTextBoxColumn2.DataPropertyName = "Numero_Pedido";
            this.numeroPedidoDataGridViewTextBoxColumn2.HeaderText = "Numero_Pedido";
            this.numeroPedidoDataGridViewTextBoxColumn2.Name = "numeroPedidoDataGridViewTextBoxColumn2";
            this.numeroPedidoDataGridViewTextBoxColumn2.ReadOnly = true;
            this.numeroPedidoDataGridViewTextBoxColumn2.Width = 108;
            // 
            // dataPedidoDataGridViewTextBoxColumn2
            // 
            this.dataPedidoDataGridViewTextBoxColumn2.DataPropertyName = "Data_Pedido";
            this.dataPedidoDataGridViewTextBoxColumn2.HeaderText = "Data_Pedido";
            this.dataPedidoDataGridViewTextBoxColumn2.Name = "dataPedidoDataGridViewTextBoxColumn2";
            this.dataPedidoDataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataPedidoDataGridViewTextBoxColumn2.Width = 94;
            // 
            // estoqueDataGridViewTextBoxColumn2
            // 
            this.estoqueDataGridViewTextBoxColumn2.DataPropertyName = "Estoque";
            this.estoqueDataGridViewTextBoxColumn2.HeaderText = "Estoque";
            this.estoqueDataGridViewTextBoxColumn2.Name = "estoqueDataGridViewTextBoxColumn2";
            this.estoqueDataGridViewTextBoxColumn2.ReadOnly = true;
            this.estoqueDataGridViewTextBoxColumn2.Width = 71;
            // 
            // quantCompradaDataGridViewTextBoxColumn2
            // 
            this.quantCompradaDataGridViewTextBoxColumn2.DataPropertyName = "Quant_Comprada";
            this.quantCompradaDataGridViewTextBoxColumn2.HeaderText = "Quant_Comprada";
            this.quantCompradaDataGridViewTextBoxColumn2.Name = "quantCompradaDataGridViewTextBoxColumn2";
            this.quantCompradaDataGridViewTextBoxColumn2.ReadOnly = true;
            this.quantCompradaDataGridViewTextBoxColumn2.Width = 115;
            // 
            // quantUsadaDataGridViewTextBoxColumn2
            // 
            this.quantUsadaDataGridViewTextBoxColumn2.DataPropertyName = "Quant_Usada";
            this.quantUsadaDataGridViewTextBoxColumn2.HeaderText = "Quant_Usada";
            this.quantUsadaDataGridViewTextBoxColumn2.Name = "quantUsadaDataGridViewTextBoxColumn2";
            this.quantUsadaDataGridViewTextBoxColumn2.ReadOnly = true;
            this.quantUsadaDataGridViewTextBoxColumn2.Width = 98;
            // 
            // usuarioLogadoDataGridViewTextBoxColumn2
            // 
            this.usuarioLogadoDataGridViewTextBoxColumn2.DataPropertyName = "Usuario_Logado";
            this.usuarioLogadoDataGridViewTextBoxColumn2.HeaderText = "Usuario_Logado";
            this.usuarioLogadoDataGridViewTextBoxColumn2.Name = "usuarioLogadoDataGridViewTextBoxColumn2";
            this.usuarioLogadoDataGridViewTextBoxColumn2.ReadOnly = true;
            this.usuarioLogadoDataGridViewTextBoxColumn2.Width = 110;
            // 
            // tblToluenoBindingSource
            // 
            this.tblToluenoBindingSource.DataMember = "tblTolueno";
            this.tblToluenoBindingSource.DataSource = this.bDPQDataSet;
            // 
            // tblToluenoTableAdapter
            // 
            this.tblToluenoTableAdapter.ClearBeforeFill = true;
            // 
            // idProdutosQuimicosDataGridViewTextBoxColumn3
            // 
            this.idProdutosQuimicosDataGridViewTextBoxColumn3.DataPropertyName = "IdProdutosQuimicos";
            this.idProdutosQuimicosDataGridViewTextBoxColumn3.HeaderText = "IdProdutosQuimicos";
            this.idProdutosQuimicosDataGridViewTextBoxColumn3.Name = "idProdutosQuimicosDataGridViewTextBoxColumn3";
            this.idProdutosQuimicosDataGridViewTextBoxColumn3.ReadOnly = true;
            this.idProdutosQuimicosDataGridViewTextBoxColumn3.Width = 126;
            // 
            // produtoDataGridViewTextBoxColumn3
            // 
            this.produtoDataGridViewTextBoxColumn3.DataPropertyName = "Produto";
            this.produtoDataGridViewTextBoxColumn3.HeaderText = "Produto";
            this.produtoDataGridViewTextBoxColumn3.Name = "produtoDataGridViewTextBoxColumn3";
            this.produtoDataGridViewTextBoxColumn3.ReadOnly = true;
            this.produtoDataGridViewTextBoxColumn3.Width = 69;
            // 
            // desenhoDataGridViewTextBoxColumn3
            // 
            this.desenhoDataGridViewTextBoxColumn3.DataPropertyName = "Desenho";
            this.desenhoDataGridViewTextBoxColumn3.HeaderText = "Desenho";
            this.desenhoDataGridViewTextBoxColumn3.Name = "desenhoDataGridViewTextBoxColumn3";
            this.desenhoDataGridViewTextBoxColumn3.ReadOnly = true;
            this.desenhoDataGridViewTextBoxColumn3.Width = 75;
            // 
            // numeroNFDataGridViewTextBoxColumn3
            // 
            this.numeroNFDataGridViewTextBoxColumn3.DataPropertyName = "Numero_NF";
            this.numeroNFDataGridViewTextBoxColumn3.HeaderText = "Numero_NF";
            this.numeroNFDataGridViewTextBoxColumn3.Name = "numeroNFDataGridViewTextBoxColumn3";
            this.numeroNFDataGridViewTextBoxColumn3.ReadOnly = true;
            this.numeroNFDataGridViewTextBoxColumn3.Width = 89;
            // 
            // dataEmissaoNFDataGridViewTextBoxColumn3
            // 
            this.dataEmissaoNFDataGridViewTextBoxColumn3.DataPropertyName = "Data_Emissao_NF";
            this.dataEmissaoNFDataGridViewTextBoxColumn3.HeaderText = "Data_Emissao_NF";
            this.dataEmissaoNFDataGridViewTextBoxColumn3.Name = "dataEmissaoNFDataGridViewTextBoxColumn3";
            this.dataEmissaoNFDataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataEmissaoNFDataGridViewTextBoxColumn3.Width = 120;
            // 
            // numeroPedidoDataGridViewTextBoxColumn3
            // 
            this.numeroPedidoDataGridViewTextBoxColumn3.DataPropertyName = "Numero_Pedido";
            this.numeroPedidoDataGridViewTextBoxColumn3.HeaderText = "Numero_Pedido";
            this.numeroPedidoDataGridViewTextBoxColumn3.Name = "numeroPedidoDataGridViewTextBoxColumn3";
            this.numeroPedidoDataGridViewTextBoxColumn3.ReadOnly = true;
            this.numeroPedidoDataGridViewTextBoxColumn3.Width = 108;
            // 
            // dataPedidoDataGridViewTextBoxColumn3
            // 
            this.dataPedidoDataGridViewTextBoxColumn3.DataPropertyName = "Data_Pedido";
            this.dataPedidoDataGridViewTextBoxColumn3.HeaderText = "Data_Pedido";
            this.dataPedidoDataGridViewTextBoxColumn3.Name = "dataPedidoDataGridViewTextBoxColumn3";
            this.dataPedidoDataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataPedidoDataGridViewTextBoxColumn3.Width = 94;
            // 
            // estoqueDataGridViewTextBoxColumn3
            // 
            this.estoqueDataGridViewTextBoxColumn3.DataPropertyName = "Estoque";
            this.estoqueDataGridViewTextBoxColumn3.HeaderText = "Estoque";
            this.estoqueDataGridViewTextBoxColumn3.Name = "estoqueDataGridViewTextBoxColumn3";
            this.estoqueDataGridViewTextBoxColumn3.ReadOnly = true;
            this.estoqueDataGridViewTextBoxColumn3.Width = 71;
            // 
            // quantCompradaDataGridViewTextBoxColumn3
            // 
            this.quantCompradaDataGridViewTextBoxColumn3.DataPropertyName = "Quant_Comprada";
            this.quantCompradaDataGridViewTextBoxColumn3.HeaderText = "Quant_Comprada";
            this.quantCompradaDataGridViewTextBoxColumn3.Name = "quantCompradaDataGridViewTextBoxColumn3";
            this.quantCompradaDataGridViewTextBoxColumn3.ReadOnly = true;
            this.quantCompradaDataGridViewTextBoxColumn3.Width = 115;
            // 
            // quantUsadaDataGridViewTextBoxColumn3
            // 
            this.quantUsadaDataGridViewTextBoxColumn3.DataPropertyName = "Quant_Usada";
            this.quantUsadaDataGridViewTextBoxColumn3.HeaderText = "Quant_Usada";
            this.quantUsadaDataGridViewTextBoxColumn3.Name = "quantUsadaDataGridViewTextBoxColumn3";
            this.quantUsadaDataGridViewTextBoxColumn3.ReadOnly = true;
            this.quantUsadaDataGridViewTextBoxColumn3.Width = 98;
            // 
            // usuarioLogadoDataGridViewTextBoxColumn3
            // 
            this.usuarioLogadoDataGridViewTextBoxColumn3.DataPropertyName = "Usuario_Logado";
            this.usuarioLogadoDataGridViewTextBoxColumn3.HeaderText = "Usuario_Logado";
            this.usuarioLogadoDataGridViewTextBoxColumn3.Name = "usuarioLogadoDataGridViewTextBoxColumn3";
            this.usuarioLogadoDataGridViewTextBoxColumn3.ReadOnly = true;
            this.usuarioLogadoDataGridViewTextBoxColumn3.Width = 110;
            // 
            // tblToluenoBindingSource1
            // 
            this.tblToluenoBindingSource1.DataMember = "tblTolueno";
            this.tblToluenoBindingSource1.DataSource = this.bDPQDataSet;
            // 
            // idProdutosQuimicosDataGridViewTextBoxColumn4
            // 
            this.idProdutosQuimicosDataGridViewTextBoxColumn4.DataPropertyName = "IdProdutosQuimicos";
            this.idProdutosQuimicosDataGridViewTextBoxColumn4.HeaderText = "IdProdutosQuimicos";
            this.idProdutosQuimicosDataGridViewTextBoxColumn4.Name = "idProdutosQuimicosDataGridViewTextBoxColumn4";
            this.idProdutosQuimicosDataGridViewTextBoxColumn4.ReadOnly = true;
            this.idProdutosQuimicosDataGridViewTextBoxColumn4.Width = 126;
            // 
            // produtoDataGridViewTextBoxColumn4
            // 
            this.produtoDataGridViewTextBoxColumn4.DataPropertyName = "Produto";
            this.produtoDataGridViewTextBoxColumn4.HeaderText = "Produto";
            this.produtoDataGridViewTextBoxColumn4.Name = "produtoDataGridViewTextBoxColumn4";
            this.produtoDataGridViewTextBoxColumn4.ReadOnly = true;
            this.produtoDataGridViewTextBoxColumn4.Width = 69;
            // 
            // desenhoDataGridViewTextBoxColumn4
            // 
            this.desenhoDataGridViewTextBoxColumn4.DataPropertyName = "Desenho";
            this.desenhoDataGridViewTextBoxColumn4.HeaderText = "Desenho";
            this.desenhoDataGridViewTextBoxColumn4.Name = "desenhoDataGridViewTextBoxColumn4";
            this.desenhoDataGridViewTextBoxColumn4.ReadOnly = true;
            this.desenhoDataGridViewTextBoxColumn4.Width = 75;
            // 
            // numeroNFDataGridViewTextBoxColumn4
            // 
            this.numeroNFDataGridViewTextBoxColumn4.DataPropertyName = "Numero_NF";
            this.numeroNFDataGridViewTextBoxColumn4.HeaderText = "Numero_NF";
            this.numeroNFDataGridViewTextBoxColumn4.Name = "numeroNFDataGridViewTextBoxColumn4";
            this.numeroNFDataGridViewTextBoxColumn4.ReadOnly = true;
            this.numeroNFDataGridViewTextBoxColumn4.Width = 89;
            // 
            // dataEmissaoNFDataGridViewTextBoxColumn4
            // 
            this.dataEmissaoNFDataGridViewTextBoxColumn4.DataPropertyName = "Data_Emissao_NF";
            this.dataEmissaoNFDataGridViewTextBoxColumn4.HeaderText = "Data_Emissao_NF";
            this.dataEmissaoNFDataGridViewTextBoxColumn4.Name = "dataEmissaoNFDataGridViewTextBoxColumn4";
            this.dataEmissaoNFDataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataEmissaoNFDataGridViewTextBoxColumn4.Width = 120;
            // 
            // numeroPedidoDataGridViewTextBoxColumn4
            // 
            this.numeroPedidoDataGridViewTextBoxColumn4.DataPropertyName = "Numero_Pedido";
            this.numeroPedidoDataGridViewTextBoxColumn4.HeaderText = "Numero_Pedido";
            this.numeroPedidoDataGridViewTextBoxColumn4.Name = "numeroPedidoDataGridViewTextBoxColumn4";
            this.numeroPedidoDataGridViewTextBoxColumn4.ReadOnly = true;
            this.numeroPedidoDataGridViewTextBoxColumn4.Width = 108;
            // 
            // dataPedidoDataGridViewTextBoxColumn4
            // 
            this.dataPedidoDataGridViewTextBoxColumn4.DataPropertyName = "Data_Pedido";
            this.dataPedidoDataGridViewTextBoxColumn4.HeaderText = "Data_Pedido";
            this.dataPedidoDataGridViewTextBoxColumn4.Name = "dataPedidoDataGridViewTextBoxColumn4";
            this.dataPedidoDataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataPedidoDataGridViewTextBoxColumn4.Width = 94;
            // 
            // estoqueDataGridViewTextBoxColumn4
            // 
            this.estoqueDataGridViewTextBoxColumn4.DataPropertyName = "Estoque";
            this.estoqueDataGridViewTextBoxColumn4.HeaderText = "Estoque";
            this.estoqueDataGridViewTextBoxColumn4.Name = "estoqueDataGridViewTextBoxColumn4";
            this.estoqueDataGridViewTextBoxColumn4.ReadOnly = true;
            this.estoqueDataGridViewTextBoxColumn4.Width = 71;
            // 
            // quantCompradaDataGridViewTextBoxColumn4
            // 
            this.quantCompradaDataGridViewTextBoxColumn4.DataPropertyName = "Quant_Comprada";
            this.quantCompradaDataGridViewTextBoxColumn4.HeaderText = "Quant_Comprada";
            this.quantCompradaDataGridViewTextBoxColumn4.Name = "quantCompradaDataGridViewTextBoxColumn4";
            this.quantCompradaDataGridViewTextBoxColumn4.ReadOnly = true;
            this.quantCompradaDataGridViewTextBoxColumn4.Width = 115;
            // 
            // quantUsadaDataGridViewTextBoxColumn4
            // 
            this.quantUsadaDataGridViewTextBoxColumn4.DataPropertyName = "Quant_Usada";
            this.quantUsadaDataGridViewTextBoxColumn4.HeaderText = "Quant_Usada";
            this.quantUsadaDataGridViewTextBoxColumn4.Name = "quantUsadaDataGridViewTextBoxColumn4";
            this.quantUsadaDataGridViewTextBoxColumn4.ReadOnly = true;
            this.quantUsadaDataGridViewTextBoxColumn4.Width = 98;
            // 
            // usuarioLogadoDataGridViewTextBoxColumn4
            // 
            this.usuarioLogadoDataGridViewTextBoxColumn4.DataPropertyName = "Usuario_Logado";
            this.usuarioLogadoDataGridViewTextBoxColumn4.HeaderText = "Usuario_Logado";
            this.usuarioLogadoDataGridViewTextBoxColumn4.Name = "usuarioLogadoDataGridViewTextBoxColumn4";
            this.usuarioLogadoDataGridViewTextBoxColumn4.ReadOnly = true;
            this.usuarioLogadoDataGridViewTextBoxColumn4.Width = 110;
            // 
            // tblMetiletilcetonaBindingSource
            // 
            this.tblMetiletilcetonaBindingSource.DataMember = "tblMetiletilcetona";
            this.tblMetiletilcetonaBindingSource.DataSource = this.bDPQDataSet;
            // 
            // tblMetiletilcetonaTableAdapter
            // 
            this.tblMetiletilcetonaTableAdapter.ClearBeforeFill = true;
            // 
            // idProdutosQuimicosDataGridViewTextBoxColumn5
            // 
            this.idProdutosQuimicosDataGridViewTextBoxColumn5.DataPropertyName = "IdProdutosQuimicos";
            this.idProdutosQuimicosDataGridViewTextBoxColumn5.HeaderText = "IdProdutosQuimicos";
            this.idProdutosQuimicosDataGridViewTextBoxColumn5.Name = "idProdutosQuimicosDataGridViewTextBoxColumn5";
            this.idProdutosQuimicosDataGridViewTextBoxColumn5.ReadOnly = true;
            this.idProdutosQuimicosDataGridViewTextBoxColumn5.Width = 126;
            // 
            // produtoDataGridViewTextBoxColumn5
            // 
            this.produtoDataGridViewTextBoxColumn5.DataPropertyName = "Produto";
            this.produtoDataGridViewTextBoxColumn5.HeaderText = "Produto";
            this.produtoDataGridViewTextBoxColumn5.Name = "produtoDataGridViewTextBoxColumn5";
            this.produtoDataGridViewTextBoxColumn5.ReadOnly = true;
            this.produtoDataGridViewTextBoxColumn5.Width = 69;
            // 
            // desenhoDataGridViewTextBoxColumn5
            // 
            this.desenhoDataGridViewTextBoxColumn5.DataPropertyName = "Desenho";
            this.desenhoDataGridViewTextBoxColumn5.HeaderText = "Desenho";
            this.desenhoDataGridViewTextBoxColumn5.Name = "desenhoDataGridViewTextBoxColumn5";
            this.desenhoDataGridViewTextBoxColumn5.ReadOnly = true;
            this.desenhoDataGridViewTextBoxColumn5.Width = 75;
            // 
            // numeroNFDataGridViewTextBoxColumn5
            // 
            this.numeroNFDataGridViewTextBoxColumn5.DataPropertyName = "Numero_NF";
            this.numeroNFDataGridViewTextBoxColumn5.HeaderText = "Numero_NF";
            this.numeroNFDataGridViewTextBoxColumn5.Name = "numeroNFDataGridViewTextBoxColumn5";
            this.numeroNFDataGridViewTextBoxColumn5.ReadOnly = true;
            this.numeroNFDataGridViewTextBoxColumn5.Width = 89;
            // 
            // dataEmissaoNFDataGridViewTextBoxColumn5
            // 
            this.dataEmissaoNFDataGridViewTextBoxColumn5.DataPropertyName = "Data_Emissao_NF";
            this.dataEmissaoNFDataGridViewTextBoxColumn5.HeaderText = "Data_Emissao_NF";
            this.dataEmissaoNFDataGridViewTextBoxColumn5.Name = "dataEmissaoNFDataGridViewTextBoxColumn5";
            this.dataEmissaoNFDataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataEmissaoNFDataGridViewTextBoxColumn5.Width = 120;
            // 
            // numeroPedidoDataGridViewTextBoxColumn5
            // 
            this.numeroPedidoDataGridViewTextBoxColumn5.DataPropertyName = "Numero_Pedido";
            this.numeroPedidoDataGridViewTextBoxColumn5.HeaderText = "Numero_Pedido";
            this.numeroPedidoDataGridViewTextBoxColumn5.Name = "numeroPedidoDataGridViewTextBoxColumn5";
            this.numeroPedidoDataGridViewTextBoxColumn5.ReadOnly = true;
            this.numeroPedidoDataGridViewTextBoxColumn5.Width = 108;
            // 
            // dataPedidoDataGridViewTextBoxColumn5
            // 
            this.dataPedidoDataGridViewTextBoxColumn5.DataPropertyName = "Data_Pedido";
            this.dataPedidoDataGridViewTextBoxColumn5.HeaderText = "Data_Pedido";
            this.dataPedidoDataGridViewTextBoxColumn5.Name = "dataPedidoDataGridViewTextBoxColumn5";
            this.dataPedidoDataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataPedidoDataGridViewTextBoxColumn5.Width = 94;
            // 
            // estoqueDataGridViewTextBoxColumn5
            // 
            this.estoqueDataGridViewTextBoxColumn5.DataPropertyName = "Estoque";
            this.estoqueDataGridViewTextBoxColumn5.HeaderText = "Estoque";
            this.estoqueDataGridViewTextBoxColumn5.Name = "estoqueDataGridViewTextBoxColumn5";
            this.estoqueDataGridViewTextBoxColumn5.ReadOnly = true;
            this.estoqueDataGridViewTextBoxColumn5.Width = 71;
            // 
            // quantCompradaDataGridViewTextBoxColumn5
            // 
            this.quantCompradaDataGridViewTextBoxColumn5.DataPropertyName = "Quant_Comprada";
            this.quantCompradaDataGridViewTextBoxColumn5.HeaderText = "Quant_Comprada";
            this.quantCompradaDataGridViewTextBoxColumn5.Name = "quantCompradaDataGridViewTextBoxColumn5";
            this.quantCompradaDataGridViewTextBoxColumn5.ReadOnly = true;
            this.quantCompradaDataGridViewTextBoxColumn5.Width = 115;
            // 
            // quantUsadaDataGridViewTextBoxColumn5
            // 
            this.quantUsadaDataGridViewTextBoxColumn5.DataPropertyName = "Quant_Usada";
            this.quantUsadaDataGridViewTextBoxColumn5.HeaderText = "Quant_Usada";
            this.quantUsadaDataGridViewTextBoxColumn5.Name = "quantUsadaDataGridViewTextBoxColumn5";
            this.quantUsadaDataGridViewTextBoxColumn5.ReadOnly = true;
            this.quantUsadaDataGridViewTextBoxColumn5.Width = 98;
            // 
            // usuarioLogadoDataGridViewTextBoxColumn5
            // 
            this.usuarioLogadoDataGridViewTextBoxColumn5.DataPropertyName = "Usuario_Logado";
            this.usuarioLogadoDataGridViewTextBoxColumn5.HeaderText = "Usuario_Logado";
            this.usuarioLogadoDataGridViewTextBoxColumn5.Name = "usuarioLogadoDataGridViewTextBoxColumn5";
            this.usuarioLogadoDataGridViewTextBoxColumn5.ReadOnly = true;
            this.usuarioLogadoDataGridViewTextBoxColumn5.Width = 110;
            // 
            // tblAcetonaBindingSource
            // 
            this.tblAcetonaBindingSource.DataMember = "tblAcetona";
            this.tblAcetonaBindingSource.DataSource = this.bDPQDataSet;
            // 
            // tblAcetonaTableAdapter
            // 
            this.tblAcetonaTableAdapter.ClearBeforeFill = true;
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
            this.TabPage_AcidoCloridrico.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.TabPage_AcidoSulfurico.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.TabPage_HidroxidoPotassio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.TabPage_Tolueno.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.TabPage_Acetona.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.TabPage_Metiletilcetona.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDPQDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAcidoCloridricoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAcidoSulfuricoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHidroxidoPostasioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblToluenoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblToluenoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMetiletilcetonaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAcetonaBindingSource)).EndInit();
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
        public System.Windows.Forms.TabPage TabPage_AcidoCloridrico;
        public System.Windows.Forms.TabPage TabPage_AcidoSulfurico;
        private System.Windows.Forms.ComboBox Cx_Item;
        private System.Windows.Forms.DateTimePicker Cx_Data_Emissao_NF;
        private System.Windows.Forms.DateTimePicker Cx_Data_Pedido;
        public System.Windows.Forms.TabPage TabPage_Tolueno;
        public System.Windows.Forms.TabPage TabPage_Acetona;
        public System.Windows.Forms.TabPage TabPage_Metiletilcetona;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.DataGridView dataGridView2;
        public System.Windows.Forms.TabPage TabPage_HidroxidoPotassio;
        public System.Windows.Forms.DataGridView dataGridView3;
        public System.Windows.Forms.DataGridView dataGridView4;
        public System.Windows.Forms.DataGridView dataGridView5;
        public System.Windows.Forms.DataGridView dataGridView6;
        public System.Windows.Forms.TextBox Cx_Usuario_Logado;
        public System.Windows.Forms.DataGridViewTextBoxColumn Data_Lancamento_Acetona;
        public System.Windows.Forms.DataGridViewTextBoxColumn Data_Lancamento_Metiletilcetona;
        private System.Windows.Forms.Button btn_Relatorio;
        private BDPQDataSet bDPQDataSet;
        private System.Windows.Forms.BindingSource tblAcidoCloridricoBindingSource;
        private BDPQDataSetTableAdapters.tblAcidoCloridricoTableAdapter tblAcidoCloridricoTableAdapter;
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
        private System.Windows.Forms.BindingSource tblAcidoSulfuricoBindingSource;
        private BDPQDataSetTableAdapters.tblAcidoSulfuricoTableAdapter tblAcidoSulfuricoTableAdapter;
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
        private System.Windows.Forms.BindingSource tblHidroxidoPostasioBindingSource;
        private BDPQDataSetTableAdapters.tblHidroxidoPostasioTableAdapter tblHidroxidoPostasioTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProdutosQuimicosDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn produtoDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn desenhoDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroNFDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataEmissaoNFDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroPedidoDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataPedidoDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn estoqueDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantCompradaDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantUsadaDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioLogadoDataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource tblToluenoBindingSource;
        private BDPQDataSetTableAdapters.tblToluenoTableAdapter tblToluenoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProdutosQuimicosDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn produtoDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn desenhoDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroNFDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataEmissaoNFDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroPedidoDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataPedidoDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn estoqueDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantCompradaDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantUsadaDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioLogadoDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProdutosQuimicosDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn produtoDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn desenhoDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroNFDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataEmissaoNFDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroPedidoDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataPedidoDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn estoqueDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantCompradaDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantUsadaDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioLogadoDataGridViewTextBoxColumn4;
        private System.Windows.Forms.BindingSource tblToluenoBindingSource1;
        private System.Windows.Forms.BindingSource tblMetiletilcetonaBindingSource;
        private BDPQDataSetTableAdapters.tblMetiletilcetonaTableAdapter tblMetiletilcetonaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProdutosQuimicosDataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn produtoDataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn desenhoDataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroNFDataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataEmissaoNFDataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroPedidoDataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataPedidoDataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn estoqueDataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantCompradaDataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantUsadaDataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioLogadoDataGridViewTextBoxColumn5;
        private System.Windows.Forms.BindingSource tblAcetonaBindingSource;
        private BDPQDataSetTableAdapters.tblAcetonaTableAdapter tblAcetonaTableAdapter;
    }
}