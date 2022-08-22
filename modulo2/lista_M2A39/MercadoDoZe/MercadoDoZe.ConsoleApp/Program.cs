using System;
using System.Data.SqlClient;
//using System.Collections.Generic;
using MercadoDoZe.Classes;
using MercadoDoZe.Classes.DAO;

namespace MercadoDoZe.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            var opcaoStr = String.Empty;
            Console.Clear(); 
            while (opcaoStr != "3")
            { 
                Console.Clear(); 
                Console.WriteLine("----------------------------------");
                Console.WriteLine("--------- MERCADO DO ZE ----------");
                Console.WriteLine("----------------------------------");
                Console.WriteLine("|    [1] Gerenciar Produto.      |");
                Console.WriteLine("|    [2] Gerenciar Cliente.      |");
                Console.WriteLine("|    [3] Sair.                   |");            
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
                        Menu.MenuCliente();
                        break;
                    case "3":
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
