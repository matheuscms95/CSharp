namespace Calculadora.src
{
    public class Formas : IFormas
    {
        public double Retangulo(double a, double b)
        {
            return a * b;
        }

        public double Quadrado(double a)
        {
            return a * a;
        }

        public double Triangulo(double a, double b)
        {
            return (a * b) / 2;
        }
    }
}