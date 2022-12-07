using System;

namespace ExercData
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira data no formato dd/mm/yyyy: ");
            var dataCompleta = Console.ReadLine();

            var dataQuebrada = dataCompleta.Split("/");

            var dia = Convert.ToInt16(dataQuebrada[0]);
            var mes = Convert.ToInt16(dataQuebrada[1]);
            var ano = Convert.ToInt16(dataQuebrada[2]);

            var data = new Data(dia, mes, ano);
            Console.WriteLine($"A data inserida é: {data.DataCompleta}");

            Console.ReadKey();

            Console.WriteLine("Digite: ");
            System.Console.WriteLine("[1] Para somar dia.");
            System.Console.WriteLine("[2] Para somar mês.");
            System.Console.WriteLine("[3] Para somar ano.");
            var escolha = Console.ReadLine();
            if (String.IsNullOrEmpty(escolha))
            {
                System.Console.WriteLine("Valor invalido!");
            }
           

            Console.WriteLine("Digite o valor que deseja somar: ");
            var valorParaSoma = Convert.ToInt16(Console.ReadLine());

            switch (escolha)
            {
                case "1":
                    data.DiasParaAdicionar = valorParaSoma;
                    break;
                case "2":
                    data.MesesParaAdicionar = valorParaSoma;
                    break;
                case "3":
                    data.AnosParaAdicionar = valorParaSoma;
                    break;
            }
            
            Console.WriteLine($"A data final é: {data.DataCompleta}");
        }
    }
}
