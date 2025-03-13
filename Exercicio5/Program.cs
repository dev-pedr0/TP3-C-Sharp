using Ingressos;
internal class Program
{
    private static void Main(string[] args)
    {
        Ingresso ingressoLinkinPark = new("Linkin Park - From Zero", 159.99, 712);

        ingressoLinkinPark.SetNomeDoShow("From Zero");
        ingressoLinkinPark.setPreco(215.25);
        ingressoLinkinPark.setQuantidadeDisponivel(114);

        string nome = ingressoLinkinPark.getNomeDoShow();
        double preco = ingressoLinkinPark.getPreco();
        int quantidade = ingressoLinkinPark.getQuantidadeDisponivel();

        Console.WriteLine(nome);
        Console.WriteLine(preco);
        Console.WriteLine(quantidade);
    }
}