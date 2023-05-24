using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            // instanciei a classe / criei o objeto
            TelaLoginPrincipal TelaLogin = new TelaLoginPrincipal();

            //usando metodo show
            TelaLogin.Show();

            //definindo a janela "pai" para o form TelaLogin, ou seja, obrigando a tela criada a ser aberta dentro do Form principal
            TelaLogin.MdiParent = this;

        }

        private void TelaLogin_Load(object sender, EventArgs e)
        {

        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // instanciei a classe / criei o objeto
            TelaCadastro TelaLogin = new TelaCadastro();

            //usando metodo show
            TelaLogin.Show();

            //definindo a janela "pai" para o form TelaLogin, ou seja, obrigando a tela criada a ser aberta dentro do Form principal
            TelaLogin.MdiParent = this;

        }
    }
}
