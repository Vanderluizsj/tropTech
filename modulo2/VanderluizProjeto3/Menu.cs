using System;
namespace VanderluizProjeto3
{
    public class Menu
    {
        public string MenuInicial()
        {            
            var opcaoStr = string.Empty;            
            int opcaoPrincipal = 0;
            do 
            {
                Console.Clear(); 
                Console.ForegroundColor = ConsoleColor.Blue; 
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("    Bem vindo ao Sistema de e-mail do TropTech!   ");
                Console.WriteLine("--------------------------------------------------");                    
                Console.WriteLine("Digite uma das opções abaixo:");
                Console.WriteLine("[1] Aluno.");
                Console.WriteLine("[2] Professor.");
                Console.WriteLine("[3] Sair.");                
                Console.WriteLine("--------------------------------------------------");
                //Console.ForegroundColor = ConsoleColor.White;
                opcaoStr = Console.ReadLine();
                
                opcaoPrincipal = String.IsNullOrEmpty(opcaoStr)? 0 : 1;                  
                opcaoPrincipal = opcaoPrincipal == 1? int.Parse(opcaoStr) : 0;                  
            }while (opcaoPrincipal <1 || opcaoPrincipal >3);
            return opcaoStr;
        }
        public string MenuAluno()
        {            
            var opcaoStr = string.Empty;            
            int opcaoPrincipal = 0;
            do 
            {
                Console.Clear(); 
                Console.ForegroundColor = ConsoleColor.Blue; 
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("            Bem vindo ao submenu Aluno!           ");
                Console.WriteLine("--------------------------------------------------");                    
                Console.WriteLine("Digite uma das opções abaixo:");
                Console.WriteLine("[1] Enviar dúvida.");
                Console.WriteLine("[2] Visualizar e-mails.");
                Console.WriteLine("[3] Voltar ao menu principal.");                
                Console.WriteLine("--------------------------------------------------");
                //Console.ForegroundColor = ConsoleColor.White;
                opcaoStr = Console.ReadLine();
                
                opcaoPrincipal = String.IsNullOrEmpty(opcaoStr)? 0 : 1;                  
                opcaoPrincipal = opcaoPrincipal == 1? int.Parse(opcaoStr) : 0;                  
            }while (opcaoPrincipal <1 || opcaoPrincipal >3);
            return opcaoStr;
        }
        public string MenuProfessor()
        {            
            var opcaoStr = string.Empty;            
            int opcaoPrincipal = 0;
            do 
            {
                Console.Clear(); 
                Console.ForegroundColor = ConsoleColor.Blue; 
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("          Bem vindo ao submenu Professor!          ");
                Console.WriteLine("--------------------------------------------------");                    
                Console.WriteLine("Digite uma das opções abaixo:");
                Console.WriteLine("[1] Enviar Resposta.");
                Console.WriteLine("[2] Visualizar e-mails de dúvidas.");
                Console.WriteLine("[3] Visualizar registro de dúvidas resposdidas.");
                Console.WriteLine("[4] Voltar ao menu principal.");                
                Console.WriteLine("--------------------------------------------------");
                //Console.ForegroundColor = ConsoleColor.White;
                opcaoStr = Console.ReadLine();
                
                opcaoPrincipal = String.IsNullOrEmpty(opcaoStr)? 0 : 1;                  
                opcaoPrincipal = opcaoPrincipal == 1? int.Parse(opcaoStr) : 0;                  
            }while (opcaoPrincipal <1 || opcaoPrincipal >4);
            return opcaoStr;
        }
        
    }
}