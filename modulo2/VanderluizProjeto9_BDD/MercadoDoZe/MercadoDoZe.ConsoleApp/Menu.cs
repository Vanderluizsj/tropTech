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
                System.Console.WriteLine("--       MENU PRODUTO       --");
                System.Console.WriteLine("------------------------------");
                System.Console.WriteLine("| Digite o que deseja fazer: |");
                System.Console.WriteLine("------------------------------");
                System.Console.WriteLine("|   [1] Inserir registros.   |");
                System.Console.WriteLine("|   [2] Modificar registros. |");
                System.Console.WriteLine("|   [3] Apagar registros.    |");
                System.Console.WriteLine("|   [4] Consultar registros. |");
                System.Console.WriteLine("|   [5] Entrada de produtos. |");
                System.Console.WriteLine("|   [6] Saida de produtos.   |");
                System.Console.WriteLine("|   [7] Voltar.              |");
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
                System.Console.WriteLine("--       MENU CLIENTE       --");         
                System.Console.WriteLine("------------------------------");
                System.Console.WriteLine("| Digite o que deseja fazer: |");
                System.Console.WriteLine("------------------------------");
                System.Console.WriteLine("|   [1] Inserir registros.   |");
                System.Console.WriteLine("|   [2] Modificar registros. |");
                System.Console.WriteLine("|   [3] Apagar registros.    |");
                System.Console.WriteLine("|   [4] Consultar registros. |");
                System.Console.WriteLine("|   [5] Voltar.              |");
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
        public static void MenuPedido()
        {
            Pedido pedido= new Pedido();
            Produto produto = new Produto();
            PedidoDAO pedidoDAO = new PedidoDAO();
            ProdutoDAO produtoDAO = new ProdutoDAO();

            var opcaoStr = String.Empty;
            Console.Clear(); 
            while (opcaoStr != "4")
            {        
                Console.Clear();
                System.Console.WriteLine("------------------------------");
                System.Console.WriteLine("--       MENU PEDIDO       --");         
                System.Console.WriteLine("------------------------------");
                System.Console.WriteLine("| Digite o que deseja fazer: |");
                System.Console.WriteLine("------------------------------");
                System.Console.WriteLine("|   [1] Cadastrar pedido.    |");
                System.Console.WriteLine("|   [2] Apagar pedido.       |");
                System.Console.WriteLine("|   [3] Consultar pedidos.   |");
                System.Console.WriteLine("|   [4] Voltar.              |");
                System.Console.WriteLine("------------------------------");
                opcaoStr = Console.ReadLine();
                
                switch (opcaoStr)
                {
                    case "1":                                               
                        Console.Clear();                               
                        Inserir.InserirPedido(pedido, pedidoDAO, produtoDAO, produto);
                        Console.ReadKey(); 
                        break;
                    case "2":
                        Console.Clear();                               
                        Apagar.ApagarRegistroPedido(pedido, pedidoDAO);
                        Console.ReadKey(); 
                        break;
                    case "3":
                        Console.Clear();                               
                        Consultar.ConsultarRegistroPedido(pedido, pedidoDAO);
                        Console.ReadKey(); 
                        break;
                    case "4":                      
                                               
                        break;
                    default:
                        break;
                }
            }
        }        
    }
}
    