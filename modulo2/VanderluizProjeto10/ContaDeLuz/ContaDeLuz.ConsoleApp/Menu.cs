using System;
using ContaDeLuz.Domain;
using ContaDeLuz.Infra.SqlServer.DAO;
using ContaDeLuz.Infra.SqlServer;

namespace ContaDeLuz.ConsoleApp
{
    public class Menu
    {
        private static ContaDeLuzRepository _contaRepository = new ContaDeLuzRepository();
        public static void MenuProduto()
        {
            ContaLuz conta = new ContaLuz();            
            ContaDeLuzDAO contaDAO = new ContaDeLuzDAO();            
            
            var opcaoStr = String.Empty;
            Console.Clear(); 
            while (opcaoStr != "5")
            {        
                Console.Clear();
                System.Console.WriteLine("------------------------------");         
                System.Console.WriteLine("--     MENU CONTA DE LUZ    --");
                System.Console.WriteLine("------------------------------");
                System.Console.WriteLine("| Digite o que deseja fazer: |");
                System.Console.WriteLine("------------------------------");
                System.Console.WriteLine("|   [1] Inserir conta.       |");
                System.Console.WriteLine("|   [2] Modificar conta.     |");
                System.Console.WriteLine("|   [3] Apagar conta.        |");
                System.Console.WriteLine("|   [4] Consultar conta.     |");
                System.Console.WriteLine("|   [5] Voltar.              |");
                System.Console.WriteLine("------------------------------");
                opcaoStr = Console.ReadLine();
                
                switch (opcaoStr)
                {
                    case "1":                                               
                        Console.Clear();                               
                        Inserir.InserirRegistro(conta, _contaRepository);
                        Console.ReadKey(); 
                        break;
                    case "2":
                        Console.Clear();                               
                        Modificar.ModificarRegistro(conta, _contaRepository);
                        Console.ReadKey(); 
                        break;
                    case "3":
                        Console.Clear();                               
                        Apagar.ApagarRegistro(conta, _contaRepository);
                        Console.ReadKey(); 
                        break;
                    case "4":
                        Console.Clear();                               
                        Consultar.ConsultarRegistro(conta, _contaRepository);
                        Console.ReadKey(); 
                        break;
                    case "5": 
                        break;
                    default:
                        break;
                }
            }               
        }        
    }
}
    