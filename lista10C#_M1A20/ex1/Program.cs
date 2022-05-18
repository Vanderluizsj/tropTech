using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá!");
            
            Console.WriteLine("Digite o numero de trabalhadores avaliados: ");
            int qtdTrabalhadores = int.Parse(Console.ReadLine());
            string[] nome = new string[qtdTrabalhadores];
            int[] idade = new int[qtdTrabalhadores];
            int[] tempoTrabalho = new int[qtdTrabalhadores];
            string[] aposentado = new string[qtdTrabalhadores];
		
		
            for(int i =0; i < qtdTrabalhadores; i++){
                Console.WriteLine("---------------------------------------------------");
                Console.Write("Digite o nome do trabalhadore a ser avaliado: ");
                nome[i] = Console.ReadLine();
            
                Console.Write("\nDigite o idade dos trabalhador a ser avaliado: ");
                idade[i] = int.Parse(Console.ReadLine());
            
                Console.Write("\nDigite o tempo de trabalho do trabalhador a ser avaliado: ");
                tempoTrabalho[i] = int.Parse(Console.ReadLine());

                trabalhadorAposentado(idade, tempoTrabalho, qtdTrabalhadores, aposentado);

            }
            for(int i =0; i < qtdTrabalhadores; i++){
                Console.Write($"\nNome: {nome[i]}\t idade: {idade[i]}\t tempo de trabalho: {tempoTrabalho[i]}\t Situação: {aposentado[i]}");
            }

            static void trabalhadorAposentado(int[] idade, int[] tempoTrabalho, int qtdTrabalhadores, string[] aposentado){
                for(int i =0; i < qtdTrabalhadores; i++)
                {
                    int idadeTrabalhador = idade[i];
                    int tempoDeTrabalho = tempoTrabalho[i];
                    if (idadeTrabalhador>=65)
                    {
                        aposentado[i] = "Sim";
                    } else if (tempoDeTrabalho >= 30)
                    {
                        aposentado[i] = "Sim";
                    } else if (idadeTrabalhador >= 60 && tempoDeTrabalho >=25)
                    {
                        aposentado[i] = "Sim";
                    }else{
                        aposentado[i] = "Não";
                    }
                }
            }
        }
    }
}
