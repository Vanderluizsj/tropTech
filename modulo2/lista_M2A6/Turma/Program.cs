using System;

namespace Turma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------");
			Console.WriteLine("-- Gerenciador de Turmas --");
			Console.WriteLine("---------------------------");
			
			Turma turma = new Turma();
			
			Console.Write("Digite o nome da turma: ");
			turma.Nome = Console.ReadLine();
			
			for(int i = 0; i< 2; i++) {
				var aluno = new Aluno();
				
				Console.Write($"Digite o nome do aluno {i + 1}:");
				aluno.Nome = Console.ReadLine();
				
				Console.WriteLine($"Digite a matricula do aluno {i + 1}:");
				aluno.NumeroMatricula = Convert.ToInt32(Console.ReadLine());
				
				Console.WriteLine($"Digite a nota da prova do aluno {i + 1}:");
				aluno.NotaDaProva = Convert.ToDouble(Console.ReadLine());
				
				turma.Alunos.Add((aluno));
			}
			
			Console.WriteLine("\n==== Alunos cadastrados ======\n");
			
			for(int i = 0; i< turma.Alunos.Count; i++) {
				Console.WriteLine($"-- Aluno {i + 1} --");
				Console.WriteLine($"Nome: {turma.Alunos[i].Nome}");
				Console.WriteLine($"Matricula: {turma.Alunos[i].NumeroMatricula}");
				Console.WriteLine($"Nota: {turma.Alunos[i].NotaDaProva}\n");
			}
			
			Console.WriteLine("\n------ Turma -------");
			Console.WriteLine($"Nome: {turma.Nome}");
			double media = turma.CalcularMedia();
			Console.WriteLine($"Media da Prova: {media}");
	
        }
    }
}
