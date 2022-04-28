using System;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá!");
            Console.Write("Informe o código da condição de pagamento: ");
            var cod = int.Parse(Console.ReadLine());
            Console.Write("Informe o valor do produto: ");
            var valor = double.Parse(Console.ReadLine());

            switch (cod)
            {               
            case 1:            
                Console.WriteLine("À vista em dinheiro ou cheque, com 10% de desconto");
                Console.WriteLine($"Valor a pagar = R$ {valor * 0.9}");                
                break;            
            case 2:                
                Console.WriteLine("À vista com cartão de crédito, com 5% de desconto");
                Console.WriteLine($"Valor a pagar = R$ {valor * 0.95}");
                break;
            case 3:                
                Console.WriteLine("Em 2 vezes, preço normal de etiqueta sem juros");
                Console.WriteLine($"Valor a pagar = R$ {valor} em 2x de R$ {valor/2}");
                break;
            case 4:
                valor = valor * 1.1;                
                Console.WriteLine("Em 3 vezes, preço de etiqueta com acréscimo de 10%");
                Console.WriteLine($"Valor a pagar = R$ {valor} em 3x de R$ {valor/3}");
                break;                        
            default:
                Console.WriteLine("Código inválido!");
                break;
            }
        }
    }
}
