using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            var tecla = string.Empty;

            while (tecla != "6")
            {
               Console.WriteLine("------------------------");
                Console.WriteLine("[1] Empilhar. ");
                Console.WriteLine("[2] Desempilhar. ");
                Console.WriteLine("[3] Ver topo. ");
                Console.WriteLine("[4] Checar item ");
                Console.WriteLine("[5] Limpar. ");
                Console.WriteLine("[6] Sair. ");
                Console.WriteLine("------------------------"); 
                tecla = Console.ReadLine();
                Console.Clear();
            }
            
        }
    }
}
