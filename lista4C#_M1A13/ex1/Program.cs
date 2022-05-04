using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá!");
            Console.Write("Informe o código do produto: ");
            var cod = int.Parse(Console.ReadLine());

            if (cod == 1)
            {
                Console.WriteLine("Alimento não-perecível!");
            }
            else if (cod == 2 || cod == 3 || cod == 4)
            {
                Console.WriteLine("Alimento perecível!");
            }
            else if (cod == 5 || cod == 6)
            {
                Console.WriteLine("Vestuário!");
            }
            else if (cod == 7)
            {
                Console.WriteLine("Higiene pessoal!");
            }
            else if (cod == 8 || cod == 9 || cod == 10)
            {
                Console.WriteLine("Utensílios domésticos!");
            }
            else
            {
                Console.WriteLine("Código inválido!");
            }
            
        }
    }
}
