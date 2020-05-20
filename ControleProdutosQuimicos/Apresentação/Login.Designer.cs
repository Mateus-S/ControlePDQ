namespace ControleProdutosQuimicos
{
    partial class frm_login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.Cx_Usuario = new System.Windows.Forms.TextBox();
            this.Cx_Senha = new System.Windows.Forms.TextBox();
            this.btn_Conectar = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(188, 63);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(66, 18);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(188, 119);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(57, 18);
            this.lblSenha.TabIndex = 2;
            this.lblSenha.Text = "Senha:";
            // 
            // Cx_Usuario
            // 
            this.Cx_Usuario.BackColor = System.Drawing.SystemColors.Menu;
            this.Cx_Usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Cx_Usuario.Font = new System.Drawing.Font("Arial", 10F);
            this.Cx_Usuario.Location = new System.Drawing.Point(285, 66);
            this.Cx_Usuario.Name = "Cx_Usuario";
            this.Cx_Usuario.Size = new System.Drawing.Size(100, 16);
            this.Cx_Usuario.TabIndex = 3;
            this.Cx_Usuario.TextChanged += new System.EventHandler(this.Cx_Usuario_TextChanged);
            // 
            // Cx_Senha
            // 
            this.Cx_Senha.BackColor = System.Drawing.SystemColors.Menu;
            this.Cx_Senha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Cx_Senha.Font = new System.Drawing.Font("Arial", 10F);
            this.Cx_Senha.Location = new System.Drawing.Point(285, 121);
            this.Cx_Senha.Name = "Cx_Senha";
            this.Cx_Senha.PasswordChar = '*';
            this.Cx_Senha.Size = new System.Drawing.Size(100, 16);
            this.Cx_Senha.TabIndex = 4;
            // 
            // btn_Conectar
            // 
            this.btn_Conectar.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_Conectar.FlatAppearance.BorderSize = 0;
            this.btn_Conectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Conectar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Conectar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_Conectar.Location = new System.Drawing.Point(192, 168);
            this.btn_Conectar.Name = "btn_Conectar";
            this.btn_Conectar.Size = new System.Drawing.Size(83, 27);
            this.btn_Conectar.TabIndex = 5;
            this.btn_Conectar.Text = "Conectar";
            this.btn_Conectar.UseCompatibleTextRendering = true;
            this.btn_Conectar.UseVisualStyleBackColor = false;
            this.btn_Conectar.Click += new System.EventHandler(this.btn_Conectar_Click);
            // 
            // btn_Sair
            // 
            this.btn_Sair.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_Sair.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveBorder;
            this.btn_Sair.FlatAppearance.BorderSize = 0;
            this.btn_Sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sair.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Sair.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_Sair.Location = new System.Drawing.Point(305, 168);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(90, 27);
            this.btn_Sair.TabIndex = 6;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = false;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 262);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.btn_Conectar);
            this.Controls.Add(this.Cx_Senha);
            this.Controls.Add(this.Cx_Usuario);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frm_login";
            this.ShowIcon = false;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox Cx_Usuario;
        private System.Windows.Forms.TextBox Cx_Senha;
        private System.Windows.Forms.Button btn_Conectar;
        private System.Windows.Forms.Button btn_Sair;
    }
}

