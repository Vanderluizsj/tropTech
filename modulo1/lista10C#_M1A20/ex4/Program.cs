using System;

namespace ex4
{
    public class Program
    {
        static int[] numeros = new int[1];
	    static int elementos = 0;
        public static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Informe um número: ");
                int numero = int.Parse(Console.ReadLine());
                InserirItem(numero);
                Console.WriteLine($"Tamanho: {numeros.Length} - Elementos: {elementos}");
            }
    	}

	    static void InserirItem(int numero)
	    {
		    if (elementos == numeros.Length)
		    {
			    int[] temp = new int[numeros.Length * 2];
			    for (int i = 0; i < numeros.Length; i++)
				    temp[i] = numeros[i];
			        numeros = temp;
		    }

		    numeros[elementos] = numero;
		    elementos++;
        }
    }
}
