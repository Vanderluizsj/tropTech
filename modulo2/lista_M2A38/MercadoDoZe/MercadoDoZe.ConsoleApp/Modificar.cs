using System;
using System.Data.SqlClient;
using MercadoDoZe.Classes;
using MercadoDoZe.Classes.DAO;
namespace MercadoDoZe.ConsoleApp
{
    public class Modificar
    {
        public static void ModificarRegistro(Produto produto, ProdutoDAO produtoDAO)
        {
             var opcaoStr = String.Empty;
            while (opcaoStr != "2")
            {
                Console.Clear(); 
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("------------- EDITAR PRODUTOS ------------");
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("|    [1] Modificar registro por ID.      |");
                Console.WriteLine("|    [2] Voltar.                         |");
                Console.WriteLine("------------------------------------------");           
                opcaoStr = Console.ReadLine();
                
                switch (opcaoStr)
                {
                    case "1":
                        System.Console.WriteLine("Digite o ID do produto a ser modificado:");
                        var id = int.Parse(Console.ReadLine());
                        produtoDAO.AtualizarProduto(id);
                                                                  
                                        
                        
                        Console.ForegroundColor = ConsoleColor.Green;
                        System.Console.WriteLine("Registros modificados com sucesso. Precione enter para continuar!");
                        Console.ForegroundColor = ConsoleColor.White;
                       
                        Console.ReadKey(); 
                        break;
                    case "2":
                        Console.ForegroundColor = ConsoleColor.Green;
                        System.Console.WriteLine("Precione enter para continuar!");                        
                        Console.ForegroundColor = ConsoleColor.White;                         
                        break;
                    default:
                        break;
                }
            }           
                
        }
    }
}