using System;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o tamanho do vetor A: ");
            int tamanhoVetorA = int.Parse(Console.ReadLine());
            Console.Write("\nInsira o tamanho do vetor B: ");
            int tamanhoVetorB = int.Parse(Console.ReadLine());
            int[] vetorA = new int[tamanhoVetorA];
            int[] vetorB = new int[tamanhoVetorB];
            int tamanhoVetorC =
                tamanhoVetorA > tamanhoVetorB ? tamanhoVetorA : tamanhoVetorB;

            int[] vetorC = new int[tamanhoVetorC];

            for (int i = 0; i < tamanhoVetorA; i++)
            {
                Console.Write("\nDigite o " + (i + 1) + "º numero do vetorA: ");
                vetorA[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < tamanhoVetorB; i++)
            {
                Console.Write("\nDigite o " + (i + 1) + "º numero do vetorB: ");
                vetorB[i] = int.Parse(Console.ReadLine());
                
            }
            for (int x = 0; x < tamanhoVetorC; x++)
            {
                var teste = vetorA[x] + vetorB[x];
                vetorC[x] = teste;
            }

            Console.WriteLine("\nOs numeros do vetorA são: ");
            for (int i = 0; i < tamanhoVetorA; i++)
            {
                Console.Write("[" + vetorA[i] + "] ");
            }
            Console.WriteLine("\nOs numeros do vetorB são: ");
            for (int i = 0; i < tamanhoVetorB; i++)
            {
                Console.Write("[" + vetorB[i] + "] ");
            }
            Console.WriteLine("\nO vetorC tem " + tamanhoVetorC + " numeros. ");
            Console.WriteLine("Os numeros do vetorC são: ");
            for (int i = 0; i < tamanhoVetorC; i++)
            {
                Console.Write("[" + vetorC[i] + "] ");
            }
        }
    }
}
