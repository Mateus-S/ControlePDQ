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
            this.tblAcidoCloridricoBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tblAcidoSulfuricoBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tblHidroxidoPostasioBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.tblToluenoBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.tblAcetonaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.tblMetiletilcetonaBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.tblAcidoSulfuricoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tblHidroxidoPostasioBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.tblToluenoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tblAcetonaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblMetiletilcetonaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tblAcidoCloridricoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblMetiletilcetonaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Cx_Item = new System.Windows.Forms.ComboBox();
            this.Cx_Data_Emissao_NF = new System.Windows.Forms.DateTimePicker();
            this.Cx_Data_Pedido = new System.Windows.Forms.DateTimePicker();
            this.Cx_Usuario_Logado = new System.Windows.Forms.TextBox();
            this.tblAcidoCloridricoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblAcidoCloridricoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tblAcidoSulfuricoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblHidroxidoPostasioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblToluenoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblAcetonaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblMetiletilcetonaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblAcidoSulfuricoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblHidroxidoPostasioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblHidroxidoPostasioBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tblToluenoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblAcidoCloridricoBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.bdAcidoCloridrico = new ControleProdutosQuimicos.BancosBD.BdAcidoCloridrico();
            this.tblAcidoCloridricoBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.tblAcidoCloridricoTableAdapter = new ControleProdutosQuimicos.BancosBD.BdAcidoCloridricoTableAdapters.tblAcidoCloridricoTableAdapter();
            this.dataGridViewTextBoxColumn100 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn101 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn102 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn103 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn104 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn105 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn106 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn107 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn108 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn109 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn110 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdAcidoSulfurico = new ControleProdutosQuimicos.BancosBD.BdAcidoSulfurico();
            this.tblAcidoSulfuricoBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.tblAcidoSulfuricoTableAdapter = new ControleProdutosQuimicos.BancosBD.BdAcidoSulfuricoTableAdapters.tblAcidoSulfuricoTableAdapter();
            this.dataGridViewTextBoxColumn111 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn112 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn113 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn114 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn115 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn116 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn117 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn118 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn119 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn120 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn121 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdHidroxidoPostasio = new ControleProdutosQuimicos.BancosBD.BdHidroxidoPostasio();
            this.tblHidroxidoPostasioBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.tblHidroxidoPostasioTableAdapter = new ControleProdutosQuimicos.BancosBD.BdHidroxidoPostasioTableAdapters.tblHidroxidoPostasioTableAdapter();
            this.dataGridViewTextBoxColumn122 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn123 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn124 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn125 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn126 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn127 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn128 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn129 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn130 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn131 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn132 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdTolueno = new ControleProdutosQuimicos.BancosBD.BdTolueno();
            this.tblToluenoBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.tblToluenoTableAdapter = new ControleProdutosQuimicos.BancosBD.BdToluenoTableAdapters.tblToluenoTableAdapter();
            this.dataGridViewTextBoxColumn133 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn134 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn135 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn136 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn137 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn138 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn139 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn140 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn141 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn142 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn143 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdAcetona = new ControleProdutosQuimicos.BancosBD.BdAcetona();
            this.tblAcetonaBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.tblAcetonaTableAdapter = new ControleProdutosQuimicos.BancosBD.BdAcetonaTableAdapters.tblAcetonaTableAdapter();
            this.dataGridViewTextBoxColumn144 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn145 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn146 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn147 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn148 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn149 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn150 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn151 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn152 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn153 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn154 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdMetiletilcetona = new ControleProdutosQuimicos.BancosBD.BdMetiletilcetona();
            this.tblMetiletilcetonaBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.tblMetiletilcetonaTableAdapter = new ControleProdutosQuimicos.BancosBD.BdMetiletilcetonaTableAdapters.tblMetiletilcetonaTableAdapter();
            this.dataGridViewTextBoxColumn155 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn156 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn157 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn158 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn159 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn160 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn161 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn162 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn163 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn164 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn165 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tab_Produtos.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAcidoCloridricoBindingSource3)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAcidoSulfuricoBindingSource3)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHidroxidoPostasioBindingSource4)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblToluenoBindingSource3)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAcetonaBindingSource2)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMetiletilcetonaBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAcidoSulfuricoBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHidroxidoPostasioBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblToluenoBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAcetonaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMetiletilcetonaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAcidoCloridricoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMetiletilcetonaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAcidoCloridricoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAcidoCloridricoBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAcidoSulfuricoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHidroxidoPostasioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblToluenoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAcetonaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMetiletilcetonaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAcidoSulfuricoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHidroxidoPostasioBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHidroxidoPostasioBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblToluenoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAcidoCloridricoBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdAcidoCloridrico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAcidoCloridricoBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdAcidoSulfurico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAcidoSulfuricoBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdHidroxidoPostasio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHidroxidoPostasioBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdTolueno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblToluenoBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdAcetona)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAcetonaBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdMetiletilcetona)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMetiletilcetonaBindingSource4)).BeginInit();
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
            this.dataGridViewTextBoxColumn100,
            this.dataGridViewTextBoxColumn101,
            this.dataGridViewTextBoxColumn102,
            this.dataGridViewTextBoxColumn103,
            this.dataGridViewTextBoxColumn104,
            this.dataGridViewTextBoxColumn105,
            this.dataGridViewTextBoxColumn106,
            this.dataGridViewTextBoxColumn107,
            this.dataGridViewTextBoxColumn108,
            this.dataGridViewTextBoxColumn109,
            this.dataGridViewTextBoxColumn110});
            this.dataGridView1.DataSource = this.tblAcidoCloridricoBindingSource5;
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
            this.dataGridViewTextBoxColumn111,
            this.dataGridViewTextBoxColumn112,
            this.dataGridViewTextBoxColumn113,
            this.dataGridViewTextBoxColumn114,
            this.dataGridViewTextBoxColumn115,
            this.dataGridViewTextBoxColumn116,
            this.dataGridViewTextBoxColumn117,
            this.dataGridViewTextBoxColumn118,
            this.dataGridViewTextBoxColumn119,
            this.dataGridViewTextBoxColumn120,
            this.dataGridViewTextBoxColumn121});
            this.dataGridView2.DataSource = this.tblAcidoSulfuricoBindingSource4;
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
            this.dataGridViewTextBoxColumn122,
            this.dataGridViewTextBoxColumn123,
            this.dataGridViewTextBoxColumn124,
            this.dataGridViewTextBoxColumn125,
            this.dataGridViewTextBoxColumn126,
            this.dataGridViewTextBoxColumn127,
            this.dataGridViewTextBoxColumn128,
            this.dataGridViewTextBoxColumn129,
            this.dataGridViewTextBoxColumn130,
            this.dataGridViewTextBoxColumn131,
            this.dataGridViewTextBoxColumn132});
            this.dataGridView3.DataSource = this.tblHidroxidoPostasioBindingSource5;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(3, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(1116, 244);
            this.dataGridView3.TabIndex = 2;
            // 
            // tblHidroxidoPostasioBindingSource4
            // 
            this.tblHidroxidoPostasioBindingSource4.DataMember = "tblHidroxidoPostasio";
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
            this.dataGridViewTextBoxColumn133,
            this.dataGridViewTextBoxColumn134,
            this.dataGridViewTextBoxColumn135,
            this.dataGridViewTextBoxColumn136,
            this.dataGridViewTextBoxColumn137,
            this.dataGridViewTextBoxColumn138,
            this.dataGridViewTextBoxColumn139,
            this.dataGridViewTextBoxColumn140,
            this.dataGridViewTextBoxColumn141,
            this.dataGridViewTextBoxColumn142,
            this.dataGridViewTextBoxColumn143});
            this.dataGridView4.DataSource = this.tblToluenoBindingSource4;
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
            this.dataGridViewTextBoxColumn144,
            this.dataGridViewTextBoxColumn145,
            this.dataGridViewTextBoxColumn146,
            this.dataGridViewTextBoxColumn147,
            this.dataGridViewTextBoxColumn148,
            this.dataGridViewTextBoxColumn149,
            this.dataGridViewTextBoxColumn150,
            this.dataGridViewTextBoxColumn151,
            this.dataGridViewTextBoxColumn152,
            this.dataGridViewTextBoxColumn153,
            this.dataGridViewTextBoxColumn154});
            this.dataGridView5.DataSource = this.tblAcetonaBindingSource3;
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
            this.dataGridViewTextBoxColumn155,
            this.dataGridViewTextBoxColumn156,
            this.dataGridViewTextBoxColumn157,
            this.dataGridViewTextBoxColumn158,
            this.dataGridViewTextBoxColumn159,
            this.dataGridViewTextBoxColumn160,
            this.dataGridViewTextBoxColumn161,
            this.dataGridViewTextBoxColumn162,
            this.dataGridViewTextBoxColumn163,
            this.dataGridViewTextBoxColumn164,
            this.dataGridViewTextBoxColumn165});
            this.dataGridView6.DataSource = this.tblMetiletilcetonaBindingSource4;
            this.dataGridView6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView6.Location = new System.Drawing.Point(3, 3);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.ReadOnly = true;
            this.dataGridView6.Size = new System.Drawing.Size(1116, 244);
            this.dataGridView6.TabIndex = 4;
            // 
            // tblAcidoSulfuricoBindingSource2
            // 
            this.tblAcidoSulfuricoBindingSource2.DataMember = "tblAcidoSulfurico";
            // 
            // tblHidroxidoPostasioBindingSource3
            // 
            this.tblHidroxidoPostasioBindingSource3.DataMember = "tblHidroxidoPostasio";
            // 
            // tblToluenoBindingSource2
            // 
            this.tblToluenoBindingSource2.DataMember = "tblTolueno";
            // 
            // tblAcetonaBindingSource1
            // 
            this.tblAcetonaBindingSource1.DataMember = "tblAcetona";
            // 
            // tblMetiletilcetonaBindingSource2
            // 
            this.tblMetiletilcetonaBindingSource2.DataMember = "tblMetiletilcetona";
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
            // tblHidroxidoPostasioBindingSource1
            // 
            this.tblHidroxidoPostasioBindingSource1.DataMember = "tblHidroxidoPostasio";
            // 
            // tblHidroxidoPostasioBindingSource2
            // 
            this.tblHidroxidoPostasioBindingSource2.DataMember = "tblHidroxidoPostasio";
            // 
            // tblToluenoBindingSource1
            // 
            this.tblToluenoBindingSource1.DataMember = "tblTolueno";
            // 
            // bdAcidoCloridrico
            // 
            this.bdAcidoCloridrico.DataSetName = "BdAcidoCloridrico";
            this.bdAcidoCloridrico.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblAcidoCloridricoBindingSource5
            // 
            this.tblAcidoCloridricoBindingSource5.DataMember = "tblAcidoCloridrico";
            this.tblAcidoCloridricoBindingSource5.DataSource = this.bdAcidoCloridrico;
            // 
            // tblAcidoCloridricoTableAdapter
            // 
            this.tblAcidoCloridricoTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn100
            // 
            this.dataGridViewTextBoxColumn100.DataPropertyName = "IdProdutosQuimicos";
            this.dataGridViewTextBoxColumn100.HeaderText = "IdProdutosQuimicos";
            this.dataGridViewTextBoxColumn100.Name = "dataGridViewTextBoxColumn100";
            this.dataGridViewTextBoxColumn100.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn101
            // 
            this.dataGridViewTextBoxColumn101.DataPropertyName = "Produto";
            this.dataGridViewTextBoxColumn101.HeaderText = "Produto";
            this.dataGridViewTextBoxColumn101.Name = "dataGridViewTextBoxColumn101";
            this.dataGridViewTextBoxColumn101.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn102
            // 
            this.dataGridViewTextBoxColumn102.DataPropertyName = "Desenho";
            this.dataGridViewTextBoxColumn102.HeaderText = "Desenho";
            this.dataGridViewTextBoxColumn102.Name = "dataGridViewTextBoxColumn102";
            this.dataGridViewTextBoxColumn102.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn103
            // 
            this.dataGridViewTextBoxColumn103.DataPropertyName = "Numero_NF";
            this.dataGridViewTextBoxColumn103.HeaderText = "Numero_NF";
            this.dataGridViewTextBoxColumn103.Name = "dataGridViewTextBoxColumn103";
            this.dataGridViewTextBoxColumn103.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn104
            // 
            this.dataGridViewTextBoxColumn104.DataPropertyName = "Data_Emissao_NF";
            this.dataGridViewTextBoxColumn104.HeaderText = "Data_Emissao_NF";
            this.dataGridViewTextBoxColumn104.Name = "dataGridViewTextBoxColumn104";
            this.dataGridViewTextBoxColumn104.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn105
            // 
            this.dataGridViewTextBoxColumn105.DataPropertyName = "Numero_Pedido";
            this.dataGridViewTextBoxColumn105.HeaderText = "Numero_Pedido";
            this.dataGridViewTextBoxColumn105.Name = "dataGridViewTextBoxColumn105";
            this.dataGridViewTextBoxColumn105.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn106
            // 
            this.dataGridViewTextBoxColumn106.DataPropertyName = "Data_Pedido";
            this.dataGridViewTextBoxColumn106.HeaderText = "Data_Pedido";
            this.dataGridViewTextBoxColumn106.Name = "dataGridViewTextBoxColumn106";
            this.dataGridViewTextBoxColumn106.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn107
            // 
            this.dataGridViewTextBoxColumn107.DataPropertyName = "Estoque";
            this.dataGridViewTextBoxColumn107.HeaderText = "Estoque";
            this.dataGridViewTextBoxColumn107.Name = "dataGridViewTextBoxColumn107";
            this.dataGridViewTextBoxColumn107.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn108
            // 
            this.dataGridViewTextBoxColumn108.DataPropertyName = "Quant_Comprada";
            this.dataGridViewTextBoxColumn108.HeaderText = "Quant_Comprada";
            this.dataGridViewTextBoxColumn108.Name = "dataGridViewTextBoxColumn108";
            this.dataGridViewTextBoxColumn108.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn109
            // 
            this.dataGridViewTextBoxColumn109.DataPropertyName = "Quant_Usada";
            this.dataGridViewTextBoxColumn109.HeaderText = "Quant_Usada";
            this.dataGridViewTextBoxColumn109.Name = "dataGridViewTextBoxColumn109";
            this.dataGridViewTextBoxColumn109.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn110
            // 
            this.dataGridViewTextBoxColumn110.DataPropertyName = "Usuario_Logado";
            this.dataGridViewTextBoxColumn110.HeaderText = "Usuario_Logado";
            this.dataGridViewTextBoxColumn110.Name = "dataGridViewTextBoxColumn110";
            this.dataGridViewTextBoxColumn110.ReadOnly = true;
            // 
            // bdAcidoSulfurico
            // 
            this.bdAcidoSulfurico.DataSetName = "BdAcidoSulfurico";
            this.bdAcidoSulfurico.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblAcidoSulfuricoBindingSource4
            // 
            this.tblAcidoSulfuricoBindingSource4.DataMember = "tblAcidoSulfurico";
            this.tblAcidoSulfuricoBindingSource4.DataSource = this.bdAcidoSulfurico;
            // 
            // tblAcidoSulfuricoTableAdapter
            // 
            this.tblAcidoSulfuricoTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn111
            // 
            this.dataGridViewTextBoxColumn111.DataPropertyName = "IdProdutosQuimicos";
            this.dataGridViewTextBoxColumn111.HeaderText = "IdProdutosQuimicos";
            this.dataGridViewTextBoxColumn111.Name = "dataGridViewTextBoxColumn111";
            this.dataGridViewTextBoxColumn111.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn112
            // 
            this.dataGridViewTextBoxColumn112.DataPropertyName = "Produto";
            this.dataGridViewTextBoxColumn112.HeaderText = "Produto";
            this.dataGridViewTextBoxColumn112.Name = "dataGridViewTextBoxColumn112";
            this.dataGridViewTextBoxColumn112.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn113
            // 
            this.dataGridViewTextBoxColumn113.DataPropertyName = "Desenho";
            this.dataGridViewTextBoxColumn113.HeaderText = "Desenho";
            this.dataGridViewTextBoxColumn113.Name = "dataGridViewTextBoxColumn113";
            this.dataGridViewTextBoxColumn113.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn114
            // 
            this.dataGridViewTextBoxColumn114.DataPropertyName = "Numero_NF";
            this.dataGridViewTextBoxColumn114.HeaderText = "Numero_NF";
            this.dataGridViewTextBoxColumn114.Name = "dataGridViewTextBoxColumn114";
            this.dataGridViewTextBoxColumn114.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn115
            // 
            this.dataGridViewTextBoxColumn115.DataPropertyName = "Data_Emissao_NF";
            this.dataGridViewTextBoxColumn115.HeaderText = "Data_Emissao_NF";
            this.dataGridViewTextBoxColumn115.Name = "dataGridViewTextBoxColumn115";
            this.dataGridViewTextBoxColumn115.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn116
            // 
            this.dataGridViewTextBoxColumn116.DataPropertyName = "Numero_Pedido";
            this.dataGridViewTextBoxColumn116.HeaderText = "Numero_Pedido";
            this.dataGridViewTextBoxColumn116.Name = "dataGridViewTextBoxColumn116";
            this.dataGridViewTextBoxColumn116.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn117
            // 
            this.dataGridViewTextBoxColumn117.DataPropertyName = "Data_Pedido";
            this.dataGridViewTextBoxColumn117.HeaderText = "Data_Pedido";
            this.dataGridViewTextBoxColumn117.Name = "dataGridViewTextBoxColumn117";
            this.dataGridViewTextBoxColumn117.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn118
            // 
            this.dataGridViewTextBoxColumn118.DataPropertyName = "Estoque";
            this.dataGridViewTextBoxColumn118.HeaderText = "Estoque";
            this.dataGridViewTextBoxColumn118.Name = "dataGridViewTextBoxColumn118";
            this.dataGridViewTextBoxColumn118.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn119
            // 
            this.dataGridViewTextBoxColumn119.DataPropertyName = "Quant_Comprada";
            this.dataGridViewTextBoxColumn119.HeaderText = "Quant_Comprada";
            this.dataGridViewTextBoxColumn119.Name = "dataGridViewTextBoxColumn119";
            this.dataGridViewTextBoxColumn119.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn120
            // 
            this.dataGridViewTextBoxColumn120.DataPropertyName = "Quant_Usada";
            this.dataGridViewTextBoxColumn120.HeaderText = "Quant_Usada";
            this.dataGridViewTextBoxColumn120.Name = "dataGridViewTextBoxColumn120";
            this.dataGridViewTextBoxColumn120.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn121
            // 
            this.dataGridViewTextBoxColumn121.DataPropertyName = "Usuario_Logado";
            this.dataGridViewTextBoxColumn121.HeaderText = "Usuario_Logado";
            this.dataGridViewTextBoxColumn121.Name = "dataGridViewTextBoxColumn121";
            this.dataGridViewTextBoxColumn121.ReadOnly = true;
            // 
            // bdHidroxidoPostasio
            // 
            this.bdHidroxidoPostasio.DataSetName = "BdHidroxidoPostasio";
            this.bdHidroxidoPostasio.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblHidroxidoPostasioBindingSource5
            // 
            this.tblHidroxidoPostasioBindingSource5.DataMember = "tblHidroxidoPostasio";
            this.tblHidroxidoPostasioBindingSource5.DataSource = this.bdHidroxidoPostasio;
            // 
            // tblHidroxidoPostasioTableAdapter
            // 
            this.tblHidroxidoPostasioTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn122
            // 
            this.dataGridViewTextBoxColumn122.DataPropertyName = "IdProdutosQuimicos";
            this.dataGridViewTextBoxColumn122.HeaderText = "IdProdutosQuimicos";
            this.dataGridViewTextBoxColumn122.Name = "dataGridViewTextBoxColumn122";
            this.dataGridViewTextBoxColumn122.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn123
            // 
            this.dataGridViewTextBoxColumn123.DataPropertyName = "Produto";
            this.dataGridViewTextBoxColumn123.HeaderText = "Produto";
            this.dataGridViewTextBoxColumn123.Name = "dataGridViewTextBoxColumn123";
            this.dataGridViewTextBoxColumn123.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn124
            // 
            this.dataGridViewTextBoxColumn124.DataPropertyName = "Desenho";
            this.dataGridViewTextBoxColumn124.HeaderText = "Desenho";
            this.dataGridViewTextBoxColumn124.Name = "dataGridViewTextBoxColumn124";
            this.dataGridViewTextBoxColumn124.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn125
            // 
            this.dataGridViewTextBoxColumn125.DataPropertyName = "Numero_NF";
            this.dataGridViewTextBoxColumn125.HeaderText = "Numero_NF";
            this.dataGridViewTextBoxColumn125.Name = "dataGridViewTextBoxColumn125";
            this.dataGridViewTextBoxColumn125.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn126
            // 
            this.dataGridViewTextBoxColumn126.DataPropertyName = "Data_Emissao_NF";
            this.dataGridViewTextBoxColumn126.HeaderText = "Data_Emissao_NF";
            this.dataGridViewTextBoxColumn126.Name = "dataGridViewTextBoxColumn126";
            this.dataGridViewTextBoxColumn126.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn127
            // 
            this.dataGridViewTextBoxColumn127.DataPropertyName = "Numero_Pedido";
            this.dataGridViewTextBoxColumn127.HeaderText = "Numero_Pedido";
            this.dataGridViewTextBoxColumn127.Name = "dataGridViewTextBoxColumn127";
            this.dataGridViewTextBoxColumn127.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn128
            // 
            this.dataGridViewTextBoxColumn128.DataPropertyName = "Data_Pedido";
            this.dataGridViewTextBoxColumn128.HeaderText = "Data_Pedido";
            this.dataGridViewTextBoxColumn128.Name = "dataGridViewTextBoxColumn128";
            this.dataGridViewTextBoxColumn128.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn129
            // 
            this.dataGridViewTextBoxColumn129.DataPropertyName = "Estoque";
            this.dataGridViewTextBoxColumn129.HeaderText = "Estoque";
            this.dataGridViewTextBoxColumn129.Name = "dataGridViewTextBoxColumn129";
            this.dataGridViewTextBoxColumn129.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn130
            // 
            this.dataGridViewTextBoxColumn130.DataPropertyName = "Quant_Comprada";
            this.dataGridViewTextBoxColumn130.HeaderText = "Quant_Comprada";
            this.dataGridViewTextBoxColumn130.Name = "dataGridViewTextBoxColumn130";
            this.dataGridViewTextBoxColumn130.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn131
            // 
            this.dataGridViewTextBoxColumn131.DataPropertyName = "Quant_Usada";
            this.dataGridViewTextBoxColumn131.HeaderText = "Quant_Usada";
            this.dataGridViewTextBoxColumn131.Name = "dataGridViewTextBoxColumn131";
            this.dataGridViewTextBoxColumn131.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn132
            // 
            this.dataGridViewTextBoxColumn132.DataPropertyName = "Usuario_Logado";
            this.dataGridViewTextBoxColumn132.HeaderText = "Usuario_Logado";
            this.dataGridViewTextBoxColumn132.Name = "dataGridViewTextBoxColumn132";
            this.dataGridViewTextBoxColumn132.ReadOnly = true;
            // 
            // bdTolueno
            // 
            this.bdTolueno.DataSetName = "BdTolueno";
            this.bdTolueno.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblToluenoBindingSource4
            // 
            this.tblToluenoBindingSource4.DataMember = "tblTolueno";
            this.tblToluenoBindingSource4.DataSource = this.bdTolueno;
            // 
            // tblToluenoTableAdapter
            // 
            this.tblToluenoTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn133
            // 
            this.dataGridViewTextBoxColumn133.DataPropertyName = "IdProdutosQuimicos";
            this.dataGridViewTextBoxColumn133.HeaderText = "IdProdutosQuimicos";
            this.dataGridViewTextBoxColumn133.Name = "dataGridViewTextBoxColumn133";
            this.dataGridViewTextBoxColumn133.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn134
            // 
            this.dataGridViewTextBoxColumn134.DataPropertyName = "Produto";
            this.dataGridViewTextBoxColumn134.HeaderText = "Produto";
            this.dataGridViewTextBoxColumn134.Name = "dataGridViewTextBoxColumn134";
            this.dataGridViewTextBoxColumn134.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn135
            // 
            this.dataGridViewTextBoxColumn135.DataPropertyName = "Desenho";
            this.dataGridViewTextBoxColumn135.HeaderText = "Desenho";
            this.dataGridViewTextBoxColumn135.Name = "dataGridViewTextBoxColumn135";
            this.dataGridViewTextBoxColumn135.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn136
            // 
            this.dataGridViewTextBoxColumn136.DataPropertyName = "Numero_NF";
            this.dataGridViewTextBoxColumn136.HeaderText = "Numero_NF";
            this.dataGridViewTextBoxColumn136.Name = "dataGridViewTextBoxColumn136";
            this.dataGridViewTextBoxColumn136.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn137
            // 
            this.dataGridViewTextBoxColumn137.DataPropertyName = "Data_Emissao_NF";
            this.dataGridViewTextBoxColumn137.HeaderText = "Data_Emissao_NF";
            this.dataGridViewTextBoxColumn137.Name = "dataGridViewTextBoxColumn137";
            this.dataGridViewTextBoxColumn137.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn138
            // 
            this.dataGridViewTextBoxColumn138.DataPropertyName = "Numero_Pedido";
            this.dataGridViewTextBoxColumn138.HeaderText = "Numero_Pedido";
            this.dataGridViewTextBoxColumn138.Name = "dataGridViewTextBoxColumn138";
            this.dataGridViewTextBoxColumn138.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn139
            // 
            this.dataGridViewTextBoxColumn139.DataPropertyName = "Data_Pedido";
            this.dataGridViewTextBoxColumn139.HeaderText = "Data_Pedido";
            this.dataGridViewTextBoxColumn139.Name = "dataGridViewTextBoxColumn139";
            this.dataGridViewTextBoxColumn139.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn140
            // 
            this.dataGridViewTextBoxColumn140.DataPropertyName = "Estoque";
            this.dataGridViewTextBoxColumn140.HeaderText = "Estoque";
            this.dataGridViewTextBoxColumn140.Name = "dataGridViewTextBoxColumn140";
            this.dataGridViewTextBoxColumn140.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn141
            // 
            this.dataGridViewTextBoxColumn141.DataPropertyName = "Quant_Comprada";
            this.dataGridViewTextBoxColumn141.HeaderText = "Quant_Comprada";
            this.dataGridViewTextBoxColumn141.Name = "dataGridViewTextBoxColumn141";
            this.dataGridViewTextBoxColumn141.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn142
            // 
            this.dataGridViewTextBoxColumn142.DataPropertyName = "Quant_Usada";
            this.dataGridViewTextBoxColumn142.HeaderText = "Quant_Usada";
            this.dataGridViewTextBoxColumn142.Name = "dataGridViewTextBoxColumn142";
            this.dataGridViewTextBoxColumn142.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn143
            // 
            this.dataGridViewTextBoxColumn143.DataPropertyName = "Usuario_Logado";
            this.dataGridViewTextBoxColumn143.HeaderText = "Usuario_Logado";
            this.dataGridViewTextBoxColumn143.Name = "dataGridViewTextBoxColumn143";
            this.dataGridViewTextBoxColumn143.ReadOnly = true;
            // 
            // bdAcetona
            // 
            this.bdAcetona.DataSetName = "BdAcetona";
            this.bdAcetona.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblAcetonaBindingSource3
            // 
            this.tblAcetonaBindingSource3.DataMember = "tblAcetona";
            this.tblAcetonaBindingSource3.DataSource = this.bdAcetona;
            // 
            // tblAcetonaTableAdapter
            // 
            this.tblAcetonaTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn144
            // 
            this.dataGridViewTextBoxColumn144.DataPropertyName = "IdProdutosQuimicos";
            this.dataGridViewTextBoxColumn144.HeaderText = "IdProdutosQuimicos";
            this.dataGridViewTextBoxColumn144.Name = "dataGridViewTextBoxColumn144";
            this.dataGridViewTextBoxColumn144.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn145
            // 
            this.dataGridViewTextBoxColumn145.DataPropertyName = "Produto";
            this.dataGridViewTextBoxColumn145.HeaderText = "Produto";
            this.dataGridViewTextBoxColumn145.Name = "dataGridViewTextBoxColumn145";
            this.dataGridViewTextBoxColumn145.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn146
            // 
            this.dataGridViewTextBoxColumn146.DataPropertyName = "Desenho";
            this.dataGridViewTextBoxColumn146.HeaderText = "Desenho";
            this.dataGridViewTextBoxColumn146.Name = "dataGridViewTextBoxColumn146";
            this.dataGridViewTextBoxColumn146.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn147
            // 
            this.dataGridViewTextBoxColumn147.DataPropertyName = "Numero_NF";
            this.dataGridViewTextBoxColumn147.HeaderText = "Numero_NF";
            this.dataGridViewTextBoxColumn147.Name = "dataGridViewTextBoxColumn147";
            this.dataGridViewTextBoxColumn147.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn148
            // 
            this.dataGridViewTextBoxColumn148.DataPropertyName = "Data_Emissao_NF";
            this.dataGridViewTextBoxColumn148.HeaderText = "Data_Emissao_NF";
            this.dataGridViewTextBoxColumn148.Name = "dataGridViewTextBoxColumn148";
            this.dataGridViewTextBoxColumn148.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn149
            // 
            this.dataGridViewTextBoxColumn149.DataPropertyName = "Numero_Pedido";
            this.dataGridViewTextBoxColumn149.HeaderText = "Numero_Pedido";
            this.dataGridViewTextBoxColumn149.Name = "dataGridViewTextBoxColumn149";
            this.dataGridViewTextBoxColumn149.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn150
            // 
            this.dataGridViewTextBoxColumn150.DataPropertyName = "Data_Pedido";
            this.dataGridViewTextBoxColumn150.HeaderText = "Data_Pedido";
            this.dataGridViewTextBoxColumn150.Name = "dataGridViewTextBoxColumn150";
            this.dataGridViewTextBoxColumn150.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn151
            // 
            this.dataGridViewTextBoxColumn151.DataPropertyName = "Estoque";
            this.dataGridViewTextBoxColumn151.HeaderText = "Estoque";
            this.dataGridViewTextBoxColumn151.Name = "dataGridViewTextBoxColumn151";
            this.dataGridViewTextBoxColumn151.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn152
            // 
            this.dataGridViewTextBoxColumn152.DataPropertyName = "Quant_Comprada";
            this.dataGridViewTextBoxColumn152.HeaderText = "Quant_Comprada";
            this.dataGridViewTextBoxColumn152.Name = "dataGridViewTextBoxColumn152";
            this.dataGridViewTextBoxColumn152.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn153
            // 
            this.dataGridViewTextBoxColumn153.DataPropertyName = "Quant_Usada";
            this.dataGridViewTextBoxColumn153.HeaderText = "Quant_Usada";
            this.dataGridViewTextBoxColumn153.Name = "dataGridViewTextBoxColumn153";
            this.dataGridViewTextBoxColumn153.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn154
            // 
            this.dataGridViewTextBoxColumn154.DataPropertyName = "Usuario_Logado";
            this.dataGridViewTextBoxColumn154.HeaderText = "Usuario_Logado";
            this.dataGridViewTextBoxColumn154.Name = "dataGridViewTextBoxColumn154";
            this.dataGridViewTextBoxColumn154.ReadOnly = true;
            // 
            // bdMetiletilcetona
            // 
            this.bdMetiletilcetona.DataSetName = "BdMetiletilcetona";
            this.bdMetiletilcetona.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblMetiletilcetonaBindingSource4
            // 
            this.tblMetiletilcetonaBindingSource4.DataMember = "tblMetiletilcetona";
            this.tblMetiletilcetonaBindingSource4.DataSource = this.bdMetiletilcetona;
            // 
            // tblMetiletilcetonaTableAdapter
            // 
            this.tblMetiletilcetonaTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn155
            // 
            this.dataGridViewTextBoxColumn155.DataPropertyName = "IdProdutosQuimicos";
            this.dataGridViewTextBoxColumn155.HeaderText = "IdProdutosQuimicos";
            this.dataGridViewTextBoxColumn155.Name = "dataGridViewTextBoxColumn155";
            this.dataGridViewTextBoxColumn155.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn156
            // 
            this.dataGridViewTextBoxColumn156.DataPropertyName = "Produto";
            this.dataGridViewTextBoxColumn156.HeaderText = "Produto";
            this.dataGridViewTextBoxColumn156.Name = "dataGridViewTextBoxColumn156";
            this.dataGridViewTextBoxColumn156.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn157
            // 
            this.dataGridViewTextBoxColumn157.DataPropertyName = "Desenho";
            this.dataGridViewTextBoxColumn157.HeaderText = "Desenho";
            this.dataGridViewTextBoxColumn157.Name = "dataGridViewTextBoxColumn157";
            this.dataGridViewTextBoxColumn157.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn158
            // 
            this.dataGridViewTextBoxColumn158.DataPropertyName = "Numero_NF";
            this.dataGridViewTextBoxColumn158.HeaderText = "Numero_NF";
            this.dataGridViewTextBoxColumn158.Name = "dataGridViewTextBoxColumn158";
            this.dataGridViewTextBoxColumn158.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn159
            // 
            this.dataGridViewTextBoxColumn159.DataPropertyName = "Data_Emissao_NF";
            this.dataGridViewTextBoxColumn159.HeaderText = "Data_Emissao_NF";
            this.dataGridViewTextBoxColumn159.Name = "dataGridViewTextBoxColumn159";
            this.dataGridViewTextBoxColumn159.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn160
            // 
            this.dataGridViewTextBoxColumn160.DataPropertyName = "Numero_Pedido";
            this.dataGridViewTextBoxColumn160.HeaderText = "Numero_Pedido";
            this.dataGridViewTextBoxColumn160.Name = "dataGridViewTextBoxColumn160";
            this.dataGridViewTextBoxColumn160.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn161
            // 
            this.dataGridViewTextBoxColumn161.DataPropertyName = "Data_Pedido";
            this.dataGridViewTextBoxColumn161.HeaderText = "Data_Pedido";
            this.dataGridViewTextBoxColumn161.Name = "dataGridViewTextBoxColumn161";
            this.dataGridViewTextBoxColumn161.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn162
            // 
            this.dataGridViewTextBoxColumn162.DataPropertyName = "Estoque";
            this.dataGridViewTextBoxColumn162.HeaderText = "Estoque";
            this.dataGridViewTextBoxColumn162.Name = "dataGridViewTextBoxColumn162";
            this.dataGridViewTextBoxColumn162.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn163
            // 
            this.dataGridViewTextBoxColumn163.DataPropertyName = "Quant_Comprada";
            this.dataGridViewTextBoxColumn163.HeaderText = "Quant_Comprada";
            this.dataGridViewTextBoxColumn163.Name = "dataGridViewTextBoxColumn163";
            this.dataGridViewTextBoxColumn163.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn164
            // 
            this.dataGridViewTextBoxColumn164.DataPropertyName = "Quant_Usada";
            this.dataGridViewTextBoxColumn164.HeaderText = "Quant_Usada";
            this.dataGridViewTextBoxColumn164.Name = "dataGridViewTextBoxColumn164";
            this.dataGridViewTextBoxColumn164.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn165
            // 
            this.dataGridViewTextBoxColumn165.DataPropertyName = "Usuario_Logado";
            this.dataGridViewTextBoxColumn165.HeaderText = "Usuario_Logado";
            this.dataGridViewTextBoxColumn165.Name = "dataGridViewTextBoxColumn165";
            this.dataGridViewTextBoxColumn165.ReadOnly = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.tblAcidoCloridricoBindingSource3)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAcidoSulfuricoBindingSource3)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHidroxidoPostasioBindingSource4)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblToluenoBindingSource3)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAcetonaBindingSource2)).EndInit();
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMetiletilcetonaBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAcidoSulfuricoBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHidroxidoPostasioBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblToluenoBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAcetonaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMetiletilcetonaBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAcidoCloridricoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMetiletilcetonaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAcidoCloridricoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAcidoCloridricoBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAcidoSulfuricoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHidroxidoPostasioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblToluenoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAcetonaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMetiletilcetonaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAcidoSulfuricoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHidroxidoPostasioBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHidroxidoPostasioBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblToluenoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAcidoCloridricoBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdAcidoCloridrico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAcidoCloridricoBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdAcidoSulfurico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAcidoSulfuricoBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdHidroxidoPostasio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblHidroxidoPostasioBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdTolueno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblToluenoBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdAcetona)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAcetonaBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdMetiletilcetona)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMetiletilcetonaBindingSource4)).EndInit();
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
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox Cx_Item;
        private System.Windows.Forms.DateTimePicker Cx_Data_Emissao_NF;
        private System.Windows.Forms.DateTimePicker Cx_Data_Pedido;
        private System.Windows.Forms.TextBox Cx_Usuario_Logado;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.BindingSource tblMetiletilcetonaBindingSource;
        private System.Windows.Forms.BindingSource tblAcidoCloridricoBindingSource;
        private System.Windows.Forms.BindingSource tblAcidoCloridricoBindingSource1;
        private System.Windows.Forms.BindingSource tblMetiletilcetonaBindingSource1;
        private System.Windows.Forms.BindingSource tblAcidoSulfuricoBindingSource;
        private System.Windows.Forms.BindingSource tblAcidoCloridricoBindingSource2;
        private System.Windows.Forms.BindingSource tblHidroxidoPostasioBindingSource;
        private System.Windows.Forms.BindingSource tblToluenoBindingSource;
        private System.Windows.Forms.BindingSource tblAcetonaBindingSource;
        private System.Windows.Forms.BindingSource tblAcidoSulfuricoBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tblAcidoCloridricoBindingSource3;
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
        private System.Windows.Forms.DataGridView dataGridView2;
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
        private System.Windows.Forms.BindingSource tblAcidoSulfuricoBindingSource2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource tblHidroxidoPostasioBindingSource1;
        private System.Windows.Forms.BindingSource tblHidroxidoPostasioBindingSource2;
        private System.Windows.Forms.DataGridView dataGridView4;
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
        private System.Windows.Forms.BindingSource tblToluenoBindingSource1;
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
        private System.Windows.Forms.BindingSource tblHidroxidoPostasioBindingSource3;
        private System.Windows.Forms.BindingSource tblToluenoBindingSource2;
        private System.Windows.Forms.DataGridView dataGridView5;
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
        private System.Windows.Forms.BindingSource tblAcetonaBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView6;
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
        private System.Windows.Forms.BindingSource tblMetiletilcetonaBindingSource2;
        private System.Windows.Forms.BindingSource tblAcidoSulfuricoBindingSource3;
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
        private System.Windows.Forms.BindingSource tblHidroxidoPostasioBindingSource4;
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
        private System.Windows.Forms.BindingSource tblToluenoBindingSource3;
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
        private System.Windows.Forms.BindingSource tblAcetonaBindingSource2;
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
        private System.Windows.Forms.BindingSource tblMetiletilcetonaBindingSource3;
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
        private System.Windows.Forms.BindingSource tblAcidoCloridricoBindingSource4;
        private BancosBD.BdAcidoCloridrico bdAcidoCloridrico;
        private System.Windows.Forms.BindingSource tblAcidoCloridricoBindingSource5;
        private BancosBD.BdAcidoCloridricoTableAdapters.tblAcidoCloridricoTableAdapter tblAcidoCloridricoTableAdapter;
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
        private BancosBD.BdAcidoSulfurico bdAcidoSulfurico;
        private System.Windows.Forms.BindingSource tblAcidoSulfuricoBindingSource4;
        private BancosBD.BdAcidoSulfuricoTableAdapters.tblAcidoSulfuricoTableAdapter tblAcidoSulfuricoTableAdapter;
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
        private BancosBD.BdHidroxidoPostasio bdHidroxidoPostasio;
        private System.Windows.Forms.BindingSource tblHidroxidoPostasioBindingSource5;
        private BancosBD.BdHidroxidoPostasioTableAdapters.tblHidroxidoPostasioTableAdapter tblHidroxidoPostasioTableAdapter;
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
        private BancosBD.BdTolueno bdTolueno;
        private System.Windows.Forms.BindingSource tblToluenoBindingSource4;
        private BancosBD.BdToluenoTableAdapters.tblToluenoTableAdapter tblToluenoTableAdapter;
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
        private BancosBD.BdAcetona bdAcetona;
        private System.Windows.Forms.BindingSource tblAcetonaBindingSource3;
        private BancosBD.BdAcetonaTableAdapters.tblAcetonaTableAdapter tblAcetonaTableAdapter;
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
        private BancosBD.BdMetiletilcetona bdMetiletilcetona;
        private System.Windows.Forms.BindingSource tblMetiletilcetonaBindingSource4;
        private BancosBD.BdMetiletilcetonaTableAdapters.tblMetiletilcetonaTableAdapter tblMetiletilcetonaTableAdapter;
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
    }
}