namespace Geometria
{
    public class Circulo
    {
        //A área de um circulo é calculada por π*raio². Como pi é uma constante o raio é a única variável e por isso ele precisa ser informado na classe circulo para definir outras características como a área
        protected double raio;

        public Circulo(double raio)
        {
            this.raio = raio;
        }
        public double calcularArea()
        {
            return Math.PI * (raio * raio);
        }
    }

    public class Esfera
    {
        //A área de um esfera é calculada por 4*π*r². Como pi é uma constante o raio é a única variável e por isso ele precisa ser informado na classe esfera para definir outras características como a área
        protected double raio;

        public Esfera(double raio)
        {
            this.raio = raio;
        }

        public double calcularVolume()
        {
            return (4.0 / 3.0) * Math.PI * (raio * raio * raio);
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {

        }
    }
}