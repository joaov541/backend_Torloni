//1. Classe Animal
//Crie uma classe abstrata chamada animal com os métodos FazerSom() e Mover()
//Crie duas classes derivadas: Cachorro e Gato. Cada uma deve implementar os métodos
//de forma diferente.

using Exemplos;

// Cachorro toto = new Cachorro();
// toto.FazerSom();
// toto.Mover();

// System.Console.WriteLine();

// Gato g1 = new Gato();
// g1.FazerSom();
// g1.Mover();

// System.Console.WriteLine();

// Pessoa p = new Pessoa();
// p.FazerSom();
// p.Mover();

//2. Classe ContaBancaria
//Crie uma classe abstrata ContaBancaria com os métodos Depositar(double valor)
//e Sacar(double valor).
//Crie duas classes: ContaCorrente e ContaPoupanca, cada uma com sua própria forma de calcular o saldo após saque (por exemplo, taxa diferente)
Console.Clear();

ContaCorrente CC = new ContaCorrente();
ContaPoupanca CP = new ContaPoupanca();

CC.Depositar(10);
CP.Depositar(10);

System.Console.WriteLine($"Saldo da Conta Corrente antes do Saque: RS{CC.Saldo}");
System.Console.WriteLine($"Saldo da Conta Poupança antes do Saque: RS{CP.Saldo}");


CC.Sacar(10);
CP.Sacar(5);


System.Console.WriteLine();

System.Console.WriteLine($"Seu Saldo da Conta Corrente: {CC.Saldo}");
System.Console.WriteLine($"Saldo da Conta Poupança: {CP.Saldo}");
