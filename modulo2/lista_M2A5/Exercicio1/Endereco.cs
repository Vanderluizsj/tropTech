namespace Exercicio1
{
    public struct Endereco
    {
        public string Rua;

        public string Bairro;
        
        public int Numero;

        public string Cidade;

        public string Estado;

        public Endereco(string rua, string bairro, int numero, string cidade, string estado)
        {
            Rua = rua;
            Bairro = bairro;
            Numero = numero;
            Cidade = cidade;
            stado = estado;
        }
    }
}