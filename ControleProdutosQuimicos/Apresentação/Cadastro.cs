using ControleProdutosQuimicos.Apresentação;
using ControleProdutosQuimicos.Modelo;
using System;
using System.Windows.Forms;
using ControleProdutosQuimicos.DAL;
using System.Globalization;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Data;
using Microsoft.Office.Interop.Excel;

namespace ControleProdutosQuimicos
{
    public partial class frm_Cadastro : MetroFramework.Forms.MetroForm

    {
        
        float QuantidadeCompra = 0, QuantidadeUtilizada = 0;
        DataGridView tabela;


        public frm_Cadastro()
            

        {


            InitializeComponent();


        }

        private void BotaoSalvar_Click(object sender, EventArgs e)
        {
            LoginDalComandos logindal = new LoginDalComandos();

            int ValorEstoqueAtual = logindal.ValorAtualEstoque();
            string Resultado = "";
            MessageBox.Show("Esse é o valor Atual do Estoque\n" + Convert.ToString(ValorEstoqueAtual));


            DateTime DataEmissaonf = new DateTime();
            DataEmissaonf = Cx_Data_Emissao_NF.Value;
            DateTime DataPedido = new DateTime();
            DataPedido = Cx_Data_Pedido.Value;

            DateTime Data_Lancamento = DateTime.Today;
                
            if (Cx_Quant_Compra.Text == "")
            {
                Cx_Quant_Compra.Text = "0";
            }
            if (Cx_Quant_Usada.Text == "")
            {
                Cx_Quant_Usada.Text = "0";
            }

            QuantidadeCompra = float.Parse(Cx_Quant_Compra.Text);
            QuantidadeUtilizada = float.Parse(Cx_Quant_Usada.Text);
            if (ValorEstoqueAtual != 0)
            {
                if (Cx_Quant_Compra.Text == "0")
                {
                    float Estoque = ValorEstoqueAtual - QuantidadeUtilizada;
                    Resultado = Convert.ToString(Estoque);
                    MessageBox.Show(Resultado);
                }
                else
                {
                    float Estoque = (ValorEstoqueAtual + QuantidadeCompra) - QuantidadeUtilizada;
                    Resultado = Convert.ToString(Estoque);
                    MessageBox.Show(Resultado);

                }

            }
            else
            {
                float Estoque = QuantidadeCompra - QuantidadeUtilizada;
                Resultado = Convert.ToString(Estoque);
                MessageBox.Show(Resultado);
            }


            Controle controle = new Controle();
            String mensagem = controle.CadastrarProduto(Cx_Produto.Text, Cx_Item.Text, Cx_Numero_NF.Text, Cx_Pedido_Compra.Text, Cx_Quant_Compra.Text, Cx_Quant_Usada.Text,
                Cx_Usuario_Logado.Text, DataEmissaonf, DataPedido, Data_Lancamento, Resultado);




            if (controle.tem)
            {
                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            else

            {
                MessageBox.Show(controle.mensagem);
            }
            this.Close();
            frm_Cadastro cadastro = new frm_Cadastro();
            cadastro.Show();

        }

        private void Cadastro_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDPQDataSethome.tblHidroxidoPostasio'. Você pode movê-la ou removê-la conforme necessário.
            this.tblHidroxidoPostasioTableAdapter.Fill(this.bDPQDataSethome.tblHidroxidoPostasio);
            // TODO: esta linha de código carrega dados na tabela 'bDPQDataSethome.tblMetiletilcetona'. Você pode movê-la ou removê-la conforme necessário.
            this.tblMetiletilcetonaTableAdapter1.Fill(this.bDPQDataSethome.tblMetiletilcetona);
            // TODO: esta linha de código carrega dados na tabela 'bDPQDataSethome.tblAcetona'. Você pode movê-la ou removê-la conforme necessário.
            this.tblAcetonaTableAdapter1.Fill(this.bDPQDataSethome.tblAcetona);
            // TODO: esta linha de código carrega dados na tabela 'bDPQDataSethome.tblTolueno'. Você pode movê-la ou removê-la conforme necessário.
            this.tblToluenoTableAdapter1.Fill(this.bDPQDataSethome.tblTolueno);
            // TODO: esta linha de código carrega dados na tabela 'bDPQDataSethome.tblAcidoSulfurico'. Você pode movê-la ou removê-la conforme necessário.
            this.tblAcidoSulfuricoTableAdapter1.Fill(this.bDPQDataSethome.tblAcidoSulfurico);
            // TODO: esta linha de código carrega dados na tabela 'bDPQDataSethome.tblAcidoCloridrico'. Você pode movê-la ou removê-la conforme necessário.
            this.tblAcidoCloridricoTableAdapter1.Fill(this.bDPQDataSethome.tblAcidoCloridrico);
            // TODO: esta linha de código carrega dados na tabela 'bDPQServerTSEA.tblMetiletilcetona'. Você pode movê-la ou removê-la conforme necessário.
        
            Cx_Usuario_Logado.Text = Program.Usuariologado;

        }

