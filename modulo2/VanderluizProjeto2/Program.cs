using System;

namespace VanderluizProjeto2
{
    class Program
    {
        static void Main(string[] args)
        {
            var opcaoStr = string.Empty;
            int opcaoPrincipal = 0;
            //LinkedList<Cliente> listaClientes = new LinkedList<Cliente>();
            var cliente = new Cliente();
            while (opcaoStr != "7") //Repete até que  opção sair seja escolhida
            {
                do // repete se o campo opcaoStr for deixado em branco ou se a opção voltar for escolhida em um submenu
                {
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine("        Bem vindo ao cadastro de Clientes!        ");
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine("Digite uma das opções abaixo:");
                    Console.WriteLine("[1] Cadastrar cliente.");
                    Console.WriteLine("[2] Exibir todos os clientes.");
                    Console.WriteLine("[3] Consultar Cliente.");
                    Console.WriteLine("[4] Remover Cliente.");
                    Console.WriteLine("[5] Cadastrar venda.");
                    Console.WriteLine("[6] Exibir todas as vendas.");
                    Console.WriteLine("[7] Sair.");
                    Console.WriteLine("--------------------------------------------------");
                    opcaoStr = Console.ReadLine();
                    if (String.IsNullOrEmpty(opcaoStr))
                    {
                        opcaoPrincipal = 0;
                    }  else
                    {
                        opcaoPrincipal = 1;
                    }              

                    Console.Clear();               

                    switch (opcaoStr)
                    {
                        case "1":
                            //Menu de cadastro de clientes
                            Gerenciador.Cadastrar(cliente);
                            
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Cliente cadastrado com sucesso.");
                            
                            Console.WriteLine("\nPressione qualquer tecla para continuar.");
                            Console.ForegroundColor = ConsoleColor.White;

                            Console.ReadKey();                     
                            break;
                        case "2":
                            Gerenciador.ExibirLista(cliente);

                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("\nPressione qualquer tecla para continuar.");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.ReadKey();
                            break;
                        case "3":
                            Gerenciador.ConsultarCliente(cliente);

                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("\nPressione qualquer tecla para continuar.");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.ReadKey();
                            break;
                        case "4":
                             Gerenciador.RemoverCliente(cliente);
                             
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("\nPressione qualquer tecla para continuar.");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.ReadKey();                       
                            break;
                        case "5":
                             Gerenciador.CadastrarVenda(cliente);
                             
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("\nPressione qualquer tecla para continuar.");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.ReadKey();                       
                            break;
                        case "6":
                             Gerenciador.ExibirVendas(cliente);
                             
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("\nPressione qualquer tecla para continuar.");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.ReadKey();                       
                            break;
                        case "7":
                            //Environment.Exit(0);
                            Console.WriteLine("Obrigado por usar nosso sistema e apoir nosso trabalho!");
                            Console.WriteLine("Até a proxima!");

                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("\nPressione qualquer tecla para continuar.");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.ReadKey();
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Valor Invalido! Pressione qualquer tecla e tente novmente.");                             
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.ReadKey();
                            break;
                    }
                } while (opcaoPrincipal<1);
            }
        }
    }
}
