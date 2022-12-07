using System;

namespace Retangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo(0, 0);

            retangulo = new Retangulo(10, 2);

            Retangulo.AlterarAltura(10);

            Retangulo.AlteraLargura(5);

            Console.WriteLine("Altura do triangulo: " + Retangulo.RetornaAltura());

            Console.WriteLine("Largura do triangulo: " + Retangulo.RetornaLargura());

            Console.WriteLine("Área do triangulo: " + Retangulo.CalculaArea());
        }
    }
}
