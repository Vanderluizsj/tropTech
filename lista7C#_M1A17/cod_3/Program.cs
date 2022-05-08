using System;

namespace cod_3
{
    class Program
    {
        //Corrigido Indentação, remoção de chaves e mudança no nome das variaveis
        static void Main(string[] args)
        {
            double somaSalario = 0;
		    int quantidadePessoas = 0;
		    int quantidadePessoasComSalarioAte100 = 0;
		    int quantidadeFilhos = 0;
		    double mediaSalario = 0;
		
		    double salario = 0;
		
            while(salario >= 0)
		    {
			    Console.Write("Salário: ");
			    salario = Convert.ToDouble(Console.ReadLine());
			
			    if(salario >= 0)
			    {	
				    Console.Write("Quantidade de filhos: ");
				    var filhos = Convert.ToInt32(Console.ReadLine());
				
				    somaSalario += salario;
				    quantidadeFilhos += filhos;
				    quantidadePessoas++;
				
				    if(salario > maiorSalario)
				    {
					    maiorSalario = salario;
				    }
				
				    if(salario <= 100)
				    {
					    quantidadePessoasComSalarioAte100++;
				    }
				
			    }
		    }
		
		    var mediaSalarioPopulacao = somaSalario/quantidadePessoas;
		    Console.WriteLine("Média salarial da população: R$" + mediaSalarioPopulacao);
		
		    // faz cast para double para pegar número quebrado na divisão.
		    var mediaNumeroFilhos = (double)quantidadeFilhos/quantidadePessoas;		

		    Console.WriteLine("Média número de filhos: " + mediaNumeroFilhos);
		
		    Console.WriteLine("Maior salário: " + maiorSalario);
		
		    var percentualPessoasComSalarioAte100 = (quantidadePessoasComSalarioAte100 * 100)/quantidadePessoas;
		    Console.WriteLine("Percentual de pessoas com salário até R$100,00: " + percentualPessoasComSalarioAte100 + "%");
	    }
        
    }
}
