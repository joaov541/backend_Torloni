
namespace Exemplos
{
    public abstract class ContaBancaria
    {
        public double Saldo;
        public abstract void Depositar(double valor);
       

        public abstract void Sacar(double valor);
      
    }
}