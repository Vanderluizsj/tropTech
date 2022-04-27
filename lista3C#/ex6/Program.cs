using System;

namespace ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá!");
            Console.Write("Informe um numero inteiro: ");
            int numero = int.Parse(Console.ReadLine());
            int aux = numero;

            numero*=2;
            Console.WriteLine($"A multiplicação desse numero por 2 é: {numero}");
            numero=aux;
            numero/=2;
            Console.WriteLine($"A divisão desse numero por 2 é: {numero}");
            numero=aux;
            numero+=2;
            Console.WriteLine($"A soma desse numero por 2 é: {numero}");
            numero=aux;
            numero-=2;
            Console.WriteLine($"A subtração desse numero por 2 é: {numero}");
        }
    }
}
