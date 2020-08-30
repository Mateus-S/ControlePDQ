using ControleProdutosQuimicos.DAL;
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
    public partial class frm_ExclusaoRegistroBD : MetroFramework.Forms.MetroForm
    {
        public frm_ExclusaoRegistroBD()
        {
            InitializeComponent();
        }

        private void ExclusaoRegistroBD_Load(object sender, EventArgs e)
        {
        
        }

        private void lblProduto_Click(object sender, EventArgs e)
        {

        }

        private void btn_ConfirmarExclusao_Click(object sender, EventArgs e)
        {
            LoginDalComandos comandos = new LoginDalComandos();

            Program.Cx_ExclusaoRegistro = Cx_ExclusaoRegistro.Text;

            if (MessageBox.Show("Você tem certeza que deseja Excluir esse registro?", "Atenção",
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                comandos.ExluirDados(int.Parse(Cx_ExclusaoRegistro.Text), Cx_ExclusaoProduto.Text);
                frm_Cadastro cadastro = new frm_Cadastro();

                cadastro.Show();

                this.Close();
                MessageBox.Show(comandos.mensagem);

            }
        }

        private void Cx_ExclusaoProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.Cx_ExclusaoProduto = Cx_ExclusaoProduto.Text;

        }

        private void btn_CancelarExclusao_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
