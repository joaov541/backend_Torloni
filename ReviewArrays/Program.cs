//arrays

//Arrays
string nome = "João";
Console.WriteLine($"Nome: {nome}");


string[] nomes = new string[4];

nomes[0] = "Marcos";
nomes[1] = "Matheus";
nomes[2] = "Negueba";
nomes[3] = "João";

Console.WriteLine();
for (int i = 0; i < nomes.Length; i++)
{
    Console.WriteLine(nomes[i]);
}
