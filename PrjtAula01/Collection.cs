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
    public partial class Collection : Form
    {
        List<Cliente> Clientes = new List<Cliente>();

        Cliente clienteUm;
        public Collection()
        {
            InitializeComponent();
        }

        private void Collection_Load(object sender, EventArgs e)
        {
            /*declarando e criando vetores (2, no caso)
            string[] meuArrayString = new string[3];
            //declarando vetores com valores
            int[] meuArrayInt = { 2, 3, 7, 9, 10 };

            //colocando infos nos arrays
            meuArrayString[0] = "Tobias";
            meuArrayString[1] = "Little";
            meuArrayString[2] = "Chagas";
            //exibindo infos dos arrays
            string mensagemFinal = "";
            for (int contador = 0; contador < meuArrayString.Length; contador++)
            {

                mensagemFinal = mensagemFinal + $"{meuArrayString[contador]}\n";

            }
            MessageBox.Show(mensagemFinal);*/


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = new Cliente(Convert.ToInt32(txtID.Text), txtNome.Text);
                MessageBox.Show("Cliente adicionado com sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clientes.Add(cliente);

            }
            catch (FormatException ex)
            {
                MessageBox.Show($"{ex.HResult} - Formato inválido!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.HResult} - {ex.Message}");

            }



            txtID.Clear();
            txtNome.Clear();
            txtID.Focus();

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            listListar.Items.Clear();
            foreach (var cliente in Clientes) 
            {
                //MessageBox.Show($"{cliente.IdCliente} : {cliente.NomeCliente}");
                listListar.Items.Add($"{cliente.IdCliente} - {cliente.NomeCliente}");
                txtID.Focus();
            
            }
        }
    }
}
