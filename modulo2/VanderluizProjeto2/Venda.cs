using System;
using System.Collections.Generic;

namespace VanderluizProjeto2
{
    public class Venda
    {
        private string nome;
        private string telefone;
        private string descricao;
        private double valorTotal;
        private Cliente cliente;
        public static LinkedList<Venda> vendasClientes = new LinkedList<Venda>();

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
        public string Descricao 
        { 
            get
            {
                return this.descricao;
            }
            set
            {
                this.descricao = value;
            }
        }
        public double ValorTotal
        { 
            get
            {
                return this.valorTotal;
            }
            set
            {
                this.valorTotal = value;
            }
        }
        public Cliente Cliente
        { 
            get
            {
                return this.cliente;
            }
            set
            {
                this.cliente = value;
            }
        }

        public static int Quantidade
        {
            get
            {
                return vendasClientes.Count;
            }
        }
        
        public void CadastrarVenda(Venda venda)
        {
            vendasClientes.AddLast(venda);
        }
        
        public override string ToString()
        {
            return "Cliente{" + "nome=" + Nome + ", telefone=" + Telefone + ", descrição=" + Descricao + ", valor total=" + ValorTotal +"}";
        }

        public static void ConsultarVendas()
        {
            foreach (var venda in vendasClientes)
            {
                Console.WriteLine(venda.ToString());
            }
        }
                
    }
}