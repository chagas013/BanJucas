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
    public partial class TelaCadastro : Form
    {
        public TelaCadastro()
        {
            InitializeComponent();
        }

        private void lblCriarCadastro_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TelaCadastro_Load(object sender, EventArgs e)
        {

        }

        private void txtValDepCad_TextChanged(object sender, EventArgs e)
        {

        }

        private void btAcessoCad_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSenhaCad.Text == txtConfSenhaCad.Text)
                {
                    //Criando uma conexão
                    SqlConnection conexao =
                           new SqlConnection(ConfigurationManager.ConnectionStrings["PrjtAula01.Properties.Settings.strConexao"].ToString());

                    //Criando um comando
                    SqlCommand cmd = new SqlCommand();

                    //criando texto do comando, tipo e conexão que será usada
                    cmd.CommandText = "pi_cadastroCliente";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conexao;

                    //inserindo parâmetros à procedure
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("nome", txtNomeCad.Text);
                    cmd.Parameters.AddWithValue("cpf", txtCpfCad.Text);
                    cmd.Parameters.AddWithValue("rg", txtRgCad.Text);
                    cmd.Parameters.AddWithValue("dataNascimento", Convert.ToDateTime(dataNasc.Text));
                    cmd.Parameters.AddWithValue("telefone", txtTelCad.Text);
                    cmd.Parameters.AddWithValue("celular", txtTelCad.Text);
                    cmd.Parameters.AddWithValue("email", txtEmailCad.Text);
                    cmd.Parameters.AddWithValue("logradouro", txtLogradouro.Text);
                    cmd.Parameters.AddWithValue("numeroLogradouro", txtNumeroLogradouro.Text);
                    cmd.Parameters.AddWithValue("cep", txtCEP.Text);
                    cmd.Parameters.AddWithValue("cidade", txtCidade.Text);
                    cmd.Parameters.AddWithValue("estado", cbEstado.Text);
                    cmd.Parameters.AddWithValue("genero", txtGeneroCad.Text);
                    cmd.Parameters.AddWithValue("renda", Convert.ToDecimal(txtRendaCad.Text));
                    cmd.Parameters.AddWithValue("senhaLogin", txtSenhaCad.Text);


                    //abrir a conexão
                    conexao.Open();
                    cmd.ExecuteNonQuery(); //executa o comando no BD
                    conexao.Close();
                    MessageBox.Show("Cliente cadastrado com sucesso!!!", "Info",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    UIclear.limparTelas(this);
                }
                else
                {
                    throw new Exception("Os campos de senha não coincidem!!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
