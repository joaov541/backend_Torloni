

namespace PrimeiraClasse
{
    public class Hello
    {
        //Propriedades - Variáveis internas desta classe
        public string TextoHello = "";

        //Métodos/Comportamentos/Ações - são as funções internas desta classe 
        public void SaudarUsuario()
        {
            Console.WriteLine(this.TextoHello);
        }
        
          public void SaldarComNome(string n)
        {
         Console.WriteLine($"Olá {n}");
        }
    }
    
  
}