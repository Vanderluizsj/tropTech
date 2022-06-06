namespace VanderluizProjeto2
{
    public class PessoaJuridica:Cliente
    {
        private int CNPJ { get; set; }

        public PessoaJuridica(int cnpj) 
        {
            this.CNPJ = cnpj;               
        }
    }
}