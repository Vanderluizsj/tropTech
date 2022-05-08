using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Insira o tamanho do vetor: ");
		int numeros = int.Parse(Console.ReadLine());
		int[] vetorNumeros = new int[numeros];
		int maiorNumero = 0;
		int posicao = 0;
		
		for(int i=0; i<numeros; i++ ){
			Console.Write("Digite o " + (i+1) +"º numero do vetor: ");
			vetorNumeros[i] = int.Parse(Console.ReadLine());
			if(vetorNumeros[i] > maiorNumero){
				maiorNumero = vetorNumeros[i];
				posicao = i;
			}
			
		}
		Console.WriteLine("\nO vetor tem " + numeros + " numeros. ");
		Console.WriteLine("Os numeros do vetor são: ");
		for(int i=0; i<numeros; i++ ){
			Console.Write("["+ vetorNumeros[i] + "], ");			
		}
		Console.WriteLine("\nO maior numero do vetor é: "+ maiorNumero);
		Console.WriteLine("A sua posição é: " + posicao);

        }
    }
}
