using System;
using System.Data.SqlClient;
namespace MercadoDoZe.ConsoleApp
{
    public class Apagar
    {
        public static void ApagarRegistro()
        {

            var connectionString = @"server=.\SQLEXPRESS;initial catalog=MERCADO_DO_ZE;integrated security=true";

            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = connectionString;

            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;

            comando.CommandText = @"DELETE FROM PRODUTO;"
                                + @"DBCC CHECKIDENT ('PRODUTO', RESEED, 0);";

            comando.ExecuteScalar();
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine("Registros apagados com sucesso. Precione enter para continuar!");
            Console.ForegroundColor = ConsoleColor.White;
            conexao.Close();

        }
    }
}