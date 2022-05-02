using System;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
        double somaSalarios = 0;
		int qtdDePessoasEntrevistadas = 0;
		int qtdDePessoasComSalarioAte100 = 0;
		int somaQtdDeFilhos = 0;
		double maiorSalario = 0;
		
		double salario = 0;
		
		while(salario >= 0)
		{
			Console.Write("Salário: ");
			salario = Convert.ToDouble(Console.ReadLine());
			
			if(salario >= 0)
			{	
				Console.Write("Quantidade de filhos: ");
				var filhos = Convert.ToInt32(Console.ReadLine());
				
				somaSalarios += salario;
				somaQtdDeFilhos += filhos;
				qtdDePessoasEntrevistadas++;
				
				if(salario > maiorSalario)
				{
					maiorSalario = salario;
				}
				
				if(salario <= 100)
				{
					qtdDePessoasComSalarioAte100++;
				}
				
			}
		}
		
		var mediaSalarioPopulacao = somaSalarios/qtdDePessoasEntrevistadas;
		Console.WriteLine("Média salarial da população: R$" + mediaSalarioPopulacao);
	
		var mediaNumeroFilhos = (double)somaQtdDeFilhos/qtdDePessoasEntrevistadas;		

		Console.WriteLine("Média número de filhos: " + mediaNumeroFilhos);
		
		 Console.WriteLine("Maior salário: " + maiorSalario);
		
		var percentualPessoasComSalarioAte100 = (qtdDePessoasComSalarioAte100 * 100)/qtdDePessoasEntrevistadas;
		Console.WriteLine("Percentual de pessoas com salário até R$100,00: " + percentualPessoasComSalarioAte100 + "%");
        }
    }
}
