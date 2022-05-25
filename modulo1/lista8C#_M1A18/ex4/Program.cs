using System;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o tamanho do vetor: ");
            int numeros = int.Parse(Console.ReadLine());
            int[] vetorNumeros = new int[numeros];
            int media = 0;
            int soma = 0;

            for (int i = 0; i < numeros; i++)
            {
                Console.Write("\nDigite o " + (i + 1) + "º numero do vetor: ");
                vetorNumeros[i] = int.Parse(Console.ReadLine());
                soma += vetorNumeros[i];
            }
            media = soma / numeros;

            Console.WriteLine("Os numeros do vetor são: ");
            for (int i = 0; i < numeros; i++)
            {
                Console.Write("[" + vetorNumeros[i] + "] ");
            }

            Console.WriteLine("\nA media dos numeros do vetor é: " + media);
            Console.WriteLine("Os numeros do vetor menores que a média são: ");
            for (int i = 0; i < numeros; i++)
            {
                if (vetorNumeros[i] < media)
                {
                    Console.Write("[" + vetorNumeros[i] + "] ");
                }
            }
        }
    }
}
