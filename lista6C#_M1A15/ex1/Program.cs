using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá aluno Troptech!");
            Console.WriteLine("Você deve acertar as 10 questões para finalizar o teste.");
            Console.WriteLine("Digitar 0 na resposta encerra o programa. ");
            Console.Write("Vamos começar! Digite seu nome: ");
            
            
            var nome = Console.ReadLine();
            int pontuacao = 0; 
            
            do
            {
                for (int i = 0; i < 10; i++)
                {
                    int numero1 = new Random().Next(1,10);
                    int numero2 = new Random().Next(1,10);

                    Console.WriteLine($"Quanto é: {numero1} X {numero2} ?");
                    var resposta = int.Parse(Console.ReadLine());
                    if (resposta == 0)
                    {
                       Environment.Exit(0); 
                    }

                    if (resposta == numero1*numero2)
                    {
                        Console.WriteLine("Parabens, resposta correta!");
                        pontuacao++;
                    } else {
                        Console.WriteLine($"Que pena, não foi dessa vez! A resposta era: {numero1*numero2}");
                    }
                }
                if (pontuacao == 10)
                {
                    Console.WriteLine($"Parabens {nome}, sua pontuação é {pontuacao} e você passou!");
                } else {
                    Console.WriteLine($"Que pena {nome}, não foi dessa vez, sua pontuação é {pontuacao} e você deve refazer o teste.");
                }
            } while (pontuacao<10);


        }
    }
}
