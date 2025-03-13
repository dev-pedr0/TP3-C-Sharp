using Escola;

internal class Program
{
    private static void Main(string[] args)
    {
        Matricula matriculaTeste = new("Pedro", "ADS", 123, "Ativa", "16/06/2024");

        matriculaTeste.trancar();
        matriculaTeste.exibirInformacao();
        Console.WriteLine("-------------");
        matriculaTeste.reativar();
        matriculaTeste.exibirInformacao();
    }
}