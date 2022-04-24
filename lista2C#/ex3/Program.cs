using System;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroInteiro = 1;
            decimal numeroDecimal = 2.5m;
            string numeroEmString = "7";
            double numeroDouble = 3.7;

            decimal deInteiroParaDecimal = Convert.ToDecimal(numeroInteiro);
            int deDecimalParaInteiro = Convert.ToInt32(numeroDecimal);
            int deStringParaInteiro = Convert.ToInt32(numeroEmString);
            decimal deStringParaDecimal = Convert.ToDecimal(numeroEmString);
            decimal deDoubleParaDecimal = Convert.ToDecimal(numeroDouble);

            Console.WriteLine($"O resultado da conversão foi: {deInteiroParaDecimal}");
            Console.WriteLine($"O resultado da conversão foi: {deDecimalParaInteiro}");
            Console.WriteLine($"O resultado da conversão foi: {deStringParaInteiro}");
            Console.WriteLine($"O resultado da conversão foi: {deStringParaDecimal}");
            Console.WriteLine($"O resultado da conversão foi: {deDoubleParaDecimal}");


        }
    }
}
