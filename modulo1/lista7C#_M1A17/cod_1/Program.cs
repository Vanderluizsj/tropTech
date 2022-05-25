using System;

namespace cod_1
{
    class Program
    {
        //Corrigido Indentação, remoção de chaves e mudança no nome das variaveis
        static void Main(string[] args)
        {
            var pontuacao = 0;
            while (pontuacao < 10)
            {
                for (int i = 0; i < 10; i++)
                {
                    var numero1 = new Random().Next(1, 10);
                    var numero2 = new Random().Next(1, 10);

                    Console.WriteLine(numero1 + " x " + numero2 + "? ");

                    var resposta = Convert.ToInt32(Console.ReadLine());

                    if (resposta == numero1 * numero2)
                    {
                        Console.WriteLine("Resposta Correta!");
                        pontuacao++;
                    }
                    else
                    {
                        Console.WriteLine($"Incorreto!!! A resposta é: {numero1 * numero2}");
                    }
                }
                Console.WriteLine("Sua pontuação é: " + pontuacao + "/10");

                if (pontuacao == 10)
                    Console.WriteLine("Parabéns, você sabe a tabuada decor e salteado!");
                else
                    Console.WriteLine("Você precisa estudar mais! Vamos tentar novamente!");
            }
        }
    }
}
