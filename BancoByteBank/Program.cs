using System;
using System.Collections.Generic;
using System.Text;

namespace BancoByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaCorrente = new ContaCorrente();

            contaCorrente.Titular = "Gabriela";
            contaCorrente.Agencia = 864;
            contaCorrente.Numero = 214545;
            contaCorrente.Saldo = 100;

            Console.WriteLine("Saldo: " + contaCorrente.Saldo);

            bool resultado = contaCorrente.Sacar(500);


            Console.WriteLine(resultado);

            Console.WriteLine("Saldo: " + contaCorrente.Saldo);

            contaCorrente.Depositar(500);

            Console.WriteLine("Saldo: " + contaCorrente.Saldo);

            Console.ReadLine();
        }
    }
}
