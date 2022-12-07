using System;

namespace CalculaMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe as notas abaixo para calcular a média!");

            Console.WriteLine("Nota 1:");
            int nota1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nota 2:");
            int nota2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nota 3:");
            int nota3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Considerar valores double? (ex: 6,5)");
            System.Console.Write("[1] Sim.  ");
            System.Console.WriteLine("[2] Não.");

            string aceitarDouble = Console.ReadLine();

            if (aceitarDouble.ToLower() == "1")
                Console.WriteLine(Nota.CalculaMedia((double)nota1, (double)nota2, (double)nota3));
            else
                Console.WriteLine(Nota.CalculaMedia(nota1, nota2, nota3));
        }
    }
}
