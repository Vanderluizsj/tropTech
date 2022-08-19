using System;
using System.Data.SqlClient;
namespace MercadoDoZe.ConsoleApp
{
    public class Consultar
    {
        public static void ConsultarRegistro()
        {
            var connectionString = @"server=.\SQLEXPRESS;initial catalog=MERCADO_DO_ZE;integrated security=true";

            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = connectionString;

            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;

            var opcaoStr = String.Empty;
           
            Console.Clear(); 
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("---------------- CONSULTA DE PRODUTOS ---------------");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("|    [1] Consultar todos os itens cadastrados.      |");
            Console.WriteLine("|    [2] Consultar itens por nome.                  |");
            Console.WriteLine("|    [3] Consultar itens por id.                    |");            
            Console.WriteLine("-----------------------------------------------------");           
            opcaoStr = Console.ReadLine();
            switch (opcaoStr)
            {
                case "1":
                    comando.CommandText = @"SELECT * FROM PRODUTO";
                    break;
                case "2":
                    Console.WriteLine("Digite um nome para consulta: (ex: Refrigerante)");
                    var nome = Console.ReadLine();
                    comando.CommandText = $"SELECT * FROM PRODUTO WHERE NOME LIKE '{nome}'";
                    break;
                case "3":
                    Console.WriteLine("Digite um id para consulta: (ex: 1)");
                    var id = int.Parse(Console.ReadLine());
                    comando.CommandText = $"SELECT * FROM PRODUTO WHERE ID LIKE {id}";
                    break;                
                default:
                    Console.ForegroundColor = ConsoleColor.Green;
                    System.Console.WriteLine("Precione enter para continuar!");                        
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
                   
            SqlDataReader leitor = comando.ExecuteReader();
            bool validarConsulta = false; 
            while (leitor.Read())
            {
                validarConsulta = true;
                var id = leitor["ID"];
                var nome = leitor["NOME"];
                var descricao = leitor["DESCRICAO"];
                var vencimento = leitor["DATA_VENCIMENTO"];
                var preco = leitor["PRECO_UNITARIO"];
                var unidade = leitor["UNIDADE"];
                var quantidade = leitor["QTD_ESTOQUE"];
                Console.WriteLine($"ID: {id} - Nome: {nome} - Descrição: {descricao} - Vencimento: {vencimento} - Preço: {preco} - Unidade: {unidade} - Quantidade: {quantidade}");
            }                                 
                      
            if (!validarConsulta)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine("A tabela PRODUTO esta vazia.");
            }
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine("Precione enter para continuar!");                        
            Console.ForegroundColor = ConsoleColor.White;
            conexao.Close();
        }
    }
}