namespace VanderluizProjeto2
{
    public class Cliente
    {
        private string Nome{ get; set; }
        private string Telefone{ get; set; }
        private  Endereco Endereco{ get; set; }
        LinkedList<Cliente> listaClientes = new LinkedList<Cliente>();

        public Cliente(string nome, string telefone, Endereco endereco){
            this.Nome = nome;
            this.Telefone = telefone;
            this.Endereco = endereco;
        }
        public int Quantidade
        {
            get
            {
                return listaClientes.Length;
            }
        }
        public void CadastrarCliente(Cliente cliente)
        {
            listaClientes.AddLast(cliente);
        }   
         
        @Override 
        public String toString()
        {
            return "Cliente{" + "nome=" + nome + ", telefone=" + telefone + ", endereço=" + endereco + '}';
        }

        public void ConsultarClientes()
        {
            foreach (var cliente in listaClientes)
            {
                Console.WriteLine(cliente.toString());
            }
        }         
        public void ConsultarCliente(string consultaPessoa)
        {
            var verificacao = 0;
            foreach (var pessoa in listaClientes)
            {                               
                verificacao = pessoa == consultaPessoa? 1 : 0;                
            }
            if(verificacao>0)
            {
                Console.WriteLine($"Esse nome esta cadastrado na lista.");
                Console.WriteLine(pessoa.toString());
            } else
            {
                Console.WriteLine($"Esse nome não esta cadastrado na lista.");
            }
        }         
        public void RemoverCliente(string consultaPessoa)
        {
            var verificacao = 0;
            foreach (var pessoa in listaClientes)
            {                               
                verificacao = pessoa == consultaPessoa? 1 : 0;                
            
                if(verificacao>0)
                {
                    Console.WriteLine($"{consultaPessoa} estava cadastrado na lista e foi removido.");
                    listaClientes.Remove(consultaPessoa);
                    
                } else
                {
                    Console.WriteLine($"Esse nome não esta cadastrado na lista.");
                }
            }
        }         
        
    }
}