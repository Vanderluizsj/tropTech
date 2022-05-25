using System;
using System.Collections;
using System.Globalization;
using System.Threading;

namespace VanderluizProjeto4
{
    class JogoVelha
    {
        static void Main(string[] args)
        {
            
            bool fimJogo;
            Queue filaJogadas = new Queue();            
            int primeiroJogador;
            int quantidadePreenchida;
            fimJogo = false;
            char[,] matriz = new char[3, 3];
            quantidadePreenchida = 0;
            DateTime data;
            
            Vez();
            Iniciar();     
            
            void Iniciar(){
                while (!fimJogo)
                {
                    RenderizarTabela();                    
                    LerEscolha();
                    RenderizarTabela();
                    Fim();
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
                int controleLocal;
                int linhaEscolhida, colunaEscolhida;
                do
                {
                    controleLocal = 1;
                    Console.Write("Digite a linha: ");
                    string linha = Console.ReadLine();
                    Console.Write("Digite a coluna: ");
                    string coluna = Console.ReadLine();
                    if (String.IsNullOrEmpty(linha))
                    {
                        controleLocal = 0;
                        Console.WriteLine("O campo escolhido é inválido, por favor digite uma posição que esteja disponível na tabela.");   
                    }
                    if (String.IsNullOrEmpty(coluna))
                    {
                        controleLocal = 0;
                        Console.WriteLine("O campo escolhido é inválido, por favor digite uma posição que esteja disponível na tabela.");   
                    }
                
                linhaEscolhida = int.Parse(linha);
                colunaEscolhida = int.Parse(coluna);
                    
                } while (controleLocal < 1 || !ValidarEscolha(linhaEscolhida, colunaEscolhida));
                

                PreencherEscolha(linhaEscolhida, colunaEscolhida);
            }

            void PreencherEscolha(int linha, int coluna)
            {
                
                var temp = (char)filaJogadas.Dequeue();
                matriz[linha, coluna] = temp;
                
                quantidadePreenchida++;
            }

            bool ValidarEscolha(int linha, int coluna)
            {
                //if (matriz[linha, coluna] == 'O' && matriz[linha, coluna] == 'X')
                //{
                //    Console.WriteLine("O campo escolhido é inválido, por favor digite uma posição que esteja disponível na tabela.");
                //}
                return matriz[linha, coluna] != 'O' && matriz[linha, coluna] != 'X';
                
            }

           
            void RenderizarTabela()
            {
                Console.Clear();
                Console.WriteLine(ObterTabela());
                data = DateTime.Now;
                Console.WriteLine("Horário da jogada: " + data.ToString("HH:mm:ss"));
            }              
            string ObterTabela()
            {
                return $"__{matriz[0, 0]}__|__{matriz[0, 1]}__|__{matriz[0, 2]}__\n" +
                        $"__{matriz[1, 0]}__|__{matriz[1, 1]}__|__{matriz[1, 2]}__\n" +
                        $"  {matriz[2, 0]}  |  {matriz[2, 1]}  |  {matriz[2, 2]}\n\n";
            }
            void Fim()
            {
                if (quantidadePreenchida < 5)
                    return;

                if (ExisteVitoriaHorizontal() || ExisteVitoriaVertical() || ExisteVitoriaDiagonal())
                {
                    fimJogo = true;
                    Console.WriteLine($"Fim de jogo!!! Parabens pela vitória!");
                    return;
                }

                if (quantidadePreenchida is 9)
                {
                    fimJogo = true;
                    Console.WriteLine("Fim de jogo!!! EMPATE");
                }
            }

            bool ExisteVitoriaHorizontal()
            {
                bool vitoriaLinha1 = matriz[0, 0] == matriz[0, 1] && matriz[0, 1] == matriz[0, 2];
                bool vitoriaLinha2 = matriz[1, 0] == matriz[1, 1] && matriz[1, 1] == matriz[1, 2];
                bool vitoriaLinha3 = matriz[2, 0] == matriz[2, 1] && matriz[2, 1] == matriz[2, 2];

                return vitoriaLinha1 || vitoriaLinha2 || vitoriaLinha3;
            }

            bool ExisteVitoriaVertical()
            {
                bool vitoriaLinha1 = matriz[0, 0] == matriz[1, 0] && matriz[1, 0] == matriz[2, 0];
                bool vitoriaLinha2 = matriz[0, 1] == matriz[1, 1] && matriz[1, 1] == matriz[2, 1];
                bool vitoriaLinha3 = matriz[0, 2] == matriz[1, 2] && matriz[1, 2] == matriz[2, 2];

                return vitoriaLinha1 || vitoriaLinha2 || vitoriaLinha3;
            }

            bool ExisteVitoriaDiagonal()
            {
                bool vitoriaLinha1 = matriz[0, 0] == matriz[1, 1] && matriz[1, 1] == matriz[2, 2];
                bool vitoriaLinha2 = matriz[0, 2] == matriz[1, 1] && matriz[1, 1] == matriz[2, 0];

                return vitoriaLinha1 || vitoriaLinha2;
            }
        }
    }
}
