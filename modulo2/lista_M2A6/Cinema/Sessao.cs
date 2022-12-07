using System;
using System.Collections.Generic;

namespace Cinema
{

	public class Sessao {
		public string NomeDoFilme;
		public double Duracao;
		public List<Cadeira> Cadeiras;
		
		public Sessao(double duracao) {
			this.Duracao = duracao;
			this.Cadeiras = new List<Cadeira>();
		}

		public bool Verifica(int posicao) {

			foreach (var cadeira in Cadeiras)
			{
				if(cadeira.Numero == posicao) {
					return false;
				}
			}
			return true;
		}
		
		public bool Ocupa(int posicao) {
		bool estaLivre = Verifica(posicao);
		if(estaLivre) {
			Cadeira cadeira = new Cadeira();
			cadeira.Numero = posicao;
			Cadeiras.Add(cadeira);

			return true;
		}
			
			return false;
		}
		
		public int CalcularQtdDeVagasLivres() {
		return 10 - Cadeiras.Count;
		}
		
		public bool EstaCheia() {
		return this.CalcularQtdDeVagasLivres() == 0;
		}
	}
}


