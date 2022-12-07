namespace IMC
{
    public class Pessoa
    {
        public static string Nome;
        public static double Altura;
        public static int Peso;
        public static string Sexo;

        public Pessoa(string nome, int peso, double altura, string sexo)
        {
            Nome = nome;
            Peso = peso;
            Altura = altura;
            Sexo = sexo;
        }

        public static void AlteraNome(string novoNome)
        {
            Nome = novoNome;
        }

        public static void AlteraAltura(double novaAltura)
        {
            Altura = novaAltura;
        }

        public static void AlteraPeso(int novaPeso)
        {
            Peso = novaPeso;
        }

        public static void AlteraSexo(string novoSexo)
        {
            Sexo = novoSexo;
        }


        public static string RetornaNome()
        {
            return Nome;
        }

        public static double RetornaAltura()
        {
            return Altura;
        }

        public static int RetornaPeso()
        {
            return Peso;
        }

        public static string RetornaSexo()
        {
            return Sexo;
        }

        public static double CalculaIMC()
        {
            return Peso / Altura;
        }

    }
}