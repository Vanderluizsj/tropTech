namespace VanderluizProjeto2ComInterface
{
    public struct Endereco
    {
        private string Rua;
        private int Numero;
        private string Bairro;
        private string Cidade;
        private string Estado;
        private string Pais;

   
        public Endereco(string rua, int numero, string bairro, string cidade, string estado, string pais)
        {
            this.Rua = rua;
            this.Numero = numero;
            this.Bairro = bairro;
            this.Cidade = cidade;
            this.Estado = estado;
            this.Pais = pais;
        }

        public string Completo
        {
            get
            {
                return $"Rua " + Rua + ", " + Numero + ", " + Cidade + "/" + Estado + " - " + Pais;
            }
        }
         
    } 
}