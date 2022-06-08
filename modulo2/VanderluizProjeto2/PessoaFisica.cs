namespace VanderluizProjeto2
{
    public class PessoaFisica:Cliente
    {
        private int cpf;

        public int Cpf 
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