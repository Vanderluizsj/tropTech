using System;
using System.Data.SqlClient;
namespace MercadoDoZe.ConsoleApp
{
    public class Inserir
    {
        public static void InserirRegistro()
        {
            var opcaoStr = String.Empty;
            while (opcaoStr != "2")
            {
                Console.Clear(); 
                Console.WriteLine("--------------------------");
                Console.WriteLine("-- CADASTRO DE PRODUTOS --");
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
                        var nome = Console.ReadLine();
                        Console.WriteLine("Digite a descrição: (ex: Fanta)");
                        var descricao = Console.ReadLine();
                        Console.WriteLine("Digite o vencimento: (ex: 12-11-2022)");
                        var vencimento = Console.ReadLine();
                        Console.WriteLine("Digite o preço: (ex: 9.99)");
                        var preco = float.Parse(Console.ReadLine());
                        Console.WriteLine("Digite a unidade: (ex: 2L)");
                        var unidade = Console.ReadLine();
                        Console.WriteLine("Digite a quantidade: (ex: 10)");
                        var quantidade = int.Parse(Console.ReadLine());

                        var connectionString = @"server=.\SQLEXPRESS;initial catalog=MERCADO_DO_ZE;integrated security=true;"; 
                        SqlConnection conexao = new SqlConnection();
                        conexao.ConnectionString = connectionString;

                        conexao.Open();

                        SqlCommand comando = new SqlCommand();
                        comando.Connection = conexao;

                        comando.CommandText = $"INSERT PRODUTO VALUES ('{nome}', '{descricao}', '{vencimento}', {preco}, '{unidade}', {quantidade});";

                        comando.ExecuteNonQuery();
                        Console.ForegroundColor = ConsoleColor.Green;
                        System.Console.WriteLine("Registro inserido com sucesso. Precione enter para continuar!");
                        Console.ForegroundColor = ConsoleColor.White;
                        conexao.Close();
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