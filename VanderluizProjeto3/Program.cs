using System;

namespace VanderluizProjeto3
{
    class Program
    {
        static void Main(string[] args)
        {
        var usuario = "Luiz";
		var senha = 1234;
		var controleLogin = 0;
		var controleSenha = 0;
		var tentativas = 3;
		
        //-----------------------TELA DE LOGIN-----------------------------------------
		do{
            Console.ForegroundColor = ConsoleColor.DarkGreen;     //Muda cor para verde
            Console.WriteLine("---------LOGIN---------");
            Console.ForegroundColor = ConsoleColor.White;     //Muda cor para branco
            Console.Write("Digite o seu login: ");
            var usuarioTentativa = Console.ReadLine();
            Console.Write("Digite a sua senha: ");
            var senhaTentativa = int.Parse(Console.ReadLine());
            controleSenha = senha == senhaTentativa ? 1 :  0;
            controleLogin = usuario == usuarioTentativa ? 1 :  0; 
            tentativas--;
            Console.ForegroundColor = ConsoleColor.Red;     //Muda cor para vermelho
            if(controleLogin == 0 && controleSenha == 0){                
                Console.WriteLine("Login e Senha invalidos!");                
            }else if(controleLogin == 0){
                Console.WriteLine("Login invalido!");                
            } else if(controleSenha == 0){
                Console.WriteLine("Senha invalido!");
            }
            if(tentativas == 0){
                Console.WriteLine("Numero de tentativas excedido!");
                Environment.Exit(0);
            }
            Console.ForegroundColor = ConsoleColor.White;       //Devolve para a cor branca
		}while(controleSenha < 1 && controleLogin < 1);

        //--------------------------MENU CALCULADORA----------------------------------------
        do
        {        
            Console.WriteLine("-------------------------------------");
            Console.WriteLine($"Usuário: {usuario}");
            Console.WriteLine("----------------MENU-----------------");
            Console.WriteLine("Escolha alguma das opções abaixo: ");
            Console.WriteLine("[1] + SOMA");
            Console.WriteLine("[2] - SUBTRACAO");
            Console.WriteLine("[3] / DIVISAO");
            Console.WriteLine("[4] * MULTIPLICACAO");
            Console.WriteLine("[5] * SAIR");
            Console.WriteLine("--------------------------------------");
            var operacao = int.Parse(Console.ReadLine());
            //------------------------SUBMENUS CALCULADORA----------------------------------
            switch (operacao)
            {
                case 1:     // --------------------------- OPERAÇÃO DE + --------------------
                    do
                    {
                        Console.WriteLine("--------------------------------------");
                        Console.WriteLine($"Usuário: {usuario}");
                        Console.WriteLine("---------------OPERAÇÃO + -----------------");
                        Console.WriteLine("Escolha alguma das opções abaixo: ");
                        Console.WriteLine("[1] REFAZER OPERAÇÃO");
                        Console.WriteLine("[2] VOLTAR PARA MENU ANTERIOR");
                        Console.WriteLine("--------------------------------------");
                        var opcao = int.Parse(Console.ReadLine());
                        switch (opcao)
                        {
                            case 1:
                                Console.Write("Digite o primeiro numero: ");
                                var n1 = Double.Parse(Console.ReadLine());
                                Console.Write("Digite o segundo numero: ");
                                var n2 = Double.Parse(Console.ReadLine());
                                Console.WriteLine($"{n1} + {n2} = {n1+n2}");
                                break;
                            case 2:
                                operacao = 0;
                                break;
                            default:
                                Console.WriteLine("Opção invalida! Selecione uma das 2 opções.");
                                break;
                        }
                    } while (opcao>2 && opcao<1);                  
                case 2:     // ------------------------------ OPERAÇÃO DE - ---------------------------
                    do
                    {
                        Console.WriteLine("--------------------------------------");
                        Console.WriteLine($"Usuário: {usuario}");
                        Console.WriteLine("---------------OPERAÇÃO - --------------");
                        Console.WriteLine("Escolha alguma das opções abaixo: ");
                        Console.WriteLine("[1] REFAZER OPERAÇÃO");
                        Console.WriteLine("[2] VOLTAR PARA MENU ANTERIOR");
                        Console.WriteLine("--------------------------------------");
                        var opcao = int.Parse(Console.ReadLine());
                        switch (opcao)
                        {
                            case 1:
                                Console.Write("Digite o primeiro numero: ");
                                var n1 = Double.Parse(Console.ReadLine());
                                Console.Write("Digite o segundo numero: ");
                                var n2 = Double.Parse(Console.ReadLine());
                                Console.WriteLine($"{n1} - {n2} = {n1-n2}");
                                break;
                            case 2:
                                operacao = 0;
                                break;
                            default:
                                Console.WriteLine("Opção invalida! Selecione uma das 2 opções.");
                                break;
                        }
                    } while (opcao>2 && opcao<1);                  
                case 3:  //----------------- OPERAÇÃO DE / -------------------------------------------
                    do
                    {
                        Console.WriteLine("--------------------------------------");
                        Console.WriteLine($"Usuário: {usuario}");
                        Console.WriteLine("---------------OPERAÇÃO / --------------");
                        Console.WriteLine("Escolha alguma das opções abaixo: ");
                        Console.WriteLine("[1] REFAZER OPERAÇÃO");
                        Console.WriteLine("[2] VOLTAR PARA MENU ANTERIOR");
                        Console.WriteLine("--------------------------------------");
                        var opcao = int.Parse(Console.ReadLine());
                        switch (opcao)
                        {
                            case 1:
                                Console.Write("Digite o primeiro numero: ");
                                var n1 = Double.Parse(Console.ReadLine());
                                Console.Write("Digite o segundo numero: ");
                                var n2 = Double.Parse(Console.ReadLine());
                                Console.WriteLine($"{n1} / {n2} = {n1/n2}");
                                break;
                            case 2:
                                operacao = 0;
                                break;
                            default:
                                Console.WriteLine("Opção invalida! Selecione uma das 2 opções.");
                                break;
                        }
                    } while (opcao>2 && opcao<1);                  
                case 4:     // ----------------------------- OPERAÇÃO DE * ----------------------------
                    do
                    {
                        Console.WriteLine("--------------------------------------");
                        Console.WriteLine($"Usuário: {usuario}");
                        Console.WriteLine("---------------OPERAÇÃO * --------------");
                        Console.WriteLine("Escolha alguma das opções abaixo: ");
                        Console.WriteLine("[1] REFAZER OPERAÇÃO");
                        Console.WriteLine("[2] VOLTAR PARA MENU ANTERIOR");
                        Console.WriteLine("--------------------------------------");
                        var opcao = int.Parse(Console.ReadLine());
                        switch (opcao)
                        {
                            case 1:
                                Console.Write("Digite o primeiro numero: ");
                                var n1 = Double.Parse(Console.ReadLine());
                                Console.Write("Digite o segundo numero: ");
                                var n2 = Double.Parse(Console.ReadLine());
                                Console.WriteLine($"{n1} * {n2} = {n1*n2}");
                                break;
                            case 2:
                                operacao = 0;
                                break;
                            default:
                                Console.WriteLine("Opção invalida! Selecione uma das 2 opções.");
                                break;
                        }
                    } while (opcao>2 && opcao<1);
                case 5:     // ----------------------- SAIDA --------------------------------------

                     Environment.Exit(0);            

                default:
                    Console.WriteLine("Opção invalida! Selecione uma das 5 opções.");
                    break;
            }            
            
        } while (operacao > 4 && operacao < 1);


        }
    }
}
