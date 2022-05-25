using System;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá!");
            Console.Write("Informe o código do produto: ");
            var cod = int.Parse(Console.ReadLine());

            switch (cod)
            {               
            case 1:            
                Console.WriteLine("Alimento não-perecível!");
                break;            
            case 2:
            case 3:
            case 4:
                Console.WriteLine("Alimento perecível!");
                break;
            case 5:
            case 6:
                Console.WriteLine("Vestuário!");
                break;
            case 7:
                Console.WriteLine("Higiene pessoal!");
                break;            
            case 8:
            case 9:
            case 10:
                Console.WriteLine("Utensílios domésticos!");
                break;            
            default:
                Console.WriteLine("Código inválido!");
                break;
            }
            
        }
    }
}
