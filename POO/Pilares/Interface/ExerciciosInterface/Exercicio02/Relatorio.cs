

namespace Exercicio02
{
    public class Relatorio : IImprimivel
    {
        public string Nome = "";
        public string TextoRelatorio = "";

        public Relatorio()
        {
        }


        //Sobrecarga do construtor
        public Relatorio(string responsavel, string txtRelatorio)
        {
            Nome = responsavel;
            TextoRelatorio = txtRelatorio;
        }
        public void Imprimir()
        {
            System.Console.WriteLine($"Responsável: {Nome}");
            System.Console.WriteLine(TextoRelatorio);
            System.Console.WriteLine($"--");
        }
    }
}