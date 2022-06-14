namespace VanderluizProjeto2ComInterface
{
    public class PessoaFisica:Cliente
    {
        private string cpf;

        public string Cpf 
        { 
            get
            {
                return this.cpf;
            }
            set
            {
                this.cpf = value;
            }
        }
            
    }
}