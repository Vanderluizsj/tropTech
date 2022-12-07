using System;

namespace ExercData
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira data: (ex: 25/12/2022: ");
            var dataCompleta = Console.ReadLine();

            var dataQuebrada = dataCompleta.Split("/");

            var dia = int.Parse(dataQuebrada[0]);
            var mes = int.Parse(dataQuebrada[1]);
            var ano = int.Parse(dataQuebrada[2]);

            var data = new Data(dia, mes, ano);
            Console.WriteLine($"A data inserida é: {data.DataCompleta}");

            data.DiasParaAdicionar = 1;
            Console.WriteLine("Adicionando 1 dia: " + data.DataCompleta);

            data.MesesParaAdicionar = 3;
            Console.WriteLine("Adicionando 3 meses: " + data.DataCompleta);

            data.AnosParaAdicionar = 2;
            Console.WriteLine("Adicionando 2 anos: " + data.DataCompleta);
        }
    }
}
