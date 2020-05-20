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
    public partial class frm_Menu : MetroFramework.Forms.MetroForm
    {
        public frm_Menu()

        {
            InitializeComponent();

        }

        private void btn_NovoUsuario_Click(object sender, EventArgs e)
        {
            frm_NovoUsuario NovoUsuario = new frm_NovoUsuario();
            NovoUsuario.Show();

            this.Close();

        }

        private void frm_Menu_Load(object sender, EventArgs e)
        {

        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {


            frm_Cadastro cadastro = new frm_Cadastro();

            cadastro.Show();
            this.Close();

        }

        private void btn_SairMenu_Click(object sender, EventArgs e)
        {
            frm_login login = new frm_login();
            login.Show();
            this.Close();

        }
    }
}
