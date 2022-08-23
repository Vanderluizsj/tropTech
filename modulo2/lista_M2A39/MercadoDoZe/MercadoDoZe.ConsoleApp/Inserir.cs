using System;
using System.Data.SqlClient;
using MercadoDoZe.Classes;
using MercadoDoZe.Classes.DAO;
namespace MercadoDoZe.ConsoleApp
{
    public class Inserir
    {
        public static void InserirRegistro(Produto produto, ProdutoDAO produtoDAO)
        {
            var opcaoStr = String.Empty;
            while (opcaoStr != "2")
            {
                Console.Clear(); 
                Console.WriteLine("--------------------------");
                Console.WriteLine("--- CADASTRAR PRODUTOS ---");
                Console.WriteLine("--------------------------");
                Console.WriteLine("|    [1] Cadastrar.      |");
                Console.WriteLine("|    [2] Voltar.         |");
                Console.WriteLine("--------------------------");           
                opcaoStr = Console.ReadLine();
                switch (opcaoStr)
                {
                    case "1":
                        Console.Clear();                               
                        Console.WriteLine("Digite um nome: (ex: Refrigerante)");
                        produto.Nome = Console.ReadLine();
                        Console.WriteLine("Digite a descrição: (ex: Fanta)");
                        produto.Descricao = Console.ReadLine();
                        Console.WriteLine("Digite o vencimento: (ex: 12-11-2022)");
                        produto.Vencimento = Convert.ToDateTime(Console.ReadLine());
                        Console.WriteLine("Digite o preço: (ex: 9,99)");
                        produto.Preco = float.Parse(Console.ReadLine());
                        Console.WriteLine("Digite a unidade: (ex: 2L)");
                        produto.Unidade = Console.ReadLine();
                        Console.WriteLine("Digite a quantidade: (ex: 10)");
                        produto.QuantidadeEstoque = int.Parse(Console.ReadLine());
                        produtoDAO.AdicionarProduto(produto);

                        Console.ForegroundColor = ConsoleColor.Green;
                        System.Console.WriteLine("Registro inserido com sucesso. Precione enter para continuar!");
                        Console.ForegroundColor = ConsoleColor.White;                        
                        Console.ReadKey(); 
                        break;
                    case "2":
                        Console.ForegroundColor = ConsoleColor.Green;
                        System.Console.WriteLine("Precione enter para continuar!");                        
                        Console.ForegroundColor = ConsoleColor.White;                         
                        break;
                    default:
                        break;
                }
            }
                
        }
        public static void InserirRegistroCliente(Cliente cliente, ClienteDAO clienteDAO)
        {
            var opcaoStr = String.Empty;
            while (opcaoStr != "2")
            {
                Console.Clear(); 
                Console.WriteLine("--------------------------");
                Console.WriteLine("--- CADASTRAR CLIENTES ---");
                Console.WriteLine("--------------------------");
                Console.WriteLine("|    [1] Cadastrar.      |");
                Console.WriteLine("|    [2] Voltar.         |");
                Console.WriteLine("--------------------------");           
                opcaoStr = Console.ReadLine();
                switch (opcaoStr)
                {
                    case "1":
                        Console.Clear();                               
                        Console.WriteLine("Digite apenas os numeros do cpf: (ex: 02114589955)");
                        cliente.Cpf = long.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o nome do cliente: (ex: João)");
                        cliente.Nome = Console.ReadLine();
                        Console.WriteLine("Digite a data de nascimento do cliente: (ex: 02-02-2002)");                        
                        cliente.DataNascimento = Convert.ToDateTime(Console.ReadLine());
                        cliente.PontosFidelidade = 0;
                        Endereco endereco = new Endereco(); 
                        Console.WriteLine("Digite o Bairro do cliente: (ex: Santa Clara)");
                        endereco.Bairro = Console.ReadLine();
                        Console.WriteLine("Digite a rua do cliente: (ex: fortaleza)");
                        endereco.Rua = Console.ReadLine();
                        Console.WriteLine("Digite o numero: (ex: 10)");
                        endereco.Numero = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o complemento: (ex: fundos)");
                        endereco.Complemento = Console.ReadLine();
                        Console.WriteLine("Digite o cep: (ex: 88600201)");
                        endereco.Cep = long.Parse(Console.ReadLine());

                        cliente.Endereco = endereco;

                        clienteDAO.AdicionarCliente(cliente);

                        Console.ForegroundColor = ConsoleColor.Green;
                        System.Console.WriteLine("Registro inserido com sucesso. Precione enter para continuar!");
                        Console.ForegroundColor = ConsoleColor.White;                        
                        Console.ReadKey(); 
                        break;
                    case "2":
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