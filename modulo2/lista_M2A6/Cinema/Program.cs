using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
			
		
			int quantidadeDeHoras = 3;
			
			Sessao sessao = new Sessao(quantidadeDeHoras);
			
			int posicao = 0;
			while(!sessao.EstaCheia() && posicao >= 0 ) {
				Console.Clear();
				
				Console.WriteLine("-----------------------------");
            	Console.WriteLine("--- Gerenciador de Cinema ---");
            	Console.WriteLine("-----------------------------");
				
				Console.WriteLine("Digite um numero da cadeira (1-10) para ocupar: ");
				var posicaoStr = Console.ReadLine();
				if (!String.IsNullOrEmpty(posicaoStr))
				{
					posicao = int.Parse(posicaoStr);
				}
				if(posicao > 10) {
					Console.WriteLine($"{posicao} inválida, informe um numero entre 1-10!\n");
				} else if(posicao >= 0 ) {
					bool ocupouComSucesso = sessao.Ocupa(posicao);
					if(ocupouComSucesso) {
						Console.WriteLine($"Cadeira numero {posicao} ocupada com sucesso!\n");
					} else {
						Console.WriteLine($"Posição {posicao} já está ocupada, tente outra :(\n");
					}
				}
				System.Console.WriteLine("Precione enter para continuar!");
				Console.ReadKey();
			}
			int qtdDeCadeirasLivres = sessao.CalcularQtdDeVagasLivres();
			Console.WriteLine($"\nQtd de cadeiras livres: {qtdDeCadeirasLivres}");
			Console.WriteLine($"\nBom filme! :)");
        }
    }
}
