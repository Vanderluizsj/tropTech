using System;
using System.Data.SqlClient;

namespace MercadoDoZe.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var opcaoStr = String.Empty;
            Console.Clear(); 
            while (opcaoStr != "5")
            {        
                Console.Clear();         
                System.Console.WriteLine("------------------------------");
                System.Console.WriteLine("| Digite o que deseja fazer: |");
                System.Console.WriteLine("------------------------------");
                System.Console.WriteLine("|   [1] Inserir registros.   |");
                System.Console.WriteLine("|   [2] Modificar registros. |");
                System.Console.WriteLine("|   [3] Apagar registros.    |");
                System.Console.WriteLine("|   [4] Consultar registros. |");
                System.Console.WriteLine("|   [5] Sair                 |");
                System.Console.WriteLine("------------------------------");
                opcaoStr = Console.ReadLine();
            
                switch (opcaoStr)
                {
                    case "1":
                        Console.Clear();                               
                        Inserir.InserirRegistro();
                        Console.ReadKey(); 
                        break;
                    case "2":
                        Console.Clear();                               
                        Modificar.ModificarRegistro();
                        Console.ReadKey(); 
                        break;
                    case "3":
                        Console.Clear();                               
                        Apagar.ApagarRegistro();
                        Console.ReadKey(); 
                        break;
                    case "4":
                        Console.Clear();                               
                        Consultar.ConsultarRegistro();
                        Console.ReadKey(); 
                        break;
                    case "5":
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
