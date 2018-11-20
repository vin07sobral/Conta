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
            if (saldo < valor)
            {
               throw new OperacaoException("Não há saldo suficiente! Saque Cancelado");
            }
            if (valor > limiteDeDaque)
            {
                throw new OperacaoException("Valor do saque é superior ao limite da conta! Saque cancelado.");
            }
            
            saldo = saldo - valor;
        }
    }
}
