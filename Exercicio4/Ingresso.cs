using Ingressos;

internal class Program
{
    private static void Main(string[] args)
    {
        Ingresso ingressoImagineDragons = new("Imagine Dragons-Loom", 122.00, 564);

        double novoPreco = ingressoImagineDragons.AlterarPreco(175.35);
        int novaQuantidade = ingressoImagineDragons.AlterarQuantidade(74);

        ingressoImagineDragons.ExibirInformacoes();
    }
}