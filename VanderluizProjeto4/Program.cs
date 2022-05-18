using System;
using System.Collections;

namespace VanderluizProjeto4
{
    class JogoVelha
    {
        static void Main(string[] args)
        {
            char jogador1;
            char jogador2;
            bool fimJogo;
            Queue filaJogadas = new Queue();            
            int primeiroJogador;
            int quantidadePreenchida;
            fimJogo = false;
            char[,] matriz = new char[3, 3];
            quantidadePreenchida = 0;
            Iniciar();      
            
            void Iniciar(){
                while (!fimJogo)
                {
                    RenderizarTabela();
                    Vez();
                    LerEscolha();
                    RenderizarTabela();
                    //VerificarFim();
                }
            }

            void Vez()
            {
                do
                 {
                    Console.WriteLine("Olá jogador1! Escolha com qual dos dois símbolos abaixo você quer começar: ");
                    Console.WriteLine("1 = X ");
                    Console.WriteLine("2 = O ");
                    string primeiroJogadorS = Console.ReadLine();
                    if (String.IsNullOrEmpty(primeiroJogadorS))
                    {
                        Console.WriteLine($"O numero digitado é invalido! Tente novamente.");
                        primeiroJogador = 0;
                    }
                    primeiroJogador = int.Parse(primeiroJogadorS);                 
                    
                } while (primeiroJogador < 1 || primeiroJogador > 2);           
                
                                
                switch (primeiroJogador)
                {
                    case 1:
                        jogador1 = 'X';
                        jogador2 = 'O';
                        filaJogadas.Enqueue('X');  //1 
                        filaJogadas.Enqueue('O');  //2
                        filaJogadas.Enqueue('X');  //3
                        filaJogadas.Enqueue('O');  //4
                        filaJogadas.Enqueue('X');  //5
                        filaJogadas.Enqueue('O');  //6
                        filaJogadas.Enqueue('X');  //7
                        filaJogadas.Enqueue('O');  //8
                        filaJogadas.Enqueue('X');  //9                 
                        break;
                    case 2:
                        jogador1 = 'O';
                        jogador2 = 'X';
                        filaJogadas.Enqueue('O');  //1
                        filaJogadas.Enqueue('X');  //2
                        filaJogadas.Enqueue('O');  //3
                        filaJogadas.Enqueue('X');  //4
                        filaJogadas.Enqueue('O');  //5
                        filaJogadas.Enqueue('X');  //6
                        filaJogadas.Enqueue('O');  //7
                        filaJogadas.Enqueue('X');  //8
                        filaJogadas.Enqueue('O');  //9
                        break;
                    default:
                        Console.WriteLine("Opção invalida! Escolha uma das 2 opções.");
                        break;
                }
            }
            void LerEscolha(){
                Console.WriteLine($"Agora é a vez de {filaJogadas.Peek()}, entre uma posição de 0,0 a 2,2 que esteja disponível na tabela");

                bool verifica = int.TryParse(Console.ReadLine(), out int posicaoEscolhida);
                while (!verifica || !ValidarEscolha(posicaoEscolhida))
                {
                    Console.WriteLine("O campo escolhido é inválido, por favor digite uma posição que esteja disponível na tabela.");
                    verifica = int.TryParse(Console.ReadLine(), out posicaoEscolhida);
                    //problema ao validar escolha do usuario, não reconhece a entrada
                }
                PreencherEscolha(posicaoEscolhida);
            }

            void PreencherEscolha(int posicaoEscolhida)
            {
                int linha = posicaoEscolhida - 1;
                int coluna = posicaoEscolhida - 1;
                var temp = (char)filaJogadas.Dequeue();
                matriz[linha, coluna] = temp;
                
                quantidadePreenchida++;
            }

            bool ValidarEscolha(int posicaoEscolhida)
            {
                int linha = posicaoEscolhida - 1;
                int coluna = posicaoEscolhida - 1;

                return matriz[linha, coluna] != 'O' && matriz[linha, coluna] != 'X';
            }

           
            void RenderizarTabela()
            {
                Console.Clear();
                Console.WriteLine(ObterTabela());
            }              
            string ObterTabela()
            {
                return $"__{matriz[0, 0]}__|__{matriz[0, 1]}__|__{matriz[0, 2]}__\n" +
                        $"__{matriz[0, 0]}__|__{matriz[0, 1]}__|__{matriz[0, 2]}__\n" +
                        $"  {matriz[0, 0]}  |  {matriz[0, 1]}  |  {matriz[0, 2]}\n\n";
            }
        }
    }
}
