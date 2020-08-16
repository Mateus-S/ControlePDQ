namespace ControleProdutosQuimicos.Apresentação
{
    partial class frm_ExportarExcel
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
            this.Cx_Produto_ExportarExcel = new System.Windows.Forms.ComboBox();
            this.lbl_Escolher_Produto_ExportExcel = new MetroFramework.Controls.MetroLabel();
            this.btn_Gerar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Cx_Produto_ExportarExcel
            // 
            this.Cx_Produto_ExportarExcel.BackColor = System.Drawing.SystemColors.Menu;
            this.Cx_Produto_ExportarExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cx_Produto_ExportarExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cx_Produto_ExportarExcel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cx_Produto_ExportarExcel.FormattingEnabled = true;
            this.Cx_Produto_ExportarExcel.Items.AddRange(new object[] {
            "Ácido Cloridrico",
            "Ácido Sulfúrico",
            "Hidróxido De Potássio",
            "Tolueno",
            "Acetona",
            "Metiletilcetona"});
            this.Cx_Produto_ExportarExcel.Location = new System.Drawing.Point(64, 63);
            this.Cx_Produto_ExportarExcel.Name = "Cx_Produto_ExportarExcel";
            this.Cx_Produto_ExportarExcel.Size = new System.Drawing.Size(274, 28);
            this.Cx_Produto_ExportarExcel.TabIndex = 16;
            this.Cx_Produto_ExportarExcel.Tag = "{Selecione}";
            // 
            // lbl_Escolher_Produto_ExportExcel
            // 
            this.lbl_Escolher_Produto_ExportExcel.AutoSize = true;
            this.lbl_Escolher_Produto_ExportExcel.Location = new System.Drawing.Point(85, 27);
            this.lbl_Escolher_Produto_ExportExcel.Name = "lbl_Escolher_Produto_ExportExcel";
            this.lbl_Escolher_Produto_ExportExcel.Size = new System.Drawing.Size(238, 19);
            this.lbl_Escolher_Produto_ExportExcel.TabIndex = 17;
            this.lbl_Escolher_Produto_ExportExcel.Text = "Escolha o Produto que queira Exportar";
            // 
            // btn_Gerar
            // 
            this.btn_Gerar.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btn_Gerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Gerar.FlatAppearance.BorderSize = 0;
            this.btn_Gerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Gerar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Gerar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_Gerar.Location = new System.Drawing.Point(155, 104);
            this.btn_Gerar.Name = "btn_Gerar";
            this.btn_Gerar.Size = new System.Drawing.Size(105, 28);
            this.btn_Gerar.TabIndex = 31;
            this.btn_Gerar.Text = "Gerar";
            this.btn_Gerar.UseVisualStyleBackColor = false;
            this.btn_Gerar.Click += new System.EventHandler(this.btn_Gerar_Click);
            // 
            // frm_ExportarExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 156);
            this.Controls.Add(this.btn_Gerar);
            this.Controls.Add(this.lbl_Escolher_Produto_ExportExcel);
            this.Controls.Add(this.Cx_Produto_ExportarExcel);
            this.Name = "frm_ExportarExcel";
            this.Load += new System.EventHandler(this.ExportarExcel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Cx_Produto_ExportarExcel;
        private MetroFramework.Controls.MetroLabel lbl_Escolher_Produto_ExportExcel;
        private System.Windows.Forms.Button btn_Gerar;
    }
}