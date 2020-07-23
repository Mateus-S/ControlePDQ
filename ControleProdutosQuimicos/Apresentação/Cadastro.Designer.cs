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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.Cx_Item = new System.Windows.Forms.ComboBox();
            this.Cx_Data_Emissao_NF = new System.Windows.Forms.DateTimePicker();
            this.Cx_Data_Pedido = new System.Windows.Forms.DateTimePicker();
            this.Cx_Usuario_Logado = new System.Windows.Forms.TextBox();
            this.bDPQServerTSEA = new ControleProdutosQuimicos.BDPQServerTSEA();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblAcidoCloridricoTableAdapter = new ControleProdutosQuimicos.BDPQServerTSEATableAdapters.tblAcidoCloridricoTableAdapter();
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
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tblAcidoSulfuricoTableAdapter = new ControleProdutosQuimicos.BDPQServerTSEATableAdapters.tblAcidoSulfuricoTableAdapter();
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
            this.bindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.tblHidroxidoPostasioTableAdapter = new ControleProdutosQuimicos.BDPQServerTSEATableAdapters.tblHidroxidoPostasioTableAdapter();
            this.dataGridViewTextBoxColumn188 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn189 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn190 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn191 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn192 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn193 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn194 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn195 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn196 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn197 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn198 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.tblToluenoTableAdapter = new ControleProdutosQuimicos.BDPQServerTSEATableAdapters.tblToluenoTableAdapter();
            this.dataGridViewTextBoxColumn199 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn200 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn201 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn202 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn203 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn204 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn205 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn206 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn207 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn208 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn209 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.tblAcetonaTableAdapter = new ControleProdutosQuimicos.BDPQServerTSEATableAdapters.tblAcetonaTableAdapter();
            this.dataGridViewTextBoxColumn210 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn211 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn212 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn213 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn214 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn215 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn216 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn217 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn218 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn219 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn220 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.tblMetiletilcetonaTableAdapter = new ControleProdutosQuimicos.BDPQServerTSEATableAdapters.tblMetiletilcetonaTableAdapter();
            this.dataGridViewTextBoxColumn221 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn222 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn223 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn224 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn225 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn226 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn227 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn228 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn229 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn230 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn231 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tab_Produtos.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDPQServerTSEA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource6)).BeginInit();
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
            this.BotaoSalvar.Location = new System.Drawing.Point(234, 293);
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
            this.BotaoLimparDados.Location = new System.Drawing.Point(467, 293);
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
            this.BotaoSair.Location = new System.Drawing.Point(700, 293);
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
            this.tab_Produtos.Location = new System.Drawing.Point(12, 327);
            this.tab_Produtos.Name = "tab_Produtos";
            this.tab_Produtos.SelectedIndex = 0;
            this.tab_Produtos.Size = new System.Drawing.Size(1130, 276);
            this.tab_Produtos.TabIndex = 26;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1122, 250);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ácido Cloridrico";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            this.dataGridViewTextBoxColumn176});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1116, 244);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1122, 250);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ácido Sulfurico";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridViewTextBoxColumn187});
            this.dataGridView2.DataSource = this.bindingSource2;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(1116, 244);
            this.dataGridView2.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1122, 250);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Hidróxido De Potássio";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn188,
            this.dataGridViewTextBoxColumn189,
            this.dataGridViewTextBoxColumn190,
            this.dataGridViewTextBoxColumn191,
            this.dataGridViewTextBoxColumn192,
            this.dataGridViewTextBoxColumn193,
            this.dataGridViewTextBoxColumn194,
            this.dataGridViewTextBoxColumn195,
            this.dataGridViewTextBoxColumn196,
            this.dataGridViewTextBoxColumn197,
            this.dataGridViewTextBoxColumn198});
            this.dataGridView3.DataSource = this.bindingSource3;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(3, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(1116, 244);
            this.dataGridView3.TabIndex = 2;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridView4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1122, 250);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Tolueno";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn199,
            this.dataGridViewTextBoxColumn200,
            this.dataGridViewTextBoxColumn201,
            this.dataGridViewTextBoxColumn202,
            this.dataGridViewTextBoxColumn203,
            this.dataGridViewTextBoxColumn204,
            this.dataGridViewTextBoxColumn205,
            this.dataGridViewTextBoxColumn206,
            this.dataGridViewTextBoxColumn207,
            this.dataGridViewTextBoxColumn208,
            this.dataGridViewTextBoxColumn209});
            this.dataGridView4.DataSource = this.bindingSource4;
            this.dataGridView4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView4.Location = new System.Drawing.Point(3, 3);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.Size = new System.Drawing.Size(1116, 244);
            this.dataGridView4.TabIndex = 2;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dataGridView5);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1122, 250);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Acetona";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dataGridView5
            // 
            this.dataGridView5.AllowUserToAddRows = false;
            this.dataGridView5.AllowUserToDeleteRows = false;
            this.dataGridView5.AutoGenerateColumns = false;
            this.dataGridView5.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn210,
            this.dataGridViewTextBoxColumn211,
            this.dataGridViewTextBoxColumn212,
            this.dataGridViewTextBoxColumn213,
            this.dataGridViewTextBoxColumn214,
            this.dataGridViewTextBoxColumn215,
            this.dataGridViewTextBoxColumn216,
            this.dataGridViewTextBoxColumn217,
            this.dataGridViewTextBoxColumn218,
            this.dataGridViewTextBoxColumn219,
            this.dataGridViewTextBoxColumn220});
            this.dataGridView5.DataSource = this.bindingSource5;
            this.dataGridView5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView5.Location = new System.Drawing.Point(3, 3);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.ReadOnly = true;
            this.dataGridView5.Size = new System.Drawing.Size(1116, 244);
            this.dataGridView5.TabIndex = 3;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.dataGridView6);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(1122, 250);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Metiletilcetona";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // dataGridView6
            // 
            this.dataGridView6.AllowUserToAddRows = false;
            this.dataGridView6.AllowUserToDeleteRows = false;
            this.dataGridView6.AutoGenerateColumns = false;
            this.dataGridView6.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn221,
            this.dataGridViewTextBoxColumn222,
            this.dataGridViewTextBoxColumn223,
            this.dataGridViewTextBoxColumn224,
            this.dataGridViewTextBoxColumn225,
            this.dataGridViewTextBoxColumn226,
            this.dataGridViewTextBoxColumn227,
            this.dataGridViewTextBoxColumn228,
            this.dataGridViewTextBoxColumn229,
            this.dataGridViewTextBoxColumn230,
            this.dataGridViewTextBoxColumn231});
            this.dataGridView6.DataSource = this.bindingSource6;
            this.dataGridView6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView6.Location = new System.Drawing.Point(3, 3);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.ReadOnly = true;
            this.dataGridView6.Size = new System.Drawing.Size(1116, 244);
            this.dataGridView6.TabIndex = 4;
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
            this.Cx_Item.SelectedIndexChanged += new System.EventHandler(this.Cx_Item_SelectedIndexChanged);
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
            this.Cx_Usuario_Logado.TextChanged += new System.EventHandler(this.Cx_Usuario_Logado_TextChanged);
            // 
            // bDPQServerTSEA
            // 
            this.bDPQServerTSEA.DataSetName = "BDPQServerTSEA";
            this.bDPQServerTSEA.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "tblAcidoCloridrico";
            this.bindingSource1.DataSource = this.bDPQServerTSEA;
            // 
            // tblAcidoCloridricoTableAdapter
            // 
            this.tblAcidoCloridricoTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn166
            // 
            this.dataGridViewTextBoxColumn166.DataPropertyName = "IdProdutosQuimicos";
            this.dataGridViewTextBoxColumn166.HeaderText = "Registro";
            this.dataGridViewTextBoxColumn166.Name = "dataGridViewTextBoxColumn166";
            this.dataGridViewTextBoxColumn166.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn167
            // 
            this.dataGridViewTextBoxColumn167.DataPropertyName = "Produto";
            this.dataGridViewTextBoxColumn167.HeaderText = "Produto";
            this.dataGridViewTextBoxColumn167.Name = "dataGridViewTextBoxColumn167";
            this.dataGridViewTextBoxColumn167.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn168
            // 
            this.dataGridViewTextBoxColumn168.DataPropertyName = "Desenho";
            this.dataGridViewTextBoxColumn168.HeaderText = "Desenho";
            this.dataGridViewTextBoxColumn168.Name = "dataGridViewTextBoxColumn168";
            this.dataGridViewTextBoxColumn168.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn169
            // 
            this.dataGridViewTextBoxColumn169.DataPropertyName = "Numero_NF";
            this.dataGridViewTextBoxColumn169.HeaderText = "Numero_NF";
            this.dataGridViewTextBoxColumn169.Name = "dataGridViewTextBoxColumn169";
            this.dataGridViewTextBoxColumn169.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn170
            // 
            this.dataGridViewTextBoxColumn170.DataPropertyName = "Data_Emissao_NF";
            this.dataGridViewTextBoxColumn170.HeaderText = "Data_Emissao_NF";
            this.dataGridViewTextBoxColumn170.Name = "dataGridViewTextBoxColumn170";
            this.dataGridViewTextBoxColumn170.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn171
            // 
            this.dataGridViewTextBoxColumn171.DataPropertyName = "Numero_Pedido";
            this.dataGridViewTextBoxColumn171.HeaderText = "Numero_Pedido";
            this.dataGridViewTextBoxColumn171.Name = "dataGridViewTextBoxColumn171";
            this.dataGridViewTextBoxColumn171.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn172
            // 
            this.dataGridViewTextBoxColumn172.DataPropertyName = "Data_Pedido";
            this.dataGridViewTextBoxColumn172.HeaderText = "Data_Pedido";
            this.dataGridViewTextBoxColumn172.Name = "dataGridViewTextBoxColumn172";
            this.dataGridViewTextBoxColumn172.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn173
            // 
            this.dataGridViewTextBoxColumn173.DataPropertyName = "Estoque";
            this.dataGridViewTextBoxColumn173.HeaderText = "Estoque";
            this.dataGridViewTextBoxColumn173.Name = "dataGridViewTextBoxColumn173";
            this.dataGridViewTextBoxColumn173.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn174
            // 
            this.dataGridViewTextBoxColumn174.DataPropertyName = "Quant_Comprada";
            this.dataGridViewTextBoxColumn174.HeaderText = "Quant_Comprada";
            this.dataGridViewTextBoxColumn174.Name = "dataGridViewTextBoxColumn174";
            this.dataGridViewTextBoxColumn174.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn175
            // 
            this.dataGridViewTextBoxColumn175.DataPropertyName = "Quant_Usada";
            this.dataGridViewTextBoxColumn175.HeaderText = "Quant_Usada";
            this.dataGridViewTextBoxColumn175.Name = "dataGridViewTextBoxColumn175";
            this.dataGridViewTextBoxColumn175.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn176
            // 
            this.dataGridViewTextBoxColumn176.DataPropertyName = "Usuario_Logado";
            this.dataGridViewTextBoxColumn176.HeaderText = "Usuario_Logado";
            this.dataGridViewTextBoxColumn176.Name = "dataGridViewTextBoxColumn176";
            this.dataGridViewTextBoxColumn176.ReadOnly = true;
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataMember = "tblAcidoSulfurico";
            this.bindingSource2.DataSource = this.bDPQServerTSEA;
            // 
            // tblAcidoSulfuricoTableAdapter
            // 
            this.tblAcidoSulfuricoTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn177
            // 
            this.dataGridViewTextBoxColumn177.DataPropertyName = "IdProdutosQuimicos";
            this.dataGridViewTextBoxColumn177.HeaderText = "Registro";
            this.dataGridViewTextBoxColumn177.Name = "dataGridViewTextBoxColumn177";
            this.dataGridViewTextBoxColumn177.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn178
            // 
            this.dataGridViewTextBoxColumn178.DataPropertyName = "Produto";
            this.dataGridViewTextBoxColumn178.HeaderText = "Produto";
            this.dataGridViewTextBoxColumn178.Name = "dataGridViewTextBoxColumn178";
            this.dataGridViewTextBoxColumn178.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn179
            // 
            this.dataGridViewTextBoxColumn179.DataPropertyName = "Desenho";
            this.dataGridViewTextBoxColumn179.HeaderText = "Desenho";
            this.dataGridViewTextBoxColumn179.Name = "dataGridViewTextBoxColumn179";
            this.dataGridViewTextBoxColumn179.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn180
            // 
            this.dataGridViewTextBoxColumn180.DataPropertyName = "Numero_NF";
            this.dataGridViewTextBoxColumn180.HeaderText = "Numero_NF";
            this.dataGridViewTextBoxColumn180.Name = "dataGridViewTextBoxColumn180";
            this.dataGridViewTextBoxColumn180.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn181
            // 
            this.dataGridViewTextBoxColumn181.DataPropertyName = "Data_Emissao_NF";
            this.dataGridViewTextBoxColumn181.HeaderText = "Data_Emissao_NF";
            this.dataGridViewTextBoxColumn181.Name = "dataGridViewTextBoxColumn181";
            this.dataGridViewTextBoxColumn181.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn182
            // 
            this.dataGridViewTextBoxColumn182.DataPropertyName = "Numero_Pedido";
            this.dataGridViewTextBoxColumn182.HeaderText = "Numero_Pedido";
            this.dataGridViewTextBoxColumn182.Name = "dataGridViewTextBoxColumn182";
            this.dataGridViewTextBoxColumn182.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn183
            // 
            this.dataGridViewTextBoxColumn183.DataPropertyName = "Data_Pedido";
            this.dataGridViewTextBoxColumn183.HeaderText = "Data_Pedido";
            this.dataGridViewTextBoxColumn183.Name = "dataGridViewTextBoxColumn183";
            this.dataGridViewTextBoxColumn183.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn184
            // 
            this.dataGridViewTextBoxColumn184.DataPropertyName = "Estoque";
            this.dataGridViewTextBoxColumn184.HeaderText = "Estoque";
            this.dataGridViewTextBoxColumn184.Name = "dataGridViewTextBoxColumn184";
            this.dataGridViewTextBoxColumn184.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn185
            // 
            this.dataGridViewTextBoxColumn185.DataPropertyName = "Quant_Comprada";
            this.dataGridViewTextBoxColumn185.HeaderText = "Quant_Comprada";
            this.dataGridViewTextBoxColumn185.Name = "dataGridViewTextBoxColumn185";
            this.dataGridViewTextBoxColumn185.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn186
            // 
            this.dataGridViewTextBoxColumn186.DataPropertyName = "Quant_Usada";
            this.dataGridViewTextBoxColumn186.HeaderText = "Quant_Usada";
            this.dataGridViewTextBoxColumn186.Name = "dataGridViewTextBoxColumn186";
            this.dataGridViewTextBoxColumn186.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn187
            // 
            this.dataGridViewTextBoxColumn187.DataPropertyName = "Usuario_Logado";
            this.dataGridViewTextBoxColumn187.HeaderText = "Usuario_Logado";
            this.dataGridViewTextBoxColumn187.Name = "dataGridViewTextBoxColumn187";
            this.dataGridViewTextBoxColumn187.ReadOnly = true;
            // 
            // bindingSource3
            // 
            this.bindingSource3.DataMember = "tblHidroxidoPostasio";
            this.bindingSource3.DataSource = this.bDPQServerTSEA;
            // 
            // tblHidroxidoPostasioTableAdapter
            // 
            this.tblHidroxidoPostasioTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn188
            // 
            this.dataGridViewTextBoxColumn188.DataPropertyName = "IdProdutosQuimicos";
            this.dataGridViewTextBoxColumn188.HeaderText = "Registro";
            this.dataGridViewTextBoxColumn188.Name = "dataGridViewTextBoxColumn188";
            this.dataGridViewTextBoxColumn188.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn189
            // 
            this.dataGridViewTextBoxColumn189.DataPropertyName = "Produto";
            this.dataGridViewTextBoxColumn189.HeaderText = "Produto";
            this.dataGridViewTextBoxColumn189.Name = "dataGridViewTextBoxColumn189";
            this.dataGridViewTextBoxColumn189.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn190
            // 
            this.dataGridViewTextBoxColumn190.DataPropertyName = "Desenho";
            this.dataGridViewTextBoxColumn190.HeaderText = "Desenho";
            this.dataGridViewTextBoxColumn190.Name = "dataGridViewTextBoxColumn190";
            this.dataGridViewTextBoxColumn190.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn191
            // 
            this.dataGridViewTextBoxColumn191.DataPropertyName = "Numero_NF";
            this.dataGridViewTextBoxColumn191.HeaderText = "Numero_NF";
            this.dataGridViewTextBoxColumn191.Name = "dataGridViewTextBoxColumn191";
            this.dataGridViewTextBoxColumn191.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn192
            // 
            this.dataGridViewTextBoxColumn192.DataPropertyName = "Data_Emissao_NF";
            this.dataGridViewTextBoxColumn192.HeaderText = "Data_Emissao_NF";
            this.dataGridViewTextBoxColumn192.Name = "dataGridViewTextBoxColumn192";
            this.dataGridViewTextBoxColumn192.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn193
            // 
            this.dataGridViewTextBoxColumn193.DataPropertyName = "Numero_Pedido";
            this.dataGridViewTextBoxColumn193.HeaderText = "Numero_Pedido";
            this.dataGridViewTextBoxColumn193.Name = "dataGridViewTextBoxColumn193";
            this.dataGridViewTextBoxColumn193.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn194
            // 
            this.dataGridViewTextBoxColumn194.DataPropertyName = "Data_Pedido";
            this.dataGridViewTextBoxColumn194.HeaderText = "Data_Pedido";
            this.dataGridViewTextBoxColumn194.Name = "dataGridViewTextBoxColumn194";
            this.dataGridViewTextBoxColumn194.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn195
            // 
            this.dataGridViewTextBoxColumn195.DataPropertyName = "Estoque";
            this.dataGridViewTextBoxColumn195.HeaderText = "Estoque";
            this.dataGridViewTextBoxColumn195.Name = "dataGridViewTextBoxColumn195";
            this.dataGridViewTextBoxColumn195.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn196
            // 
            this.dataGridViewTextBoxColumn196.DataPropertyName = "Quant_Comprada";
            this.dataGridViewTextBoxColumn196.HeaderText = "Quant_Comprada";
            this.dataGridViewTextBoxColumn196.Name = "dataGridViewTextBoxColumn196";
            this.dataGridViewTextBoxColumn196.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn197
            // 
            this.dataGridViewTextBoxColumn197.DataPropertyName = "Quant_Usada";
            this.dataGridViewTextBoxColumn197.HeaderText = "Quant_Usada";
            this.dataGridViewTextBoxColumn197.Name = "dataGridViewTextBoxColumn197";
            this.dataGridViewTextBoxColumn197.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn198
            // 
            this.dataGridViewTextBoxColumn198.DataPropertyName = "Usuario_Logado";
            this.dataGridViewTextBoxColumn198.HeaderText = "Usuario_Logado";
            this.dataGridViewTextBoxColumn198.Name = "dataGridViewTextBoxColumn198";
            this.dataGridViewTextBoxColumn198.ReadOnly = true;
            // 
            // bindingSource4
            // 
            this.bindingSource4.DataMember = "tblTolueno";
            this.bindingSource4.DataSource = this.bDPQServerTSEA;
            // 
            // tblToluenoTableAdapter
            // 
            this.tblToluenoTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn199
            // 
            this.dataGridViewTextBoxColumn199.DataPropertyName = "IdProdutosQuimicos";
            this.dataGridViewTextBoxColumn199.HeaderText = "Registro";
            this.dataGridViewTextBoxColumn199.Name = "dataGridViewTextBoxColumn199";
            this.dataGridViewTextBoxColumn199.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn200
            // 
            this.dataGridViewTextBoxColumn200.DataPropertyName = "Produto";
            this.dataGridViewTextBoxColumn200.HeaderText = "Produto";
            this.dataGridViewTextBoxColumn200.Name = "dataGridViewTextBoxColumn200";
            this.dataGridViewTextBoxColumn200.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn201
            // 
            this.dataGridViewTextBoxColumn201.DataPropertyName = "Desenho";
            this.dataGridViewTextBoxColumn201.HeaderText = "Desenho";
            this.dataGridViewTextBoxColumn201.Name = "dataGridViewTextBoxColumn201";
            this.dataGridViewTextBoxColumn201.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn202
            // 
            this.dataGridViewTextBoxColumn202.DataPropertyName = "Numero_NF";
            this.dataGridViewTextBoxColumn202.HeaderText = "Numero_NF";
            this.dataGridViewTextBoxColumn202.Name = "dataGridViewTextBoxColumn202";
            this.dataGridViewTextBoxColumn202.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn203
            // 
            this.dataGridViewTextBoxColumn203.DataPropertyName = "Data_Emissao_NF";
            this.dataGridViewTextBoxColumn203.HeaderText = "Data_Emissao_NF";
            this.dataGridViewTextBoxColumn203.Name = "dataGridViewTextBoxColumn203";
            this.dataGridViewTextBoxColumn203.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn204
            // 
            this.dataGridViewTextBoxColumn204.DataPropertyName = "Numero_Pedido";
            this.dataGridViewTextBoxColumn204.HeaderText = "Numero_Pedido";
            this.dataGridViewTextBoxColumn204.Name = "dataGridViewTextBoxColumn204";
            this.dataGridViewTextBoxColumn204.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn205
            // 
            this.dataGridViewTextBoxColumn205.DataPropertyName = "Data_Pedido";
            this.dataGridViewTextBoxColumn205.HeaderText = "Data_Pedido";
            this.dataGridViewTextBoxColumn205.Name = "dataGridViewTextBoxColumn205";
            this.dataGridViewTextBoxColumn205.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn206
            // 
            this.dataGridViewTextBoxColumn206.DataPropertyName = "Estoque";
            this.dataGridViewTextBoxColumn206.HeaderText = "Estoque";
            this.dataGridViewTextBoxColumn206.Name = "dataGridViewTextBoxColumn206";
            this.dataGridViewTextBoxColumn206.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn207
            // 
            this.dataGridViewTextBoxColumn207.DataPropertyName = "Quant_Comprada";
            this.dataGridViewTextBoxColumn207.HeaderText = "Quant_Comprada";
            this.dataGridViewTextBoxColumn207.Name = "dataGridViewTextBoxColumn207";
            this.dataGridViewTextBoxColumn207.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn208
            // 
            this.dataGridViewTextBoxColumn208.DataPropertyName = "Quant_Usada";
            this.dataGridViewTextBoxColumn208.HeaderText = "Quant_Usada";
            this.dataGridViewTextBoxColumn208.Name = "dataGridViewTextBoxColumn208";
            this.dataGridViewTextBoxColumn208.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn209
            // 
            this.dataGridViewTextBoxColumn209.DataPropertyName = "Usuario_Logado";
            this.dataGridViewTextBoxColumn209.HeaderText = "Usuario_Logado";
            this.dataGridViewTextBoxColumn209.Name = "dataGridViewTextBoxColumn209";
            this.dataGridViewTextBoxColumn209.ReadOnly = true;
            // 
            // bindingSource5
            // 
            this.bindingSource5.DataMember = "tblAcetona";
            this.bindingSource5.DataSource = this.bDPQServerTSEA;
            // 
            // tblAcetonaTableAdapter
            // 
            this.tblAcetonaTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn210
            // 
            this.dataGridViewTextBoxColumn210.DataPropertyName = "IdProdutosQuimicos";
            this.dataGridViewTextBoxColumn210.HeaderText = "Registro";
            this.dataGridViewTextBoxColumn210.Name = "dataGridViewTextBoxColumn210";
            this.dataGridViewTextBoxColumn210.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn211
            // 
            this.dataGridViewTextBoxColumn211.DataPropertyName = "Produto";
            this.dataGridViewTextBoxColumn211.HeaderText = "Produto";
            this.dataGridViewTextBoxColumn211.Name = "dataGridViewTextBoxColumn211";
            this.dataGridViewTextBoxColumn211.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn212
            // 
            this.dataGridViewTextBoxColumn212.DataPropertyName = "Desenho";
            this.dataGridViewTextBoxColumn212.HeaderText = "Desenho";
            this.dataGridViewTextBoxColumn212.Name = "dataGridViewTextBoxColumn212";
            this.dataGridViewTextBoxColumn212.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn213
            // 
            this.dataGridViewTextBoxColumn213.DataPropertyName = "Numero_NF";
            this.dataGridViewTextBoxColumn213.HeaderText = "Numero_NF";
            this.dataGridViewTextBoxColumn213.Name = "dataGridViewTextBoxColumn213";
            this.dataGridViewTextBoxColumn213.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn214
            // 
            this.dataGridViewTextBoxColumn214.DataPropertyName = "Data_Emissao_NF";
            this.dataGridViewTextBoxColumn214.HeaderText = "Data_Emissao_NF";
            this.dataGridViewTextBoxColumn214.Name = "dataGridViewTextBoxColumn214";
            this.dataGridViewTextBoxColumn214.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn215
            // 
            this.dataGridViewTextBoxColumn215.DataPropertyName = "Numero_Pedido";
            this.dataGridViewTextBoxColumn215.HeaderText = "Numero_Pedido";
            this.dataGridViewTextBoxColumn215.Name = "dataGridViewTextBoxColumn215";
            this.dataGridViewTextBoxColumn215.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn216
            // 
            this.dataGridViewTextBoxColumn216.DataPropertyName = "Data_Pedido";
            this.dataGridViewTextBoxColumn216.HeaderText = "Data_Pedido";
            this.dataGridViewTextBoxColumn216.Name = "dataGridViewTextBoxColumn216";
            this.dataGridViewTextBoxColumn216.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn217
            // 
            this.dataGridViewTextBoxColumn217.DataPropertyName = "Estoque";
            this.dataGridViewTextBoxColumn217.HeaderText = "Estoque";
            this.dataGridViewTextBoxColumn217.Name = "dataGridViewTextBoxColumn217";
            this.dataGridViewTextBoxColumn217.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn218
            // 
            this.dataGridViewTextBoxColumn218.DataPropertyName = "Quant_Comprada";
            this.dataGridViewTextBoxColumn218.HeaderText = "Quant_Comprada";
            this.dataGridViewTextBoxColumn218.Name = "dataGridViewTextBoxColumn218";
            this.dataGridViewTextBoxColumn218.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn219
            // 
            this.dataGridViewTextBoxColumn219.DataPropertyName = "Quant_Usada";
            this.dataGridViewTextBoxColumn219.HeaderText = "Quant_Usada";
            this.dataGridViewTextBoxColumn219.Name = "dataGridViewTextBoxColumn219";
            this.dataGridViewTextBoxColumn219.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn220
            // 
            this.dataGridViewTextBoxColumn220.DataPropertyName = "Usuario_Logado";
            this.dataGridViewTextBoxColumn220.HeaderText = "Usuario_Logado";
            this.dataGridViewTextBoxColumn220.Name = "dataGridViewTextBoxColumn220";
            this.dataGridViewTextBoxColumn220.ReadOnly = true;
            // 
            // bindingSource6
            // 
            this.bindingSource6.DataMember = "tblMetiletilcetona";
            this.bindingSource6.DataSource = this.bDPQServerTSEA;
            // 
            // tblMetiletilcetonaTableAdapter
            // 
            this.tblMetiletilcetonaTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn221
            // 
            this.dataGridViewTextBoxColumn221.DataPropertyName = "IdProdutosQuimicos";
            this.dataGridViewTextBoxColumn221.HeaderText = "Registro";
            this.dataGridViewTextBoxColumn221.Name = "dataGridViewTextBoxColumn221";
            this.dataGridViewTextBoxColumn221.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn222
            // 
            this.dataGridViewTextBoxColumn222.DataPropertyName = "Produto";
            this.dataGridViewTextBoxColumn222.HeaderText = "Produto";
            this.dataGridViewTextBoxColumn222.Name = "dataGridViewTextBoxColumn222";
            this.dataGridViewTextBoxColumn222.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn223
            // 
            this.dataGridViewTextBoxColumn223.DataPropertyName = "Desenho";
            this.dataGridViewTextBoxColumn223.HeaderText = "Desenho";
            this.dataGridViewTextBoxColumn223.Name = "dataGridViewTextBoxColumn223";
            this.dataGridViewTextBoxColumn223.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn224
            // 
            this.dataGridViewTextBoxColumn224.DataPropertyName = "Numero_NF";
            this.dataGridViewTextBoxColumn224.HeaderText = "Numero_NF";
            this.dataGridViewTextBoxColumn224.Name = "dataGridViewTextBoxColumn224";
            this.dataGridViewTextBoxColumn224.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn225
            // 
            this.dataGridViewTextBoxColumn225.DataPropertyName = "Data_Emissao_NF";
            this.dataGridViewTextBoxColumn225.HeaderText = "Data_Emissao_NF";
            this.dataGridViewTextBoxColumn225.Name = "dataGridViewTextBoxColumn225";
            this.dataGridViewTextBoxColumn225.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn226
            // 
            this.dataGridViewTextBoxColumn226.DataPropertyName = "Numero_Pedido";
            this.dataGridViewTextBoxColumn226.HeaderText = "Numero_Pedido";
            this.dataGridViewTextBoxColumn226.Name = "dataGridViewTextBoxColumn226";
            this.dataGridViewTextBoxColumn226.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn227
            // 
            this.dataGridViewTextBoxColumn227.DataPropertyName = "Data_Pedido";
            this.dataGridViewTextBoxColumn227.HeaderText = "Data_Pedido";
            this.dataGridViewTextBoxColumn227.Name = "dataGridViewTextBoxColumn227";
            this.dataGridViewTextBoxColumn227.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn228
            // 
            this.dataGridViewTextBoxColumn228.DataPropertyName = "Estoque";
            this.dataGridViewTextBoxColumn228.HeaderText = "Estoque";
            this.dataGridViewTextBoxColumn228.Name = "dataGridViewTextBoxColumn228";
            this.dataGridViewTextBoxColumn228.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn229
            // 
            this.dataGridViewTextBoxColumn229.DataPropertyName = "Quant_Comprada";
            this.dataGridViewTextBoxColumn229.HeaderText = "Quant_Comprada";
            this.dataGridViewTextBoxColumn229.Name = "dataGridViewTextBoxColumn229";
            this.dataGridViewTextBoxColumn229.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn230
            // 
            this.dataGridViewTextBoxColumn230.DataPropertyName = "Quant_Usada";
            this.dataGridViewTextBoxColumn230.HeaderText = "Quant_Usada";
            this.dataGridViewTextBoxColumn230.Name = "dataGridViewTextBoxColumn230";
            this.dataGridViewTextBoxColumn230.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn231
            // 
            this.dataGridViewTextBoxColumn231.DataPropertyName = "Usuario_Logado";
            this.dataGridViewTextBoxColumn231.HeaderText = "Usuario_Logado";
            this.dataGridViewTextBoxColumn231.Name = "dataGridViewTextBoxColumn231";
            this.dataGridViewTextBoxColumn231.ReadOnly = true;
            // 
            // frm_Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 623);
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
            this.Name = "frm_Cadastro";
            this.ShowIcon = false;
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.Cadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tab_Produtos.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDPQServerTSEA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource6)).EndInit();
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
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox Cx_Item;
        private System.Windows.Forms.DateTimePicker Cx_Data_Emissao_NF;
        private System.Windows.Forms.DateTimePicker Cx_Data_Pedido;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.DataGridView dataGridView6;
        private System.Windows.Forms.TextBox Cx_Usuario_Logado;
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
        private BDPQServerTSEA bDPQServerTSEA;
        private System.Windows.Forms.BindingSource bindingSource1;
        private BDPQServerTSEATableAdapters.tblAcidoCloridricoTableAdapter tblAcidoCloridricoTableAdapter;
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
        private System.Windows.Forms.BindingSource bindingSource2;
        private BDPQServerTSEATableAdapters.tblAcidoSulfuricoTableAdapter tblAcidoSulfuricoTableAdapter;
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
        private System.Windows.Forms.BindingSource bindingSource3;
        private BDPQServerTSEATableAdapters.tblHidroxidoPostasioTableAdapter tblHidroxidoPostasioTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn188;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn189;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn190;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn191;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn192;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn193;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn194;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn195;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn196;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn197;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn198;
        private System.Windows.Forms.BindingSource bindingSource4;
        private BDPQServerTSEATableAdapters.tblToluenoTableAdapter tblToluenoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn199;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn200;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn201;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn202;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn203;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn204;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn205;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn206;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn207;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn208;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn209;
        private System.Windows.Forms.BindingSource bindingSource5;
        private BDPQServerTSEATableAdapters.tblAcetonaTableAdapter tblAcetonaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn210;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn211;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn212;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn213;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn214;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn215;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn216;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn217;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn218;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn219;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn220;
        private System.Windows.Forms.BindingSource bindingSource6;
        private BDPQServerTSEATableAdapters.tblMetiletilcetonaTableAdapter tblMetiletilcetonaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn221;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn222;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn223;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn224;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn225;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn226;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn227;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn228;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn229;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn230;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn231;
    }
}