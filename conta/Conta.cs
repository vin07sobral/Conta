using System;
using System.Collections.Generic;
using System.Text;

namespace conta
{
    class Conta
    {
        public int numero { get; set; }
        public string titular { get; set; }
        public double saldo { get; private set; }
        public double limiteDeDaque { get; set; }

        public Conta(int numero, string titular, double limiteDeSaque)
        {
            this.numero = numero;
            this.titular = titular;
            this.limiteDeDaque = limiteDeDaque;
            this.saldo = 0.0;
        }

        public void depositar(double valor)
        {
            saldo = saldo + valor;
        }

        public void sacar(double valor)
        {
            saldo = saldo - valor;
        }
    }
}
