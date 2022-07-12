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

            contaCorrente.Titular = "Bruno";
            contaCorrente.Agencia = 864;
            contaCorrente.Numero = 214545;
            contaCorrente.Saldo = 100;

            Console.WriteLine("Saldo: " + contaCorrente.Saldo);

            bool resultado = contaCorrente.Sacar(500);


            Console.WriteLine(resultado);

            Console.WriteLine("Saldo: " + contaCorrente.Saldo);

            contaCorrente.Depositar(500);

            Console.WriteLine("Saldo: " + contaCorrente.Saldo);


            ContaCorrente contaGabriela = new ContaCorrente();

            contaGabriela.Titular = "Gabriela";
            contaGabriela.Saldo = 100;

            Console.WriteLine("Saldo Bruno: " + contaCorrente.Saldo);
            Console.WriteLine("Saldo Gabriela: " + contaGabriela.Saldo);

            contaCorrente.Transferir(200, contaGabriela);

            Console.WriteLine("Saldo Bruno: " + contaCorrente.Saldo);
            Console.WriteLine("Saldo Gabriela: " + contaGabriela.Saldo);

            bool resultadoTranferencia = contaCorrente.Transferir(200, contaGabriela);

            Console.WriteLine("Resultado da transferência: " + resultadoTranferencia);

            Console.ReadLine();
        }
    }
}
