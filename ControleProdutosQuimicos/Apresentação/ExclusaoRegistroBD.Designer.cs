namespace ControleProdutosQuimicos.Apresentação
{
    partial class frm_ExclusaoRegistroBD
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
            this.Cx_ExclusaoRegistro = new MetroFramework.Controls.MetroTextBox();
            this.btn_ConfirmarExclusao = new System.Windows.Forms.Button();
            this.Cx_ExclusaoProduto = new System.Windows.Forms.ComboBox();
            this.btn_CancelarExclusao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Cx_ExclusaoRegistro
            // 
            this.Cx_ExclusaoRegistro.Location = new System.Drawing.Point(34, 49);
            this.Cx_ExclusaoRegistro.Name = "Cx_ExclusaoRegistro";
            this.Cx_ExclusaoRegistro.Size = new System.Drawing.Size(118, 23);
            this.Cx_ExclusaoRegistro.TabIndex = 0;
            // 
            // btn_ConfirmarExclusao
            // 
            this.btn_ConfirmarExclusao.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btn_ConfirmarExclusao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ConfirmarExclusao.FlatAppearance.BorderSize = 0;
            this.btn_ConfirmarExclusao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ConfirmarExclusao.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.btn_ConfirmarExclusao.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_ConfirmarExclusao.Location = new System.Drawing.Point(150, 90);
            this.btn_ConfirmarExclusao.Name = "btn_ConfirmarExclusao";
            this.btn_ConfirmarExclusao.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_ConfirmarExclusao.Size = new System.Drawing.Size(76, 26);
            this.btn_ConfirmarExclusao.TabIndex = 25;
            this.btn_ConfirmarExclusao.Text = "Confirmar";
            this.btn_ConfirmarExclusao.UseVisualStyleBackColor = false;
            this.btn_ConfirmarExclusao.Click += new System.EventHandler(this.btn_ConfirmarExclusao_Click);
            // 
            // Cx_ExclusaoProduto
            // 
            this.Cx_ExclusaoProduto.BackColor = System.Drawing.SystemColors.Menu;
            this.Cx_ExclusaoProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cx_ExclusaoProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cx_ExclusaoProduto.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cx_ExclusaoProduto.FormattingEnabled = true;
            this.Cx_ExclusaoProduto.Items.AddRange(new object[] {
            "Ácido Cloridrico",
            "Ácido Sulfúrico",
            "Hidróxido De Potássio",
            "Tolueno",
            "Acetona",
            "Metiletilcetona"});
            this.Cx_ExclusaoProduto.Location = new System.Drawing.Point(190, 44);
            this.Cx_ExclusaoProduto.Name = "Cx_ExclusaoProduto";
            this.Cx_ExclusaoProduto.Size = new System.Drawing.Size(274, 28);
            this.Cx_ExclusaoProduto.TabIndex = 26;
            this.Cx_ExclusaoProduto.Tag = "{Selecione}";
            this.Cx_ExclusaoProduto.SelectedIndexChanged += new System.EventHandler(this.Cx_ExclusaoProduto_SelectedIndexChanged);
            // 
            // btn_CancelarExclusao
            // 
            this.btn_CancelarExclusao.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btn_CancelarExclusao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CancelarExclusao.FlatAppearance.BorderSize = 0;
            this.btn_CancelarExclusao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CancelarExclusao.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.btn_CancelarExclusao.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_CancelarExclusao.Location = new System.Drawing.Point(276, 90);
            this.btn_CancelarExclusao.Name = "btn_CancelarExclusao";
            this.btn_CancelarExclusao.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_CancelarExclusao.Size = new System.Drawing.Size(76, 26);
            this.btn_CancelarExclusao.TabIndex = 27;
            this.btn_CancelarExclusao.Text = "Cancelar";
            this.btn_CancelarExclusao.UseVisualStyleBackColor = false;
            this.btn_CancelarExclusao.Click += new System.EventHandler(this.btn_CancelarExclusao_Click);
            // 
            // frm_ExclusaoRegistroBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 123);
            this.Controls.Add(this.btn_CancelarExclusao);
            this.Controls.Add(this.Cx_ExclusaoProduto);
            this.Controls.Add(this.btn_ConfirmarExclusao);
            this.Controls.Add(this.Cx_ExclusaoRegistro);
            this.Name = "frm_ExclusaoRegistroBD";
            this.Load += new System.EventHandler(this.ExclusaoRegistroBD_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public MetroFramework.Controls.MetroTextBox Cx_ExclusaoRegistro;
        public System.Windows.Forms.Button btn_ConfirmarExclusao;
        public System.Windows.Forms.ComboBox Cx_ExclusaoProduto;
        public System.Windows.Forms.Button btn_CancelarExclusao;
    }
}