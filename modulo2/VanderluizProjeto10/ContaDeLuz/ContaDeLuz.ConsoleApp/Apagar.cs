using System;
using ContaDeLuz.Domain;
using ContaDeLuz.Infra.SqlServer;
namespace ContaDeLuz.ConsoleApp
{
    public class Apagar
    {
        public static bool testeDeIntencao = false;
        public static void ApagarRegistro(ContaLuz conta, ContaDeLuzRepository _conta)
        {
            var opcaoStr = String.Empty;
            while (opcaoStr != "3")
            {
                do
                {                  
                    Console.Clear(); 
                    Console.WriteLine("---------------------------");
                    Console.WriteLine("--- APAGAR CONTA DE LUZ ---");
                    Console.WriteLine("---------------------------");
                    Console.WriteLine("|   [1] APAGAR UMA CONTA. |");
                    Console.WriteLine("|   [2] APAGAR TUDO.      |");
                    Console.WriteLine("|   [3] Voltar.           |");
                    Console.WriteLine("---------------------------");           
                    opcaoStr = Console.ReadLine();
                } while (Verificacao.VerificarStringVazia(opcaoStr));
                switch (opcaoStr)
                {
                    case "1":
                        Console.Clear();                               
                        
                        Console.WriteLine("Digite o Numero da fatura ser APAGADA:");
                        var numero = int.Parse(Console.ReadLine());
                        
                        conta = _conta.BuscarPorNumeroFatura(numero, conta);
                        Console.WriteLine($"A conta que sera apagada é: {conta}");
                        
                        testeDeIntencao = Verificacao.VerificacaoDeIntencao(testeDeIntencao);
                        if (testeDeIntencao)
                        {
                            _conta.Apagar(conta);
                        }                     
                        
                        Console.ReadKey(); 
                        break;
                    case "2":
                        Console.Clear();
                        System.Console.WriteLine("TODOS OS REGISTROS DA TABELA SERÃO APAGADOS!");
                        
                        testeDeIntencao = Verificacao.VerificacaoDeIntencao(testeDeIntencao);
                        if (testeDeIntencao)
                        {
                            _conta.ApagarTudo();
                        }
                        
                        Console.ForegroundColor = ConsoleColor.Green;
                        System.Console.WriteLine("Precione enter para continuar!");                        
                        Console.ForegroundColor = ConsoleColor.White;                         
                        break;
                    case "3":
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        System.Console.WriteLine("Precione enter para continuar!");                        
                        Console.ForegroundColor = ConsoleColor.White;                         
                        break;
                    default:
                        break;
                }
            }

        }        
              
               
    }
}