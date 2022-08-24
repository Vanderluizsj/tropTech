using System;
using MercadoDoZe.Classes;
using MercadoDoZe.Classes.DAO;
namespace MercadoDoZe.ConsoleApp
{
    public class EntradaSaidaEstoque
    {
        public static void Entrada(Produto produto, ProdutoDAO produtoDAO)
        {
            Console.Clear();
            Console.WriteLine(" ------------ ENTRADA ESTOQUE ----------- \n");

            Console.WriteLine("Digite o id do produto:");
            var id = Convert.ToInt32(Console.ReadLine());

            produto = produtoDAO.BuscarPorId(id);

            if (produto.Id == 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Produto não encontrado!");
                
                System.Console.WriteLine("Precione enter para continuar!");                        
        
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();                
            }
            else
            {
               Console.WriteLine($"Quantidade atual no estoque: {produto.QuantidadeEstoque}");

                Console.ReadKey();
                Console.ForegroundColor = ConsoleColor.Green;
                System.Console.WriteLine("Precione enter para continuar!");                        
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("Digite a quantidade de entrada no estoque:");
                var quantidade = Convert.ToInt32(Console.ReadLine());

                produto.EntradaEstoque(quantidade);
                produtoDAO.EntradaSaidaEstoque(produto);
                Console.WriteLine($"Quantidade atual no estoque: {produto.QuantidadeEstoque}");  
            }           
        }

        public static void Saida(Produto produto, ProdutoDAO produtoDAO)
        {
            Console.Clear();
            Console.WriteLine(" -------- SAIDA ESTOQUE --------- \n");

            Console.WriteLine("Digite o id do produto: ");
            var id = Convert.ToInt32(Console.ReadLine());

            produto = produtoDAO.BuscarPorId(id);

            if (produto.Id == 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Produto não encontrado!");
                System.Console.WriteLine("Precione enter para continuar!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();
                
            }
            else
            {                
                Console.WriteLine($"Quantidade atual no estoque: {produto.QuantidadeEstoque}");

                Console.ForegroundColor = ConsoleColor.Green;
                System.Console.WriteLine("Precione enter para continuar!");                        
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();

                Console.WriteLine("Digite a quantidade de saída no estoque:");
                var quantidade = Convert.ToInt32(Console.ReadLine());

                produto.SaidaEstoque(quantidade);
                produtoDAO.EntradaSaidaEstoque(produto);
                Console.WriteLine($"Quantidade atual no estoque: {produto.QuantidadeEstoque}");
            }
        }
    }
}