using System;
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
                        Console.Clear();
                        System.Console.WriteLine("Digite o ID do produto a ser modificado:");
                        var id = int.Parse(Console.ReadLine());
                        produto = produtoDAO.BuscarPorId(id);

                        Console.WriteLine($" Produto que será editado:\n {produto}");

                        Console.ReadKey();

                        Console.WriteLine("Digite o nome do produto:");
                        produto.Nome = Console.ReadLine();

                        Console.WriteLine("Digite a descrição:");
                        produto.Descricao = Console.ReadLine();

                        Console.WriteLine("Digite a data de vencimento:(DD/MM/YYYY)");
                        produto.Vencimento = Convert.ToDateTime(Console.ReadLine());

                        Console.WriteLine("Digite o preço unitário:");
                        produto.Preco = float.Parse(Console.ReadLine());

                        Console.WriteLine("Digite a unidade:");
                        produto.Unidade = Console.ReadLine();

                        produtoDAO.AtualizarProduto(produto);                  
                                                                
                        Console.ForegroundColor = ConsoleColor.Green;
                        System.Console.WriteLine("Registros modificados com sucesso. Precione enter para continuar!");
                        Console.ForegroundColor = ConsoleColor.White;
                       
                        Console.ReadKey(); 
                        break;
                    case "2":
                        Console.Clear();
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