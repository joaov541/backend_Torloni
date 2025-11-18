

namespace Exemplos
{
    public class Cachorro : Animal
    {
        public override void FazerSom()
        {
            System.Console.WriteLine($"Au Au Au");
        }

        public override void Mover()
        {
            System.Console.WriteLine($"Ploc Ploc Ploc");
        }
    }
}