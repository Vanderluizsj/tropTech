using System;

namespace MercadoDoZe.Classes
{
    public class Produto    
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime Vencimento { get; set; }
        public float Preco { get; set; }
        public string Unidade { get; set; }
        public int QuantidadeEstoque { get; set; }

        public Produto()
        {
            
        }
        public override string ToString()
        {
            return $" Id:{Id}\n Nome: {Nome}\n Descrição: {Descricao}\n Preço unitário:{Preco}\n"
                  +$" Unidade: {Unidade}\n Data Vencimento: {Vencimento.ToShortDateString()}\n"
                  +$" Quantidade no estoque: {QuantidadeEstoque}";
        }

        public void EntradaEstoque(int quantidade)
        {
            QuantidadeEstoque += quantidade;
        }

        public void SaidaEstoque(int quantidade)
        {
            QuantidadeEstoque -= quantidade;
        }
    }
}
