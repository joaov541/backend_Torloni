

namespace Exemplos
{
    public class Gato : Animal
    {
        public override void FazerSom()
        {
           System.Console.WriteLine($"Miua Miau Miau");
        }

        public override void Mover()
        {
            System.Console.WriteLine($"Tic Tic Tic");
        }
    }
}