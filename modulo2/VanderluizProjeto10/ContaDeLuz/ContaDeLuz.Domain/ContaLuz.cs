using System;

namespace ContaDeLuz.Domain
{
    public class ContaLuz
    {
        public int NumeroFatura { get; set; }
        public DateTime DataLeitura { get; set; }
        public decimal QuantidadeKw { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataPagamento { get; set; }
        public decimal MediaConsumo { get; set; }
        public bool Cadastrada { get; set; }

        public ContaLuz(int numeroFatura, DateTime dataLeitura, decimal quantidadeKw, decimal valor,  DateTime dataPagamento, decimal mediaConsumo)
        {
            NumeroFatura = numeroFatura;
            DataLeitura = dataLeitura;
            QuantidadeKw = quantidadeKw;
            Valor = valor;
            DataPagamento = dataPagamento;  
            MediaConsumo = mediaConsumo;         
        }

        public ContaLuz()
        {
            
        }

        public override string ToString()
        {
            return $"---------------------------------\n"
                  +$"Numero da fatura = {NumeroFatura}\n"
                  +$"Data da Leitura = {DataLeitura}\n"
                  +$"Quantidade de kw = {QuantidadeKw}\n"
                  +$"Valor = {Valor}\n"
                  +$"Data de Pagamento = {DataPagamento}\n"
                  +$"Media de consumo = {MediaConsumo}\n"
                  +$"--------------------------------\n";
        }
    }
}
