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



            Console.WriteLine("Nome do titular: " + contaCorrente.Titular);
            Console.WriteLine("Agencia: " + contaCorrente.Agencia);
            Console.WriteLine("Número: " + contaCorrente.Numero);
            Console.WriteLine("Saldo: " + contaCorrente.Saldo);

            Console.ReadLine();
        }
    }
}
