namespace Retangulo
{
    public class Retangulo
    {
        public static int Altura;
        public static int Largura;

        public Retangulo(int altura, int largura)
        {
            Altura = altura;
            Largura = largura;
        }

        public static void AlterarAltura(int novaAltura)
        {
            Altura = novaAltura;
        }

        public static void AlteraLargura(int novaLargura)
        {
            Largura = novaLargura;
        }

        public static int RetornaAltura()
        {
            return Altura;
        }

        public static int RetornaLargura()
        {
            return Largura;
        }

        public static int CalculaArea()
        {
            return Altura * Largura;
        }
    }
}