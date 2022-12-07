using System;
using System.Collections.Generic;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao = string.Empty;

            LinkedList<Aluno> listaAlunos = new LinkedList<Aluno>();
            LinkedList<Professor> listaProfessores = new LinkedList<Professor>();

            do
            {
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("- Cadastro de Alunos e Professores! -");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Escolha um opção para continuar:");
                Console.WriteLine("[1] - Cadastrar Aluno");
                Console.WriteLine("[2] - Cadastrar Professor");
                Console.WriteLine("[3] - Listar Alunos e Professores");
                Console.WriteLine("[4] - Sair");
                Console.WriteLine("-------------------------------------");

                opcao = Console.ReadLine();
                opcao = String.IsNullOrEmpty(opcao)? "0" : opcao;
                if (opcao == "1")
                {
                    Console.Write("Informe o Nome: ");
                    string nome = Console.ReadLine();

                    Console.Write("Informe a Idade: ");
                    int idade = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Informe o Turma: ");
                    string turma = Console.ReadLine();

                    Console.Write("Informe o CEP: ");
                    string cep = Console.ReadLine();

                    Console.Write("Informe o Número: ");
                    int numero = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Informe o Complemento: ");
                    string complemento = Console.ReadLine();

                    Endereco endereco = new Endereco(cep, numero, complemento);
                    Aluno aluno = new Aluno(nome, idade, turma, endereco);

                    listaAlunos.AddLast(aluno);

                    Console.WriteLine("Aluno cadastrado com sucesso.");
                }
                else if (opcao == "2")
                {
                    Console.Write("Informe o Nome: ");
                    string nome = Console.ReadLine();

                    Console.Write("Informe a Matéria: ");
                    string materia = Console.ReadLine();

                    Console.Write("Informe o CPF: ");
                    string cpf = Console.ReadLine();

                    Console.Write("Informe o CEP: ");
                    string cep = Console.ReadLine();

                    Console.Write("Informe o Número: ");
                    int numero = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Informe o Complemento: ");
                    string complemento = Console.ReadLine();

                    Endereco endereco = new Endereco(cep, numero, complemento);
                    Professor professor = new Professor(nome, materia, cpf, endereco);

                    listaProfessores.AddLast(professor);

                    Console.WriteLine("Professor cadastrado com sucesso.");
                }
                else if (opcao == "3")
                {
                    Console.WriteLine("Lista de Alunos cadastrados:");
                    foreach (var aluno in listaAlunos)
                    {
                        Console.WriteLine(aluno.ImprimirInformacoes());
                    }

                    Console.WriteLine("Lista de Professores cadastrados:");
                    foreach (var professor in listaProfessores)
                    {
                        Console.WriteLine(professor.ImprimirInformacoes());
                    }
                }

            } while (opcao != "4");
        }
    }
}
