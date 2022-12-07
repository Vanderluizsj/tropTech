using System;

namespace CalculaTempo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número de dias: ");
            int dias = int.Parse(Console.ReadLine());

            Console.WriteLine($"O número de dias:{dias} tem {Tempo.CalculaNumeroDeHoras(dias)} horas");

            Console.WriteLine($"O número de dias:{dias} tem {Tempo.CalculaNumeroDeMinutos(dias)} minutos");

            Console.WriteLine($"O número de dias:{dias} tem {Tempo.CalculaNumeroDeSegundos(dias)} segundos");
        }
    }
}
