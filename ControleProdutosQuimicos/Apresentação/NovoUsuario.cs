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

namespace ControleProdutosQuimicos.Apresentação
{
    public partial class frm_NovoUsuario : MetroFramework.Forms.MetroForm
    {
        public frm_NovoUsuario()
        {
            InitializeComponent();
        }

        private void NovoUsuario_Load(object sender, EventArgs e)
        {

        }

        private void Botao_ConfirmarNovoUsuario_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            String mensagem = controle.CadastrarNovousuario(Cx_NovoUsuario.Text, Cx_NovaSenha.Text, Cx_ConfirmarNovaSenha.Text);
            if (controle.tem)
            {
                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                
            else

            {
                MessageBox.Show(controle.mensagem);
            }
             
            }

        private void Botao_CancelarNovoUsuario_Click(object sender, EventArgs e)
        {
            frm_Menu menu = new frm_Menu();
            menu.Show();
            this.Close();
        }
    }
   
} 
