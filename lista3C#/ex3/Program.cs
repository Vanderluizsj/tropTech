using System;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o tamanho em centimetros do primeiro lado do triangulo: ");
            var l1 = Console.ReadLine();
            Console.Write("\nInforme o tamanho em centimetros do segundo lado do triangulo: ");
            var l2 = Console.ReadLine();
            Console.Write("\nInforme o tamanho em centimetros do terceiro lado do triangulo: ");
            var l3 = Console.ReadLine();
            bool equilatero = false;
            bool escaleno = false;
            bool isosceles = false;

            if (l1==l2 && l1==l3)
            {
                equilatero = true;
            }
            if (l1!=l2 && l1!=l3 && l2 != l3)
            {
                escaleno = true;
            }            
            if (l1==l2 && l1 != l3 || l1==l3 && l1 != l2 || l2==l3 && l2!=l1)
            {
                isosceles = true;
            }
            
            Console.WriteLine($"Equilatero: {equilatero}"); //todos os lados iguais
            Console.WriteLine($"Escaleno: {escaleno}"); //todos os lados diferentes
            Console.WriteLine($"Isosceles: {isosceles}"); //quando dois lados possuem a mesma medida
        }
    }
}
