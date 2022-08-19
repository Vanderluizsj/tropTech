using System;
using System.Data.SqlClient;
namespace MercadoDoZe.ConsoleApp
{
    public class Modificar
    {
        public static void ModificarRegistro()
        {
            var connectionString = @"server=.\SQLEXPRESS;initial catalog=MERCADO_DO_ZE;integrated security=true";

            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = connectionString;

            conexao.Open();

            SqlCommand comando = new SqlCommand();

                comando.Connection = conexao;
                comando.CommandText = @"UPDATE PRODUTO SET QTD_ESTOQUE = 10 WHERE QTD_ESTOQUE<5;"
                                    + @"UPDATE PRODUTO SET QTD_ESTOQUE = 0 WHERE NOME='%Papel%';"
                                    + @"UPDATE PRODUTO SET QTD_ESTOQUE = 0 WHERE NOME='Refri%';"
                                    + @"UPDATE PRODUTO SET QTD_ESTOQUE = 5 WHERE ID=2;"
                                    + @"UPDATE PRODUTO SET DESCRICAO = 'Fanta', QTD_ESTOQUE=5 WHERE ID=1;";
                
            comando.ExecuteNonQuery();
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine("Registros modificados com sucesso. Precione enter para continuar!");
            Console.ForegroundColor = ConsoleColor.White;
            conexao.Close();
        }
    }
}