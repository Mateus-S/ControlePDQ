using ControleProdutosQuimicos.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public string CadastrarProduto(String Produto, String Desenho, String Numero_NF, String Numero_Pedido, String Quant_Comprada,
            String Quant_Usada, String Usuario_Logado, DateTime Data_Emissao_NF, DateTime Data_Pedido, string Resultado)
        {
          
            LoginDalComandos cadprod = new LoginDalComandos();
            this.mensagem = cadprod.CadastrarProduto(Produto, Desenho, Numero_NF, Numero_Pedido, Quant_Comprada, Quant_Usada, Usuario_Logado, Data_Pedido, Data_Emissao_NF,Resultado);
            if (cadprod.tem)
            {
                this.tem = true;

            }

            return mensagem;
        }

        

    }
}
