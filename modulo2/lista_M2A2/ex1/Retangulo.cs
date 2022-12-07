namespace ExercRetangulo
{
    public class Retangulo
    {
        private double _base;
        private double _altura;

        public double Area
        {
            get { return _base * _altura; }
        }

        public Retangulo(double baseTriangulo, double alturaTriangulo)
        {
            _base = baseTriangulo;
            _altura = alturaTriangulo;
        }
    }
}