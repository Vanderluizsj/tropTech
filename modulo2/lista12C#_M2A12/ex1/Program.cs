using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            IAreaCalculavel[] vetorFigurasGeometricas = new IAreaCalculavel[]
            {
                new Quadrado(3),
                new Retangulo(2, 4),
                new Circulo(5)
            };
           foreach (var figura in vetorFigurasGeometricas)
           {
               double area = figura.CalcularArea();
               System.Console.WriteLine(area);
           }
        }
    }
}
