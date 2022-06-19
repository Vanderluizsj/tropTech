using System;

namespace VanderluizProjeto3
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            string opcaoStr = String.Empty;
            string opcao = String.Empty;            
                       
            while (opcaoStr != "3")
            {
                opcaoStr = menu.MenuInicial();
                EmailDuvida email = new EmailDuvida();
                EmailResposta resposta = new EmailResposta();
                switch (opcaoStr)
                {
                    case "1":
                        Console.Clear(); 
                        opcao = menu.MenuAluno();
                        switch (opcao)
                        {
                            case "1":
                                Console.Clear();                               
                                GerencidorDeEmails.FazerPergunta(email);
                                Console.ReadKey(); 
                                break;
                            case "2":
                                Console.Clear();                               
                                GerencidorDeEmails.Exibir(email);
                                Console.ReadKey();
                                break;
                            case "3":
                                Console.Clear();
                                break;
                            default:
                                break;
                         }
                        break;
                    case "2":
                        Console.Clear(); 
                        opcao = menu.MenuProfessor();
                        switch (opcao)
                        {
                            case "1":
                                Console.Clear();                               
                                GerencidorDeEmails.ResponderPergunta(resposta);
                                Console.ReadKey(); 
                                break;
                            case "2":
                                Console.Clear();                               
                                GerencidorDeEmails.Exibir(email);
                                Console.ReadKey();
                                break;
                            case "3":
                                Console.Clear();
                                GerencidorDeEmails.Exibir(resposta);
                                Console.ReadKey();
                                break;
                            case "4":
                                Console.Clear();
                                break;
                            default:
                                break;
                        }
                        break;                   
                    case "3":
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    default:
                        break;
                }

            }
        }
    }
}
