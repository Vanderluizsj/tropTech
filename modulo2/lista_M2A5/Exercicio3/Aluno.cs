namespace Exercicio3
{
    public class Aluno
    {
        public string Nome { get; set; }

        public int Idade { get; set; }

        public string Turma { get; set; }

        public Endereco Endereco { get; set; }

        public Aluno(string nome, int idade, string turma, Endereco endereco)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Turma = turma;
            this.Endereco = endereco;
        }

        public string ImprimirInformacoes(){
            return $"{Nome} - {Turma} - {Endereco.Cep}";
        }
    }
}