using System;

namespace AtividadeComplementar
{
    class Program
    {
        static void Main(string[] args)
        {
            var operacao = 0;
            Double saldo = 10000.00;
            Double saque = 0;
            Double deposito = 0;
            int quantidadeNotas100 = 0;
            int quantidadeNotas50 = 0;
            int quantidadeNotas20 = 0;
            int quantidadeNotas10 = 0;
            int opcao = 0;
            do
            {
                Console.Clear();
                quantidadeNotas100 = 0;
                quantidadeNotas50 = 0;
                quantidadeNotas20 = 0;
                quantidadeNotas10 = 0;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("----------------MENU-----------------");
                Console.WriteLine("Escolha alguma das opções abaixo: ");
                Console.WriteLine("[1] SAQUE");
                Console.WriteLine("[2] DEPOSITO");
                Console.WriteLine("[3] SALDO");            
                Console.WriteLine("[4] SAIR");            
                Console.WriteLine("--------------------------------------");
                Console.ForegroundColor = ConsoleColor.White;
                operacao = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (operacao)
                {
                    case 1:
                        Console.Write("Notas disponiveis: R$100, R$50, R$20 e R$10 ");
                        Console.Write("\nDigite o valor do saque: ");
                        saque = Double.Parse(Console.ReadLine());
                        if (saque>saldo)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Saldo insuficiente!");  
                            Console.Write($"Saldo atual = R$ {saldo}");  
                            Console.WriteLine("\nDigite um valor que seja menor que o saldo atual.");
                            Console.WriteLine("\nPressione qualquer tecla para tentar novamente.");
                            Console.ForegroundColor = ConsoleColor.White;
                            operacao = 0;
                            Console.ReadKey();
                            break;
                        }
                        if (saque%10 != 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Valor de saque indisponivel!");
                            Console.WriteLine("Notas disponiveis: R$100, R$50, R$20 e R$10 ");
                            Console.WriteLine("Digite um valor que seja possivel retirar com essas notas.");
                            Console.WriteLine("\nPressione qualquer tecla para tentar novamente.");
                            Console.ForegroundColor = ConsoleColor.White;
                            operacao = 0;
                            Console.ReadKey();
                            break;
                        }
                        Console.WriteLine($"Valor do saque = {saque} ");
                        saldo-=saque;
                        while (saque>=100)
                        {
                            saque -= 100;
                            quantidadeNotas100++;
                        }
                        while (saque>=50)
                        {
                            saque -= 50;
                            quantidadeNotas50++;
                        }
                        while (saque>=20)
                        {
                            saque -= 20;
                            quantidadeNotas20++;
                        }
                        while (saque>=10)
                        {
                            saque -= 10;
                            quantidadeNotas10++;
                        }
                        Console.WriteLine($"{quantidadeNotas100} nota(s) de R$100");
                        Console.WriteLine($"{quantidadeNotas50} nota(s) de R$50");
                        Console.WriteLine($"{quantidadeNotas20} nota(s) de R$20");
                        Console.WriteLine($"{quantidadeNotas10} nota(s) de R$10");
                        Console.WriteLine($"Saldo atual = R$ {saldo} ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Digite [1] para fazer outra operação. ");  
                        Console.ForegroundColor = ConsoleColor.White;                      
                        opcao = int.Parse(Console.ReadLine());
                        if (opcao == 1)
                        {
                            operacao = 0;
                        }
                        break;
                    case 2:
                        Console.Write("Digite o valor do depósito: ");
                        deposito = Double.Parse(Console.ReadLine());
                        saldo+=deposito;
                        Console.WriteLine($"Saldo atual = R$ {saldo} ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Digite [1] para fazer outra operação. ");     
                        Console.ForegroundColor = ConsoleColor.White;                   
                        opcao = int.Parse(Console.ReadLine());
                        if (opcao == 1)
                        {
                            operacao = 0;
                        }
                        
                        break;
                    case 3:
                        Console.WriteLine($"Saldo atual = R$ {saldo} ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Digite [1] para fazer outra operação. "); 
                        Console.ForegroundColor = ConsoleColor.White;                       
                        opcao = int.Parse(Console.ReadLine());
                        if (opcao == 1)
                        {
                            operacao = 0;
                        }
                        
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Opção invalida! Pressione qualquer tecla para continuar e selecione uma das 4 opções.");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadKey();
                        break;
                }
                
            } while (operacao > 4 || operacao < 1);
        }   
    }
}
