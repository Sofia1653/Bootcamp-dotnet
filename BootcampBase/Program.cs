using System; 

namespace BootcampBase
{
    class Program
    {
        public static void Main(string[] args)
        {
            /*Console.WriteLine("Seja bem-vindo ao sistema de estacionamento\n");

            Console.Write("Qual é o preço inicial? R$ ");
            decimal precoFixo = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Qual é o preço por hora adicional? R$ ");
            decimal precoExtra = Convert.ToDecimal(Console.ReadLine());
            
            Estacionamento estacionamento = new Estacionamento(precoFixo, precoExtra);

            bool rodando = true;
            while (rodando)
            {
                int opcao = estacionamento.Menu();

                switch (opcao)
                {
                    case 1:
                        estacionamento.CadastrarVeiculo();
                        break;
                    case 2:
                        estacionamento.RemoverVeiculo();
                        break;
                    case 3:
                        estacionamento.ListarVeiculos();
                        break;
                    case 4:
                        rodando = false;
                        Console.WriteLine("Encerrando o sistema");
                        break;
                }
            }*/
            
            Pessoa p1 = new Pessoa();
            p1.nome = "Sofia";
            p1.sobrenome = "Gomes";
            
            Pessoa p2 = new Pessoa();
            p2.nome = "Peter";
            p2.sobrenome = "Araujo";
            
            Curso curso = new Curso();
            curso.nome = "dotnet";
            curso.alunos = new List<Pessoa>();
            
            curso.AdicionarAluno(p1);
            curso.AdicionarAluno(p2);
            Console.WriteLine(curso.QuantidadeMatriculados());
            curso.ListarAlunos();

            curso.RemoverAluno(p2);
            Console.WriteLine(curso.QuantidadeMatriculados());
            curso.ListarAlunos();
        }
    }
}