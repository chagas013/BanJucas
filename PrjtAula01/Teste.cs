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

            minhaConta = new Conta(2, 0, 1000, "Ativa", 0, DateTime.Now, null, "Corrente");
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            //Método informal - Concatenando (Separando o método por bloco)
            //lblTotalSaldo.Text = "Saldo: R$ " + minhaConta.Depositar(Convert.ToDouble(txtVlrDpst.Text)).ToString("n2");

            //Método formal - Template String sempre começar com $ (Técnica de programação que une texto com variáveis)
            lblTotalSaldo.Text = $"Saldo: R$ {minhaConta.Depositar(Convert.ToDouble(txtVlrDpst.Text)).ToString("n2")}.";

            Conta contaA = new Conta();
            contaA.Depositar(500);
            Conta contaB = new Conta();
            contaB.Depositar(1500);

            MessageBox.Show(Conta.RetornarSaldoTodasContas(), "Valor Total de depósitos");

        }

        private void btnSaque_Click(object sender, EventArgs e)
        {
            lblSaldo.Text = $"Saldo: R$ {minhaConta.Sacar(Convert.ToDouble(txtVlrDpst.Text)).ToString("n2")}.";
        }
    }
}
