using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleProdutosQuimicos.Apresentação;
using ControleProdutosQuimicos.Modelo;

namespace ControleProdutosQuimicos.DAL
{
    class LoginDalComandos
    {
        public bool tem = false;
        public string mensagem = "";
        public int EstoqueTotal;
        public string ResultadoFinal;
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
        public string CadastrarProduto(string table, String Produto, String Desenho, String Numero_NF, String Numero_Pedido, String Quant_Comprada, String Quant_Usada, String Usuario_Logado, DateTime Data_Pedido, DateTime Data_Emissao_NF, DateTime Data_lancamento, string Resultado)
        {
            // comandos para inserir aqui o que vai cadastrar no banco retornando uma string informando se deu certo ou se houve algum erro.
            tem = false;

            {
                {
                    ;
                    cmd.CommandText = $"insert into {table} (Produto, Desenho, Numero_NF, Numero_Pedido, " +
                                      "Quant_Comprada, Quant_Usada, Usuario_Logado, Data_Pedido , Data_Emissao_NF, Data_Lancamento, Estoque) " +
                                      "values (@p,@d,@nf,@np,@qc,@qu,@ul,@den,@dp,@dl,@rs);";
                    cmd.Parameters.AddWithValue("@p", Produto);
                    cmd.Parameters.AddWithValue("@d", Desenho);
                    cmd.Parameters.AddWithValue("@nf", Numero_NF);
                    cmd.Parameters.AddWithValue("@np", Numero_Pedido);
                    cmd.Parameters.AddWithValue("@qc", Quant_Comprada);
                    cmd.Parameters.AddWithValue("@qu", Quant_Usada);
                    cmd.Parameters.AddWithValue("@ul", Usuario_Logado);
                    cmd.Parameters.AddWithValue("@den", Data_Pedido);
                    cmd.Parameters.AddWithValue("@dp", Data_Emissao_NF);
                    cmd.Parameters.AddWithValue("@dl", Data_lancamento);
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
                Controle controle = new Controle();

            }


            return mensagem;
        }
        public string ExluirDados(int id, string table)
        {

            // comandos para deletar registros na tabela.
            tem = false;


            try
            {
                cmd.Connection = con.Conectar();
                cmd.CommandText = $" DELETE from {table} WHERE IdProdutosQuimicos = " + id;
                cmd.ExecuteNonQuery();
                mensagem = "Deletado com Sucesso";
                tem = true;

            }

            catch (SqlException)
            {
                mensagem = "Erro com o Banco de dados";
            }


            return mensagem;
        }
        public int ValorAtualEstoque(string table)
        {

            cmd.Connection = con.Conectar();
            cmd.CommandText = $" SELECT SUM (Quant_Comprada) - SUM (Quant_Usada) from {table}";
            try
            {
                var VerificaEstque = Convert.ToInt32(cmd.ExecuteScalar());
                EstoqueTotal = Convert.ToInt32(VerificaEstque);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            con.desconectar();
            this.mensagem = "Cadastrado com Sucesso";
            tem = true;
            return EstoqueTotal;
        }
        public string Estoque(float quantComprada, float quantUsada, float estoqueAtual)
        {
            if (estoqueAtual != 0)
            {
                if (quantComprada == 0)
                {
                    float Estoque = estoqueAtual - quantUsada;
                    ResultadoFinal = Convert.ToString(Estoque);

                }
                else
                {
                    float Estoque = (estoqueAtual + quantComprada) - quantUsada;
                    ResultadoFinal = Convert.ToString(Estoque);

                }

            }
            else
            {
                float Estoque = quantComprada - quantUsada;
                ResultadoFinal = Convert.ToString(Estoque);
            }
            return ResultadoFinal;
        }
    }
}


