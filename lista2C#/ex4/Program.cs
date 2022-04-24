using System;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o caracter que sera impresso na arvore: ");
            char l1 = Convert.ToChar(Console.ReadLine());   


        for (int i = 0, x = 1, b = 6; i < 7; i++, x+=2, b--)
        {
            var espaco = " ";
            for (int a = 0; a < b; a++)
            {
                Console.Write(espaco);
            }       


            for (int z = 0; z < x; z++)            
                Console.Write(l1);            
           
            Console.Write("\n");
        }

        }
    }
}
