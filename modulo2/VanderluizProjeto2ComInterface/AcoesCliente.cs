using System;

namespace VanderluizProjeto2ComInterface
{
    public class AcoesCliente
    {
        public static void Cadastrar()
        {
            string opcaoStr = string.Empty;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Digite uma das opções abaixo: ");
            Console.WriteLine("[1] Cadastrar cliente Pessoa Física.");
            Console.WriteLine("[2] Consultar Cliente Pessoa Jurídica.");
            Console.WriteLine("[3] Voltar ao menu anterior."); 
            Console.ForegroundColor = ConsoleColor.White;
            

            opcaoStr = Console.ReadLine();

            if (String.IsNullOrEmpty(opcaoStr))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Valor Invalido! Pressione qualquer tecla e tente novmente.");                            
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();         
                }
            else if (opcaoStr == "3")
            {
                return;
            }
            else
            {
                if (opcaoStr == "1")
                {
                    PessoaFisica clientePf = new PessoaFisica();

                    Console.Write("Informe o Nome: ");
                    clientePf.Nome = Console.ReadLine();
                    Console.Write("Informe o numero de Telefone:  ");
                    clientePf.Telefone = Console.ReadLine();
                    Console.Write("Informe a Rua: ");
                    string rua = Console.ReadLine();
                    Console.Write("Informe o Bairro: ");
                    string bairro = Console.ReadLine();
                    Console.Write("Informe o Número: ");
                    int numero = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Informe a Cidade: ");
                    string cidade = Console.ReadLine();
                    Console.Write("Informe o Estado: ");
                    string estado = Console.ReadLine();
                    Console.Write("Informe o País: ");
                    string pais = Console.ReadLine();
                    Console.Write("Informe a CPF: "); 
                    clientePf.Cpf = Console.ReadLine();

                    Endereco endereco = new Endereco(rua, numero, bairro, cidade, estado, pais);
                    clientePf.Endereco = endereco;
                    
                    clientePf.CadastrarCliente(clientePf);
                } else if (opcaoStr == "2")
                {
                    PessoaJuridica clientePj = new PessoaJuridica();

                    Console.Write("Informe o Nome: ");
                    clientePj.Nome = Console.ReadLine();
                    Console.Write("Informe o numero de telefone:  ");
                    clientePj.Telefone = Console.ReadLine();
                    Console.Write("Informe a Rua: ");
                    string rua = Console.ReadLine();
                    Console.Write("Informe o Bairro: ");
                    string bairro = Console.ReadLine();
                    Console.Write("Informe o Número: ");
                    int numero = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Informe a Cidade: ");
                    string cidade = Console.ReadLine();
                    Console.Write("Informe o Estado: ");
                    string estado = Console.ReadLine();
                    Console.Write("Informe o País: ");
                    string pais = Console.ReadLine();
                    Console.Write("Informe a CNPJ: ");
                    clientePj.Cnpj = Console.ReadLine();
                    Endereco endereco = new Endereco(rua, numero, bairro, cidade, estado, pais);
                    clientePj.Endereco = endereco;                      
                    
                    clientePj.CadastrarCliente(clientePj);
                }              
            }               

        }
        public static void ExibirLista(Cliente cliente)
        {
            if(cliente.Quantidade == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("A lista está vazia! Ainda não tem clietes cadastrados.");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            else
            {
                cliente.ConsultarClientes();
            }
        }
        public static void ConsultarCliente(Cliente cliente)
        {
            if(cliente.Quantidade == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("A lista está vazia! Ainda não tem clietes cadastrados.");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            else
            {
                int opcao = 0;
                do
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Informe o Nome que deseja consultar na lista");
                    string nomeConsulta = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    if (nomeConsulta == string.Empty)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Valor Invalido, tente denovo");
                        Console.ForegroundColor = ConsoleColor.White;
                        opcao = 0;
                    }else
                    {
                        opcao = 1;          
                        cliente.ConsultarCliente(nomeConsulta);                     
                    }
                } while (opcao<1);
                
            }
        } 
        public static void RemoverCliente(Cliente cliente)
        {
            if(cliente.Quantidade == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("A lista está vazia! Ainda não tem clietes cadastrados.");
                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
            else
            {
                int opcao = 0;
                do
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Informe o Nome que deseja remover da lista");
                    Console.ForegroundColor = ConsoleColor.White;
                    string nomeConsulta = Console.ReadLine();

                    if (nomeConsulta == string.Empty)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Valor Invalido, tente denovo");
                        Console.ForegroundColor = ConsoleColor.White;
                        opcao = 0;
                    }else
                    {
                        opcao = 1;          
                        cliente.RemoverCliente(nomeConsulta);                     
                    }
                } while (opcao<1);
                
            }
        }
        
    }
}