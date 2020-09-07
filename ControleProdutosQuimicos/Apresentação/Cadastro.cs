using ControleProdutosQuimicos.Apresentação;
using ControleProdutosQuimicos.Modelo;
using System;
using System.Windows.Forms;
using ControleProdutosQuimicos.DAL;
using System.Collections.Generic;


namespace ControleProdutosQuimicos
{
    public partial class frm_Cadastro : MetroFramework.Forms.MetroForm

    {


        float QuantidadeCompra = 0, QuantidadeUtilizada = 0;
        DataGridView tabela;
        Controle controle = new Controle();
        LoginDalComandos comandos = new LoginDalComandos();




        public frm_Cadastro()


        {


            InitializeComponent();


        }

        private void BotaoSalvar_Click(object sender, EventArgs e)
        {
            string table = "";
            switch (tab_Produtos.SelectedTab.Text)
            {
                case "Ácido Cloridrico":
                    table = "tblAcidocloridrico";
                    break;
                case "Ácido Sulfurico":
                    table = "tblAcidoSulfurico";
                    break;
                case "Tolueno":
                    table = "tblTolueno";
                    break;
                case "Hidroxido de Postásio":
                    table = "tblHidroxidoPostasio";
                    break;
                case "Acetona":
                    table = "tblAcetona";
                    break;
                case "Metiletilcetona":
                    table = "tblMetiletilcetona";
                    break;

            }

            LoginDalComandos logindal = new LoginDalComandos();
            int ValorEstoqueAtual = logindal.ValorAtualEstoque(table);
            MessageBox.Show("Esse é o valor Atual do Estoque\n" + Convert.ToString(ValorEstoqueAtual), "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DateTime DataEmissaonf = Cx_Data_Emissao_NF.Value;
            DateTime DataPedido = Cx_Data_Pedido.Value;
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
            string Resultado;
            Resultado = logindal.Estoque(QuantidadeCompra, QuantidadeUtilizada, ValorEstoqueAtual);
            MessageBox.Show($"Este é o resultado do Estoque após o incremento: {Resultado}", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Controle controle = new Controle();
            String mensagem = controle.CadastrarProduto(table, Cx_Produto.Text, Cx_Item.Text, Cx_Numero_NF.Text, Cx_Pedido_Compra.Text, Cx_Quant_Compra.Text, Cx_Quant_Usada.Text,
                Cx_Usuario_Logado.Text, DataEmissaonf, DataPedido, Data_Lancamento, Resultado);

            if (controle.tem)
            {
                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            else

            {
                MessageBox.Show(controle.mensagem);
            }
            AtualizarDados();
            ResetarForm();


        }
        private void Cadastro_Load(object sender, EventArgs e)
        {

            AtualizarDados();
            Cx_Usuario_Logado.Text = Program.Usuariologado;

        }
        private void BotaoSair_Click(object sender, EventArgs e)
        {
            frm_Menu menu = new frm_Menu();
            menu.Show();
            this.Close();

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
            string table = "";
            switch (tab_Produtos.SelectedTab.Text)
            {
                case "Ácido Cloridrico":
                    table = "tblAcidocloridrico";
                    break;
                case "Ácido Sulfurico":
                    table = "tblAcidoSulfurico";
                    break;
                case "Tolueno":
                    table = "tblTolueno";
                    break;
                case "Hidroxido de Postásio":
                    table = "tblHidroxidoPostasio";
                    break;
                case "Acetona":
                    table = "tblAcetona";
                    break;
                case "Metiletilcetona":
                    table = "tblMetiletilcetona";
                    break;

            }
            LoginDalComandos comandos = new LoginDalComandos();
            comandos.ExluirDados((int)e.Row.Cells[0].Value, table);
            Controle controle = new Controle();
            AtualizarDados();
        }
        private void dataGridView2_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            string table = "";
            switch (tab_Produtos.SelectedTab.Text)
            {
                case "Ácido Cloridrico":
                    table = "tblAcidocloridrico";
                    break;
                case "Ácido Sulfurico":
                    table = "tblAcidoSulfurico";
                    break;
                case "Tolueno":
                    table = "tblTolueno";
                    break;
                case "Hidroxido de Postásio":
                    table = "tblHidroxidoPostasio";
                    break;
                case "Acetona":
                    table = "tblAcetona";
                    break;
                case "Metiletilcetona":
                    table = "tblMetiletilcetona";
                    break;

            }
            LoginDalComandos comandos = new LoginDalComandos();
            comandos.ExluirDados((int)e.Row.Cells[0].Value, table);
            Controle controle = new Controle();
            AtualizarDados();

        }
        private void dataGridView3_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            string table = "";
            switch (tab_Produtos.SelectedTab.Text)
            {
                case "Ácido Cloridrico":
                    table = "tblAcidocloridrico";
                    break;
                case "Ácido Sulfurico":
                    table = "tblAcidoSulfurico";
                    break;
                case "Tolueno":
                    table = "tblTolueno";
                    break;
                case "Hidróxido De Postássio":
                    table = "tblHidroxidoPostasio";
                    break;
                case "Acetona":
                    table = "tblAcetona";
                    break;
                case "Metiletilcetona":
                    table = "tblMetiletilcetona";
                    break;

            }
            LoginDalComandos comandos = new LoginDalComandos();
            comandos.ExluirDados((int)e.Row.Cells[0].Value, table);
            Controle controle = new Controle();
            AtualizarDados();

        }
        private void dataGridView4_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)

