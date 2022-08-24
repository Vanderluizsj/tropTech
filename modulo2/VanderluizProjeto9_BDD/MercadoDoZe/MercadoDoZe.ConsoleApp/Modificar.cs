using System;
using MercadoDoZe.Classes;
using MercadoDoZe.Classes.DAO;
namespace MercadoDoZe.ConsoleApp
{
    public class Modificar
    {
        public static void ModificarRegistro(Produto produto, ProdutoDAO produtoDAO)
        {
            var opcaoStr = String.Empty;
            while (opcaoStr != "2")
            {
                Console.Clear(); 
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("------------- EDITAR PRODUTOS ------------");
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("|    [1] Modificar registro por ID.      |");
                Console.WriteLine("|    [2] Voltar.                         |");
                Console.WriteLine("------------------------------------------");           
                opcaoStr = Console.ReadLine();
                
                switch (opcaoStr)
                {
                    case "1":
                        Console.Clear();
                        System.Console.WriteLine("Digite o ID do produto a ser modificado:");
                        var id = int.Parse(Console.ReadLine());
                        produto = produtoDAO.BuscarPorId(id);

                        Console.WriteLine($" Produto que será editado:\n {produto}");

                        Console.ReadKey();

                        Console.WriteLine("Digite o nome do produto:");
                        produto.Nome = Console.ReadLine();

                        Console.WriteLine("Digite a descrição:");
                        produto.Descricao = Console.ReadLine();

                        Console.WriteLine("Digite a data de vencimento:(DD/MM/YYYY)");
                        produto.Vencimento = Convert.ToDateTime(Console.ReadLine());

                        Console.WriteLine("Digite o preço unitário:");
                        produto.Preco = float.Parse(Console.ReadLine());

                        Console.WriteLine("Digite a unidade:");
                        produto.Unidade = Console.ReadLine();

                        produtoDAO.AtualizarProduto(produto);                  
                                                                
                        Console.ForegroundColor = ConsoleColor.Green;
                        System.Console.WriteLine("Registros modificados com sucesso. Precione enter para continuar!");
                        Console.ForegroundColor = ConsoleColor.White;
                       
                        Console.ReadKey(); 
                        break;
                    case "2":
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
        public static void ModificarRegistroCliente(Cliente cliente, ClienteDAO clienteDAO)
        {
            var opcaoStr = String.Empty;
            while (opcaoStr != "2")
            {
                Console.Clear(); 
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("------------- EDITAR CLIENTE  ------------");
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("|    [1] Modificar registro por CPF      |");
                Console.WriteLine("|    [2] Voltar.                         |");
                Console.WriteLine("------------------------------------------");           
                opcaoStr = Console.ReadLine();
                
                switch (opcaoStr)
                {
                    case "1":
                        Console.Clear();
                        System.Console.WriteLine("Digite o cpf do cliente a ser modificado:");
                        var cpf = long.Parse(Console.ReadLine());
                        cliente = clienteDAO.BuscarPorCpf(cpf);

                        Console.WriteLine($" Cliente que será editado:\n {cliente}");

                        Console.ReadKey();

                        Console.WriteLine("Digite o nome do cliente:");
                        cliente.Nome = Console.ReadLine();

                        Console.WriteLine("Digite a data de nascimento:(DD/MM/YYYY)");
                        cliente.DataNascimento = Convert.ToDateTime(Console.ReadLine());
                        
                        Endereco endereco = new Endereco();

                        Console.WriteLine("Digite o nome da rua:");
                        endereco.Rua = Console.ReadLine();

                        Console.WriteLine("Digite o numero:");
                        endereco.Numero = int.Parse(Console.ReadLine());

                        Console.WriteLine("Digite o nome do bairro:");
                        endereco.Bairro = Console.ReadLine();

                        Console.WriteLine("Digite o cep:");
                        endereco.Cep = long.Parse(Console.ReadLine());

                        Console.WriteLine("Digite o complemento:");
                        endereco.Complemento = Console.ReadLine();

                        cliente.Endereco = endereco;

                        clienteDAO.AtualizarCliente(cliente);                  
                                                                
                        Console.ForegroundColor = ConsoleColor.Green;
                        System.Console.WriteLine("Registros modificados com sucesso. Precione enter para continuar!");
                        Console.ForegroundColor = ConsoleColor.White;
                       
                        Console.ReadKey(); 
                        break;
                    case "2":
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