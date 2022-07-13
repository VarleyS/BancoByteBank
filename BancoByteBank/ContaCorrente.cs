using BancoByteBank;

namespace BancoByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }
        public int Agencia { get; set; }
        public int Numero { get; set; }
        private double Saldo;

        public void DefinirSaldo(double saldo)
        {
            if(saldo < 0)
            {
                return;
            }
            
            this.Saldo = saldo;
           
        }

        public double ObterSaldo()
        {
            return Saldo;
        }


        public bool Sacar(double valor)
        {
            if (Saldo < valor)
            {
                return false;
            }

            Saldo -= valor;
            return true;

        }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (Saldo < valor)
            {
                return false;
            }
            Saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }
}
