namespace CalculaMedia
{
    public class Nota
    {
        public static int CalculaMedia(params int[] notas)
        {
            int somaNotas = 0;

            foreach (var nota in notas)
            {
                somaNotas += nota;
            }

            return somaNotas / notas.Length;
        }

         public static double CalculaMedia(params double[] notas)
        {
            double somaNotas = 0;

            foreach (var nota in notas)
            {
                somaNotas += nota;
            }

            return somaNotas / notas.Length;
        }
    }
}