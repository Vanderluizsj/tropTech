using System;
using System.Collections;

namespace VanderluizProjeto1
{
    class Program
    {
        static void Main(string[] args)
        {
            var fila = new Fila();
            var opcaoStr = string.Empty;
            int opcaoPrincipal = 0;
            while (opcaoStr != "6")
            {
                do
                {
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine("Digite uma das opções abaixo:");
                    Console.WriteLine("[1] Enfileirar.");
                    Console.WriteLine("[2] Desemfileirar.");
                    Console.WriteLine("[3] Ver inicio.");
                    Console.WriteLine("[4] Checar Item.");
                    Console.WriteLine("[5] Limpar.");
                    Console.WriteLine("[6] Sair.");
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
                            AcoesDoSistema.Enfileirar(fila);
                            Console.ReadKey();                     
                            break;
                        case "2":
                            AcoesDoSistema.Desenfileirar(fila);
                            Console.ReadKey();
                            break;
                        case "3":
                            AcoesDoSistema.Primeiro(fila);
                            Console.ReadKey();
                            break;
                        case "4":
                            AcoesDoSistema.Procurar(fila); 
                            Console.ReadKey();                       
                            break;
                        case "5":
                            AcoesDoSistema.Limpar(fila);
                            Console.ReadKey();
                            break;
                        case "6":
                            Environment.Exit(0);
                            break;

                        default:
                            Console.WriteLine("Valor Invalido, tente denovo");
                            break;
                    }
                } while (opcaoPrincipal<1);
            }
        }
    }
}
