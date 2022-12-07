using System;
using System.Collections.Generic;

namespace Agenda2
{
    class Program
    {
        static void Main(string[] args)
        {
            var contatos = new LinkedList<contatoDaAgenda>();

            string resposta;

            do
            {
                contatoDaAgenda novocontato;

                Console.Write("Digite o nome: ");
                var nome = Console.ReadLine();

                Console.Write("Digite o telefone: ");
                var telefone = Console.ReadLine();

                Console.Write("Digite o endereço: ");
                var endereco = Console.ReadLine();

                Console.Write("Digite a profissão: ");
                var profissao = Console.ReadLine();
                
                novocontato = new contatoDaAgenda(nome, telefone);
                novocontato.Endereco = endereco;
                novocontato.Profissao = profissao;

                contatos.AddLast(novocontato);

                Console.Write("\n\n");

                Console.WriteLine($"Já foram cadastrados {contatoDaAgenda.QuantidadeDecontatosNaAgenda} contatos.");

                Console.Write("\n\n");

                Console.WriteLine("Gostaria de cadastrar mais um contato? [S/N]");
                System.Console.WriteLine("[1] Para SIM" );
                System.Console.WriteLine("[2] Para NÃO");
                resposta = Console.ReadLine();
                if (String.IsNullOrEmpty(resposta))
                {
                    resposta = "2";
                }
                Console.Clear();

            } while (resposta == "1");

            for (var node = contatos.First; node != null; node = node.Next)
            {
                var contato = node.Value;
                Console.WriteLine($"{contato.Nome}, Tel. {contato.Telefone}, End. {contato.Endereco}, Profissão {contato.Profissao}");
            }

            Console.ReadKey();
        }
    }
}
