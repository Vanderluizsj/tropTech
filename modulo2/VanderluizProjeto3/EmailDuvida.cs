using System;
using System.Collections.Generic;
namespace VanderluizProjeto3
{
    public class EmailDuvida : IEmailExibivel
    {
        public int Identificacao { get; set; }
        public string Conteudo { get; set; }
        public bool Respondido { get; set; }
        public static LinkedList<EmailDuvida> listaDeDuvidas = new LinkedList<EmailDuvida>();

        public EmailDuvida()
        {
        
        }
        public static int Quantidade
        {
            get
            {
                return listaDeDuvidas.Count;
            }
        }
        public void adicionarDuvida(EmailDuvida email){
            listaDeDuvidas.AddLast(email);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(email.ToString());
            Console.WriteLine("Duvida cadastrada com sucesso!");
        }

        public override string ToString()
        {            
            return  $"======================Dúvida=======================\n" +
                    $"Número de Identificação do e-mail: {Identificacao}\n" +
                    $"Pergunta: {Conteudo}\n" +
                    $"Respondido: {Respondido}\n"+
                    $"====================================================";
        }
        public void Exibir()
        {
            Console.ForegroundColor = ConsoleColor.White;
            foreach (EmailDuvida duvida in listaDeDuvidas)
            {               
                Console.WriteLine(duvida.ToString());
            }         
        }
        
    }
}