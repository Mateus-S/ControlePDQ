using System;
using System.Windows.Forms;
using ControleProdutosQuimicos.Modelo;
using Microsoft.Office.Tools.Excel.Controls;

namespace ControleProdutosQuimicos.Apresentação
{
    public partial class frm_ExportarExcel : MetroFramework.Forms.MetroForm
    {
        System.Windows.Forms.DataGridView dados;

        public frm_ExportarExcel()
        {
            InitializeComponent();
        }

        private void ExportarExcel_Load(object sender, EventArgs e)
        {

        }

        private void btn_Gerar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            frm_Cadastro cadastro = new frm_Cadastro();

            dados = cadastro.dataGridView1;

            controle.ExportarDados(dados);

        }
    }
}
