using Encapsulamento;

// float dinheiro = 200;

// ContaBancaria contaEdu = new ContaBancaria();
// ContaBancaria contaMaria = new ContaBancaria(dinheiro);

// contaEdu.Depositar(dinheiro);
// System.Console.WriteLine($"Saldo do Edu: R${contaEdu.GetSaldo()}");
// System.Console.WriteLine($"Saldo da Maria: R${contaMaria.GetSaldo()}");


// contaEdu.Sacar(30);
// System.Console.WriteLine($"Saldo do Edu após o saque: R${contaEdu.GetSaldo()}");


// contaMaria.Sacar(50);
// System.Console.WriteLine($"Saldo da Maria após o saque: R${contaMaria.GetSaldo()}");

// Exercício Desafio:

// Crie um programa em C# para representar um carro usando o conceito de encapsulamento, porém sem utilizar propriedades com get e set. Utilize somente atributos privados e métodos públicos para acessar e modificar os dados. Siga as instruções:

// Crie uma classe chamada Carro.

// Dentro da classe, crie três atributos privados:

// marca (string)

// modelo (string)

// velocidadeAtual (int)

// Crie métodos públicos para definir e obter a marca:

// DefinirMarca(string valor)

// ObterMarca()

// Crie métodos públicos para definir e obter o modelo:

// DefinirModelo(string valor)

// ObterModelo()

// Crie um método público para obter a velocidade atual:

// ObterVelocidade()

// Crie dois métodos públicos que alterem a velocidade do carro:

// Acelerar(int valor): aumenta a velocidade.

// Frear(int valor): diminui a velocidade, mas nunca pode ficar abaixo de zero.

// No método Main, crie um objeto da classe Carro, defina sua marca e modelo usando os métodos criados, acelere e freie algumas vezes.

// Após as operações, mostre na tela a marca, o modelo e a velocidade atual do carro usando os métodos de leitura.


Carro MyCar = new Carro();
MyCar.DefinirMarca("Honda");
MyCar.DefinirModelo("Civic G10");

MyCar.Acelerar(90);
MyCar.Frear(30);

System.Console.WriteLine("Marca: "+ MyCar.ObterMarca());
System.Console.WriteLine("Modelo: "+ MyCar.ObterModelo());
System.Console.WriteLine("Velocidade atual: "+ MyCar.ObterVelocidade());
