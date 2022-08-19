using System;
using System.Data.SqlClient;
namespace MercadoDoZe.ConsoleApp
{
    public class Modificar
    {
        public static void ModificarRegistro()
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
                var connectionString = @"server=.\SQLEXPRESS;initial catalog=MERCADO_DO_ZE;integrated security=true;"; 
                SqlConnection conexao = new SqlConnection();
                conexao.ConnectionString = connectionString;

                conexao.Open();

                SqlCommand comando = new SqlCommand();
                comando.Connection = conexao;
                switch (opcaoStr)
                {
                    case "1":
                        System.Console.WriteLine("Digite o ID do produto a ser modificado:");
                        var id = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("------------------------------------------");
                        Console.WriteLine("----- Digite o que deseja modificar: -----");
                        Console.WriteLine("------------------------------------------");
                        Console.WriteLine("|    [1] Modificar nome.                 |");
                        Console.WriteLine("|    [2] Modificar descricao.            |");
                        Console.WriteLine("|    [3] Modificar vencimento.           |");
                        Console.WriteLine("|    [4] Modificar preco.                |");
                        Console.WriteLine("|    [5] Modificar unidade.              |");
                        Console.WriteLine("|    [6] Modificar quantidade.           |");
                        Console.WriteLine("------------------------------------------");
                        var opcao = Console.ReadLine();
                        switch (opcao)
                        {
                            case "1":
                                Console.WriteLine("Digite um nome: (ex: Refrigerante)");
                                var nome = Console.ReadLine();
                                comando.CommandText = @"UPDATE PRODUTO SET NOME = @NOME WHERE ID = @ID";
                                comando.Parameters.AddWithValue("@ID", id);
                                comando.Parameters.AddWithValue("@NOME", nome);
                                break;
                            case "2":
                                Console.WriteLine("Digite a descrição: (ex: Fanta)");
                                var descricao = Console.ReadLine();
                                comando.CommandText = @"UPDATE PRODUTO SET DESCRICAO = @DESCRICAO WHERE ID = @ID";
                                comando.Parameters.AddWithValue("@ID", id);
                                comando.Parameters.AddWithValue("@DESCRICAO", descricao);
                                break;
                            case "3":
                                Console.WriteLine("Digite o vencimento: (ex: 12-11-2022)");
                                var vencimento = Console.ReadLine();
                                comando.CommandText = @"UPDATE PRODUTO SET DATA_VENCIMENTO = @VENCIMENTO WHERE ID = @ID";
                                comando.Parameters.AddWithValue("@ID", id);
                                comando.Parameters.AddWithValue("@VENCIMENTO", vencimento);
                                break;
                            case "4":
                                Console.WriteLine("Digite o preço: (ex: 9,99)");
                                var preco = float.Parse(Console.ReadLine());
                                comando.CommandText = @"UPDATE PRODUTO SET PRECO_UNITARIO = @PRECO WHERE ID = @ID";
                                comando.Parameters.AddWithValue("@ID", id);
                                comando.Parameters.AddWithValue("@PRECO", preco);
                                break;
                            case "5":
                                Console.WriteLine("Digite a unidade: (ex: 2L)");
                                var unidade = Console.ReadLine();
                                comando.CommandText = @"UPDATE PRODUTO SET UNIDADE = @UNIDADE WHERE ID = @ID";
                                comando.Parameters.AddWithValue("@ID", id);
                                comando.Parameters.AddWithValue("@UNIDADE", unidade);
                                break;
                            case "6":
                                Console.WriteLine("Digite a quantidade: (ex: 10)");
                                var quantidade = int.Parse(Console.ReadLine());
                                comando.CommandText = @"UPDATE PRODUTO SET QTD_ESTOQUE = @QTD WHERE ID = @ID";
                                comando.Parameters.AddWithValue("@ID", id);
                                comando.Parameters.AddWithValue("@QTD", quantidade);
                                break;
                            default:
                                break;
                        }                            
                                            
                                        
                        comando.ExecuteNonQuery();
                        Console.ForegroundColor = ConsoleColor.Green;
                        System.Console.WriteLine("Registros modificados com sucesso. Precione enter para continuar!");
                        Console.ForegroundColor = ConsoleColor.White;
                        conexao.Close();
                        

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