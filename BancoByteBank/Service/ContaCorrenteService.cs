using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BancoByteBank.Service
{
    public class ContaCorrenteService
    {
        Menu menu = new Menu();
        ClienteService clienteService = new ClienteService();
        ContaCorrente conta = new ContaCorrente();
        List<ContaCorrente> contaCorrentes = new List<ContaCorrente>();
        TituloDaOpcaoSelecionada titulo = new TituloDaOpcaoSelecionada();

        public void AdicionaContaCorrente()
        {
            var clientes = clienteService.ObtemListaDeClientes();
            Console.Clear();
            titulo.ExibindoTituloOpcao("Cadastro de Conta Corrente");

            Console.WriteLine("Digite o nome do cliente:");
            string nome = Console.ReadLine();

            foreach (var cliente in clientes)
            {
                if(nome == cliente.Nome)
                {
                    contaCorrentes.Add(new ContaCorrente
                    {
                        Titular = cliente,
                        Agencia = NumeroAgencia(),
                        Numero = NumeroConta()
                    });
                }
            }

            Console.WriteLine($"\nConta Corrente em nome de {nome} registrada com sucesso!");

            Thread.Sleep(2000);

            Console.WriteLine(ObtemListaDeContas().ToString());

            Console.Clear();

            menu.MenuBoasVindas();
        }

        public void DefinirSaldo(double saldo)
        {
            if (saldo < 0)
            {
                return;
            }

            conta.Saldo = saldo;

        }

        public double ObterSaldo()
        {
            return conta.Saldo;
        }

        public bool Sacar(double valor)
        {
            if (conta.Saldo < valor)
            {
                return false;
            }

            conta.Saldo -= valor;
            return true;

        }

        public void Depositar(double valor)
        {
            conta.Saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrenteService contaDestino)
        {
            if (conta.Saldo < valor)
            {
                return false;
            }
            conta.Saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }

        public int NumeroConta()
        {
            Random rdn = new Random();

            int num = rdn.Next(100000);
            
            return num;
        }

        public int NumeroAgencia()
        {
            int num = 1204;
            return num;
        }
        public List<ContaCorrente> ObtemListaDeContas()
        {
            var lista = clienteService.ObtemListaDeClientes();

            contaCorrentes.Add(new ContaCorrente
            {
                Titular = lista.First(),
                Agencia = 1204,
                Numero = NumeroConta()
            });

            return contaCorrentes;
        }
    }
}
