using System;
using ContaDeLuz.Domain;
using ContaDeLuz.Infra.SqlServer.DAO;

namespace ContaDeLuz.ConsoleApp
{
    public class Verificacao
    {
        public static bool VerificarStringVazia(String verificar)
        {
            bool teste=String.IsNullOrEmpty(verificar)? true : false;
            return teste;
        }
        public static bool VerificacaoDeIntencao(bool teste)
        {                
            System.Console.WriteLine("Continuar? [1]SIM e [2]NÃO");
            var verificacao = Console.ReadLine();                
            Console.Clear();
            if (verificacao == "1")
            {
                teste = true;                    
                Console.ForegroundColor = ConsoleColor.Green;
                System.Console.WriteLine("Registros apagados com sucesso. Precione enter para continuar!");
                Console.ForegroundColor = ConsoleColor.White;   
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                System.Console.WriteLine("Operação cancelada!");
                Console.ForegroundColor = ConsoleColor.White;
                teste = false; 
            }
            return teste;
        }
        
    }
}