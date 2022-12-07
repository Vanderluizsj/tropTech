using System;

namespace IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine($"Digite o nome da pessoa: ");
            var nome = Console.ReadLine();
            System.Console.WriteLine($"Digite o peso da pessoa: ");
            var peso = int.Parse(Console.ReadLine());
            System.Console.WriteLine($"Digite o altura da pessoa: ");
            var altura = float.Parse(Console.ReadLine());
            Console.WriteLine($"Digite o sexo da pessoa: ('f' para feminino e 'm' para masculino) ");
            var sexo = Console.ReadLine();
            Pessoa pessoa = new Pessoa(nome, peso, altura, sexo);
            Console.WriteLine("Nome da pessoa: " + Pessoa.RetornaNome());
            Console.WriteLine("Peso da pessoa: " + Pessoa.RetornaPeso());
            Console.WriteLine("Altura da pessoa: " + Pessoa.RetornaAltura());
            Console.WriteLine("Sexo da pessoa: " + Pessoa.RetornaSexo());
            Console.WriteLine("IMC da pessoa: " + Pessoa.CalculaIMC());
            System.Console.WriteLine("------------------------------------------");
            Pessoa.AlteraNome("Fulana");
            Pessoa.AlteraAltura(1.60);
            Pessoa.AlteraPeso(56);
            Pessoa.AlteraSexo("f");

            Console.WriteLine("Nome da pessoa: " + Pessoa.RetornaNome());
            Console.WriteLine("Peso da pessoa: " + Pessoa.RetornaPeso());
            Console.WriteLine("Altura da pessoa: " + Pessoa.RetornaAltura());
            Console.WriteLine("Sexo da pessoa: " + Pessoa.RetornaSexo());
            Console.WriteLine("IMC da pessoa: " + Pessoa.CalculaIMC());
        }
    }
}
