using System;

namespace cod_2
{
    class Program
    {
        //Corrigido Indentação, remoção de chaves e mudança no nome das variaveis
        static void Main(string[] args)
        {
            Console.WriteLine("Descubra a tabuada!");
		    Console.Write("Qual tabuada você gostaria de consultar (1 a 10): ");
		    var tabuada = Convert.ToInt32(Console.ReadLine());
		
		    Console.Write("Qual é o número de inicio: ");
		    var inicio = Convert.ToInt32(Console.ReadLine());

		    Console.Write("Qual é o número de fim: ");
		    var fim = Convert.ToInt32(Console.ReadLine());
			
		    if(tabuada > 10 || tabuada < 1)
            {
			    Console.WriteLine("Valor inválido, tente novamente.");
			    return;
		    }
		
		    for(var i=inicio; i <= fim; i++)
            {
			    Console.WriteLine(tabuada + " x " + inicio + " = " + inicio * tabuada);
		    }
        }
    }
}
