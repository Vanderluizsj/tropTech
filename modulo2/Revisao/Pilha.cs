namespace Revisao
{
    public class Pilha
    {
        private string[] _pilha; // array, vai os [] e o nome com _

        public int Quantidade  //Get: retorna algo e Set: recebe algo
        {
            get
            {
                return _pilha.Length; // .Length da o tamanho do array
            }
        }
        public string Topo  //Get: retorna algo e Set: recebe algo
        {
            get
            {
                if (_pilha.Length < 1)
                {
                    return string.Empty;  //retorna se estiver vazia
                } else
                {
                   var topoPilha = _pilha[_pilha.Length-1];
                   return topoPilha;

                   //ou return _pilha [_pilha.Lenght-1]; 
                }
                
            }
        }

        public void Empilhar()
        {
            //empilhar é o método a ser desenvolvido
            //NovoItem vai receber o que o usuario informou (ass)

            _pilha = new string[_pilha.Lenght+1];  //quando add o novo item, vai aumentar um item na pilha
        //

            _pilha[_pilha.Lenght-1] = novoItem;  //add novo item
          
        }
        public void Desempilhar()
        {


        }
        public void Limpar()
        {


        }
        public void Procurar()
        {


        }
    }
}