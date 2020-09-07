using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleProdutosQuimicos
{
    public static class Program
    {

        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        public static string Usuariologado;
        public static string CxProduto;
        public static string Cx_ExclusaoProduto;
        public static string Cx_ExclusaoRegistro;

        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm_Cadastro());
        }
    }
}
