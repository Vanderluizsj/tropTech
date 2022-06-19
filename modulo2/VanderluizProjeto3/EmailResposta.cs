using System;
using System.Collections.Generic;
namespace VanderluizProjeto3
{
    public class EmailResposta : IEmailExibivel
    {
        public int Identificacao { get; set; }
        public int IdentificacaoDuvida { get; set; }
        public string Conteudo { get; set; }
        public string ConteudoDuvida { get; set; }
        public bool Respondido { get; set; }
        public static LinkedList<EmailResposta> listaDeRespostas = new LinkedList<EmailResposta>();

        public EmailResposta()
        {
           
        }
        public static int Quantidade
        {
            get
            {
                return listaDeRespostas.Count;
            }
        }
        public static void Resposta(EmailResposta email)
        {
            listaDeRespostas.AddLast(email);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(email.ToString());
            Console.WriteLine("Resposta cadastrada com sucesso!");
            
        }
        public override string ToString()
        {            
            return  $"======================Resposta======================\n" +
                    $"Número de Identificação do e-mail Dúvida: {IdentificacaoDuvida}\n" +
                    $"Número de Identificação do e-mail Resposta: {Identificacao}\n" +
                    $"Pergunta: {ConteudoDuvida}\n" +
                    $"Resposta: {Conteudo}\n" +
                    $"Respondido: {Respondido}\n"+
                    $"====================================================";
        }
        public void Exibir()
        {
            Console.ForegroundColor = ConsoleColor.White;
            foreach (EmailResposta resposta in listaDeRespostas)
            {               
                Console.WriteLine(resposta.ToString());
            }         
        }
    }
}