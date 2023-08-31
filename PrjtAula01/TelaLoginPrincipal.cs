using System.Configuration;
using System.Data;
using System;
using System.Diagnostics.Eventing.Reader;
using PrjtAula01.Classes;
using System.Data.SqlClient;
using DTO;

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

                    if (!leitor.IsDBNull (3))
                    {
                        UsuarioLogado.Rg = leitor.GetString(3);
                    }

                    UsuarioLogado.DataNascimento = leitor.GetDateTime(4);

                    if (!leitor.IsDBNull(5))
                    {
                        UsuarioLogado.Telefone = leitor.GetString(5);
                    }

                    UsuarioLogado.Celular = leitor.GetString(6);

                    if (!leitor.IsDBNull(7))
                    {
                        UsuarioLogado.Email = leitor.GetString(7);
                    }

                    UsuarioLogado.Logradouro = leitor.GetString(8);
                    UsuarioLogado.NumeroLogradouro = leitor.GetString(9);
                    UsuarioLogado.Cep = leitor.GetString(10);
                    UsuarioLogado.Cidade = leitor.GetString(11);
                    UsuarioLogado.Estado = leitor.GetString(12);
                    UsuarioLogado.Genero = leitor.GetString(13);
                    UsuarioLogado.RendaMensal = leitor.GetDecimal(14);
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

                    

                    //verificar se há linhas retornadas do leitor
                    if (leitor.HasRows)
                    {
                        //repete a leitura e enquanto há linhas segue na estrutura
                        //de repetição
                        while (leitor.Read())
                        {
                            //cria uma conta na memória
                            Conta conta = new Conta();
                            //passa os dados do leitor para a conta na memória - objeto conta
                            conta.IdConta = leitor.GetInt32(0);
                            conta.IdCliente = leitor.GetInt32(1);
                            conta.StatusConta = leitor.GetString(2);
                            conta.TipoConta = leitor.GetString(3);
                            conta.Saldo = leitor.GetDecimal(4);
                            conta.Limite = leitor.GetDecimal(5);
                            conta.DataAbertura = leitor.GetDateTime(6);                           
                            conta.SenhaConta = leitor.GetString(8);


                            //adiciona a conta recém criada na memória para a colection de contas
                            UsuarioLogado.Contas.Add(conta);
                        }
                    }
                    leitor.Close(); //fecha leitor
                    conexao.Close(); //fecha conexao com BD

                    Form telaPrincipal = Application.OpenForms["TelaLogin"];
                    //acessando o formulário aberto através da variável janelaPrincipal
                    MenuStrip menuPrincipal = (MenuStrip)telaPrincipal.Controls[0];
                    menuPrincipal.Items[0].Text = "Logout";
                    menuPrincipal.Items[1].Visible = true;
                    menuPrincipal.Items[2].Visible = true;
                    menuPrincipal.Items[3].Visible = true;
                    menuPrincipal.Items[4].Visible = true;                                       
                    menuPrincipal.Items[5].Visible = true;                    



                    MessageBox.Show($"Olá,{UsuarioLogado.Nome}!\n" +
                        $"Você foi logado na conta {UsuarioLogado.Contas[0].IdCliente.ToString()}\n" +
                        $"Para trocar de conta, utilize o menu Conta\\Alternar Conta");
                    //MessageBox.Show($"{CorrentistaLogado.Id.ToString()},{CorrentistaLogado.NomeCorrentista},{CorrentistaLogado.DataNascimento.ToString()},{CorrentistaLogado.Logradouro}," +
                    //    $"{CorrentistaLogado.Numero},{CorrentistaLogado.Complemento},{CorrentistaLogado.Cidade}," +
                    //    $"{CorrentistaLogado.Estado},{CorrentistaLogado.Cpf},{CorrentistaLogado.Senha},{CorrentistaLogado.Celular}");
                    this.Close();                   
                    
                    
                    


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