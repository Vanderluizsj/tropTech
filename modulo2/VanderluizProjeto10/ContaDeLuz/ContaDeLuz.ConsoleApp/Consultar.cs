using System;
using System.Collections.Generic;
using ContaDeLuz.Domain;
using ContaDeLuz.Infra.SqlServer;
namespace ContaDeLuz.ConsoleApp
{
    public class Consultar
    {
        public static void ConsultarRegistro(ContaLuz conta, ContaDeLuzRepository _contaDeLuzRepository)
        {
            var opcaoStr = String.Empty;
            do
            {
                Console.Clear(); 
                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine("---------------- CONSULTAR PRODUTOS -----------------");
                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine("|    [1] Consultar todos os itens cadastrados.      |");
                Console.WriteLine("|    [2] Consultar itens por numero                 |");           
                Console.WriteLine("-----------------------------------------------------");           
                opcaoStr = Console.ReadLine();
            } while (Verificacao.VerificarStringVazia(opcaoStr));          
            switch (opcaoStr)
            {
                case "1":
                    Console.Clear();
                    var listaContas = _contaDeLuzRepository.BuscarTodos();
                    Imprimir(listaContas);

                    Console.ForegroundColor = ConsoleColor.Green;
                    System.Console.WriteLine("Precione enter para continuar!");                        
                    Console.ForegroundColor = ConsoleColor.White; 
                    break;
                case "2":                    
                    Console.Clear();
                    Console.WriteLine("Digite o numero da fatura para consulta: (ex: 1122)");
                    var numero = int.Parse(Console.ReadLine());
                    conta = _contaDeLuzRepository.BuscarPorNumeroFatura(numero, conta);
                    if (conta.NumeroFatura!=0)
                    {
                       System.Console.WriteLine(conta.ToString());   
                    }                                      
                    break;                
                default:
                    Console.ForegroundColor = ConsoleColor.Green;
                    System.Console.WriteLine("Precione enter para continuar!");                        
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
            void Imprimir(List<ContaLuz> listaContas)
            {
                foreach (var item in listaContas)
                {
                    System.Console.WriteLine(item.ToString());
                }
            }         
                        
        }       
                     
    }
}