using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjtAula01.Classes
{
    public class Conta
    {

        public int IdConta { get; set; }
        public int IdCliente { get; set; }
        public double Saldo { get; set; }
        public string Status { get; set; }
        public double Limite { get; set; }
        public DateTime DataAbertura { get; set; }
        public DateTime DataEncerramento { get; set; }




        public Conta() { 
        
        }

        public Conta(int idConta, int idCliente, double Saldo, string Status, double Limite, DateTime DataAbertura)
        {
            this.IdConta = idConta;
            this.IdCliente = idCliente;
            this.Saldo = Saldo;
            this.Status = Status;
            this.Limite = Limite;
            this.DataAbertura = DataAbertura;

        }
    }
}
