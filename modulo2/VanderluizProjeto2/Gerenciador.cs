using System;

namespace VanderluizProjeto2
{
    public class Gerenciador
    {
        public static void Cadastrar()
        {
            string opcaoStr = string.Empty;
            
            Console.WriteLine("Digite uma das opções abaixo: ");
            Console.WriteLine("[1] Cadastrar cliente Pessoa Física.");
            Console.WriteLine("[2] Consultar Cliente Pessoa Jurídica.");
            Console.WriteLine("[3] Voltar ao menu anterior."); 
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
                    clientePf.Cpf = Convert.ToInt32(Console.ReadLine());

                    Endereco endereco = new Endereco(rua, numero, bairro, cidade, estado, pais);
                    clientePf.Endereco = endereco;
                    //Cliente cliente = new PessoaFisica();
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
                    clientePj.Cnpj = Convert.ToInt32(Console.ReadLine());
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
                Console.WriteLine("A lista está vazia! Ainda não tem clietes cadastrados.");
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
                Console.WriteLine("A lista está vazia! Ainda não tem clietes cadastrados.");
                return;
            }
            else
            {
                int opcao = 0;
                do
                {
                    Console.WriteLine("Informe o Nome que deseja consultar na lista");
                    string nomeConsulta = Console.ReadLine();

                    if (nomeConsulta == string.Empty)
                    {
                        Console.WriteLine("Valor Invalido, tente denovo");
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
                Console.WriteLine("A lista está vazia! Ainda não tem clietes cadastrados.");
                return;
            }
            else
            {
                int opcao = 0;
                do
                {
                    Console.WriteLine("Informe o Nome que deseja remover da lista");
                    string nomeConsulta = Console.ReadLine();

                    if (nomeConsulta == string.Empty)
                    {
                        Console.WriteLine("Valor Invalido, tente denovo");
                        opcao = 0;
                    }else
                    {
                        opcao = 1;          
                        cliente.RemoverCliente(nomeConsulta);                     
                    }
                } while (opcao<1);
                
            }
        }
        public static void CadastrarVenda()
        {
            string opcaoStr = string.Empty;             
            Console.WriteLine("Digite uma das opções abaixo: ");
            Console.WriteLine("[1] Cadastrar venda.");            
            Console.WriteLine("[2] Voltar ao menu anterior."); 
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
                
                Console.Write("Pessoa física ou jurídica?");
                var tipoCliente = Console.ReadLine();
                if (tipoCliente == "física" || tipoCliente == "fisica")
                {
                    PessoaFisica clientePf = new PessoaFisica();

                    Console.Write("Informe o Nome do cliente: ");
                    string nome = Console.ReadLine();
                    bool clienteExiste = Cliente.ConsultarClienteVenda(nome);
                    if (clienteExiste)
                    {
                        Venda venda = new Venda();
                        clientePf.Nome = nome;
                        Console.Write("Informe a descrição do produto: ");
                        venda.Descricao = Console.ReadLine();
                        Console.Write("Informe o valor do produto: ");
                        venda.ValorTotal = double.Parse(Console.ReadLine());
                                               
                        
                        venda.CadastrarVenda(venda);
                    }
                    
                    } else if (tipoCliente == "jurídica" || tipoCliente == "juridica")
                    {
                        PessoaJuridica clientePj = new PessoaJuridica();

                        Console.Write("Informe o Nome do cliente: ");
                        string nome = Console.ReadLine();

                        bool clienteExiste = Cliente.ConsultarClienteVenda(nome);
                        if (clienteExiste)
                        {
                            Venda venda = new Venda();
                            Console.Write("Informe a descrição do produto: ");
                            venda.Descricao = Console.ReadLine();
                            venda.ValorTotal = double.Parse(Console.ReadLine());
                                                       
                            venda.CadastrarVenda(venda);
                        }
                    }
                }else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Valor Invalido! Pressione qualquer tecla e tente novmente.");                            
                    Console.ForegroundColor = ConsoleColor.White;
                }
                                                       
            
        }
        public static void ExibirVendas(Venda venda)
        {
            if(venda.Quantidade == 0)
            {
                Console.WriteLine("A lista está vazia! Ainda não tem vendas cadastradas.");
                return;
            }
            else
            {
                Venda.ConsultarVendas();
            }
        } 
    }
}