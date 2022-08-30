using System;
using ContaDeLuz.Domain;
using ContaDeLuz.Infra.SqlServer;
namespace ContaDeLuz.ConsoleApp
{
    public class Modificar
    {
        public static void ModificarRegistro(ContaLuz conta, ContaDeLuzRepository _conta)
        {
            
                Console.Clear(); 
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("------------- EDITAR CONTA ---------------");
                Console.WriteLine("------------------------------------------");

                Console.WriteLine("Digite o numero da fatura a ser modificada:");
                var numeroFatura = int.Parse(Console.ReadLine());
                conta = _conta.BuscarPorNumeroFatura(numeroFatura, conta);

                Console.WriteLine($"A conta que será editada:\n {conta}");

                Console.ReadKey();

                Console.WriteLine("Digite a nova data da leitura:(DD/MM/YYYY)");
                conta.DataLeitura = Convert.ToDateTime(Console.ReadLine());
                      
                Console.WriteLine("Digite a quantidade de Kw:");
                conta.QuantidadeKw = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Digite o valor:");
                conta.Valor = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Digite a data de pagamento:(DD/MM/YYYY)");
                conta.DataPagamento = Convert.ToDateTime(Console.ReadLine());

                _conta.Modificar(conta);                 
                                                                
                Console.ForegroundColor = ConsoleColor.Green;
                System.Console.WriteLine("Registros modificados com sucesso. Precione enter para continuar!");
                Console.ForegroundColor = ConsoleColor.White;
                       
                Console.ReadKey(); 
                        
        }
    }           
                
}
        