using System;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá!");
            Console.Write("Informe a quantidade de produtos a ser cadastrado: ");
            int qtdProdutos = int.Parse(Console.ReadLine());
            string[] nomeProduto = new string[qtdProdutos];
            double[] precoProduto = new double[qtdProdutos];

            for (int i = 0; i < qtdProdutos; i++)
            {
                string nome = "";
                Console.Write("\nInforme o nome do produto: ");
                nome = Console.ReadLine();
                nomeProduto[i] = nome;

                Console.Write("\nInforme o valor do produto: ");
                precoProduto[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine($"\nPRODUTO\tPREÇO\tOPÇÃO1\tOPÇÃO2\tOPÇÃO3\tOPÇÃO4");
            Console.WriteLine($"-------\t------\t-------\t-------\t-------\t-------");
            for (int i = 0; i < qtdProdutos; i++)
            {               
                
                Console.WriteLine($"{nomeProduto[i]}\t{precoProduto[i]}"+
                $"\t{precoProduto[i]*0.9}\t{precoProduto[i]*0.95}\t{precoProduto[i]}\t{precoProduto[i]*1.1}");
            } 

            
            
            
        }
    }
}
