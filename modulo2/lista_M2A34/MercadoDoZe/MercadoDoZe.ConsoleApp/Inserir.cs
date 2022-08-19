using System;
using System.Data.SqlClient;
namespace MercadoDoZe.ConsoleApp
{
    public class Inserir
    {
        public static void InserirRegistro()
        {
            var connectionString = @"server=.\SQLEXPRESS;initial catalog=MERCADO_DO_ZE;integrated security=true;"; 
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = connectionString;

            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;

            comando.CommandText = @"INSERT PRODUTO VALUES ('Refrigerante', 'Picolino Cola', '15-11-2022', 5.25, '2L', 4),"
                +@"('Arroz', 'Panelaço', '18-08-2022', 3.99, '1kg', 7),"
                +@"('Feijão', 'Urbano', '18-10-2022', 5.99, '1kg', 10),"
                +@"('Macarrão', 'Urbano', '18-12-2022', 4.99, '1kg', 7),"
                +@"('Papel Higienico', 'Fofinho', '18-08-2030', 5.99, 'pct', 9),"
                +@"('Algodão', 'Jonson', '11-08-2025', 2.99, 'cx', 3),"
                +@"('Farinha', 'super10', '18-01-2023', 5.99, '1kg', 5),"                
                +@"('Pão', 'Pão de forma', '16-08-2022', 6.75, '300g', 5),"
                +@"('Chocolate', 'Nestle', '27-12-2022', 7.52, '120g', 6),"
                +@"('Amaciante', 'Confort', '18-08-2022', 8.25, '1L', 7);";

            comando.ExecuteNonQuery();
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine("Registros inseridos com sucesso. Precione enter para continuar!");
            Console.ForegroundColor = ConsoleColor.White;
            conexao.Close();
        }
            
    }
}