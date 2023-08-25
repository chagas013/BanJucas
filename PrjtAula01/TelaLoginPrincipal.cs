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


            try
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

                conexao.Open(); //abrindo a conexão

                leitor = cmd.ExecuteReader();
                //igualando o leitor ao resultado trazido do BD (só é usado ExecuteReader quando há "select" no banco)

                if (leitor.HasRows) //se o leitor encontrar linhas de dados
                {
                    leitor.Read();

                    UsuarioLogado.IdCliente = leitor.GetInt32(0);
                    UsuarioLogado.Nome = leitor.GetString(1);
                    UsuarioLogado.Cpf = leitor.GetString(2);

                    if (leitor.IsDBNull (3))
                    {
                        UsuarioLogado.Rg = leitor.GetString(3);
                    }

                    UsuarioLogado.DataNascimento = leitor.GetDateTime(4);

                    if (leitor.IsDBNull(5))
                    {
                        UsuarioLogado.Telefone = leitor.GetString(5);
                    }

                    UsuarioLogado.Celular = leitor.GetString(6);

                    if (leitor.IsDBNull(7))
                    {
                        UsuarioLogado.Email = leitor.GetString(7);
                    }

                    UsuarioLogado.Logradouro = leitor.GetString(8);
                    UsuarioLogado.NumeroLogradouro = leitor.GetString(9);
                    UsuarioLogado.Cep = leitor.GetString(10);
                    UsuarioLogado.Cidade = leitor.GetString(11);
                    UsuarioLogado.Estado = leitor.GetString(12);
                    UsuarioLogado.Genero = leitor.GetString(13);
                    UsuarioLogado.RendaMensal = leitor.GetDouble(14);
                    UsuarioLogado.Senha = leitor.GetString(15);

                    //fechando leitor
                    leitor.Close();

                    //criando texto do comando, tipo e conexão que será usada
                    cmd.CommandText = "ps_buscaContasPorIdCliente";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conexao;

                    //passando os parâmetros necessários
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("idCliente", UsuarioLogado.IdCliente);

                    //ler novamente o leitor
                    leitor = cmd.ExecuteReader();

                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorretos!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }


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