        {
            string table = "";
            switch (tab_Produtos.SelectedTab.Text)
            {
                case "Ácido Cloridrico":
                    table = "tblAcidocloridrico";
                    break;
                case "Ácido Sulfurico":
                    table = "tblAcidoSulfurico";
                    break;
                case "Tolueno":
                    table = "tblTolueno";
                    break;
                case "Hidroxido de Postásio":
                    table = "tblHidroxidoPostasio";
                    break;
                case "Acetona":
                    table = "tblAcetona";
                    break;
                case "Metiletilcetona":
                    table = "tblMetiletilcetona";
                    break;

            }
            LoginDalComandos comandos = new LoginDalComandos();
            comandos.ExluirDados((int)e.Row.Cells[0].Value, table);
            Controle controle = new Controle();
            AtualizarDados();
        }
        private void dataGridView5_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)

        {
            string table = "";
            switch (tab_Produtos.SelectedTab.Text)
            {
                case "Ácido Cloridrico":
                    table = "tblAcidocloridrico";
                    break;
                case "Ácido Sulfurico":
                    table = "tblAcidoSulfurico";
                    break;
                case "Tolueno":
                    table = "tblTolueno";
                    break;
                case "Hidroxido de Postásio":
                    table = "tblHidroxidoPostasio";
                    break;
                case "Acetona":
                    table = "tblAcetona";
                    break;
                case "Metiletilcetona":
                    table = "tblMetiletilcetona";
                    break;

            }
            LoginDalComandos comandos = new LoginDalComandos();
            comandos.ExluirDados((int)e.Row.Cells[0].Value, table);
            Controle controle = new Controle();
            AtualizarDados();
        }
        private void dataGridView6_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)

        {
            string table = "";
            switch (tab_Produtos.SelectedTab.Text)
            {
                case "Ácido Cloridrico":
                    table = "tblAcidocloridrico";
                    break;
                case "Ácido Sulfurico":
                    table = "tblAcidoSulfurico";
                    break;
                case "Tolueno":
                    table = "tblTolueno";
                    break;
                case "Hidroxido de Postásio":
                    table = "tblHidroxidoPostasio";
                    break;
                case "Acetona":
                    table = "tblAcetona";
                    break;
                case "Metiletilcetona":
                    table = "tblMetiletilcetona";
                    break;

            }
            LoginDalComandos comandos = new LoginDalComandos();
            comandos.ExluirDados((int)e.Row.Cells[0].Value, table);
            Controle controle = new Controle();
            AtualizarDados();
        }
        public void Cx_Produto_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Cx_Produto.Text)
            {
                case "Ácido Cloridrico":
                    Cx_Item.Text = "N4981917P012";
                    tab_Produtos.SelectTab(0);
                    break;
                case "Ácido Sulfúrico":
                    Cx_Item.Text = "Z40981302P025";
                    tab_Produtos.SelectTab(1);
                    break;
                case "Hidróxido De Potássio":
                    Cx_Item.Text = "Z40981302P003";
                    tab_Produtos.SelectTab(2);
                    break;
                case "Tolueno":
                    Cx_Item.Text = "Z40981302P017";
                    tab_Produtos.SelectTab(3);
                    break;
                case "Acetona":
                    Cx_Item.Text = "Z40981302P006";
                    tab_Produtos.SelectTab(4);
                    break;
                case "Metiletilcetona":
                    Cx_Item.Text = "Z40981302P005";
                    tab_Produtos.SelectTab(5);
                    break;

            }

        }
        private void BotaoLimparDados_Click(object sender, EventArgs e)
        {
            List<int> IdExclusao = new List<int>();
            string table = "";
            switch (tab_Produtos.SelectedTab.Text)
            {
                case "Ácido Cloridrico":
                    table = "tblAcidocloridrico";
                    IdExclusao.Add((int)dataGridView1.CurrentRow.Cells[0].Value);
                    break;
                case "Ácido Sulfurico":
                    table = "tblAcidoSulfurico";
                    IdExclusao.Add((int)dataGridView2.CurrentRow.Cells[0].Value);
                    break;
                case "Hidróxido De Potássio":
                    table = "tblHidroxidoPostasio";
                    IdExclusao.Add((int)dataGridView3.CurrentRow.Cells[0].Value);
                    break;
                case "Tolueno":
                    table = "tblTolueno";
                    IdExclusao.Add((int)dataGridView4.CurrentRow.Cells[0].Value);
                    break;

                case "Acetona":
                    table = "tblAcetona";
                    IdExclusao.Add((int)dataGridView5.CurrentRow.Cells[0].Value);
                    break;
                case "Metiletilcetona":
                    table = "tblMetiletilcetona";
                    IdExclusao.Add((int)dataGridView6.CurrentRow.Cells[0].Value);
                    break;

            }


            foreach (var id in IdExclusao)
            {
                comandos.ExluirDados(id, table);

            }
            AtualizarDados();


            //MessageBox.Show("Digite qual o registro que deseja excluir", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Question);

        }
        public void AtualizarDados()
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
        }
        public void ResetarForm()
        {
            Cx_Produto.ResetText();
            Cx_Item.ResetText();
            Cx_Numero_NF.ResetText();
            Cx_Pedido_Compra.ResetText();
            Cx_Data_Emissao_NF.ResetText();
            Cx_Data_Pedido.ResetText();
            Cx_Quant_Compra.ResetText();
            Cx_Quant_Usada.ResetText();
            Cx_Produto.Focus();

        }
    }
}

