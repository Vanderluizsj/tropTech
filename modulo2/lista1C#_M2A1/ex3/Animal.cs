namespace AnimalDeEstimacao
{
    public class Animal
    {
        public static string Peixe = "peixe";
        public static string Gato = "gato";
        public static string Cachorro = "cachorro";
        public string Nome;
        public string Tipo;

        public Animal(string nome, string tipo)
        {
            Nome = nome;

            if (tipo.ToLower() != Cachorro && tipo.ToLower() != Gato && tipo.ToLower() != Peixe)
            {
                Tipo = Peixe;
            }
            else
            {
                Tipo = tipo;
            }
        }
    }
}