using System;
namespace VanderluizProjeto3
{
    public class GerencidorDeEmails
    {
        public static int contador = 0;
        public static void FazerPergunta(EmailDuvida email)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            System.Console.WriteLine("Digite a sua duvida: ");
            string duvida = Console.ReadLine();
                        
            if (Validacao.Validar(duvida))
            {
                contador++;
                email.Conteudo = duvida;
                email.Identificacao = contador;
                email.Respondido = false;
                email.adicionarDuvida(email); 
            } else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine("O campo duvida foi deixado em branco! Digite um valor valido.");
            }                        
        }
        public static void Exibir(IEmailExibivel email)
        {
            int quantidade = EmailDuvida.Quantidade;
            if (Validacao.ValidarExibicao(quantidade))
            {
                email.Exibir();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("A lista está vazia! Ainda não tem email de dúvida cadastrado.");
            }            
        }
        
        public static void ResponderPergunta(EmailResposta email)
        {
            int quantidade = EmailDuvida.Quantidade;
            if (Validacao.ValidarExibicao(quantidade))
            {
                foreach (var duvida in EmailDuvida.listaDeDuvidas)
                {
                    System.Console.WriteLine(duvida.ToString());
                    System.Console.WriteLine("Digite a Resposta abaixo: ");
                    string resposta = Console.ReadLine();
                    contador++;
                    if (Validacao.Validar(resposta))
                    {
                        email.Conteudo = resposta;
                        email.Identificacao = contador;
                        email.IdentificacaoDuvida = duvida.Identificacao;
                        email.ConteudoDuvida = duvida.Conteudo;
                        email.Respondido = true;
                        EmailResposta.Resposta(email);
                        EmailDuvida.listaDeDuvidas.Remove(duvida);
                        break;

                    }else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        System.Console.WriteLine("O campo duvida foi deixado em branco! Digite um valor valido.");
                    } 
                    
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("A lista está vazia! Ainda não tem email de dúvida cadastrado.");
            }  
        }
        
    }
}