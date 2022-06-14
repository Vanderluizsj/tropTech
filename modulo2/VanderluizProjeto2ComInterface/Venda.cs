using System;
using System.Collections.Generic;

namespace VanderluizProjeto2ComInterface
{
    public class Venda
    {
        private string nome;
        private string telefone;
        private string descricao;
        private double valorTotal;
        private Cliente cliente;
        
        public static LinkedList<Venda> vendasClientesPf = new LinkedList<Venda>();
        public static LinkedList<Venda> vendasClientesPj = new LinkedList<Venda>();

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
                return vendasClientesPf.Count + vendasClientesPj.Count;
            }
        }
        
        public void CadastrarVendaPf(Venda venda)
        {
            vendasClientesPf.AddLast(venda);
        }
        public void CadastrarVendaPj(Venda venda)
        {
            vendasClientesPj.AddLast(venda);
        }
        
        public override string ToString()
        {
            return "Cliente{" + "nome=" + Nome + ", telefone=" + Telefone + ", descrição=" + Descricao + ", valor total=" + ValorTotal +"}";
        }

        public static void ConsultarVendasPf()
        {
            foreach (var venda in vendasClientesPf)
            {
                Console.WriteLine(venda.ToString());
            }
        }
        public static void ConsultarVendasPj()
        {
            foreach (var venda in vendasClientesPj)
            {
                Console.WriteLine(venda.ToString());
            }
        }
                
    }
}