using System;

namespace cod_4
{
    class Program
    {
        //Corrigido Indentação, remoção de chaves e mudança no nome das variaveis
        static void Main(string[] args)
        {
            Console.Write("Digite a medida em cm da base do triângulo: ");
		    var baseTriangulo = Convert.ToDouble(Console.ReadLine());
		
		    Console.Write("Digite a medida em cm da altura do triângulo: ");
		    var alturaTriangulo = Convert.ToDouble(Console.ReadLine());
		
		    var areaTriangulo = (baseTriangulo * alturaTriangulo) / 2;
		
		    Console.WriteLine("A área do triângulo é: " + areaTriangulo);
            
        }
    }
}
