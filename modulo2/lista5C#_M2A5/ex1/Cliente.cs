namespace ex1
{
    public class Cliente
    {
        public CadastrarCliente Cadastro {get; set;}
        public string Nome;
        public int Idade;

        public Cliente(CadastrarCliente  cadastro, string nome, int idade){
            this.Cadastro = cadastro;
            this.Nome = nome;
            this.Idade = idade;
        }

    }
}