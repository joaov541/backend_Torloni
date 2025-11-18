

namespace Exemplos
{
    public class ControleRemoto : IControle
    {
        public int NivelVolume = 0;
        public int VolumeMaximo = 100;
        public void AumentarVolume()
        {
            if (NivelVolume < VolumeMaximo)
            {
                NivelVolume++;
                System.Console.WriteLine($"Nível atual do volume: {NivelVolume}");
            }
            else
            {
                System.Console.WriteLine($"O volume já atingiu o nível Máximo: {NivelVolume}");
            }
        }

        public void Desligar()
        {
            System.Console.WriteLine("Desligando a TV...");
        }

        public void DiminuirVolume()
        {
            if (NivelVolume == 0)
            {
                System.Console.WriteLine($"O volume já está no mínimo: {NivelVolume}");
            }
            else
            {
                System.Console.WriteLine($"Volume atual: {NivelVolume}");
            }
        }

        public void Ligar()
        {
            System.Console.WriteLine("Ligando a TV...");
        }
    }
}