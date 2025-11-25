using System.ComponentModel.DataAnnotations;
using ClassesEstaticas;

Console.Clear();

System.Console.WriteLine("Bem vindo ao programa");
System.Console.WriteLine();

System.Console.WriteLine("Digite um número: ");
float a = float.Parse(Console.ReadLine());

System.Console.WriteLine("Digite outro número: ");
float b = float.Parse(Console.ReadLine());

// //uso da classe estática de forma auxilixar
// float r = CalculosMatematicos.Somar(a, b);
// System.Console.WriteLine($"Soma: {r}");

// System.Console.WriteLine();

//  r = CalculosMatematicos.Subtracao(a, b);
// System.Console.WriteLine($"Subtração: {r}");

// System.Console.WriteLine();

//  r = CalculosMatematicos.Multiplicacao(a, b);
// System.Console.WriteLine($"Multiplicação: {r}");

// System.Console.WriteLine();

//  r = CalculosMatematicos.Divisão(a, b);
// System.Console.WriteLine($"Divisão: {r}");

// System.Console.WriteLine();

//Solicitar ao usuário 2 números reais e informe qual é o maior e qual é o menor dos
//números.Para isso vc deve utilizar a classe Math, utilizária do c#






if (a == b)
{
    System.Console.WriteLine("Os dois números são iguais");
}

else
{
    System.Console.WriteLine($"O maior número é: {Math.Max(a, b)}");
    System.Console.WriteLine();
    System.Console.WriteLine($"O Menor número é: {Math.Min(a, b)}");
}