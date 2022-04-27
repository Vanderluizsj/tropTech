using System;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá!");
            Console.Write("Informe sua idade: ");
            int idade = int.Parse(Console.ReadLine());
            bool maioridade = true;
            if(idade < 18){
                maioridade = false;
            }
            Console.WriteLine($"Maior de idade: {maioridade}");
        }
    }
}
