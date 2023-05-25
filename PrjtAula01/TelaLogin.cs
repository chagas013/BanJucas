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
            TelaLoginPrincipal TelaLoginPrin = new TelaLoginPrincipal();

            //usando metodo show
            TelaLoginPrin.Show();

            //definindo a janela "pai" para o form TelaLogin, ou seja, obrigando a tela criada a ser aberta dentro do Form principal
            TelaLoginPrin.MdiParent = this;

        }

        private void TelaLogin_Load(object sender, EventArgs e)
        {

        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var telaLogin = new TelaLoginPrincipal();

            // instanciei a classe / criei o objeto
            TelaCadastro TelaCad = new TelaCadastro();

            //usando metodo show
            TelaCad.Show(); 
            

            //definindo a janela "pai" para o form TelaLogin, ou seja, obrigando a tela criada a ser aberta dentro do Form principal
            TelaCad.MdiParent = this;

        }
    }
}
