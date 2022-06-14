namespace VanderluizProjeto2ComInterface
{
    public class PessoaJuridica:Cliente
    {
        private string cnpj;

        public string Cnpj 
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