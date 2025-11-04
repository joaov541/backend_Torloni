

namespace PrimeiraClasse
{
    public class Moto
    {
        //Propriedades
        public int qtdRodas = 2;
        public string marca = "";
        public string modelo = "";
        public string cor = "";

        //Métodos

          public void Acelerar()
        {
            Console.WriteLine($"Moto Acelerando");
        }
          public void Frear()
        {
            Console.WriteLine($"Moto Freando");
        }
          public void Parar()
        {
            Console.WriteLine($"Moto Parada");
        }

    }
}