using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("----      Sistema de IMC!        ----");
            Console.WriteLine("-------------------------------------");

            Console.WriteLine("Informe o nome do Paciente:");
            string nome = Console.ReadLine();

            Console.WriteLine("Informe a idade do Paciente:");
            int idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o peso do Paciente:");
            double peso = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a altura do Paciente:");
            double altura = Convert.ToDouble(Console.ReadLine());

            
            Paciente paciente = new Paciente();
            paciente.Nome = nome;
            paciente.Idade = idade;

            IMC imc = new IMC();
            imc.Altura = altura;
            imc.Peso = peso;

            paciente.Imc = imc;

            double calculoImc = paciente.CalcularImc();

            if(calculoImc < 16.00)
                Console.WriteLine($"Paciente {paciente.Nome} - IMC: {calculoImc} - Baixo peso grau III");
            else if(calculoImc >= 16.00 && calculoImc <= 16.99)
                Console.WriteLine($"Paciente {paciente.Nome} - IMC: {calculoImc} - Baixo peso grau II");
            else if(calculoImc >= 17.00 && calculoImc <= 18.49)
                Console.WriteLine($"Paciente {paciente.Nome} - IMC: {calculoImc} - Baixo peso grau I");
            else if(calculoImc >= 18.50 && calculoImc <= 24.99)
                Console.WriteLine($"Paciente {paciente.Nome} - IMC: {calculoImc} - Peso ideal");
            else if(calculoImc >= 25.00 && calculoImc <= 29.99)
                Console.WriteLine($"Paciente {paciente.Nome} - IMC: {calculoImc} - Sobrepeso");
            else if(calculoImc >= 30.00 && calculoImc <= 34.99)
                Console.WriteLine($"Paciente {paciente.Nome} - IMC: {calculoImc} - Obesidade grau I");
            else if(calculoImc >= 35.00 && calculoImc <= 39.99)
                Console.WriteLine($"Paciente {paciente.Nome} - IMC: {calculoImc} - Obesidade grau II");
            else if(calculoImc >= 40.00)
                Console.WriteLine($"Paciente {paciente.Nome} - IMC: {calculoImc} - Obesidade grau III");
        }
    }
}
