using System;
using System.Globalization;

namespace conta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Nome do titular: ");
            string titular = Console.ReadLine();
            Console.Write("Limite de saque: ");
            double limite = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Conta c = new Conta(numero, titular, limite);

            Console.WriteLine();
            Console.Write("Informe um valor para depósito: ");
            double valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.depositar(valorDeposito);
            Console.WriteLine("Novo saldo = R$: " + c.saldo.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine();
            Console.Write("Informe um valor para saque: ");
            double valorSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            if(c.saldo < valorSaque)
            {
                Console.WriteLine("Não há saldo suficiente! Saque Cancelado");
            }
            else if(valorSaque > c.limiteDeDaque)
            {
                Console.WriteLine("Valor do saque é superior ao limite da conta! Saque cancelado.");
            }
            else
            {
                c.sacar(valorSaque);
                Console.WriteLine("Novo saldo = R$: " + c.saldo.ToString("F2", CultureInfo.InvariantCulture));
            }
            Console.ReadLine();
             
        }
    }
}
