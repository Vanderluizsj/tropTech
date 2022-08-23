using System;
using System.Collections.Generic;
using MercadoDoZe.Classes;
using MercadoDoZe.Classes.DAO;
namespace MercadoDoZe.ConsoleApp
{
    public class Consultar
    {
        public static void ConsultarRegistro(Produto produto, ProdutoDAO produtoDAO)
        {
            var opcaoStr = String.Empty;
           
            Console.Clear(); 
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("---------------- CONSULTAR PRODUTOS -----------------");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("|    [1] Consultar todos os itens cadastrados.      |");
            Console.WriteLine("|    [2] Consultar itens por descricão              |");
            Console.WriteLine("|    [3] Consultar itens por id.                    |");            
            Console.WriteLine("-----------------------------------------------------");           
            opcaoStr = Console.ReadLine();
            var listaProdutos= new List<Produto>();
            switch (opcaoStr)
            {
                case "1":
                    Console.Clear();
                    listaProdutos = produtoDAO.BuscarTodos();
                    Imprimir(listaProdutos);                    
                    Console.ForegroundColor = ConsoleColor.Green;
                    System.Console.WriteLine("Precione enter para continuar!");                        
                    Console.ForegroundColor = ConsoleColor.White; 
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("Digite um nome para consulta: (ex: Refrigerante)");
                    var texto = Console.ReadLine();
                    listaProdutos = produtoDAO.BuscaPorTexto(texto);
                    Imprimir(listaProdutos);
                    Console.ForegroundColor = ConsoleColor.Green;
                    System.Console.WriteLine("Precione enter para continuar!");                        
                    Console.ForegroundColor = ConsoleColor.White; 
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("Digite um id para consulta: (ex: 1)");
                    var id = int.Parse(Console.ReadLine());
                    produto = produtoDAO.BuscarPorId(id);
                    if (!String.IsNullOrEmpty(produto.Nome))
                    {
                       System.Console.WriteLine(produto.ToString());   
                    }                                      
                    break;                
                default:
                    Console.ForegroundColor = ConsoleColor.Green;
                    System.Console.WriteLine("Precione enter para continuar!");                        
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
            void Imprimir(List<Produto> listaProdutos)
            {
                foreach (var item in listaProdutos)
                {
                    System.Console.WriteLine(item.ToString());
                }
            }          
                        
        }
        public static void ConsultarRegistroCliente(Cliente cliente, ClienteDAO clienteDAO)
        {
            var opcaoStr = String.Empty;
           
            Console.Clear(); 
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("---------------- CONSULTAR CLIENTES -----------------");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("|    [1] Consultar todos os CLIENTES cadastrados.   |");
            Console.WriteLine("|    [2] Consultar CLIENTES por nome.               |");
            Console.WriteLine("|    [3] Consultar CLIENTES por CPF.                |");            
            Console.WriteLine("-----------------------------------------------------");           
            opcaoStr = Console.ReadLine();
            var listaClientes= new List<Cliente>();
            switch (opcaoStr)
            {
                case "1":
                    Console.Clear();
                    listaClientes = clienteDAO.BuscarTodos();
                    Imprimir(listaClientes);                    
                    Console.ForegroundColor = ConsoleColor.Green;
                    System.Console.WriteLine("Precione enter para continuar!");                        
                    Console.ForegroundColor = ConsoleColor.White; 
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("Digite um nome para consulta: (ex: Ana)");
                    var nome = Console.ReadLine();
                    listaClientes = clienteDAO.BuscaPorNome(nome);
                    Imprimir(listaClientes);
                    Console.ForegroundColor = ConsoleColor.Green;
                    System.Console.WriteLine("Precione enter para continuar!");                        
                    Console.ForegroundColor = ConsoleColor.White; 
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("Digite um CPF para consulta: (ex: 02114734599)");
                    var cpf = long.Parse(Console.ReadLine());
                    cliente = clienteDAO.BuscarPorCpf(cpf);
                    if (!String.IsNullOrEmpty(cliente.Nome))
                    {
                       System.Console.WriteLine(cliente.ToString());   
                    }                                      
                    break;                
                default:
                    Console.ForegroundColor = ConsoleColor.Green;
                    System.Console.WriteLine("Precione enter para continuar!");                        
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
            void Imprimir(List<Cliente> listaClientes)
            {
                foreach (var item in listaClientes)
                {
                    System.Console.WriteLine(item.ToString());
                }
            }          
                        
        }
    }
}