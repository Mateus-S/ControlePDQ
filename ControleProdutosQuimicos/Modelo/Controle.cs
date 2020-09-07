using ControleProdutosQuimicos.DAL;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DataGridView = System.Windows.Forms.DataGridView;

namespace ControleProdutosQuimicos.Modelo
{
    public class Controle
    {
        public bool tem;
        public string mensagem = "", logado;

        public bool Acessar(String Usuario, String Senha)
        {

            LoginDalComandos LoginDao = new LoginDalComandos();
           tem = LoginDao.VerificarLogin(Usuario, Senha);
                                   
            if (!LoginDao.mensagem.Equals(""))
            {
                this.mensagem = LoginDao.mensagem;
                
            }
            return tem;
           
            
        }
        public String CadastrarNovousuario(String Novo_Usuario, String Nova_Senha, String ConfSenha)
        {
            LoginDalComandos LoginDao = new LoginDalComandos();
           this.mensagem = LoginDao.CadastrarUsuarios(Novo_Usuario, Nova_Senha, ConfSenha);
               if (LoginDao.tem)
            {
                this.tem = true;

            }
            return mensagem;
            }
        public string CadastrarProduto(String Produto, String Desenho, String Numero_NF, String Numero_Pedido, String Quant_Comprada, String Quant_Usada, String Usuario_Logado, DateTime Data_Emissao_NF, DateTime Data_Pedido, DateTime Data_Lancamento, string Resultado)
        {
          
            LoginDalComandos cadprod = new LoginDalComandos();
            this.mensagem = cadprod.CadastrarProduto(Produto, Desenho, Numero_NF, Numero_Pedido, Quant_Comprada, Quant_Usada, Usuario_Logado, Data_Pedido, Data_Emissao_NF, Data_Lancamento, Resultado);
            if (cadprod.tem)
            {
                this.tem = true;

            }

            return mensagem;
        }

        public void ExportarDados(DataGridView datalistado)
        {
            Microsoft.Office.Interop.Excel.Application exportarexcel = new Microsoft.Office.Interop.Excel.Application();

            exportarexcel.Application.Workbooks.Add(true);

            int indicecolumna = 0;

             
            
            foreach(DataGridViewColumn column in datalistado.Columns)
            {
                indicecolumna++;

                exportarexcel.Cells[1, indicecolumna] = column.Name;
            }

            int indicefila = 0;

            foreach (DataGridViewRow fila in datalistado.Rows)
            {
                indicefila++;
                indicecolumna = 0;
                foreach (DataGridViewColumn columna in datalistado.Columns)
                {
                    indicecolumna++;
                    exportarexcel.Cells[indicefila + 1, indicecolumna] = fila.Cells[columna.Name].Value;
                }

            }

            exportarexcel.Visible = true;

        }



    }
}
