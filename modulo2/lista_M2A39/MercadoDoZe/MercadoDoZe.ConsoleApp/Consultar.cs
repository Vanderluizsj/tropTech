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
    }
}