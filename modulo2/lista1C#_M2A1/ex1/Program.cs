using System;
using System.Collections.Generic;

namespace Agenda
{
    class Program
    {
        static void Main(string[] args)
        {
            var contatos = new ItemDaAgenda[5];

            for (int i = 0; i < 2; i++)
            {
                ItemDaAgenda novocontato;

                Console.Write("Digite o nome: ");
                var nome = Console.ReadLine();

                Console.Write("Digite o telefone: ");
                var telefone = Console.ReadLine();

                Console.Write("Digite o endereço: ");
                var endereco = Console.ReadLine();

                Console.Write("Digite a profissão: ");
                var profissao = Console.ReadLine();

                if (String.IsNullOrEmpty(profissao) && String.IsNullOrEmpty(endereco))
                {
                    novocontato = new ItemDaAgenda(nome, telefone);
                }               
                else
                {
                    novocontato = new ItemDaAgenda(nome, telefone, endereco, profissao);
                }

                contatos[i] = novocontato;
            }

            for (int i = 0; i < ItemDaAgenda.QuantidadeDecontatosNaAgenda; i++)
            {
                var contato = contatos[i];
                Console.WriteLine($"{contato.Nome}, Tel. {contato.Telefone}, End. {contato.Endereco}, Profissão {contato.Profissao}");
            }

            Console.ReadKey();
        }
    }
}
