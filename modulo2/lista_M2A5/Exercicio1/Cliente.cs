namespace Exercicio1
{
    public class Cliente
    {
        public string Nome { get; set; }

        public int Idade { get; set; }

        public Endereco Endereco { get; set; }

        public Cliente(string nome, int idade, Endereco endereco)
        {
            Nome = nome;
            Idade = idade;
            Endereco = endereco;
        }
    }
}