using System;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ola!");
            Console.Write("Digite o numero que você quer ver a tabuada: ");
            var numero = int.Parse(Console.ReadLine());
            Console.Write("Digite a partir de que numero você quer ver a tabuada: ");
            var inicio = int.Parse(Console.ReadLine());
            Console.Write("Digite até que numero você quer ver a tabuada: ");
            var fim = int.Parse(Console.ReadLine());

            Console.WriteLine($"\n#### TABUADA DO {numero} ####");
            Console.WriteLine($"\n#### INICIADA NO NUMERO {inicio} E FINALIZADA NO NUMERO {fim} ####");
            
            for (int i = inicio; i < fim+1; i++)
            {
                Console.WriteLine($"{i} x {numero} = {i*numero}");
            }
        }
    }
}
