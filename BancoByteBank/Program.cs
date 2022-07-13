using System;
using System.Collections.Generic;
using System.Text;

namespace BancoByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente gabriela = new Cliente();

            gabriela.Nome = "Gabriela";
            gabriela.Profissao = "Dev c#";
            gabriela.CPF = "111.111.111.11";

            ContaCorrente conta = new ContaCorrente();

            conta.titular = gabriela;
            conta.Agencia = 652;
            conta.Numero = 5652358;
            conta.Saldo = 100;



            Console.ReadLine();
        }
    }
}
