using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SerraLinhasAereas.Domain
{
    public class Viagem
    {
        public string CodigoReserva { get; set; }
        public bool IdaVolta { get; set; }
        public DateTime DataCompra { get; set; }
        public double ValorTotal { get; set; }
        public bool PassagemIda { get; set; }
        public bool PassagemVolta { get; set; }
        public Cliente Cliente { get; set; }
        public Viagem(string codigoReserva, bool idaVolta, DateTime dataCompra, double valorTotal, bool passagemIda, bool passagemVolta, Cliente cliente)
        {
            CodigoReserva = codigoReserva;
            IdaVolta = idaVolta;
            DataCompra = dataCompra;
            ValorTotal = valorTotal;
            PassagemIda = passagemIda;
            PassagemVolta = passagemVolta;
            Cliente = cliente;
        }
        public Viagem()
        {
            
        }
        public void CalculaValor(){

        }
         
    }
}