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
    public partial class MenuPrincipal : Form
    {

        public MenuPrincipal()
        {

            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void depositar_Click(object sender, EventArgs e)
        {

            // instanciei a classe / criei o objeto
            TelaDeposito TelaDep = new TelaDeposito();
            MenuPrincipal TelaPrin = new MenuPrincipal();

            //usando metodo show
            TelaDep.Show(this);


        }

        private void sacar_Click(object sender, EventArgs e)
        {
            // instanciei a classe / criei o objeto
            TelaSaque TelaSaque = new TelaSaque();

            //usando metodo show

            TelaSaque.Show();
        }

        private void sairMenu_Click(object sender, EventArgs e)
        {

        }
        public void voltarPag()
        {
            this.Close();
        }

        private void agdPagto_Click(object sender, EventArgs e)
        {

        }
    }
}
