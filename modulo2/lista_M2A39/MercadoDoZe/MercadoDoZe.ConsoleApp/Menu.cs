using System;
using System.Data.SqlClient;
using MercadoDoZe.Classes;
using MercadoDoZe.Classes.DAO;

namespace MercadoDoZe.ConsoleApp
{
    public class Menu
    {
        public static void MenuProduto()
        {
            //SqlConnection _conexao = new SqlConnection();
            Produto produto = new Produto(); 
            ProdutoDAO produtoDAO = new ProdutoDAO();
            
            var opcaoStr = String.Empty;
            Console.Clear(); 
            while (opcaoStr != "7")
            {        
                Console.Clear();         
                System.Console.WriteLine("------------------------------");
                System.Console.WriteLine("| Digite o que deseja fazer: |");
                System.Console.WriteLine("------------------------------");
                System.Console.WriteLine("|   [1] Inserir registros.   |");
                System.Console.WriteLine("|   [2] Modificar registros. |");
                System.Console.WriteLine("|   [3] Apagar registros.    |");
                System.Console.WriteLine("|   [4] Consultar registros. |");
                System.Console.WriteLine("|   [5] Entrada de produtos. |");
                System.Console.WriteLine("|   [6] Saida de produtos.   |");
                System.Console.WriteLine("|   [7] Sair                 |");
                System.Console.WriteLine("------------------------------");
                opcaoStr = Console.ReadLine();
                
                switch (opcaoStr)
                {
                    case "1":                                               
                        Console.Clear();                               
                        Inserir.InserirRegistro(produto, produtoDAO);
                        Console.ReadKey(); 
                        break;
                    case "2":
                        Console.Clear();                               
                        Modificar.ModificarRegistro(produto, produtoDAO);
                        Console.ReadKey(); 
                        break;
                    case "3":
                        Console.Clear();                               
                        Apagar.ApagarRegistro(produto, produtoDAO);
                        Console.ReadKey(); 
                        break;
                    case "4":
                        Console.Clear();                               
                        Consultar.ConsultarRegistro(produto, produtoDAO);
                        Console.ReadKey(); 
                        break;
                    case "5":
                        Console.Clear();
                        EntradaSaidaEstoque.Entrada(produto, produtoDAO);
                        Console.ReadKey(); 
                        break;
                    case "6":
                        Console.Clear();
                        EntradaSaidaEstoque.Saida(produto, produtoDAO);
                        Console.ReadKey(); 
                        break;
                    case "7":
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
        public static void MenuCliente()
        {
            Cliente cliente = new Cliente();
            ClienteDAO clienteDAO = new ClienteDAO();

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
                System.Console.WriteLine("|   [5] Voltar               |");
                System.Console.WriteLine("------------------------------");
                opcaoStr = Console.ReadLine();
                
                switch (opcaoStr)
                {
                    case "1":                                               
                        Console.Clear();                               
                        Inserir.InserirRegistroCliente(cliente, clienteDAO);
                        Console.ReadKey(); 
                        break;
                    case "2":
                        Console.Clear();                               
                        Modificar.ModificarRegistroCliente(cliente, clienteDAO);
                        Console.ReadKey(); 
                        break;
                    case "3":
                        Console.Clear();                               
                        Apagar.ApagarRegistroCliente(cliente, clienteDAO);
                        Console.ReadKey(); 
                        break;
                    case "4":
                        Console.Clear();                               
                        Consultar.ConsultarRegistroCliente(cliente, clienteDAO);
                        Console.ReadKey(); 
                        break;
                    case "5":                      
                                               
                        break;
                    default:
                        break;
                }
            }
        }        
    }
}
    