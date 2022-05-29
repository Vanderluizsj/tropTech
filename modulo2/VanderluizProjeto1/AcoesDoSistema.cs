using System;

namespace VanderluizProjeto1
{
    public class AcoesDoSistema
    {
        public static int opcao = 0;
        public static void Enfileirar(Fila fila)
        {
            do
            {
                Console.WriteLine("Informe o Nome para ser Emfileirado");
                string nomeInserido = Console.ReadLine();

                if (String.IsNullOrEmpty(nomeInserido))
                {
                    Console.WriteLine("Valor Invalido, tente denovo");
                    opcao = 0;
                }else
                {
                   opcao = 1;          
                   fila.Enfileirar(nomeInserido);
                   Console.WriteLine($"{nomeInserido} foi adicionado a fila. Agora tem {fila.Quantidade} na fila");                
                }
            } while (opcao<1);
        } 
        public static void Desenfileirar (Fila fila)
        {
            if (fila.Quantidade == 0) //Rever
            {
                Console.WriteLine("A pilha está vazia.");
                return;
            }
            
            fila.Desenfileirar();  
            Console.WriteLine($"Agora tem {fila.Quantidade} na fila.");
                      
        }
        public static void Primeiro (Fila fila) //chamando propriedade
        {
            if (fila.Quantidade == 0)
            {
                Console.WriteLine("A fila está vazia!!!");
            }
            fila.Primeiro();
        }
        public static void Limpar(Fila fila) //chamando metodos
        {
            fila.Limpar();
            Console.WriteLine($"Agora tem {fila.Quantidade} na pilha.");  
        }
        public static void Procurar (Fila fila)
        {
            do
            {
                Console.WriteLine("Informe o Nome que deseja consultar na fila");
                string nomeConsulta = Console.ReadLine();

                if (nomeConsulta == string.Empty)
                {
                    Console.WriteLine("Valor Invalido, tente denovo");
                    opcao = 0;
                }else
                {
                    opcao = 1;          
                    fila.BuscaIguais(nomeConsulta);                     
                }
            } while (opcao<1);
            /*Console.WriteLine("Qual nome deseja buscar na Lista?");
            string nomeInformado = Console.ReadLine();
            var encontrou = stack.Procurar(nomeInformado);
            if (encontrou)
            {
                Console.WriteLine($"Nome encontrando {encontrou}");
            }
            else
            {
                Console.WriteLine($"Nome não encontrando {nomeInformado}");
            }*/
        }
    }
}