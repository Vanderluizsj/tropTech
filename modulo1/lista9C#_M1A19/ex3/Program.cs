using System;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma frase e veja quantas palavras ela tem: ");
            var qtdPalavras = 0;
            string frase = Console.ReadLine();
           // int teste = frase.Length;

            Console.WriteLine(frase);
            foreach (var caracter in frase)
            {
                int caracterInt = (char) caracter;
                
                //Console.WriteLine(teste);
                if (caracterInt == 32)
                {
                    qtdPalavras++;
                }
            }
            if (String.IsNullOrEmpty(frase))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"Frase invalida! Nenhum caracter foi digitado.");
            } else{
                qtdPalavras+=1;
                Console.Write($"A frase tem {qtdPalavras} palavras");
            }
        }
    }
}
