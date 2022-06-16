namespace ex1
{
    public class Circulo : IAreaCalculavel
    {
        public double Raio{get; set;}

        public Circulo(double raio) 
        {
            this.Raio = raio;               
        }

        public double CalcularArea(){
            return this.Raio * this.Raio;
        }
    }
}