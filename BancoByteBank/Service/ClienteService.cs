using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BancoByteBank.Service
{
    public class ClienteService
    {
        public void CadastraCliente()
        {
            Menu menu = new Menu();
            Console.Clear();
            List<Cliente> _listaClientes = new List<Cliente>();

            Console.WriteLine("Digite o nome do cliente: ");

            string nome = Console.ReadLine();

            Console.WriteLine("Digite o CPF do cliente: ");
            string cpf = Console.ReadLine();

            Console.WriteLine("Digite a profissão do cliente: ");
            string profissao = Console.ReadLine();

            _listaClientes.Add(new Cliente()
            {
                Nome = nome,
                CPF = cpf,
                Profissao = profissao
            });

            Console.WriteLine($"Cliente {nome} registrado com sucesso!");

            Thread.Sleep(2000);

            Console.Clear();
            menu.MenuBoasVindas();
        }
    }
}
