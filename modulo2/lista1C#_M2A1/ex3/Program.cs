using System;

namespace AnimalDeEstimacao
{
    class Program
    {
        static void Main(string[] args)
        {
            var animais = new Animal[5];
            var quantidadeDeGatos = 0;
            var quantidadeDePeixes = 0;
            var quantidadeDeCachorro = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Digite o nome do animal: ");
                var nome = Console.ReadLine();

                Console.Write("Digite o tipo do animal (peixe, gato ou cachorro): ");
                var tipoDoAnimal = Console.ReadLine();

                var animal = new Animal(nome, tipoDoAnimal);

                animais[i] = animal;

                if (animal.Tipo == Animal.Gato)
                {
                    quantidadeDeGatos++;
                }
                else if (animal.Tipo == Animal.Cachorro)
                {
                    quantidadeDeCachorro++;
                }
                else
                {
                    quantidadeDePeixes++;
                }

                Console.Write("\n");
            }

            Console.WriteLine($"Quantidade de cachorros: {quantidadeDeCachorro}");
            Console.WriteLine($"Quantidade de gatos: {quantidadeDeGatos}");
            Console.WriteLine($"Quantidade de peixes: {quantidadeDePeixes}");
        }
    }
}
