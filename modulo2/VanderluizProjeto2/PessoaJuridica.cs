namespace VanderluizProjeto2
{
    public class PessoaJuridica:Cliente
    {
        private int cnpj;

        public int Cnpj 
        { 
            get
            {
                return this.cnpj;
            }
            set
            {
                this.cnpj = value;
            }
        }

    }
}