namespace PrjtAula01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BotaoEntrar_Click(object sender, EventArgs e)
        {
            //código quando o botão ENTRAR for clicado

            if (CaixaLogin.Text == "12345678900" && CaixaSenha.Text == "123456")
            {
                Mensagem.Text = "Usuário Verificado";
            }
            else
            {
                Mensagem.Text = "Usuário Inexistente";
            }
        }
    }
}