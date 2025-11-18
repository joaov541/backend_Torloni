
namespace Exemplos
{
    public class ContaCorrente : ContaBancaria
    {
        public double Saldo;
        public double Taxa = 0.05;
        public override void Depositar(double valor)
        {


             if (valor <= 0 )
            {
                System.Console.WriteLine($"O valor do depósito deve ser maior que R$0,00");
                return;
            }

            Saldo += valor;
        }

        public override void Sacar(double valor)
        {
            double taxa = valor + (valor * Taxa);
            double total = valor + taxa;

            if (Saldo >= total)
            {
                Saldo -= total;
            }
            else
            {
                System.Console.WriteLine("Saldo insuficiente na conta");
            }
        }
    }
}