namespace Exercicio3
{
    public struct Endereco
    {
        public string Cep;

        public int Numero;

        public string Complemento;

        public Endereco(string cep, int numero, string complemento)
        {
            this.Cep = cep;
            this.Numero = numero;
            this.Complemento = complemento;
        }
    }
}