using BancoByteBank;

namespace BancoByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }
        public int Agencia { get; set; }
        public int Numero { get; set; }

        public double Saldo;
        public static int TotalDeContasCriadas { get; private set; }

        public ContaCorrente()
        {
        }

        public ContaCorrente(Cliente cliente, int agencia, int numero)
        {
            Titular = cliente;
            Agencia = agencia;
            Numero = numero;

            TotalDeContasCriadas++;
        }
    }
}
