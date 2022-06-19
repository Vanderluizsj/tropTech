using System;
namespace VanderluizProjeto3
{
    public class Validacao
    {
        public static bool Validar(string validar)
        {
            bool verificacao = String.IsNullOrEmpty(validar) ? false : true;
            return verificacao;
        }
        public static bool ValidarExibicao(int quantidade)
        {
            bool verificacao = quantidade == 0? false : true;
            return verificacao;
        }
    }    
}