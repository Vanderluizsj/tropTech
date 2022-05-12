using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Atenção! Uma senha forte deve ter ao menos 1 letra maiuscula, 1 caracter especial, 1 letra minuscula, 1 numero e ter mais de 5 caracteres.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Digite sua nova senha: ");
            string senha = Console.ReadLine();
            int qtdLetrasMaiusculas = 0;
            int qtdLetrasMinusculas = 0;
            int qtdNumeros = 0;
            int qtdCaracteresEspeciais = 0;
            int minimoCaracteres = 0;
            foreach (var letra in senha)
            {
                int contagem = letra;
                minimoCaracteres++;
                if (contagem>64 && contagem<91)
                {
                    qtdLetrasMaiusculas++;
                } else if (contagem>96 && contagem<123)
                {
                    qtdLetrasMinusculas++;
                } else if (contagem>47 && contagem<58)
                {
                    qtdNumeros++;
                } else
                {
                    qtdCaracteresEspeciais++;
                }
            }

            Console.WriteLine($"A quantidade de letras maiusculas é de {qtdLetrasMaiusculas}");
            Console.WriteLine($"A quantidade de letras minusculas é de {qtdLetrasMinusculas}");
            Console.WriteLine($"A quantidade de numeros é de {qtdNumeros}");
            Console.WriteLine($"A quantidade de caracteres especiais é de {qtdCaracteresEspeciais}");
            Console.ForegroundColor = ConsoleColor.Red;
            if(qtdCaracteresEspeciais>0 && qtdLetrasMaiusculas>0 && qtdLetrasMinusculas>0 && qtdNumeros>0 && minimoCaracteres>5)            
                {
                    Console.WriteLine("Parabens, sua senha é forte!!!");
                } else{
                    Console.WriteLine("Senha fraca!!!");
                }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
