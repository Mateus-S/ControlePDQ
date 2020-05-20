namespace ControleProdutosQuimicos.Apresentação
{
    partial class frm_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Menu));
            this.btn_NovoUsuario = new System.Windows.Forms.Button();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.btn_SairMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_NovoUsuario
            // 
            this.btn_NovoUsuario.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btn_NovoUsuario.FlatAppearance.BorderSize = 0;
            this.btn_NovoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NovoUsuario.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.btn_NovoUsuario.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_NovoUsuario.Image = ((System.Drawing.Image)(resources.GetObject("btn_NovoUsuario.Image")));
            this.btn_NovoUsuario.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_NovoUsuario.Location = new System.Drawing.Point(123, 76);
            this.btn_NovoUsuario.Name = "btn_NovoUsuario";
            this.btn_NovoUsuario.Size = new System.Drawing.Size(77, 68);
            this.btn_NovoUsuario.TabIndex = 8;
            this.btn_NovoUsuario.Text = "Novo Usuario";
            this.btn_NovoUsuario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_NovoUsuario.UseVisualStyleBackColor = false;
            this.btn_NovoUsuario.Click += new System.EventHandler(this.btn_NovoUsuario_Click);
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btn_cadastrar.FlatAppearance.BorderSize = 0;
            this.btn_cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cadastrar.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.btn_cadastrar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_cadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cadastrar.Image")));
            this.btn_cadastrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_cadastrar.Location = new System.Drawing.Point(23, 76);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(77, 68);
            this.btn_cadastrar.TabIndex = 9;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_cadastrar.UseVisualStyleBackColor = false;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // btn_SairMenu
            // 
            this.btn_SairMenu.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btn_SairMenu.FlatAppearance.BorderSize = 0;
            this.btn_SairMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SairMenu.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.btn_SairMenu.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_SairMenu.Image = ((System.Drawing.Image)(resources.GetObject("btn_SairMenu.Image")));
            this.btn_SairMenu.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_SairMenu.Location = new System.Drawing.Point(206, 76);
            this.btn_SairMenu.Name = "btn_SairMenu";
            this.btn_SairMenu.Size = new System.Drawing.Size(77, 68);
            this.btn_SairMenu.TabIndex = 10;
            this.btn_SairMenu.Text = "Sair";
            this.btn_SairMenu.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_SairMenu.UseVisualStyleBackColor = false;
            this.btn_SairMenu.Click += new System.EventHandler(this.btn_SairMenu_Click);
            // 
            // frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 228);
            this.Controls.Add(this.btn_SairMenu);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.btn_NovoUsuario);
            this.Name = "frm_Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.frm_Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_NovoUsuario;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Button btn_SairMenu;
    }
}