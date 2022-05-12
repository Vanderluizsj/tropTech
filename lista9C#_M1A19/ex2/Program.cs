using System;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma frase em letras minusculas e veja a magica acontecer: ");
            var frase = Console.ReadLine();

            Console.WriteLine(frase.ToUpper());
        }
    }
}
