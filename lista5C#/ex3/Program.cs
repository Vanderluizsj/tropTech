using System;
using System.Collections.Generic;
namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();
            Random numAleatorio = new Random();
            int menor = 100;
            int maior = 0;
            for (int i = 0; i < 50; i++)
            {
               int numero = numAleatorio.Next(1,51);
                numeros.Add(numero);
            }
            Console.WriteLine("Os 50 numeros sorteados são: ");
            foreach (var numero in numeros)
            {
               
               Console.Write($"{numero} ");
               if (numero<menor)
               {
                    menor=numero;
               }
               if(numero>maior)
               {
                    maior=numero;
               }                
            }
            Console.WriteLine($"\n\nO maior numero dos 50 é: {maior}");
            Console.WriteLine($"O menor numero dos 50 é: {menor}");
        }
    }
}
