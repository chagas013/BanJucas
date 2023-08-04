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
        public Collection()
        {
            InitializeComponent();
        }

        private void Collection_Load(object sender, EventArgs e)
        {
            //declarando e criando vetores (2, no caso)
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
                MessageBox.Show(mensagemFinal);

        }
    }
}
