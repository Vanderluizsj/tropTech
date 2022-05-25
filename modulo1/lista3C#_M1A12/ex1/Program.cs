using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bom dia! Digite um numero decimal: ");
            decimal n1 = Decimal.Parse(Console.ReadLine());
            Console.Write("\nDigite mais um numero decimal: ");
            decimal n2 = Decimal.Parse(Console.ReadLine());
            
            var soma = n1+n2;
            var subtracao = n1-n2;
            var divisao = n1/n2;
            var multiplicacao = n1*n2;
            
            Console.WriteLine($"Os numeros digitados foram {n1} e {n2}");
            Console.WriteLine($"A soma desses numeros é: {soma}");
            Console.WriteLine($"A subtracao desses numeros é: {subtracao}");
            Console.WriteLine($"A divisao desses numeros é: {divisao}");
            Console.WriteLine($"A multiplicacao desses numeros é: {multiplicacao}");

        }
    }
}
