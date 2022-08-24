using System;

namespace MercadoDoZe.Classes
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public long CpfCliente { get; set; }
        public int IdProduto { get; set; }
        public int QtdReservado { get; set; }
        public decimal ValorTotalPedido { get; set; }

        public Pedido()
        {
            
        }

        public override string ToString()
        {
            return $"Id do pedido: {Id}\n Data do pedido: {DataPedido}\n Cpf do cliente: {CpfCliente}\n"
                 + $"Código do produto: {IdProduto}\n Quantidade reservada: {QtdReservado}\n"
                 + $"Valor total do pedido: {ValorTotalPedido}";
        }
    }
}