        private void BotaoSair_Click(object sender, EventArgs e)
        {
            frm_Menu menu = new frm_Menu();
            menu.Show();
            this.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        public void Cx_Produto_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (Cx_Produto.Text == "Ácido Cloridrico")
            {
                Cx_Item.Text = "N4981917P012";
                tab_Produtos.SelectTab(0);

            }
            else if (Cx_Produto.Text == "Ácido Sulfúrico")
            {
                Cx_Item.Text = "Z40981302P025";
                tab_Produtos.SelectTab(1);

            }
            else if (Cx_Produto.Text == "Hidróxido De Potássio")
            {
                Cx_Item.Text = "Z40981302P003";
                tab_Produtos.SelectTab(2);

            }

            else if (Cx_Produto.Text == "Tolueno")
            {
                Cx_Item.Text = "Z40981302P017";
                tab_Produtos.SelectTab(3);

            }
            else if (Cx_Produto.Text == "Acetona")
            {
                Cx_Item.Text = "Z40981302P006";
                tab_Produtos.SelectTab(4);

            }
            else if (Cx_Produto.Text == "Metiletilcetona")
            {
                Cx_Item.Text = "Z40981302P005";
                tab_Produtos.SelectTab(5);


            }
            Program.CxProduto = Cx_Produto.Text;
        }

        private void btn_Relatorio_Click_1(object sender, EventArgs e)
        {
            foreach (Control item in tab_Produtos.SelectedTab.Controls)
            {
                if (item is DataGridView)
                {
                    tabela = (DataGridView)item;
                }
            }
            if (MessageBox.Show("Será gerado o arquivo referente ao que estiver selecionado", "Atenção",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Controle controle = new Controle();

                controle.ExportarDados(tabela);
            }
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            LoginDalComandos comandos = new LoginDalComandos();
            comandos.ExluirDados((int)e.Row.Cells[0].Value, tab_Produtos.SelectedTab.Text);
            Controle controle = new Controle();
            controle.AtualizarDados();
        }
        private void dataGridView2_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            LoginDalComandos comandos = new LoginDalComandos();
            comandos.ExluirDados((int)e.Row.Cells[0].Value, tab_Produtos.SelectedTab.Text);
            Controle controle = new Controle();
            controle.AtualizarDados();

        }   
        private void dataGridView3_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            LoginDalComandos comandos = new LoginDalComandos();
            comandos.ExluirDados((int)e.Row.Cells[0].Value, tab_Produtos.SelectedTab.Text);
            Controle controle = new Controle();
            controle.AtualizarDados();

        }   
        private void dataGridView4_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)

        {
            LoginDalComandos comandos = new LoginDalComandos();
            comandos.ExluirDados((int)e.Row.Cells[0].Value, tab_Produtos.SelectedTab.Text);
            Controle controle = new Controle();
            controle.AtualizarDados();
         }
        private void dataGridView5_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)

        {
            LoginDalComandos comandos = new LoginDalComandos();
            comandos.ExluirDados((int)e.Row.Cells[0].Value, tab_Produtos.SelectedTab.Text);
            Controle controle = new Controle();
            controle.AtualizarDados();
        }
        private void dataGridView6_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)

        {
            LoginDalComandos comandos = new LoginDalComandos();
            comandos.ExluirDados((int)e.Row.Cells[0].Value, tab_Produtos.SelectedTab.Text);
            Controle controle = new Controle();
            controle.AtualizarDados();
        }


        private void BotaoLimparDados_Click(object sender, EventArgs e)
        {
            int line = dataGridView1.Columns[0].Index;
            LoginDalComandos comandos = new LoginDalComandos();
            comandos.ExluirDados(line, tab_Produtos.SelectedTab.Text);


            Controle controle = new Controle();
            controle.AtualizarDados();
            MessageBox.Show("Digite qual o registro que deseja excluir","Atenção", MessageBoxButtons.OK,MessageBoxIcon.Question);

            /*
              frm_ExclusaoRegistroBD Exclusao = new frm_ExclusaoRegistroBD();
              Exclusao.Show();
              */
        }


        


    }
}

