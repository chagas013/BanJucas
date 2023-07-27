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
        public double Saldo { get; set; } = 0;
        public string? Status { get; set; }
        public double Limite { get; set; }
        public DateTime DataAbertura { get; set; }
        public DateTime? DataEncerramento { get; set; }
        public string? TipoConta { get; set; }




        public Conta() { 
        
        }

        public Conta(int idConta, int idCliente, double saldo, string status, double limite, 
                      DateTime dataAbertura, DateTime? dataEncerramento, string? tipoConta)
        {
            this.IdConta = idConta;
            this.IdCliente = idCliente;
            this.Saldo = saldo;
            this.Status = status;
            this.Limite = limite;
            this.DataAbertura = dataAbertura;
            this.DataEncerramento = dataEncerramento;
            this.TipoConta = tipoConta;

        }

        //Criando método de depósito

        public double Depositar(double valorDeposito)
        {

            this.Saldo = this.Saldo + valorDeposito;
            return this.Saldo;

        }
    }
}
