using System;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o tamanho do vetor: ");
            int numeros = int.Parse(Console.ReadLine());
            int[] vetorNumeros = new int[numeros];
            int numerosPares = 0;
            int quantidade = 0;

            for (int i = 0; i < numeros; i++)
            {
                Console.Write("Digite o " + (i + 1) + "º numero do vetor: ");
                vetorNumeros[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("\nO vetor tem " + numeros + " numeros. ");
            Console.WriteLine("Os numeros do vetor são: ");
            for (int i = 0; i < numeros; i++)
            {
                Console.Write("[" + vetorNumeros[i] + "] ");
            }
            Console.WriteLine("\nOs numeros pares do vetor são: ");
            for (int i = 0; i < numeros; i++)
            {
                numerosPares = vetorNumeros[i];
                if (numerosPares % 2 == 0)
                {
                    Console.Write(vetorNumeros[i] + " ");
                    quantidade++;
                }
            }
            Console.WriteLine("\nO array tem " + quantidade + " numeros pares.");
        }
    }
}
