namespace Exercicio3
{
    public class Professor
    {
        public string Nome { get; set; }

        public string Materia { get; set; }

        public string Cpf { get; set; }

        public Endereco Endereco { get; set; }

        public Professor(string nome, string materia, string cpf, Endereco endereco)
        {
            this.Nome = nome;
            this.Materia = materia;
            this.Cpf = cpf;
            this.Endereco = endereco;
        }

        public string ImprimirInformacoes(){
            return $"{Nome} - {Materia} - {Endereco.Cep}";
        }
    }
}