using Geometria;
internal class Program
{
    private static void Main(string[] args)
    {
        Circulo item1 = new(2.0);
        Esfera item2 = new(5.0);

        double area = item1.calcularArea();
        double volume = item2.calcularVolume();

        Console.WriteLine($"Área do círculo é: {area}");
        Console.WriteLine($"Volume da esfera é: {volume}");
    }
}