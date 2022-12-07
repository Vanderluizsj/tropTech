using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SerraLinhasAereas.Domain
{
    public class Cliente
    {        
        public long Cpf { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string NomeCompleto { get; set; }
        public Endereco endereco { get; set; }
        public Cliente(long cpf, string nome, string sobrenome, string nomeCompleto, Endereco endereco)
        {
            Cpf = cpf;
            Nome = nome;
            Sobrenome = sobrenome;
            NomeCompleto = nomeCompleto;
            this.endereco = endereco;
        }
        public Cliente()
        {
            
        }
        public override  string ToString()
        {
            return "Cliente {" + "Cpf= " + Cpf + "nome= " + NomeCompleto + ", endereço= " + endereco.Completo + '}';
        }  
        
    }
}