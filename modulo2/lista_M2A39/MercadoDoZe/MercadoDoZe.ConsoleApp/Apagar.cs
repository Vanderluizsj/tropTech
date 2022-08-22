using System;
using System.Data.SqlClient;
using MercadoDoZe.Classes;
using MercadoDoZe.Classes.DAO;
namespace MercadoDoZe.ConsoleApp
{
    public class Apagar
    {
        public static void ApagarRegistro(Produto produto, ProdutoDAO produtoDAO)
        {
            var opcaoStr = String.Empty;
            while (opcaoStr != "3")
            {
                Console.Clear(); 
                Console.WriteLine("--------------------------");
                Console.WriteLine("---- APAGAR PRODUTOS -----");
                Console.WriteLine("--------------------------");
                Console.WriteLine("|    [1] APAGAR.         |");
                Console.WriteLine("|    [2] APAGAR TUDO.    |");
                Console.WriteLine("|    [3] Voltar.         |");
                Console.WriteLine("--------------------------");           
                opcaoStr = Console.ReadLine();
                bool teste = false;
                switch (opcaoStr)
                {
                    case "1":
                        Console.Clear();                               
                        
                        System.Console.WriteLine("Digite o ID do produto a ser APAGADO:");
                        var id = int.Parse(Console.ReadLine());
                        produto = produtoDAO.BuscarPorId(id);
                        System.Console.WriteLine($"O produto que sera apagado é: {produto}");
                        
                        teste = Verificacao(teste);
                        if (teste)
                        {
                            produtoDAO.DeletarProduto(produto);
                        }                     
                        
                        Console.ReadKey(); 
                        break;
                    case "2":
                        Console.Clear();
                        System.Console.WriteLine("TODOS OS REGISTROS DA TABELA SERÃO APAGADOS!");
                        
                        teste = Verificacao(teste);
                        if (teste)
                        {
                            produtoDAO.DeletarTodosOsProdutos();
                        }
                        
                        Console.ForegroundColor = ConsoleColor.Green;
                        System.Console.WriteLine("Precione enter para continuar!");                        
                        Console.ForegroundColor = ConsoleColor.White;                         
                        break;
                    case "3":
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        System.Console.WriteLine("Precione enter para continuar!");                        
                        Console.ForegroundColor = ConsoleColor.White;                         
                        break;
                    default:
                        break;
                }

            }        
            bool Verificacao(bool teste)
            {                
                System.Console.WriteLine("Continuar? [1]SIM e [2]NÃO");
                var verificacao = Console.ReadLine();                
                Console.Clear();
                if (verificacao == "1")
                {
                    teste = true;                    
                    Console.ForegroundColor = ConsoleColor.Green;
                    System.Console.WriteLine("Registros apagados com sucesso. Precione enter para continuar!");
                    Console.ForegroundColor = ConsoleColor.White;   
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    System.Console.WriteLine("Operação cancelada!");
                    Console.ForegroundColor = ConsoleColor.White;
                    teste = false; 
                }
                return teste;
            }         
            
        }
        
    }
}