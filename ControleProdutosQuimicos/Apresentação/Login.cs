using ControleProdutosQuimicos.Apresentação;
using ControleProdutosQuimicos.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleProdutosQuimicos
{
    public partial class frm_login : MetroFramework.Forms.MetroForm
    {
        public frm_login()
        {
            InitializeComponent();
        }

        public object MenssageButtons { get; private set; }


        private void btn_Conectar_Click(object sender, EventArgs e)

        {
            Controle controle = new Controle();

            controle.Acessar(Usuario: Cx_Usuario.Text, Senha: Cx_Senha.Text);
            Program.Usuariologado = Cx_Usuario.Text;

            if (controle.mensagem.Equals(""))
            {
                if (controle.tem)
                {
                    MessageBox.Show("Logado com Sucesso: "  + Program.Usuariologado,  "BEM VINDO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frm_Menu menu = new frm_Menu();
                    menu.Show();
                    this.Hide();

                }

                else
                {
                    MessageBox.Show("Usuario ou Senha Invalidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show(controle.mensagem);

            }





        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm_NovoUsuario NovoUsuario = new frm_NovoUsuario();
            NovoUsuario.Show();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }

        public void Cx_Usuario_TextChanged(object sender, EventArgs e)
        {


        }
    }
}

