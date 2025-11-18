

namespace Exemplos
{
    public class Pessoa : Animal
    {
        public override void FazerSom()
        {
            System.Console.WriteLine($"Olá, sou uma pessoa");
        }

        public override void Mover()
        {
            System.Console.WriteLine($"Walk Walk Walk");
        }
    }
}