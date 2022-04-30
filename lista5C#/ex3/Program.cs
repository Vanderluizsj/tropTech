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

            for (int i = 0; i < 50; i++)
            {
               int numero = numAleatorio.Next(0,50);
                numeros.Add(numero);
            }
            
            foreach (var numero in numeros)
            {
               Console.Write($"{numero} ");
                
            }
        }
    }
}
