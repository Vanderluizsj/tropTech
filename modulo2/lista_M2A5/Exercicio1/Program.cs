using System;
using System.Collections.Generic;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao = string.Empty;

            LinkedList<Cliente> listaClientes = new LinkedList<Cliente>();

            do
            {
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("----    Cadastro de Clientes!   -----");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Escolha um opção para continuar:");
                Console.WriteLine("[1] - Cadastrar Cliente");
                Console.WriteLine("[2] - Listar Clientes");
                Console.WriteLine("[3] - Sair");
                Console.WriteLine("-------------------------------------");
                
                opcao = Console.ReadLine();
                opcao = String.IsNullOrEmpty(opcao)? "0" : opcao;

                if (opcao == "1")
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

                    Endereco endereco = new Endereco(rua, bairro, numero, cidade, estado);
                    Cliente cliente = new Cliente(nome, idade, endereco);

                    listaClientes.AddLast(cliente);

                    Console.WriteLine("Cliente cadastrado com sucesso.");
                }
                else if (opcao == "2")
                {
                    Console.WriteLine("Lista de clientes:");

                    foreach (var cliente in listaClientes)
                    {
                        Console.WriteLine($"{cliente.Nome} - {cliente.Endereco.Cidade}");
                    }
                }
            } while (opcao != "3");
        }
    }
}
