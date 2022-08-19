using System;
using System.Data.SqlClient;
using MercadoDoZe.Classes;
using MercadoDoZe.Classes.DAO;
namespace MercadoDoZe.ConsoleApp
{
    public class Inserir
    {
        public static void InserirRegistro(Produto produto, ProdutoDAO produtoDAO)
        {
            var opcaoStr = String.Empty;
            while (opcaoStr != "2")
            {
                Console.Clear(); 
                Console.WriteLine("--------------------------");
                Console.WriteLine("--- CADASTRAR PRODUTOS ---");
                Console.WriteLine("--------------------------");
                Console.WriteLine("|    [1] Cadastrar.      |");
                Console.WriteLine("|    [2] Voltar.         |");
                Console.WriteLine("--------------------------");           
                opcaoStr = Console.ReadLine();
                switch (opcaoStr)
                {
                    case "1":
                        Console.Clear();                               
                        Console.WriteLine("Digite um nome: (ex: Refrigerante)");
                        produto.Nome = Console.ReadLine();
                        Console.WriteLine("Digite a descrição: (ex: Fanta)");
                        produto.Descricao = Console.ReadLine();
                        Console.WriteLine("Digite o vencimento: (ex: 12-11-2022)");
                        produto.Vencimento = Convert.ToDateTime(Console.ReadLine());
                        Console.WriteLine("Digite o preço: (ex: 9,99)");
                        produto.Preco = float.Parse(Console.ReadLine());
                        Console.WriteLine("Digite a unidade: (ex: 2L)");
                        produto.Unidade = Console.ReadLine();
                        Console.WriteLine("Digite a quantidade: (ex: 10)");
                        produto.QuantidadeEstoque = int.Parse(Console.ReadLine());
                        //Produto _produto = new Produto();
                        //_produto = produto;
                        produtoDAO.AdicionarProduto(produto);

                        Console.ForegroundColor = ConsoleColor.Green;
                        System.Console.WriteLine("Registro inserido com sucesso. Precione enter para continuar!");
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