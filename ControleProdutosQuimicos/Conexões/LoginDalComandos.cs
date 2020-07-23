using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleProdutosQuimicos.Apresentação;


namespace ControleProdutosQuimicos.DAL
{
    class LoginDalComandos
    {
        public bool tem = false;
        public string mensagem = "";
        public int EstoqueTotal;
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;


        public bool VerificarLogin(string Usuario, string Senha)
        {

            // comandos sql para verificar se tem no banco de dados
            // proucrar no banco de dados  login e senha
            cmd.CommandText = "select * from tblUsuarioSenha where Usuario = @Usuario and Senha = @Senha ";
            cmd.Parameters.AddWithValue("@Usuario", Usuario);
            cmd.Parameters.AddWithValue("@Senha", Senha);

            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    tem = true;

                }

                con.desconectar();
                dr.Close();


            }
            catch (SqlException)
            {
                this.mensagem = "Erro Banco de Dados";

            }

            return tem;

        }


        public string CadastrarUsuarios(String Novo_Usuario, String Nova_Senha, String ConfSenha)
        {
            // comandos para inserir aqui o que vai cadastrar no banco retornando uma string informando se deu certo ou se houve algum erro.
            tem = false;

            if (Nova_Senha.Equals(ConfSenha))
            {
                cmd.CommandText = "insert into tblUsuarioSenha values (@u,@s);";
                cmd.Parameters.AddWithValue("@u", Novo_Usuario);
                cmd.Parameters.AddWithValue("@s", Nova_Senha);

                try
                {
                    cmd.Connection = con.Conectar();
                    cmd.ExecuteNonQuery();
                    con.desconectar();
                    this.mensagem = "Cadastrado com Sucesso";
                    tem = true;

                }

                catch (SqlException)
                {
                    this.mensagem = "Erro com o Banco de dados";
                }

            }

            else

            {
                this.mensagem = "Senhas não Correspondem";
            }

            return mensagem;
        }
        public string CadastrarProduto(String Produto, String Desenho, String Numero_NF,
                                       String Numero_Pedido, String Quant_Comprada, String Quant_Usada,
                                       String Usuario_Logado, DateTime Data_Pedido, DateTime Data_Emissao_NF, string Resultado)
        {
            // comandos para inserir aqui o que vai cadastrar no banco retornando uma string informando se deu certo ou se houve algum erro.
            tem = false;

            {
                if (Program.CxProduto == "Ácido Cloridrico")
                {
                    ;
                    cmd.CommandText = "insert into tblAcidoCloridrico (Produto, Desenho, Numero_NF, Numero_Pedido, " +
                                      "Quant_Comprada, Quant_Usada, Usuario_Logado, Data_Pedido , Data_Emissao_NF, Estoque) " +
                                      "values (@p,@d,@nf,@np,@qc,@qu,@ul,@den,@dp,@rs);";
                    cmd.Parameters.AddWithValue("@p", Produto);
                    cmd.Parameters.AddWithValue("@d", Desenho);
                    cmd.Parameters.AddWithValue("@nf", Numero_NF);
                    cmd.Parameters.AddWithValue("@np", Numero_Pedido);
                    cmd.Parameters.AddWithValue("@qc", Quant_Comprada);
                    cmd.Parameters.AddWithValue("@qu", Quant_Usada);
                    cmd.Parameters.AddWithValue("@ul", Usuario_Logado);
                    cmd.Parameters.AddWithValue("@den", Data_Pedido);
                    cmd.Parameters.AddWithValue("@dp", Data_Emissao_NF);
                    cmd.Parameters.AddWithValue("@rs", Resultado);
                }
                else if ((Program.CxProduto == "Ácido Sulfúrico"))
                {
                    cmd.CommandText = "insert into tblAcidoSulfurico (Produto, Desenho, Numero_NF, Numero_Pedido, " +
                                  "Quant_Comprada, Quant_Usada, Usuario_Logado, Data_Pedido , Data_Emissao_NF, Estoque) " +
                                  "values (@p,@d,@nf,@np,@qc,@qu,@ul,@den,@dp,@rs);";
                    cmd.Parameters.AddWithValue("@p", Produto);
                    cmd.Parameters.AddWithValue("@d", Desenho);
                    cmd.Parameters.AddWithValue("@nf", Numero_NF);
                    cmd.Parameters.AddWithValue("@np", Numero_Pedido);
                    cmd.Parameters.AddWithValue("@qc", Quant_Comprada);
                    cmd.Parameters.AddWithValue("@qu", Quant_Usada);
                    cmd.Parameters.AddWithValue("@ul", Usuario_Logado);
                    cmd.Parameters.AddWithValue("@den", Data_Pedido);
                    cmd.Parameters.AddWithValue("@dp", Data_Emissao_NF);
                    cmd.Parameters.AddWithValue("@rs", Resultado);
                }
                else if ((Program.CxProduto == "Hidróxido De Potássio"))
                {
                    cmd.CommandText = "insert into tblHidroxidoPostasio (Produto, Desenho, Numero_NF, Numero_Pedido, " +
                                 "Quant_Comprada, Quant_Usada, Usuario_Logado, Data_Pedido , Data_Emissao_NF, Estoque) " +
                                 "values (@p,@d,@nf,@np,@qc,@qu,@ul,@den,@dp,@rs);";
                    cmd.Parameters.AddWithValue("@p", Produto);
                    cmd.Parameters.AddWithValue("@d", Desenho);
                    cmd.Parameters.AddWithValue("@nf", Numero_NF);
                    cmd.Parameters.AddWithValue("@np", Numero_Pedido);
                    cmd.Parameters.AddWithValue("@qc", Quant_Comprada);
                    cmd.Parameters.AddWithValue("@qu", Quant_Usada);
                    cmd.Parameters.AddWithValue("@ul", Usuario_Logado);
                    cmd.Parameters.AddWithValue("@den", Data_Pedido);
                    cmd.Parameters.AddWithValue("@dp", Data_Emissao_NF);
                    cmd.Parameters.AddWithValue("@rs", Resultado);
                }
                else if ((Program.CxProduto == "Tolueno"))
                {
                    cmd.CommandText = "insert into tblTolueno (Produto, Desenho, Numero_NF, Numero_Pedido, " +
                                   "Quant_Comprada, Quant_Usada, Usuario_Logado, Data_Pedido , Data_Emissao_NF, Estoque) " +
                                   "values (@p,@d,@nf,@np,@qc,@qu,@ul,@den,@dp,@rs);";
                    cmd.Parameters.AddWithValue("@p", Produto);
                    cmd.Parameters.AddWithValue("@d", Desenho);
                    cmd.Parameters.AddWithValue("@nf", Numero_NF);
                    cmd.Parameters.AddWithValue("@np", Numero_Pedido);
                    cmd.Parameters.AddWithValue("@qc", Quant_Comprada);
                    cmd.Parameters.AddWithValue("@qu", Quant_Usada);
                    cmd.Parameters.AddWithValue("@ul", Usuario_Logado);
                    cmd.Parameters.AddWithValue("@den", Data_Pedido);
                    cmd.Parameters.AddWithValue("@dp", Data_Emissao_NF);
                    cmd.Parameters.AddWithValue("@rs", Resultado);
                }
                else if ((Program.CxProduto == "Acetona"))
                {
                    cmd.CommandText = "insert into tblAcetona (Produto, Desenho, Numero_NF, Numero_Pedido, " +
                                  "Quant_Comprada, Quant_Usada, Usuario_Logado, Data_Pedido , Data_Emissao_NF, Estoque) " +
                                  "values (@p,@d,@nf,@np,@qc,@qu,@ul,@den,@dp,@rs);";
                    cmd.Parameters.AddWithValue("@p", Produto);
                    cmd.Parameters.AddWithValue("@d", Desenho);
                    cmd.Parameters.AddWithValue("@nf", Numero_NF);
                    cmd.Parameters.AddWithValue("@np", Numero_Pedido);
                    cmd.Parameters.AddWithValue("@qc", Quant_Comprada);
                    cmd.Parameters.AddWithValue("@qu", Quant_Usada);
                    cmd.Parameters.AddWithValue("@ul", Usuario_Logado);
                    cmd.Parameters.AddWithValue("@den", Data_Pedido);
                    cmd.Parameters.AddWithValue("@dp", Data_Emissao_NF);
                    cmd.Parameters.AddWithValue("@rs", Resultado);
                }
                else if ((Program.CxProduto == "Metiletilcetona"))
                {
                    cmd.CommandText = "insert into tblMetiletilcetona (Produto, Desenho, Numero_NF, Numero_Pedido, " +
                                  "Quant_Comprada, Quant_Usada, Usuario_Logado, Data_Pedido , Data_Emissao_NF, Estoque) " +
                                  "values (@p,@d,@nf,@np,@qc,@qu,@ul,@den,@dp,@rs);";
                    cmd.Parameters.AddWithValue("@p", Produto);
                    cmd.Parameters.AddWithValue("@d", Desenho);
                    cmd.Parameters.AddWithValue("@nf", Numero_NF);
                    cmd.Parameters.AddWithValue("@np", Numero_Pedido);
                    cmd.Parameters.AddWithValue("@qc", Quant_Comprada);
                    cmd.Parameters.AddWithValue("@qu", Quant_Usada);
                    cmd.Parameters.AddWithValue("@ul", Usuario_Logado);
                    cmd.Parameters.AddWithValue("@den", Data_Pedido);
                    cmd.Parameters.AddWithValue("@dp", Data_Emissao_NF);
                    cmd.Parameters.AddWithValue("@rs", Resultado);
                }


                try
                {
                    cmd.Connection = con.Conectar();
                    cmd.ExecuteNonQuery();
                    con.desconectar();
                    this.mensagem = "Cadastrado com Sucesso";
                    tem = true;

                }

                catch (SqlException Ex)
                {
                    this.mensagem = Ex.Message;
                }

            }


            return mensagem;
        }

        public int ValorAtualEstoque()
        {

            if (Program.CxProduto == "Ácido Cloridrico")
            {
                cmd.Connection = con.Conectar();
                cmd.CommandText = " SELECT SUM (Quant_Comprada) - SUM (Quant_Usada) from tblAcidocloridrico";
                try
                {
                    var VerificaEstque = Convert.ToInt32(cmd.ExecuteScalar());
                    EstoqueTotal = Convert.ToInt32(VerificaEstque);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }


            }
            else if (Program.CxProduto == "Ácido Sulfúrico")
            {
                cmd.Connection = con.Conectar();
                cmd.CommandText = " SELECT SUM (Quant_Comprada) - SUM (Quant_Usada) from tblAcidoSulfurico";
                try
                {
                    var VerificaEstque = Convert.ToInt32(cmd.ExecuteScalar());

                    EstoqueTotal = Convert.ToInt32(VerificaEstque);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
            else if (Program.CxProduto == "Hidróxido De Potássio")
            {
                cmd.Connection = con.Conectar();
                cmd.CommandText = "SELECT SUM (Estoque) - SUM (Quant_Usada) from tblHidroxidoPostasio";
                try
                {
                    var VerificaEstque = Convert.ToInt32(cmd.ExecuteScalar());
                    EstoqueTotal = Convert.ToInt32(VerificaEstque);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
            else if (Program.CxProduto == "Tolueno")
            {
                cmd.Connection = con.Conectar();
                cmd.CommandText = "SELECT SUM (Quant_Comprada) - SUM (Quant_Usada)  from tblTolueno";
                try
                {
                    var VerificaEstque = Convert.ToInt32(cmd.ExecuteScalar());
                    EstoqueTotal = Convert.ToInt32(VerificaEstque);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
            else if (Program.CxProduto == "Acetona")
            {
                cmd.Connection = con.Conectar();
                cmd.CommandText = "SELECT SUM (Quant_Comprada) - SUM (Quant_Usada) from tblAcetona";
                try
                {
                    var VerificaEstque = Convert.ToInt32(cmd.ExecuteScalar());
                    EstoqueTotal = Convert.ToInt32(VerificaEstque);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
            else if (Program.CxProduto == "Metiletilcetona")
            {
                cmd.Connection = con.Conectar();
                cmd.CommandText = "SELECT SUM (Quant_Comprada) - SUM (Quant_Usada) from tblMetiletilcetona";

                try
                {
                    var VerificaEstque = Convert.ToInt32(cmd.ExecuteScalar());
                    EstoqueTotal = Convert.ToInt32(VerificaEstque);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }


            }

            con.desconectar();
            this.mensagem = "Cadastrado com Sucesso";
            tem = true;
            return EstoqueTotal;
        }
        public string ExluirDados()
        {
            // comandos para deletar registros na tabela.
            tem = false;

            if (Program.Cx_ExclusaoProduto == "Ácido Cloridrico")
            {

                try
                {
                    cmd.Connection = con.Conectar();
                    cmd.CommandText = " DELETE from tblAcidocloridrico WHERE IdProdutosQuimicos = " + Program.Cx_ExclusaoRegistro;
                    cmd.ExecuteNonQuery();
                    this.mensagem = "Deletado com Sucesso";
                    tem = true;

                }

                catch (SqlException)
                {
                    this.mensagem = "Erro com o Banco de dados";
                }

            }
            else if (Program.Cx_ExclusaoProduto == "Ácido Sulfúrico")
            {

                try
                {
                    cmd.Connection = con.Conectar();
                    cmd.CommandText = " DELETE from tblAcidoSulfurico WHERE IdProdutosQuimicos = " + Program.Cx_ExclusaoRegistro;
                    cmd.ExecuteNonQuery();
                    this.mensagem = "Deletado com Sucesso";
                    tem = true;

                }

                catch (SqlException)
                {
                    this.mensagem = "Erro com o Banco de dados";
                }

            }
            else if (Program.Cx_ExclusaoProduto == "Hidróxido De Potássio")
            {

                try
                {
                    cmd.Connection = con.Conectar();
                    cmd.CommandText = " DELETE from tblHidroxidoPostasio WHERE IdProdutosQuimicos = " + Program.Cx_ExclusaoRegistro;
                    cmd.ExecuteNonQuery();
                    this.mensagem = "Deletado com Sucesso";
                    tem = true;

                }

                catch (SqlException)
                {
                    this.mensagem = "Erro com o Banco de dados";
                }

            }
            else if (Program.Cx_ExclusaoProduto == "Tolueno")
            {

                try
                {
                    cmd.Connection = con.Conectar();
                    cmd.CommandText = " DELETE from tblTolueno WHERE IdProdutosQuimicos = " + Program.Cx_ExclusaoRegistro;
                    cmd.ExecuteNonQuery();
                    this.mensagem = "Deletado com Sucesso";
                    tem = true;

                }

                catch (SqlException)
                {
                    this.mensagem = "Erro com o Banco de dados";
                }

            }
            else if (Program.Cx_ExclusaoProduto == "Acetona")
            {

                try
                {
                    cmd.Connection = con.Conectar();
                    cmd.CommandText = " DELETE from tblAcetona WHERE IdProdutosQuimicos = " + Program.Cx_ExclusaoRegistro;
                    cmd.ExecuteNonQuery();
                    this.mensagem = "Deletado com Sucesso";
                    tem = true;

                }

                catch (SqlException)
                {
                    this.mensagem = "Erro com o Banco de dados";
                }

            }
            else if (Program.Cx_ExclusaoProduto == "Metiletilcetona")
            {

                try
                {
                    cmd.Connection = con.Conectar();
                    cmd.CommandText = " DELETE from tblMetiletilcetona WHERE IdProdutosQuimicos = " + Program.Cx_ExclusaoRegistro;
                    cmd.ExecuteNonQuery();
                    this.mensagem = "Deletado com Sucesso";
                    tem = true;

                }

                catch (SqlException)
                {
                    this.mensagem = "Erro com o Banco de dados";
                }

            }

            return mensagem;
        }

    }
}


