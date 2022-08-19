using System;
using System.Data.SqlClient;
namespace MercadoDoZe.ConsoleApp
{
    public class Apagar
    {
        public static void ApagarRegistro()
        {
             var opcaoStr = String.Empty;
            while (opcaoStr != "2")
            {
                Console.Clear(); 
                Console.WriteLine("--------------------------");
                Console.WriteLine("---- APAGAR PRODUTOS -----");
                Console.WriteLine("--------------------------");
                Console.WriteLine("|    [1] APAGAR.         |");
                Console.WriteLine("|    [2] Voltar.         |");
                Console.WriteLine("--------------------------");           
                opcaoStr = Console.ReadLine();
                switch (opcaoStr)
                {
                    case "1":
                        Console.Clear();                               
                        
                        var connectionString = @"server=.\SQLEXPRESS;initial catalog=MERCADO_DO_ZE;integrated security=true;"; 
                        SqlConnection conexao = new SqlConnection();
                        conexao.ConnectionString = connectionString;

                        conexao.Open();

                        SqlCommand comando = new SqlCommand();
                        comando.Connection = conexao;
                        
                        System.Console.WriteLine("Digite o ID do produto a ser APAGADO:");
                        var id = int.Parse(Console.ReadLine());

                        comando.CommandText = @"DELETE FROM PRODUTO WHERE ID = @ID";
                        comando.Parameters.AddWithValue("@ID", id);
                        
                        comando.ExecuteNonQuery();

                        Console.ForegroundColor = ConsoleColor.Green;
                        System.Console.WriteLine("Registros apagados com sucesso. Precione enter para continuar!");
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