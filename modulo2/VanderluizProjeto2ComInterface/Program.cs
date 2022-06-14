using System;

namespace VanderluizProjeto2ComInterface 
{
    class Program
    {
        static void Main(string[] args)
        {
                
            var cliente = new Cliente();
            var venda = new Venda();
            Menu menu = new Menu();
            string opcaoStr = String.Empty;
                       
            while (opcaoStr != "7")
            {
                opcaoStr = menu.MenuInicial();

                switch (opcaoStr)
                {
                    case "1":
                   //Menu de cadastro de clientes
                        Console.Clear();
                        AcoesCliente.Cadastrar();                            
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Cliente cadastrado com sucesso.");                            
                        Console.WriteLine("\nPressione qualquer tecla para continuar.");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadKey();                     
                        break;
                    case "2":
                        Console.Clear();
                        AcoesCliente.ExibirLista(cliente);                            
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nPressione qualquer tecla para continuar.");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.Clear();
                        AcoesCliente.ConsultarCliente(cliente);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nPressione qualquer tecla para continuar.");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.Clear();
                        AcoesCliente.RemoverCliente(cliente);                             
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nPressione qualquer tecla para continuar.");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadKey();                       
                        break;
                    case "5":
                        Console.Clear();
                        AcoesVenda.CadastrarVenda();                             
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nPressione qualquer tecla para continuar.");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadKey();                       
                        break;
                    case "6":
                        AcoesVenda.ExibirVendas();                             
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nPressione qualquer tecla para continuar.");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadKey();                       
                        break;
                    case "7":
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Obrigado por usar nosso sistema e apoir nosso trabalho!");
                        Console.WriteLine("Até a proxima!");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nPressione qualquer tecla para continuar.");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadKey();
                        break;
                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Valor Invalido! Pressione qualquer tecla e tente novmente.");                             
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadKey();
                        break;
                } 
            }           
        }
    }
}
