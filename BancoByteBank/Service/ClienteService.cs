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
        Menu menu = new Menu();
        readonly Cliente cliente;
        List<Cliente> clientes = new List<Cliente>();
        TituloDaOpcaoSelecionada titulo = new TituloDaOpcaoSelecionada();

        public void CadastraCliente()
        {
            Console.Clear();
            titulo.ExibindoTituloOpcao("Cadastro de Clientes");

            Console.WriteLine("\nDigite o nome do cliente: ");
            string nome = Console.ReadLine();

            Console.WriteLine("\nDigite o CPF do cliente: ");
            string cpf = Console.ReadLine();

            Console.WriteLine("\nDigite a profissão do cliente:\n");
            string profissao = Console.ReadLine();

            clientes.Add(new Cliente(nome, cpf, profissao)
            {
                Nome = nome,
                CPF = cpf,
                Profissao = profissao
            });

            Console.WriteLine($"\nCliente {nome} registrado com sucesso!");

            Thread.Sleep(2000);

            Console.Clear();

            menu.MenuBoasVindas();
        }

        public void RetornaClientesCadastrados()
        {
            ObtemLista().ToList();
            Console.Clear();
            titulo.ExibindoTituloOpcao("Exibindo clientes cadastrados");

            for (int i = 0; i < clientes.Count; i++)
            {
                Console.WriteLine("Cliente:\n");
                Console.WriteLine($"Identificador: {clientes[i].ID}");
                Console.WriteLine($"Nome: {clientes[i].Nome}");
                Console.WriteLine($"CPF: {clientes[i].CPF}");
                Console.WriteLine($"Profissão: {clientes[i].Profissao}\n");
            }

            Console.WriteLine("Pressione uma tecla para retornar ao menu: ");
            Console.ReadKey();

            Console.Clear();
            menu.MenuBoasVindas();
        }

        public IEnumerable<Cliente> ObtemLista()
        {
            clientes.Add(new Cliente()
            {
                ID = 0,
                Nome = "Tom",
                CPF = "Guerreiro",
                Profissao = "Aprendiz"
            });
            clientes.Add(new Cliente()
            {
                ID = 1,
                Nome = "Tomas",
                CPF = "Guerreiro",
                Profissao = "Aprendiz"
            });
            clientes.Add(new Cliente()
            {
                ID = 2,
                Nome = "Soy",
                CPF = "Mago",
                Profissao = "Aprendiz"
            });
            clientes.Add(new Cliente()
            {
                ID = 3,
                Nome = "D#",
                CPF = "Guerreiro",
                Profissao = "Aprendiz"
            });
            clientes.Add(new Cliente()
            {
                ID = 4,
                Nome = "D2",
                CPF = "Guerreiro",
                Profissao = "Aprendiz"
            });
            clientes.Add(new Cliente()
            {
                ID = 5,
                Nome = "D1",
                CPF = "Mago",
                Profissao = "Aprendiz"
            });
            clientes.Add(new Cliente()
            {
                ID = 6,
                Nome = "T3",
                CPF = "Guerreiro",
                Profissao = "Aprendiz"
            });
            clientes.Add(new Cliente()
            {
                ID = 7,
                Nome = "T2",
                CPF = "Guerreiro",
                Profissao = "Aprendiz"
            });
            clientes.Add(new Cliente()
            {
                ID = 8,
                Nome = "T1",
                CPF = "Mago",
                Profissao = "Aprendiz"
            });

            return clientes;
        }
    }
}
