using System;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o lado do triangulo equilatero: ");
            var lado = Double.Parse(Console.ReadLine());

            var altura = (lado*Math.Pow(3, 0.5))/4;
            
            var area = (Math.Pow(lado, 2)*Math.Pow(3, 0.5))/4;
            
            Console.WriteLine($"A altura do triangulo é {altura} e a area é {area}");

        }
    }
}
