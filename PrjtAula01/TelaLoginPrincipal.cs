using System.Diagnostics.Eventing.Reader;

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


            //código quando o botão ENTRAR for clicado

            string mensagem;

            if (caixaLogin.Text == String.Empty || senhaLogin.Text == String.Empty)
            {
                mensagem = "Dados não informados";
            }
            else if (caixaLogin.TextLength < 11 || senhaLogin.TextLength < 6)
            {
                mensagem = "Preencha os dados corretamente";
            }

            else
            {
                if (caixaLogin.Text == "12345678900" && senhaLogin.Text == "123456")
                {
                    mensagem = "Usuário Verificado";
                }
                else
                {
                    mensagem = "Usuário Inexistente";
                }

            }
            // Mensagem.Text = mensagem; // mensagem em um label

            MessageBox.Show(mensagem, "Aviso!");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void criarCadastro_Click(object sender, EventArgs e)
        {

        }
    }
}