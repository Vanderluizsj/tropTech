using System;

namespace Aluno
{
	public class Program
	{
		public static void Main()
		{
			Console.WriteLine("==== Gerenciador de Alunos ======");
			Aluno[] alunos = new Aluno[5];
			for(int i = 0; i< alunos.Length; i++) {
				var aluno = new Aluno();
				
				Console.Write($"Digite os dados do aluno {i + 1}: ");
				Console.Write($"Digite o nome do aluno:");
				aluno.Nome = Console.ReadLine();
				
				Console.WriteLine($"Digite a matricula do aluno:");
				aluno.Matricula = Convert.ToInt32(Console.ReadLine());
				
				Console.WriteLine($"Digite a nota da prova do aluno:");
				aluno.NotaProva = Convert.ToDecimal(Console.ReadLine());
			
				alunos[i] = aluno; 
			}
			
			Console.WriteLine("\n--	 Alunos cadastrados  --\n");
			Console.WriteLine("------------------------------");

			for(int i = 0; i< alunos.Length; i++) {
				Console.WriteLine($"-----  Aluno {i + 1}  -----");
				Console.WriteLine($"Nome: {alunos[i].Nome}");
				Console.WriteLine($"Matricula: {alunos[i].Matricula}");
				Console.WriteLine($"Nota: {alunos[i].NotaProva}\n");
			}
		}
	}

}
