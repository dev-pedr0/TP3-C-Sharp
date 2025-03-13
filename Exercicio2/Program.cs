namespace Ingressos
{
    public class Ingresso
    {
        //Ingresso ligado a um show específico, então é necessário o nome do show
        protected String nomeDoShow;
        //Preço do ingresso para indicar ao cliente para que seja pago
        protected double preco;
        //Quantidade disponível para não se vender mais ingressos do que existem
        protected int quantidadeDisponivel;

        public Ingresso(string nomeDoShow, double preco, int quantidadeDisponivel)
        {
            this.nomeDoShow = nomeDoShow;
            this.preco = preco;
            this.quantidadeDisponivel = quantidadeDisponivel;
        }

        public double AlterarPreco(double novoPreco)
        {
            Console.WriteLine($"Novo preço: {novoPreco}");
            preco = novoPreco;
            return novoPreco;
        }

        public int AlterarQuantidade(int novaQuantidade)
        {
            Console.WriteLine($"Nova quantidade: {novaQuantidade}");
            quantidadeDisponivel = novaQuantidade;
            return novaQuantidade;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Nome do show: {nomeDoShow}");
            Console.WriteLine($"Preço: {preco}");
            Console.WriteLine($"Quantidade: {quantidadeDisponivel}");
        }

        public string getNomeDoShow()
        {
            return nomeDoShow;
        }

        public double getPreco()
        {
            return preco;
        }

        public int getQuantidadeDisponivel()
        {
            return quantidadeDisponivel;
        }

        public void SetNomeDoShow(string novoNome)
        {
            nomeDoShow = novoNome;
            Console.WriteLine($"Novo nome: {novoNome}");
        }

        public void setPreco(double preco)
        {
            this.preco = preco;
            Console.WriteLine($"Novo preço: {preco}");
        }

        public void setQuantidadeDisponivel(int quantidadeDisponivel)
        {
            this.quantidadeDisponivel = quantidadeDisponivel;
            Console.WriteLine($"Nova quantidade: {quantidadeDisponivel}");
        }
    }
    internal class Program
    {
        private static void Main(string[] args)
        {
            Ingresso ingressoTeste = new("Show Teste", 30.00, 12);
            ingressoTeste.ExibirInformacoes();
        }
    }
}