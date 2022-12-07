namespace Exercicio2
{
    public class Paciente
    {
        public string Nome { get; set; }

        public int Idade { get; set; }

        public IMC Imc { get; set; }

        public double CalcularImc(){
            var imc = Imc.Peso / (Imc.Altura * Imc.Altura);
            return imc;
        }
    }
}