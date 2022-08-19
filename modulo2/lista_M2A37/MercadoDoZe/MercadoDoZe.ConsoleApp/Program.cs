using System;
using System.Data.SqlClient;

namespace MercadoDoZe.ConsoleApp
{
    class Program
    {
        static SqlConnection conexao = new SqlConnection();
//------------------------------------CONEXAO-----------------------------------
        public static void AbrirConexao()
        {
            var connectionString = @"server=.\SQLexpress;initial catalog=MERCADO_DO_ZE;integrated security=true;";

            conexao.ConnectionString = connectionString;

            conexao.Open();
        }

        public static void FecharConexao()
        {
            conexao.Close();
        }
//----------------------------------MAIN--------------------------------------------
               
        static void Main(string[] args)
        {
            var opcaoStr = String.Empty;
            Console.Clear();             
            while (opcaoStr != "7")
            {        
                Console.Clear();         
                System.Console.WriteLine("------------------------------");
                System.Console.WriteLine("| Digite o que deseja fazer: |");
                System.Console.WriteLine("------------------------------");
                System.Console.WriteLine("|   [1] Inserir registros.   |");
                System.Console.WriteLine("|   [2] Modificar registros. |");
                System.Console.WriteLine("|   [3] Apagar registros.    |");
                System.Console.WriteLine("|   [4] Consultar registros. |");
                System.Console.WriteLine("|   [5] Entrada              |");
                System.Console.WriteLine("|   [6] Saida                |");
                System.Console.WriteLine("|   [7] Sair                 |");
                System.Console.WriteLine("------------------------------");
                opcaoStr = Console.ReadLine();
            
                switch (opcaoStr)
                {
                    case "1":
                        Console.Clear();                               
                        InserirRegistro();
                        Console.ReadKey(); 
                        break;
                    case "2":
                        Console.Clear();                               
                        ModificarRegistro();
                        Console.ReadKey(); 
                        break;
                    case "3":
                        Console.Clear();                               
                        ApagarRegistro();
                        Console.ReadKey(); 
                        break;
                    case "4":
                        Console.Clear();                               
                        ConsultarRegistro();
                        Console.ReadKey(); 
                        break;
                    case "5":
                        Console.Clear();                        
                        Console.ForegroundColor = ConsoleColor.Green;                               
                        System.Console.WriteLine("Função ainda não implementada. Precione enter para sair!");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadKey(); 
                        break;
                    case "6":
                        Console.Clear();                        
                        Console.ForegroundColor = ConsoleColor.Green;                               
                        System.Console.WriteLine("Função ainda não implementada. Precione enter para sair!");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadKey(); 
                        break;
                    case "7":
                        Console.Clear();                        
                        Console.ForegroundColor = ConsoleColor.Green;                               
                        System.Console.WriteLine("Obrigado por utilizar nossas soluções. Precione enter para sair!");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadKey(); 
                        break;
                    default:
                        break;
                }
            }
           
        }
//-----------------------------------INSERIR--------------------------------
         public static void InserirRegistro()
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
                        AbrirConexao();                               
                        Console.WriteLine("Digite um nome: (ex: Refrigerante)");
                        var nome = Console.ReadLine();
                        Console.WriteLine("Digite a descrição: (ex: Fanta)");
                        var descricao = Console.ReadLine();
                        Console.WriteLine("Digite o vencimento: (ex: 12-11-2022)");
                        var vencimento = Console.ReadLine();
                        Console.WriteLine("Digite o preço: (ex: 9,99)");
                        var preco = float.Parse(Console.ReadLine());
                        Console.WriteLine("Digite a unidade: (ex: 2L)");
                        var unidade = Console.ReadLine();
                        Console.WriteLine("Digite a quantidade: (ex: 10)");
                        var quantidade = int.Parse(Console.ReadLine());

                        
                        SqlCommand comando = new SqlCommand();
                        comando.Connection = conexao;

                        comando.CommandText = $"INSERT PRODUTO VALUES (@NOME, @DESCRICAO, @VENCIMENTO, @PRECO, @UNIDADE, @QUANTIDADE)";
                        comando.Parameters.AddWithValue("@NOME", nome);
                        comando.Parameters.AddWithValue("@DESCRICAO", descricao);
                        comando.Parameters.AddWithValue("@VENCIMENTO", vencimento);
                        comando.Parameters.AddWithValue("@PRECO", preco);
                        comando.Parameters.AddWithValue("@UNIDADE", unidade);
                        comando.Parameters.AddWithValue("@QUANTIDADE", quantidade);

                        comando.ExecuteNonQuery();

                        Console.ForegroundColor = ConsoleColor.Green;
                        System.Console.WriteLine("Registro inserido com sucesso. Precione enter para continuar!");
                        Console.ForegroundColor = ConsoleColor.White;

