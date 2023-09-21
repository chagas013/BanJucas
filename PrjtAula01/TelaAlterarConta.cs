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
    public partial class TelaAlterarConta : Form
    {
        public TelaAlterarConta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                SqlConnection conexao =
                new SqlConnection(ConfigurationManager.ConnectionStrings["PrjtAula01.Properties.Settings.strConexao"].ToString());
                SqlDataReader leitor;

                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "ps_ValidarSenhaConta";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conexao;

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("idConta", cbAlterarConta.Text);
                cmd.Parameters.AddWithValue("senhaConta", txtConfirmarSenhaContas.Text);

                conexao.Open();

                leitor = cmd.ExecuteReader();                

                if (leitor.HasRows)
                {
                    UsuarioLogado.contaLogada = Convert.ToInt32(cbAlterarConta.Text);
                    MessageBox.Show($"Você está agora na conta {UsuarioLogado.contaLogada}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                       
                }
                else
                {
                    throw new Exception("Senha Incorreta.");
                }

                conexao.Close();
                UIclear.limparTelas(this);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            

        }

        private void cbAlterarConta_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void TelaAlterarConta_Load(object sender, EventArgs e)
        {
            foreach (var item in UsuarioLogado.Contas)
            {
                cbAlterarConta.Items.Add(item.IdConta);
            }

            cbAlterarConta.Text = cbAlterarConta.Items[0].ToString();
        }
    }
}
