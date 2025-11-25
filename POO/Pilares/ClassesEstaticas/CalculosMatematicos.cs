
namespace ClassesEstaticas
{
    public static class CalculosMatematicos
    {
        
        //Operações Matemáticas Simles
        //visibilidade TipoDeRetorno Nome(Parâmetros) {corpo}

        public static float Somar(float a, float b)
        {
           return a+b;
        }

        //criar as outras três 3 operações
        //não se esqueça que não existe divisão
        //por zero, então na divisão 

        public static float Subtracao(float a, float b)
        {
            return a-b;
        }

        public static float Multiplicacao(float a, float b)
        {
            return a*b;
        }
        public static float Divisão(float a, float b)
        {

            if ( b == 0)
            {
                System.Console.WriteLine("Não é possível dividir com o número 0...");
                return 0;
            }

            return a/b;
        }

        


    }
}