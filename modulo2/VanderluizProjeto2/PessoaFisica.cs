namespace VanderluizProjeto2
{
    public class PessoaFisica:Cliente
    {
        private int CPF { get; set; }
        public PessoaFisica(int cpf) 
        {
            this.CPF = cpf;               
        }
        
                
    }
}