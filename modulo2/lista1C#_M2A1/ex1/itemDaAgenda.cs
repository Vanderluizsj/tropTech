namespace ex1
{
    public class ItemDaAgenda
    {
        public static int quantidadeItens;
        public string nome;
        public string telefone;
        public string endereco;
        public string profissao;
        
        public itemDaAgenda(string nome, string telefone){
            nome = this.nome;
            telefone = this.telefone;

            quantidadeItens++;
        }

        public itemDaAgenda(string nome, string telefone, string endereco, string profissao){
            nome = this.nome;
            telefone = this.telefone;
            endereco = this.endereco;
            profissao = this.profissao;

            quantidadeItens++;
        }

        
    }
}