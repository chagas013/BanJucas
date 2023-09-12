using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjtAula01
{
    public partial class TelaAlterarDados : Form
    {
        public TelaAlterarDados()
        {
            InitializeComponent();
        }

        private void btSalvarAlteracao_Click(object sender, EventArgs e)
        {

            try
            {
                SqlConnection conexao =
                               new SqlConnection(ConfigurationManager.ConnectionStrings["PrjtAula01.Properties.Settings.strConexao"].ToString());

                //Criando um comando
                SqlCommand cmd = new SqlCommand();

                //criando texto do comando, tipo e conexão que será usada
                cmd.CommandText = "pu_alterarDados";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conexao;

                //inserindo parâmetros à procedure
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("nome", txtAlterarNome.Text);
                cmd.Parameters.AddWithValue("cpf", txtAlterarCpf.Text);
                cmd.Parameters.AddWithValue("rg", txtAlterarRg.Text);
                cmd.Parameters.AddWithValue("dataNascimento", Convert.ToDateTime(cbAlterarDataNasc.Text));
                cmd.Parameters.AddWithValue("telefone", txtAlterarCel.Text);
                cmd.Parameters.AddWithValue("celular", txtAlterarTel.Text);
                cmd.Parameters.AddWithValue("email", txtAlterarEmail.Text);
                cmd.Parameters.AddWithValue("logradouro", txtAlterarLogradouro.Text);
                cmd.Parameters.AddWithValue("numeroLogradouro", txtAlterarNumeroLogradouro.Text);
                cmd.Parameters.AddWithValue("cep", txtAlterarCep.Text);
                cmd.Parameters.AddWithValue("cidade", txtAlterarCidade.Text);
                cmd.Parameters.AddWithValue("estado", cbAlterarEstado.Text);
                cmd.Parameters.AddWithValue("genero", cbAlterarGenero.Text);
                cmd.Parameters.AddWithValue("renda", Convert.ToDecimal(txtAlterarRenda.Text));


                //abrir a conexão
                conexao.Open();

                cmd.ExecuteNonQuery(); //executa o comando no BD

                conexao.Close();

                MessageBox.Show("Cliente alterado com sucesso!!!", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                UIclear.limparTelas(this);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TelaAlterarDados_Load(object sender, EventArgs e)
        {
            txtAlterarNome.Text = UsuarioLogado.Nome;
            txtAlterarCpf.Text = UsuarioLogado.Cpf;
            txtAlterarRg.Text = UsuarioLogado.Rg;
            cbAlterarDataNasc.Text = Convert.ToString(UsuarioLogado.DataNascimento);
            txtAlterarTel.Text = UsuarioLogado.Telefone;
            txtAlterarCel.Text = UsuarioLogado.Celular;
            txtAlterarEmail.Text = UsuarioLogado.Email;
            txtAlterarLogradouro.Text = UsuarioLogado.Logradouro;
            txtAlterarNumeroLogradouro.Text = UsuarioLogado.NumeroLogradouro;
            txtAlterarCep.Text = UsuarioLogado.Cep;
            txtAlterarEmail.Text = UsuarioLogado.Email;
            txtAlterarCidade.Text = UsuarioLogado.Cidade;
            cbAlterarEstado.Text = UsuarioLogado.Estado;
            cbAlterarGenero.Text = UsuarioLogado.Genero;
            txtAlterarRenda.Text = Convert.ToString (UsuarioLogado.RendaMensal);


        }
    }
}
