using System;

namespace CalculaTempo
{
    public class Tempo
    {
        public static long CalculaNumeroDeHoras(int numeroDeDias)
        {
            return numeroDeDias * 24;
        }

        public static long CalculaNumeroDeMinutos(int numeroDeDias)
        {
            return (numeroDeDias * 24) * 60;
        }

        public static long CalculaNumeroDeSegundos(int numeroDeDias)
        {
            return (((numeroDeDias * 24) * 60) * 60);
        }
    }
}