

namespace Exercicio02
{
    public class Fatura : IImprimivel
    {
        public string Devedor = "";
        public string Credor = "";
        public float valor = 0;
        public int DiasDeAtraso = 0;
        private float Juros = 0.10f;

        // Sobrecarga do Construtor - obriga a passar os dados na criação do objeto
        public Fatura(string dev, string cred, float valFat, int qtdAtraso)
        {
            Devedor = dev;
            Credor = cred;
            valor = valFat;
            DiasDeAtraso = qtdAtraso;
        }

        public Fatura()
        {
        }

        public void Imprimir()
        {
           CalcularValorDivida();
            System.Console.WriteLine($@"
Credor: {Credor} 
Devedor: {Devedor} 
Dias de Atraso: {DiasDeAtraso} dia(s)
Valor: R${valor:F2}
Júros: R${(Juros * DiasDeAtraso):F2}
Total Com Júros: R${valor:F2}
            ");//Já pula uma linha


        }


        public void CalcularValorDivida()
        {
            if (DiasDeAtraso > 0)
            {
                valor = valor + DiasDeAtraso * Juros;
            }

          if (DiasDeAtraso >= 5)
          {
             System.Console.WriteLine("Dívida encaminhada para o SERASA");
          }
        }
    }
}