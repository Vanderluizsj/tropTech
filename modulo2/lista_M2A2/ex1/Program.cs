using System;

namespace ExercRetangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a altura do retangulo: ");
            var alturaRetangulo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a base do retangulo: ");
            var baseRetangulo = Convert.ToDouble(Console.ReadLine());

            var retangulo = new Retangulo(baseRetangulo, alturaRetangulo);

            Console.WriteLine($"A área do retaângulo é: {retangulo.Area}");

        }
    }
}
