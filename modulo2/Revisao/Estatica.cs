using System;

namespace revisão
{
    public static class Estatica //a classe é static
    {
        public static void Empilhar (Pilha stack) //metodo para empilhar os nomes que seram colocados
        {
            Console.WriteLine("Informe o Nome para ser Empilhado");
            string nomeInserido = Console.ReadLine();

            if (nomeInserido == string.Empty)
            {
                Console.WriteLine("Valor Invalido, tente denovo");
            }
            stack.Empilhar(nomeInserido);
            Console.WriteLine($"Agora tem {stack.Quantidade} na pilha");
        }
        public static void Desempilhar (Pilha stack)
        {
            if (stack.Quantidade == 0)
            {
                Console.WriteLine("A pilha está vazia.");
                return;
            }
            string itemDe = stack.Desempilhar();
            Console.WriteLine($"O item que saiu da pilha é{itemDe}");
            Console.WriteLine($"Agora tem {stack.Quantidade} na pilha.");            
        }
        public static void Limpar(Pilha stack) //chamando metodos
        {
            stack.Limpar();
            Console.WriteLine($"Agora tem {stack.Quantidade} na pilha.");  
        }
        public static void Topo (Pilha stack) //chamando propriedade
        {
            if (stack.Quantidade == 0)
            {
                Console.WriteLine("A pilha está vazia!!!");
            }
            Console.WriteLine(stack.Topo); 
        }
        public static void Procurar (Pilha stack)
        {
            Console.WriteLine("Qual nome deseja buscar na Lista?");
            string nomeInformado = Console.ReadLine();
            var encontrou = stack.Procurar(nomeInformado);
            if (encontrou)
            {
                Console.WriteLine($"Nome encontrando {encontrou}");
            }
            else
            {
                Console.WriteLine($"Nome não encontrando {nomeInformado}");
            }
        }
    }
}