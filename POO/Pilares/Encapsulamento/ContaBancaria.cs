

using System.Diagnostics.Contracts;

namespace Encapsulamento
{
    public class ContaBancaria
    {
        private float Saldo;

        public ContaBancaria()
        {
            Saldo = 0;
        }

        public ContaBancaria(float saldoInicial)
        {
            if (saldoInicial > 0)
            {
                Saldo = saldoInicial;
            }
           
        }


        //Método público que seta/configura/guarda o saldo
        public void Depositar(float valor)
        {
            if (valor >= 0)
            {
                 Saldo = valor;
                 return;
            }

            System.Console.WriteLine($"Valor para depósito inválido...");
           
        }


        //Método público que retorna o saldo
        public float GetSaldo()
        {
            return Saldo;
        }

        //Crie o método público Sacar(float valor)

        public void Sacar(float valor)
        {
            if (valor >= 0 && valor <= Saldo)
            {
                Saldo -= valor;
                System.Console.WriteLine($"Saque realizado com sucesso...");
                return;
            }

            System.Console.WriteLine("Valor para saque inválido...");
            
        }

    }
}