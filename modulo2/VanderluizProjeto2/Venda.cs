using System;
using System.Collections.Generic;

namespace VanderluizProjeto2
{
    public class Venda
    {

        private string descricao;
        private double valorTotal;
        private Cliente cliente;
        public static LinkedList<Venda> vendasClientes = new LinkedList<Venda>();

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

        public int Quantidade
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
            return "Cliente{" + "nome=" + cliente.Nome + ", telefone=" + cliente.Telefone + ", descrição=" + descricao + ", valor total=" + valorTotal +"}";
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