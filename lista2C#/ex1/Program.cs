using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            var n1 = "2";
            var n2 = "5";

           /* 
                OUTRA FORMA DE FAZER
           int int1 = Convert.ToInt32(n1);
           int int2 = Int32.Parse(n2);
           var soma =  int1 + int2;
           */
            var soma = Convert.ToInt32(n1) + Int32.Parse(n2);
            Console.WriteLine($"A soma é: {soma}");
        }
    }
}
