namespace revisão
{
    public class Pilha
    {
        private string[] _pilha; //è um array, vai os [] e depois o nome com _ começa com 0
        
        public int Quantidade// Get e set é caracteriza uma propriedade Get: retorna alguma coisa set: da-se um valor
        {
            get
            {
                return _pilha.Length; //.Leangth da o tamanho do Array.
            }            
        }
        public string Topo //propriedade sempre precisar ser retornado de alguma maneira para ser imprimido
        {
            get
            {
                if (_pilha.Length < 1) //esse if é caso a fila não tiver nenhum item
                {
                    return string.Empty; //aqui vai retornar que a pilha está vazia
                }
                var topoPilha = _pilha[_pilha.Length-1]; //aqui é para ver o numero item da pilha e vai retornar esse item.
                return topoPilha;

                // return _pilha [_pilha.Length-1];//aqui é para ver o numero item da pilha e vai retornar esse item. de outra forma 
            }
        }
        public Pilha () //contrutor, ele constroi a pilha pra dai ela ser preenchida
        {
            _pilha = new string[0];
        }
        public void Empilhar (string novoItem) 
        //empilhar é o nome do Metodo precisar ser preciso para saber o que faz
        //NovoItem vai receber o que o usuario informou (assinatura)
        {
            var pilhaAtual = _pilha;
            _pilha = new string[_pilha.Length +1];//quando add o novo item, vai aumentar 1 item na pilha
            //_pilha nome, new string dizendo que é um array, [_pilha.length+1] que a pilha é 0 +1. 
            for (int i = 0; i < pilhaAtual.Length; i++)
            {
                _pilha [i] = pilhaAtual [i];
            }       
            _pilha[_pilha.Length-1] = novoItem; //add novo item           
                        
        }
        public string Desempilhar () 
        {
            var pilhaTemporaria = _pilha;
            _pilha = new string [pilhaTemporaria.Length-1];
            return pilhaTemporaria[_pilha.Length];
        }
        public void Limpar ()//é um metodo sem retorno por ser VOID (não precisa ter return)
        {
            _pilha = new string[0];
        }
        public bool Procurar (string nomeInformado) // a procura está em valores Booleanos 
        {
         for (int i = 0; i < _pilha.Length; i++)
         {
             if (nomeInformado == _pilha[i])
             {
                return true;
             }             
         }  
         return false; 
        }   
        
    }
}