using Ingressos;
internal class Program
{
    private static void Main(string[] args)
    {
        //O método contrutor permite criar um objeto de uma classe com os valores obrigatórios sem precisar criar o objeto e depois editar os valores. O método faz essas duas atividades de uma vez só
        Ingresso ingressoGenerico = new("Show Genérico",55.55, 215);

        ingressoGenerico.ExibirInformacoes();        
    }
}