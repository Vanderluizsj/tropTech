namespace ex1
{
    public struct endereco
   {
        public string Rua;
        public string Bairro;
        public int Numero;
        public string Cidade;
        public string Estado;

        public Endereco(string rua, string bairro, int numero, string cidade, string estado){
        this.Rua = rua;
        this.Bairro = bairro;
        this.Numero = numero;
        this.Cidde = cidade;
        this.Estado = estado;
            }    

        public string listagem(){
            return $"{Nome} - {Cidade}";
        }
        
    }
}