using System;
using System.Data.SqlClient;

namespace MercadoDoZe.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var opcaoStr = String.Empty;
            while (opcaoStr != "4")
            {                
                System.Console.WriteLine("Digite o que deseja fazer: ");
                System.Console.WriteLine("[1] Inserir registros.");
                System.Console.WriteLine("[2] Modificar registros. ");
                System.Console.WriteLine("[3] Apagar registros. ");
                System.Console.WriteLine("[4] Sair ");
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
                        
                        Console.ReadKey(); 
                        break;
                    default:
                        break;
                }
            }
           
        }
    }
}
