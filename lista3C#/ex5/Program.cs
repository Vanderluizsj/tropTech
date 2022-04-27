using System;

namespace ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá!");
            Console.Write("Informe um numero inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            numero*=numero;
            Console.WriteLine($"O dobro desse numero é: {numero}");
            numero++;
            Console.WriteLine($"Incrementando mais 1 fica: {numero}");

        }
    }
}
