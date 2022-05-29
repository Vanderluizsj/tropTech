using System;
using System.Collections;

namespace revisão
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Pilha();
            var tecla = string.Empty; //empty vai dizer que a string está vazia.
            while (tecla != "6")
            {

                Console.WriteLine("**************************");
                Console.WriteLine("[1] Empilhar.");
                Console.WriteLine("[2] Desempilhar.");
                Console.WriteLine("[3] Ver topo.");
                Console.WriteLine("[4] Checar Item.");
                Console.WriteLine("[5] Limpar.");
                Console.WriteLine("[6] Sair.");
                Console.WriteLine("**************************");
                tecla = Console.ReadLine();
                Console.Clear();

                switch (tecla)
                {
                    case "1":
                        //chamada o metodo EMPILHAR, pela classe static
                        Estatica.Empilhar(stack);
                        Console.ReadKey();
                        break;
                    case "2":
                        Estatica.Desempilhar(stack);
                        Console.ReadKey();
                        break;
                    case "3":
                        Estatica.Topo(stack);
                        Console.ReadKey();
                        break;
                    case "4":
                        Estatica.Procurar(stack);
                        Console.ReadKey();
                        break;
                    case "5":
                        Estatica.Limpar(stack);
                        Console.ReadKey();
                        break;

                    default:
                        break;
                }
                Console.Clear();
            }


        }
    }
}
