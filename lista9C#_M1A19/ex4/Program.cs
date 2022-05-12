using System;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma frase sobre tecnologia e veja quantas palavras da frase estão entre as reservadas nesse programa: ");
            string[] palavras = {"programador", "tecnologia", "computador"};
            string frase = Console.ReadLine();
            string[] fraseArray = frase.Split(' ' , ',');
            int numeroPalavras = 0;

            for (int x = 0; x < palavras.Length; x++)
            {               
                for (int i = 0; i < fraseArray.Length; i++)
                {
                    string palavra = palavras[x];
                    string palavraFrase = fraseArray[i];
                    if (String.Equals(palavra, palavraFrase))
                    {
                        numeroPalavras++;
                    }
                }
           }

            Console.Write($"A frase tem {numeroPalavras} palavra(s) reservada(s)");
        }
    }
}
