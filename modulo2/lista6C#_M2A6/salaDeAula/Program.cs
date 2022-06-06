using System;

namespace salaDeAula
{
    class Program
    {
        static void Main(string[] args)
        {
                for (int i = 0; i < 5; i++)
                {
                    Aluno aluno = new Aluno(); 
                    Console.Write("Digite o nome do aluno a ser cadastrado: ");
                    aluno.Nome = Console.ReadLine();
                    Console.Write("\nDigite a matricula do aluno a ser cadastrado: ");
                    aluno.Matricula = int.Parse(Console.ReadLine());
                    Console.Write("\nDigite a nota do aluno a ser cadastrado: ");
                    aluno.NotaProva = double.Parse(Console.ReadLine());
                
                    aluno.Cadastrar(aluno);
                }                              
                           

        }
    }
}
