namespace ex1
{
    public class Retangulo : IAreaCalculavel
    {
        public double Altura { get; set; }
        public double Base { get; set; }

        public Retangulo(double altura, double _base)
        {
            this.Altura = altura;
            this.Base = _base;
        }

        public double CalcularArea(){
            return this.Altura * this.Base;
        }
    }
}