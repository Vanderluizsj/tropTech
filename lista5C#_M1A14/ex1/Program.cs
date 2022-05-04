using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ola!");
            Console.Write("Digite o numero que você quer ver a tabuada: ");
            var numero = int.Parse(Console.ReadLine());

            Console.WriteLine($"\n#### TABUADA DO {numero} ####");
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine($"{i} x {numero} = {i*numero}");
            }
        }
    }
}
