namespace Escola
{
     public class Matricula
    {
        protected string nomeDoAluno;
        protected string curso;
        protected int numeroMatricula;
        protected string situacao;
        protected string dataInicial;

        public Matricula(string nomeDoAluno, string curso, int numeroMatricula, string situacao, string dataInicial)
        {
            this.nomeDoAluno = nomeDoAluno;
            this.curso = curso;
            this.numeroMatricula = numeroMatricula;
            this.situacao = situacao;
            this.dataInicial = dataInicial;
        }
        
        public void trancar()
        {
            situacao = "Trancada";
            Console.WriteLine("Matricula Trancada");
        }

        public void reativar()
        {
            situacao = "Ativa";
            Console.WriteLine("Matricula Ativada");
        }

        public void exibirInformacao()
        {
            Console.WriteLine($"Nome: {nomeDoAluno}");
            Console.WriteLine($"Curso: {curso}");
            Console.WriteLine($"Matrícula: {numeroMatricula}");
            Console.WriteLine($"Situação: {situacao}");
            Console.WriteLine($"Data de Início: {dataInicial}");
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            
        }
    }
}