                        FecharConexao();
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
//--------------------------------MODIFICAR--------------------------------
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
                AbrirConexao();

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
                                System.Console.WriteLine("O produto modificado foi:");
                                comando.CommandText = $"SELECT * FROM PRODUTO WHERE ID = @ID_CONSULTA";
                                comando.Parameters.AddWithValue("@ID_CONSULTA", id);
                                comando.ExecuteNonQuery();
                                comando.CommandText = @"UPDATE PRODUTO SET NOME = @NOME WHERE ID = @ID";
                                comando.Parameters.AddWithValue("@ID", id);
                                comando.Parameters.AddWithValue("@NOME", nome);
                                break;
                            case "2":
                                Console.WriteLine("Digite a descrição: (ex: Fanta)");
                                var descricao = Console.ReadLine();
                                System.Console.WriteLine("O produto modificado foi:");
                                comando.CommandText = $"SELECT * FROM PRODUTO WHERE ID = @ID_CONSULTA";
                                comando.Parameters.AddWithValue("@ID_CONSULTA", id);
                                comando.CommandText = @"UPDATE PRODUTO SET DESCRICAO = @DESCRICAO WHERE ID = @ID";
                                comando.Parameters.AddWithValue("@ID", id);
                                comando.Parameters.AddWithValue("@DESCRICAO", descricao);
                                break;
                            case "3":
                                Console.WriteLine("Digite o vencimento: (ex: 12-11-2022)");
                                var vencimento = Console.ReadLine();
                                System.Console.WriteLine("O produto modificado foi:");
                                comando.CommandText = $"SELECT * FROM PRODUTO WHERE ID = @ID_CONSULTA";
                                comando.Parameters.AddWithValue("@ID_CONSULTA", id);
                                comando.CommandText = @"UPDATE PRODUTO SET DATA_VENCIMENTO = @VENCIMENTO WHERE ID = @ID";
                                comando.Parameters.AddWithValue("@ID", id);
                                comando.Parameters.AddWithValue("@VENCIMENTO", vencimento);
                                break;
                            case "4":
                                Console.WriteLine("Digite o preço: (ex: 9,99)");
                                var preco = float.Parse(Console.ReadLine());
                                System.Console.WriteLine("O produto modificado foi:");
                                comando.CommandText = $"SELECT * FROM PRODUTO WHERE ID = @ID_CONSULTA";
                                comando.Parameters.AddWithValue("@ID_CONSULTA", id);
                                comando.CommandText = @"UPDATE PRODUTO SET PRECO_UNITARIO = @PRECO WHERE ID = @ID";
                                comando.Parameters.AddWithValue("@ID", id);
                                comando.Parameters.AddWithValue("@PRECO", preco);
                                break;
                            case "5":
                                Console.WriteLine("Digite a unidade: (ex: 2L)");
                                var unidade = Console.ReadLine();
                                System.Console.WriteLine("O produto modificado foi:");
                                comando.CommandText = $"SELECT * FROM PRODUTO WHERE ID = @ID_CONSULTA";
                                comando.Parameters.AddWithValue("@ID_CONSULTA", id);
                                comando.CommandText = @"UPDATE PRODUTO SET UNIDADE = @UNIDADE WHERE ID = @ID";
                                comando.Parameters.AddWithValue("@ID", id);
                                comando.Parameters.AddWithValue("@UNIDADE", unidade);
                                break;
                            case "6":
                                Console.WriteLine("Digite a quantidade: (ex: 10)");
                                var quantidade = int.Parse(Console.ReadLine());
                                System.Console.WriteLine("O produto modificado foi:");
                                comando.CommandText = $"SELECT * FROM PRODUTO WHERE ID = @ID_CONSULTA";
                                comando.Parameters.AddWithValue("@ID_CONSULTA", id);
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
                FecharConexao();
            }           
                
        }
//-----------------------------APAGAR--------------------------------
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
                        AbrirConexao();
                        
                        SqlCommand comando = new SqlCommand();
                        comando.Connection = conexao;
                        
                        System.Console.WriteLine("Digite o ID do produto a ser APAGADO:");
                        var id = int.Parse(Console.ReadLine());
                        System.Console.WriteLine("O produto apagado foi:");                                
                        comando.CommandText = $"SELECT * FROM PRODUTO WHERE ID = @ID_CONSULTA";
                        comando.Parameters.AddWithValue("@ID_CONSULTA", id);
                        comando.CommandText = @"DELETE FROM PRODUTO WHERE ID = @ID";
                        comando.Parameters.AddWithValue("@ID", id);
                        
                        comando.ExecuteNonQuery();

                        Console.ForegroundColor = ConsoleColor.Green;
                        System.Console.WriteLine("Registros apagados com sucesso. Precione enter para continuar!");
                        Console.ForegroundColor = ConsoleColor.White;
                        
                        FecharConexao();
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

//-----------------------------CONSULTAR-----------------------------

        public static void ConsultarRegistro()
        {
            AbrirConexao();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;

            var opcaoStr = String.Empty;
           
            Console.Clear(); 
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("---------------- CONSULTAR PRODUTOS -----------------");
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
                    comando.CommandText = $"SELECT * FROM PRODUTO WHERE NOME = @NOME_PRODUTO";
                    comando.Parameters.AddWithValue("@NOME_PRODUTO", nome);
                    break;
                case "3":
                    Console.WriteLine("Digite um id para consulta: (ex: 1)");
                    var id = int.Parse(Console.ReadLine());
                    comando.CommandText = $"SELECT * FROM PRODUTO WHERE ID = @ID_PRODUTO";
                    comando.Parameters.AddWithValue("@ID_PRODUTO", id);
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
            FecharConexao();
        }
    }
}
