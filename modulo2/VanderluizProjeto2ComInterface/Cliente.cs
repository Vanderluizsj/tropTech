using System;
using System.Collections.Generic;

namespace VanderluizProjeto2ComInterface
{
    public class Cliente
    {
        protected string nome;
        protected string telefone;
        protected  Endereco endereco;
        public static LinkedList<Cliente> listaClientes = new LinkedList<Cliente>();
        

        public string Nome 
        { 
            get
            {
                return this.nome;
            }
            set
            {
                this.nome = value;
            }
        }
        public string Telefone
        { 
            get
            {
                return this.telefone;
            }
            set
            {
                this.telefone = value;
            }
        }
        public Endereco Endereco
        { 
            get
            {
                return this.endereco;
            }
            set
            {
                this.endereco = value;
            }
        }
        public Cliente()
        {
            
        }
        public Cliente(string nome, string telefone, Endereco endereco){
            this.nome = nome;
            this.telefone = telefone;
            this.endereco = endereco;
        }
        public int Quantidade
        {
            get
            {
                return listaClientes.Count;
            }
        }
        public void CadastrarCliente(Cliente cliente)
        {
            listaClientes.AddLast(cliente);
        }   
         
        
        public override  string ToString()
        {
            return "Cliente {" + "nome= " + nome + ", telefone= " + telefone + ", endereço= " + endereco.Completo + '}';
        }

        public void ConsultarClientes()
        {
            foreach (var cliente in listaClientes)
            {
                Console.WriteLine(cliente.ToString());
            }
        }         
        public void ConsultarCliente(string consultaPessoa)
        {
            bool verificacao = false;
            foreach (var pessoa in listaClientes)
            {                               
                if(pessoa.Nome == consultaPessoa)
                {
                    System.Console.WriteLine(pessoa);
                    verificacao = true;
                }                
            }
            if(!verificacao)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Esse nome não esta cadastrado na lista.");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }         
        public void RemoverCliente(string consultaPessoa)
        {
            bool verificacao = false;
            foreach (var pessoa in listaClientes)
            {                               
                if(pessoa.Nome == consultaPessoa)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"{consultaPessoa} estava cadastrado na lista e foi removido.");
                    Console.ForegroundColor = ConsoleColor.White;
                    listaClientes.Remove(pessoa);
                    verificacao = true;
                    break;
                }                 
            
                if(!verificacao)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Esse nome não esta cadastrado na lista.");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
        public static string ConsultarClienteVenda(string consultaPessoa)
        {
            int verificacao = 0;
            string telefoneVenda= "0";
            foreach (var pessoa in listaClientes)
            {                               
                if(pessoa.Nome == consultaPessoa)
                {
                    verificacao = 1;
                    telefoneVenda = pessoa.Telefone;
                }                
            }
            if(verificacao == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Esse nome não esta cadastrado na lista.");
                Console.ForegroundColor = ConsoleColor.White;
            }
            return telefoneVenda;
        }         
        
    }
}