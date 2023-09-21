using DTO;
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
    public partial class TelaCriarConta : Form
    {
        public TelaCriarConta()
        {
            InitializeComponent();
        }

        private void btCriarConta_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSenhaCriar.Text == txtConfSenhaCriar.Text)
                {
                    Conta conta = new Conta();
                    conta.IdCliente = UsuarioLogado.IdCliente;
                    conta.StatusConta = "ATIVA";
                    conta.TipoConta = "Corrente";
                    conta.Saldo = Convert.ToDecimal(txtValDepConta.Text);
                    conta.Limite = UsuarioLogado.RendaMensal * 0.3m;
                    conta.DataAbertura = DateTime.Now;                   
                    conta.SenhaConta = txtSenhaCriar.Text;

                    //Criando uma conexão
                    SqlConnection conexao =
                               new SqlConnection(ConfigurationManager.ConnectionStrings["PrjtAula01.Properties.Settings.strConexao"].ToString());

                    //Criando um comando
                    SqlCommand cmd = new SqlCommand();

                    //criando texto do comando, tipo e conexão que será usada
                    cmd.CommandText = "pi_conta";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conexao;

                    //inserindo parâmetros à procedure
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("idCliente", conta.IdCliente);
                    cmd.Parameters.AddWithValue("statusConta", conta.StatusConta);
                    cmd.Parameters.AddWithValue("tipoConta", conta.TipoConta);
                    cmd.Parameters.AddWithValue("saldo", conta.Saldo);
                    cmd.Parameters.AddWithValue("limite", conta.Limite);                    
                    cmd.Parameters.AddWithValue("dataAbertura", conta.DataAbertura);                  
                    cmd.Parameters.AddWithValue("senhaConta", conta.SenhaConta);

                    //abrir a conexão
                    conexao.Open();

                    //executa o comando no BD e captura o retorno devolvido pelo procedimento
                    conta.IdConta = Convert.ToInt32(cmd.ExecuteScalar());

                    /*MessageBox.Show(conta.IdCliente.ToString());*/

                    conexao.Close();
                    MessageBox.Show($"Conta criada com sucesso!!!", "Info",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    UsuarioLogado.Contas.Add(conta);

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

        private void txtSenhaCriar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
