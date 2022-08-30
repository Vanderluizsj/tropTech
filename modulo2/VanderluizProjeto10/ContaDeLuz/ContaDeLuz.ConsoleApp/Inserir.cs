using System;
using ContaDeLuz.Domain;
using ContaDeLuz.Infra.SqlServer;
namespace ContaDeLuz.ConsoleApp
{
    public class Inserir
    {
        public static void InserirRegistro(ContaLuz conta, ContaDeLuzRepository _contaRepository)
        {
            Console.Clear(); 
            Console.WriteLine("--------------------------");
            Console.WriteLine("---  CADASTRAR CONTA   ---");
            Console.WriteLine("--------------------------");
                                   
            Console.WriteLine("Digite o numero da fatura: (ex: 1123)");
            conta.NumeroFatura = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a data da leitura: (ex: 12-11-2022)");
            conta.DataLeitura = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de Kw: (ex: 20,9)");
            conta.QuantidadeKw = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Digite Valor: (ex: 250,99)");
            conta.Valor = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Digite a data de pagamento: (ex: 12-11-2022)");
            conta.DataPagamento = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Digite a media de consumo: (ex: 300)");
            conta.MediaConsumo = decimal.Parse(Console.ReadLine());
            conta.Cadastrada = true;
            var lista = _contaRepository.BuscarTodos();
            bool verificaData = false;
            foreach (var item in lista)
            {
                verificaData = DateTime.Equals(conta.DataLeitura, item.DataLeitura);
            }
            if (!verificaData)
            {
                _contaRepository.Cadastrar(conta);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Registro inserido com sucesso. Precione enter para continuar!");
                Console.ForegroundColor = ConsoleColor.White;                        
                Console.ReadKey(); 
            } else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine("Já tem uma fatura com a mesma data cadastrada");
                Console.ForegroundColor = ConsoleColor.White; 
            }                                                             
        }        
    }
}