namespace Agenda2
{
    public class contatoDaAgenda
    {
        public static int QuantidadeDecontatosNaAgenda;
        public string Nome;
        public string Telefone;
        public string Endereco;
        public string Profissao;

        public contatoDaAgenda(string nome, string telefone)
        {
            Nome = nome;
            Telefone = telefone;

            QuantidadeDecontatosNaAgenda++;
        }

        public contatoDaAgenda(string nome, string telefone, string endereco, string profissao) : this(nome, telefone)
        {
            Nome = nome;
            Telefone = telefone;
            Endereco = endereco;
            Profissao = profissao;

            QuantidadeDecontatosNaAgenda++;
        }
    }
}