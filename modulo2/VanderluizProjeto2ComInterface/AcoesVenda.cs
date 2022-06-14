using System;
namespace VanderluizProjeto2ComInterface
{
    public class AcoesVenda
    {
         public static void CadastrarVenda()
        {
            string opcaoStr = string.Empty; 
            Console.ForegroundColor = ConsoleColor.Green;            
            Console.WriteLine("Digite uma das opções abaixo: ");
            Console.WriteLine("[1] Cadastrar venda.");            
            Console.WriteLine("[2] Voltar ao menu anterior."); 
            Console.ForegroundColor = ConsoleColor.White;
            opcaoStr = Console.ReadLine();

            if (String.IsNullOrEmpty(opcaoStr))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Valor Invalido! Pressione qualquer tecla e tente novmente.");                            
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();         
            }
            else if (opcaoStr == "2")
            {
                return;
            }
            else if(opcaoStr == "1")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Digite uma das opções abaixo: ");
                Console.WriteLine("[1] Pessoa física.");            
                Console.WriteLine("[2] Pessoa jurídica."); 
                var tipoCliente = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
                
                if (tipoCliente == "1")
                {
                    PessoaFisica clientePf = new PessoaFisica();

                    Console.Write("Informe o Nome do cliente: ");
                    string nome = Console.ReadLine();
                    string telefoneVenda = "0";
                    telefoneVenda = Cliente.ConsultarClienteVenda(nome);
                    if (telefoneVenda != "0")
                    {
                        Venda venda = new Venda();
                        venda.Nome = nome;
                        venda.Telefone = telefoneVenda;
                        Console.Write("Informe a descrição do produto: ");
                        venda.Descricao = Console.ReadLine();
                        Console.Write("Informe o valor do produto: ");
                        venda.ValorTotal = double.Parse(Console.ReadLine());
                                               
                        
                        venda.CadastrarVendaPf(venda);
                    }
                    
                    } else if (tipoCliente == "2")
                    {
                        PessoaJuridica clientePj = new PessoaJuridica();

                        Console.Write("Informe o Nome do cliente: ");
                        string nome = Console.ReadLine();
                        string telefoneVenda = "0";
                        telefoneVenda = Cliente.ConsultarClienteVenda(nome);
                        if (telefoneVenda != "0")
                        {
                            Venda venda = new Venda();
                            venda.Nome = nome;
                            venda.Telefone = telefoneVenda;
                            Console.Write("Informe a descrição do produto: ");
                            venda.Descricao = Console.ReadLine();
                            venda.ValorTotal = double.Parse(Console.ReadLine());
                                                       
                            venda.CadastrarVendaPj(venda);
                        }
                    }
                }else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Valor Invalido! Pressione qualquer tecla e tente novmente.");                            
                    Console.ForegroundColor = ConsoleColor.White;
                }
                                                       
            
        }
        public static void ExibirVendas()
        {
            if(Venda.Quantidade == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("A lista está vazia! Ainda não tem vendas cadastradas.");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            else
            {
                Venda.ConsultarVendasPf();
                Venda.ConsultarVendasPj();
            }
        }
    }
}