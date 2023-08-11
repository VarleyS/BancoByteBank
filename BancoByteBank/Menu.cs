using BancoByteBank.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoByteBank
{
    public class Menu
    {
        ClienteService clienteService = new ClienteService();
        public void MenuBoasVindas()
        {
            Console.WriteLine(@"
██████╗░░█████╗░███╗░░██╗░█████╗░░█████╗░  ██████╗░███████╗░█████╗░██╗░░░██╗██████╗░░█████╗░
██╔══██╗██╔══██╗████╗░██║██╔══██╗██╔══██╗  ██╔══██╗╚════██║██╔══██╗██║░░░██║██╔══██╗██╔══██╗
██████╦╝███████║██╔██╗██║██║░░╚═╝██║░░██║  ██████╦╝░░███╔═╝██║░░╚═╝██║░░░██║██████╦╝██║░░██║
██╔══██╗██╔══██║██║╚████║██║░░██╗██║░░██║  ██╔══██╗██╔══╝░░██║░░██╗██║░░░██║██╔══██╗██║░░██║
██████╦╝██║░░██║██║░╚███║╚█████╔╝╚█████╔╝  ██████╦╝███████╗╚█████╔╝╚██████╔╝██████╦╝╚█████╔╝
╚═════╝░╚═╝░░╚═╝╚═╝░░╚══╝░╚════╝░░╚════╝░  ╚═════╝░╚══════╝░╚════╝░░╚═════╝░╚═════╝░░╚════╝░");

            Console.WriteLine("Bem vindo ao sistema!");
            Console.WriteLine();

            Console.WriteLine("Digite 1 para registro de conta: ");
            Console.WriteLine("Digite 2 para total de contas criadas: ");
            Console.WriteLine("Digite 3 para obter saldo: ");
            Console.WriteLine("Digite 4 para deposito de valor: ");
            Console.WriteLine("Digite 5 para registro de conta:");
            Console.WriteLine("Digite 6 para saque: ");
            Console.WriteLine("Digite 7 para transferência de valor: ");
            Console.WriteLine("Digite 8 para sair do sistema: ");
            Console.WriteLine();

            var opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1: clienteService.CadastraCliente();
                    break;
                case 2: Console.WriteLine("Você digitou opção " + opcao);
                    break;
                case 3: Console.WriteLine("Você digitou opção " + opcao);
                    break;
                case 4: Console.WriteLine("Você digitou opção " + opcao);
                    break;
                case 5: Console.WriteLine("Você digitou opção " + opcao);
                    break;
                case 6: Console.WriteLine("Você digitou opção " + opcao);
                    break;
                case 7: Console.WriteLine("Você digitou opção " + opcao);
                    break;
                case 8: Console.WriteLine("Você digitou opção " + opcao);
                    break;
                case 9: Console.WriteLine("Volte sempre!");
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
    }
}
