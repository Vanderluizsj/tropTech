using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World");
            Console.WriteLine("Digite o numero de trabalhadores avaliados: ");
            int qtdTrabalhadores = int.Parse(Console.ReadLine());
            string[] nome = new string[qtdTrabalhadores];
            int[] idade = new int[qtdTrabalhadores];
            int[] tempoTrabalho = new int[qtdTrabalhadores];
		
		
            for(int i =0; i < qtdTrabalhadores; i++){
                Console.WriteLine("Digite o nome do trabalhadore a ser avaliado: ");
                nome[i] = Console.ReadLine();
            
                Console.WriteLine("Digite o idade dos trabalhador a ser avaliado: ");
                idade[i] = int.Parse(Console.ReadLine());
            
                Console.WriteLine("Digite o tempo de trabalho do trabalhador a ser avaliado: ");
                tempoTrabalho[i] = int.Parse(Console.ReadLine());
            }
    }
}
