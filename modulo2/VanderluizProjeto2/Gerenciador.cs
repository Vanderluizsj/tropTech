using System;

namespace VanderluizProjeto2
{
    public class Gerenciador
    {
        public static void Cadastrar(Cliente cliente)
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
                Console.Write("Informe o Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Informe a Idade: ");
                int idade = Convert.ToInt32(Console.ReadLine());
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

                if (opcaoStr == "1")
                {
                    Console.Write("Informe a CPF: "); 
                    int cpf = Convert.ToInt32(Console.ReadLine());
                    Endereco endereco = new Endereco(rua, bairro, numero, cidade, estado, pais);
                    Cliente cliente = new PessoaFisica(nome, idade, cpf, endereco);
                    cliente.CadastrarCliente(cliente);
                } else if (opcaoStr == "2")
                {
                    Console.Write("Informe a CNPJ: ");
                    int cnpj = Convert.ToInt32(Console.ReadLine());
                    Endereco endereco = new Endereco(rua, bairro, numero, cidade, estado, pais);                      
                    Cliente cliente = new PessoaJuridica(nome, idade, cnpj, endereco);
                    cliente.CadastrarCliente(cliente);
                }              
            }               

        }
        public static void ExibirLista(Cliente cliente){
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
    }
}