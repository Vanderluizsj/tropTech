using System;
using System.Collections.Generic;

namespace Turma
{
	public class Turma  {
		public string Nome;
		public List<Aluno> Alunos;
		public Turma()
		{
		this.Alunos = new List<Aluno>();
		}
		
		public double CalcularMedia() 
		{
			double somatorio = 0;
			foreach (var aluno in Alunos)
			{
				somatorio += aluno.NotaDaProva;
			}
					
			double media = somatorio / this.Alunos.Count;
			
			return media;
		}
		
	}
}
					
