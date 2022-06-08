using System;

namespace VanderluizProjeto1
{
    public class Fila
    {
        private string[] _fila;
        int quantidade = 0;
        
         public Fila () //contrutor, ele constroi a fila pra dai ela ser preenchida
        {
            _fila = new string[0];
        }
        public void Enfileirar(string novoItem)
        {
                var filaAtual = _fila;
                _fila = new string[_fila.Length +1];//quando add o novo item, vai aumentar 1 item na fila
                //_fila nome, new string dizendo que é um array, [_fila.length+1] que a fila é 0 +1. 
                for (int i = 0; i < filaAtual.Length; i++)
                {
                    _fila [i] = filaAtual [i];
                }       
                _fila[_fila.Length-1] = novoItem; //add novo item  
                quantidade++;                 
           
        }
        public int Quantidade
        {
            get
            {
                return _fila.Length;
            }
        }
        public void Desenfileirar(){
            if (_fila.Length>0)
            {
                var saindoFila = _fila[0];
                string[] temp = new string[_fila.Length-1];
                for (int i = 0; i < temp.Length; i++)
                {
                    temp[i]=_fila[i+1];
                }
                quantidade--;
                
                _fila = temp;
                Console.WriteLine($"{saindoFila} foi retirdo da fila.");
            } else
            {
                Console.WriteLine("Fila vazia!");
            }
        }

        public void Primeiro(){
            if (_fila.Length>0)
            {
                Console.WriteLine($"O primeiro nome na fila é: {_fila[0]}");
            } else
            {
                Console.WriteLine("Fila vazia!");
            }
            
        }

        public void Limpar(){
            _fila = new string[0];
        }

        public void BuscaIguais(string consultaPessoa)
        {

            var verificacao = 0;
            foreach (var pessoa in _fila)
            {                               
                verificacao = pessoa == consultaPessoa? 1 : 0;                
            }
            if(verificacao>0)
            {
                Console.WriteLine($"Esse nome já foi cadastrado na fila.");
            } else
            {
                Console.WriteLine($"Esse nome não foi cadastrado na fila.");
            }
        }

    }
}