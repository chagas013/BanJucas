using PrjtAula01.Classes;
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
    public partial class Teste : Form
    {
        Conta minhaConta;

        public Teste()
        {
            InitializeComponent();
        }

        private void Teste_Load(object sender, EventArgs e)
        {
            //Conta minhaConta = new Conta();
            //minhaConta.Saldo = 1000;
            //minhaConta.Status = "Ativa";

            //MessageBox.Show(minhaConta.Saldo.ToString() + " " + minhaConta.Status, "Minha Conta");

            minhaConta = new Conta (2, 0, 1000, "Ativa", 0, DateTime.Now, null, "Corrente" );
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            minhaConta.Depositar(Convert.ToDouble(txtVlrDpst.Text));
            lblTotalSaldo.Text = "Saldo: " + minhaConta.Saldo;
        }
    }
}
