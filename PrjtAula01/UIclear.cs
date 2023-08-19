using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjtAula01
{
    
    public class UIclear
    {
        public static void limparTelas(Form form)
        {
            foreach (Control controle in form.Controls)
            {
                if (controle is TextBox)
                {
                    ((TextBox)controle).Clear();
                }
            }
        }
    }
}
