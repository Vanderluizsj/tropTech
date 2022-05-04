using System;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá aluno Troptech!");            
            Console.Write("Digite o numero de semanas de estudo: ");
            var semanas = int.Parse(Console.ReadLine());
            Console.Write("Digite o numero de dias de estudo: ");
            var dias = int.Parse(Console.ReadLine());
                       
            for (int i = 0; i < semanas; i++)
            {                                              
                Console.WriteLine($" Semana: {i+1}");
                for (int x = 0; x < dias; x++)
                {   
                    Console.WriteLine($" Dia: {x+1}");
                }
            }
            Console.WriteLine($"Parabéns você estudou {semanas*dias} dia(s)!");
        }
    }
}
