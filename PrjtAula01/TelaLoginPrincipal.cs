using System.Configuration;
using System.Data;
using System;
using System.Diagnostics.Eventing.Reader;
using PrjtAula01.Classes;
using System.Data.SqlClient;

namespace PrjtAula01
{
    public partial class TelaLoginPrincipal : Form
    {
        public TelaLoginPrincipal()
        {
            InitializeComponent();
        }

        private void BotaoEntrar_Click(object sender, EventArgs e)
        {

            
            //Criando uma conexão

            SqlConnection conexao =
            new SqlConnection(ConfigurationManager.ConnectionStrings["PrjtAula01.Properties.Settings.strConexao"].ToString());

            SqlDataReader leitor; //declarando uma variável do tipo leitor de dados

            //Criando um comando
            SqlCommand cmd = new SqlCommand();

            //criando texto do comando, tipo e conexão que será usada
            cmd.CommandText = "ps_validaLogin";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conexao;

            //passando parâmetros necessários
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("cpf", caixaLogin.Text);
            cmd.Parameters.AddWithValue("senhaLogin", senhaLogin.Text);


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void criarCadastro_Click(object sender, EventArgs e)
        {
            // instanciei a classe / criei o objeto
            TelaCadastro telaCadastro = new TelaCadastro();
            telaCadastro.MdiParent = this;

            //usando metodo show
            telaCadastro.Show();

        }

        private void caixaLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TelaLoginPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}