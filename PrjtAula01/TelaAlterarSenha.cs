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
    public partial class TelaAlterarSenha : Form
    {
        public TelaAlterarSenha()
        {
            InitializeComponent();
        }

        private void btSalvarSenha_Click(object sender, EventArgs e)
        {
            try
            {
                if (UsuarioLogado.Senha == txtSenhaAtual.Text)
                {

                    if (txtAlterarSenha.Text == txtConfAlterarSenha.Text)
                    {
                        SqlConnection conexao =
                        new SqlConnection(ConfigurationManager.ConnectionStrings["PrjtAula01.Properties.Settings.strConexao"].ToString());
                    
                        SqlCommand cmd = new SqlCommand();
                    

                        cmd.CommandText = "pu_AlterarSenha";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = conexao;


                        cmd.Parameters.Clear();

                        cmd.Parameters.AddWithValue("idCliente", UsuarioLogado.IdCliente);
                        cmd.Parameters.AddWithValue("senhaLogin", txtAlterarSenha.Text);


                        conexao.Open();

                        cmd.ExecuteNonQuery();

                        conexao.Close();

                        MessageBox.Show("Senha alterada com sucesso!", "Info!");

                        UIclear.limparTelas(this);

                        this.Close();
                    }

                    else
                    {
                        throw new Exception("As Senhas Não Conferem!");
                    }
                }

                else
                {
                    throw new Exception("A senha atual está incorreta!");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        
    }
}

