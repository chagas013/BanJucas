using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrjtAula01.Classes;

namespace PrjtAula01
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.menu.Items[0].Text == "Logar")
            {
                TelaLoginPrincipal telaLogin = new TelaLoginPrincipal();
                telaLogin.MdiParent = this;
                telaLogin.Show();
            }
            else
            {
                menu.Items[0].Text = "Logar";
                menu.Items[1].Visible = true;
                menu.Items[2].Visible = false;
                menu.Items[3].Visible = false;
                menu.Items[4].Visible = false;
                menu.Items[5].Visible = false;
                menu.Items[6].Visible = false;
                UsuarioLogado.Deslogar();
            }
        }

        private void TelaLogin_Load(object sender, EventArgs e)
        {

        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var telaLogin = new TelaLoginPrincipal();

            // instanciei a classe / criei o objeto
            TelaCadastro TelaCad = new TelaCadastro();


            //definindo a janela "pai" para o form TelaLogin, ou seja, obrigando a tela criada a ser aberta dentro do Form principal
            TelaCad.MdiParent = this;

            //usando metodo show
            TelaCad.Show();



        }

        private void depósitoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaDeposito janelaDeposito = new TelaDeposito();
            janelaDeposito.MdiParent = this;
            janelaDeposito.Show();
        }

        private void saqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaSaque janelaSaque = new TelaSaque();
            janelaSaque.MdiParent = this;
            janelaSaque.Show();
        }

        private void transferênciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaTransferencia janelaTransferencia = new TelaTransferencia();
            janelaTransferencia.MdiParent = this;
            janelaTransferencia.Show();
        }

        private void logarToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarContaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (menu.Items[1].Text == "Criar Conta")
            {
                TelaCriarConta criarConta = new TelaCriarConta();
                criarConta.MdiParent = this;
                criarConta.Show();
            }

            else
            {
                TelaCadastro cadastrarConta = new TelaCadastro();
                cadastrarConta.MdiParent = this;
                cadastrarConta.Show();
            }

        }

        private void alterarDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaAlterarDados telaAlterarDados = new TelaAlterarDados();
            telaAlterarDados.MdiParent = this;
            telaAlterarDados.Show();

        }

        private void alterarSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaAlterarSenha telaAlterarSenha = new TelaAlterarSenha();
            telaAlterarSenha.MdiParent = this;
            telaAlterarSenha.Show();
        }

        private void contasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
