using System;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------------------------------------------------TABUADA---------------------------------------------------------------------------");
            for (int i = 1; i < 11; i++)
            {
                for (int x = 1; x < 11; x++)
                {
                    Console.Write($"{x} * {i} = {x*i}\t");
                }
                Console.Write("\n");
            }
        }
    }
}
