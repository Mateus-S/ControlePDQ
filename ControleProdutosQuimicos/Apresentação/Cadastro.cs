using ControleProdutosQuimicos.Apresentação;
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
using ControleProdutosQuimicos.DAL;


namespace ControleProdutosQuimicos
{
    public partial class frm_Cadastro : MetroFramework.Forms.MetroForm

    {
        
        float Estoque1 = 0, Estoque2 = 0;

        public frm_Cadastro()


        {


            InitializeComponent();


        }

        private void BotaoSalvar_Click(object sender, EventArgs e)
        {
            LoginDalComandos logindal = new LoginDalComandos();

            int v = logindal.ValorAtualEstoque();
            string resultado = "";
            MessageBox.Show(Convert.ToString(v));


            DateTime dataemissaonf = new DateTime();
            dataemissaonf = Cx_Data_Emissao_NF.Value;
            DateTime datapedido = new DateTime();
            datapedido = Cx_Data_Pedido.Value;
            if(Cx_Quant_Compra.Text == "")
            {
                Cx_Quant_Compra.Text = "0";
            }
            if (Cx_Quant_Usada.Text == "")
            {
                Cx_Quant_Usada.Text = "0";
            }
                
            Estoque1 = float.Parse(Cx_Quant_Compra.Text);
            Estoque2 = float.Parse(Cx_Quant_Usada.Text);
            if (v != 0)
            {
                float Estoque = (v + Estoque1) - Estoque2;
                resultado = Convert.ToString(Estoque);
                MessageBox.Show(resultado);
            }
            else
            {
                float Estoque = Estoque1 - Estoque2;
                resultado = Convert.ToString(Estoque);
                MessageBox.Show(resultado);
            }
          

            Controle controle = new Controle();
            String mensagem = controle.CadastrarProduto(Cx_Produto.Text, Cx_Item.Text, Cx_Numero_NF.Text, Cx_Pedido_Compra.Text, Cx_Quant_Compra.Text, Cx_Quant_Usada.Text,
                Cx_Usuario_Logado.Text, dataemissaonf, datapedido, resultado);




            if (controle.tem)
            {
                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            else
            
            {
                MessageBox.Show(controle.mensagem);
            }

            frm_Cadastro cadastro = new frm_Cadastro();

            cadastro.Show();

            this.Close();
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDProdutosQuimicosDataSet.tblMetiletilcetona'. Você pode movê-la ou removê-la conforme necessário.
            this.tblMetiletilcetonaTableAdapter.Fill(this.bDProdutosQuimicosDataSet.tblMetiletilcetona);
            // TODO: esta linha de código carrega dados na tabela 'bDProdutosQuimicosDataSet.tblAcetona'. Você pode movê-la ou removê-la conforme necessário.
            this.tblAcetonaTableAdapter.Fill(this.bDProdutosQuimicosDataSet.tblAcetona);
            // TODO: esta linha de código carrega dados na tabela 'bDProdutosQuimicosDataSet.tblTolueno'. Você pode movê-la ou removê-la conforme necessário.
            this.tblToluenoTableAdapter.Fill(this.bDProdutosQuimicosDataSet.tblTolueno);
            // TODO: esta linha de código carrega dados na tabela 'bDProdutosQuimicosDataSet.tblHidroxidoPostasio'. Você pode movê-la ou removê-la conforme necessário.
            this.tblHidroxidoPostasioTableAdapter.Fill(this.bDProdutosQuimicosDataSet.tblHidroxidoPostasio);
            // TODO: esta linha de código carrega dados na tabela 'bDProdutosQuimicosDataSet.tblAcidoSulfurico'. Você pode movê-la ou removê-la conforme necessário.
            this.tblAcidoSulfuricoTableAdapter.Fill(this.bDProdutosQuimicosDataSet.tblAcidoSulfurico);
            // TODO: esta linha de código carrega dados na tabela 'bDProdutosQuimicosDataSet.tblAcidoCloridrico'. Você pode movê-la ou removê-la conforme necessário.
            this.tblAcidoCloridricoTableAdapter.Fill(this.bDProdutosQuimicosDataSet.tblAcidoCloridrico);
            Cx_Usuario_Logado.Text = Program.Usuariologado;
                  
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BotaoSair_Click(object sender, EventArgs e)
        {
            frm_Menu menu = new frm_Menu();
            menu.Show();
            this.Close();

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void Cx_Usuario_Logado_TextChanged(object sender, EventArgs e)
        {


        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
            
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }


        public void Cx_Produto_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (Cx_Produto.Text == "Ácido Cloridrico")
            {
                Cx_Item.Text = "N4981917P012";
                               
            }
            else if (Cx_Produto.Text == "Ácido Sulfúrico")
            {
                Cx_Item.Text = "Z40981302P025";
            }
            else if (Cx_Produto.Text == "Hidróxido De Potássio")
            {
                Cx_Item.Text = "Z40981302P003";
            }

            else if (Cx_Produto.Text == "Tolueno")
            {
                Cx_Item.Text = "Z40981302P017";
            }
            else if (Cx_Produto.Text == "Acetona")
            {
                Cx_Item.Text = "Z40981302P006";
            }
            else if (Cx_Produto.Text == "Metiletilcetona")
            {
                Cx_Item.Text = "Z40981302P005";

            }
            Program.CxProduto = Cx_Produto.Text;
        }


        private void Cx_Item_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tblAcidoCloridricoBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

      
    }
}

