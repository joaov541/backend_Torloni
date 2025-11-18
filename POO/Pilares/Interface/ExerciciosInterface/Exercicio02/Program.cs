// Crie uma interface chamada IImprimivel com um método Imprimir.
// Implemente essa interface nas classes Relatorio, Contrato e Fatura.
// Em um programa principal, crie uma lista de objetos e chame o método Imprimir para cada item da lista.

using Exercicio02;

internal class Program
{
    private static void Main(string[] args)
    {
        List<IImprimivel> documentos = new List<IImprimivel>();

        // Fatura fatEdu = new Fatura("Eduardo", "Izabel Dark Lab", 50, 1);
        // fatEdu.Imprimir();

        int opcao;

        do
        {
            Console.Clear();
            //Criar um menu da seguinte forma
            Console.WriteLine($"Menu de Opções");
            Console.WriteLine($@"
1) Cadastrar Fatura
2) Cadastrar Relatório
3) Cadastrar Contrato
4) Listar Faturas
5) Listar Relatórios
6) Listar Contratos
0) Sair
Escolha a opção:
");

            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {

                case 1:
                    Console.WriteLine("Cadastrar fatura");
                    CadastrarFatura();
                    break;

                case 2:
                    Console.WriteLine("Cadastrar Relatório");
                    CadastrarContrato();
                    break;

                case 3:
                    Console.WriteLine("Cadastrar Contrato");
                     CadastrarRelatorio();
                    break;

                case 4:
                    Console.WriteLine("Listar faturas");
                    ListarFaturas();
                    break;

                case 5:
                    Console.WriteLine("Listar Relatórios");
                    ListarContratos();
                    break;

                case 6:
                    Console.WriteLine("Listar Contratos");
                    ListarRelatorios();
                    break;

                case 0:
                    Console.WriteLine("Sair");
                    break;


                default:
                    Console.WriteLine("Opção Inválida");
                    break;
            }

            Console.WriteLine("Digite <Enter> para continuar ...");
            Console.ReadLine();

        } while (opcao != 0);


        void CadastrarFatura()
        {

            Console.WriteLine("Digite o nome do devedor: ");
            string dev = Console.ReadLine();

            Console.WriteLine("Digite o nome do credor: ");
            string cred = Console.ReadLine();

            Console.WriteLine("Digite o valor da fatura: ");
            float valor = float.Parse(Console.ReadLine());

            Console.WriteLine("Quantos dias a fatura esta atrasada? ");
            int diasAtraso = int.Parse(Console.ReadLine());

            Fatura f = new Fatura(dev, cred, valor, diasAtraso);

            documentos.Add(f);
        }


        void CadastrarContrato()
        {
            Console.WriteLine("Digite o nome do contratante: ");
            string cont = Console.ReadLine();

            Console.WriteLine("Digite o nome do Prestador de Serviço: ");
            string prestSer = Console.ReadLine();

            Console.WriteLine("Digite a Cláusula: ");
            string clau = Console.ReadLine();


            Contrato contrato = new Contrato(cont, prestSer, clau);

            documentos.Add(contrato);

            System.Console.WriteLine("Contrato cadastrado com sucesso...");

        }

        void CadastrarRelatorio()
        {
            Console.WriteLine("Digite o nome do responsável: ");
            string resp = Console.ReadLine();

            Console.WriteLine("Digite o texto do relatório: ");
            string relat = Console.ReadLine();

            Relatorio relatorio = new Relatorio(resp, relat);

            documentos.Add(relatorio);

            System.Console.WriteLine("Relatório cadastrado com sucesso...");
            
        }


        void ListarFaturas()
        {
            System.Console.WriteLine("Listando as faturas: ");
            foreach (var item in documentos)
            {

                if (item is Fatura)
                {
                    item.Imprimir(); 
                }

             
              
            }
        }

        void ListarContratos()
        {
            System.Console.WriteLine("Listando os contratos: ");
            foreach (var item in documentos)
            {


                if (item is Contrato)
                {
                    item.Imprimir(); 
                }

               
            }
        }

        void ListarRelatorios()
        {
            System.Console.WriteLine("Listando os Relatórios: ");
            foreach (var item in documentos)
            {
               if (item is Relatorio)
                {
                    item.Imprimir(); 
                }

            }
        }







    }
}




// System.Console.WriteLine("===CONTRATO===");
// Contrato ct = new Contrato();
// ct.Nome = "João Vitor";
// ct.Idade = 22;
// ct.Endereco = "Rua Santa Cruz, Jardin Canhema";
// ct.Imprimir();

// System.Console.WriteLine();

// System.Console.WriteLine("===RELATÓRIO===");
// Relatorio rel = new Relatorio();
// rel.Imprimir();

// System.Console.WriteLine();

// System.Console.WriteLine("===FATURA===");
// Fatura fat = new Fatura();
// fat.Imprimir();
// System.Console.WriteLine();