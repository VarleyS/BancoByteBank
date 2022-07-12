

public class ContaCorrente
{
    public string Titular;
    public int Agencia;
    public int Numero;
    public double Saldo;


    public bool Sacar(double valor)
    {
        if(this.Saldo < valor)
        {
            return false;
        }
        
        this.Saldo -= valor;
        return true;
        
    }

    public void Depositar(double valor)
    {
        this.Saldo += valor;
    } 

    public bool Transferir(double valor, ContaCorrente contaDestino)
    {
        if(this.Saldo < valor)
        {
            return false;
        }
        this.Saldo -= valor;
        contaDestino.Depositar(valor);
        return true;
    }
}