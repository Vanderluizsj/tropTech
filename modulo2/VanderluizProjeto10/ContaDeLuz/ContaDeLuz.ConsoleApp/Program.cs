using System;

namespace ContaDeLuz.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            var opcaoStr = String.Empty;
            Console.Clear(); 
            while (opcaoStr != "2")
            { 
                Console.Clear(); 
                Console.WriteLine("----------------------------------");
                Console.WriteLine("------- CONTROLE DE CONTAS -------");
                Console.WriteLine("----------------------------------");
                Console.WriteLine("|    [1] Gerenciar conta de luz. |");   
                Console.WriteLine("|    [2] Sair.                   |");            
                Console.WriteLine("----------------------------------");           
                opcaoStr = Console.ReadLine();
                switch (opcaoStr)
                {
                    case "1":
                        Console.Clear();
                        Menu.MenuProduto();
                        break;
                    case "2":                        
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;                               
                        System.Console.WriteLine("Obrigado por utilizar nossas soluções. Precione enter para sair!");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }
            }
           
        }
    }
}
