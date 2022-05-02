using System;

namespace ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe o numero de linhas que sera impresso na arvore (minimo 5): ");
            int l1 = int.Parse(Console.ReadLine());
            
            if (l1>=5)
            {                          

                for (int i = 0, x = 1, b = 6; i < l1; i++, x+=2, b--)
                {
                    var espaco = " ";
                    for (int a = 0; a < b; a++)
                    {
                        Console.Write(espaco);
                    }       


                    for (int z = 0; z < x; z++)            
                        Console.Write("*");            
                
                    Console.Write("\n");
                }
        } 
         else{
                Console.WriteLine("Numero de linhas inferior ao solicitado. ");
        }             


        }
    }
}
