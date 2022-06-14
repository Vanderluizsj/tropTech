using System;
namespace VanderluizProjeto2ComInterface
{
    public class Menu
    {
        public string MenuInicial()
        {
            
            var opcaoStr = string.Empty;
            
            int opcaoPrincipal = 0;

            do // repete se o campo opcaoStr for deixado em branco ou se a opção voltar for escolhida em um submenu
            {
                Console.Clear(); 
                Console.ForegroundColor = ConsoleColor.Blue; 
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("        Bem vindo ao cadastro de Clientes!        ");
                Console.WriteLine("--------------------------------------------------");                    Console.WriteLine("Digite uma das opções abaixo:");
                Console.WriteLine("[1] Cadastrar cliente.");
                Console.WriteLine("[2] Exibir todos os clientes.");
                Console.WriteLine("[3] Consultar Cliente.");
                Console.WriteLine("[4] Remover Cliente.");
                Console.WriteLine("[5] Cadastrar venda.");
                Console.WriteLine("[6] Exibir todas as vendas.");
                Console.WriteLine("[7] Sair.");
                Console.WriteLine("--------------------------------------------------");
                Console.ForegroundColor = ConsoleColor.White;
                opcaoStr = Console.ReadLine();
                
                opcaoPrincipal = String.IsNullOrEmpty(opcaoStr)? 0 : 1;                  
                opcaoPrincipal = opcaoPrincipal == 1? int.Parse(opcaoStr) : 0;                  
            }while (opcaoPrincipal <1 || opcaoPrincipal >7);
            return opcaoStr;
        }
        
    }
}