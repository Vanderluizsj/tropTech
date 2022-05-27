using System;

namespace Agenda
{
    class Program
    {
        static void Main(string[] args)
        {
            var itens = new ItemDaAgenda[];

            for (int i = 0; i < 2; i++)
            {
                ItemDaAgenda novoItem;

                Console.Write("Nome: ");
                var nome = Console.ReadLine();

                Console.Write("Telefone: ");
                var telefone = Console.ReadLine();

                Console.Write("Endereço: ");
                var endereco = Console.ReadLine();

                Console.Write("Profissão: ");
                var profissao = Console.ReadLine();

                if (IsNullOrEmpty(profissao) && IsNullOrEmpty(endereco))
                {
                    novoItem = new ItemDaAgenda(nome, telefone);
                }
            }
        }
    }
}
