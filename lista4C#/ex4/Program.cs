using System;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá!");
            Console.Write("Informe sua idade: ");
            var idade = int.Parse(Console.ReadLine());
            Console.Write("Informe seu tempo de serviço: ");
            var tempo = int.Parse(Console.ReadLine());

            if (idade >= 65)
            {
                Console.WriteLine("Parabéns, você já pode se aposentar por idade!");
            }
            else if (tempo >= 30)
            {
                Console.WriteLine("Parabéns, você já pode se aposentar por tempo de serviço!");
            }
            else if (idade >= 60 && tempo >= 25)
            {
                Console.WriteLine("Parabéns, você já pode se aposentar por idade e tempo de serviço!");
            }           
            else
            {
                Console.WriteLine("Lamento, mas você ainda não pode se aposentar!");
            }
        }
    }
}
