using System;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá!");
            Console.Write("Digite o nome de uma fruta: ");
            var fruta = Console.ReadLine();
            Console.Write("Digite a cor dessa fruta: ");
            var corFruta = Console.ReadLine();
            Console.Write("Digite uma caracteristica dessa fruta: ");
            var tipoFruta = Console.ReadLine();

            Console.WriteLine($"\nA fruta escolhida foi {fruta}, a cor dela é {corFruta} e ela é {tipoFruta}.");
        }
    }
}
