using System;

namespace MercadoDoZe.Classes
{
    public class Cliente    
    {
        //CPF, Nome, Data de nascimento, Pontos de fidelidade caso tenha e cada cliente deve ter um endereço
        public long Cpf { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public int PontosFidelidade { get; set; }
        public Endereco Endereco { get; set; }
        

        public Cliente()
        {
            Endereco = new Endereco(); 
        }
        public override string ToString()
        {
            return $" Cpf:{Cpf}\n Nome: {Nome}\n Nascimento: {DataNascimento.ToShortDateString()}\n"
                  +$" Pontos de Fidelidade: {PontosFidelidade} \n {Endereco.Completo}";
        }

        
    }
}
