namespace BootcampBase;

public class People
{
    private string _nome;
    private int _idade;
    public string nome
    {
        get
        {
            return _nome.ToUpper();
        }
        set
        {
            if (value == "")
            {
                throw new ArgumentException("O nome não pode ser vazio");
            }
            _nome = value;
        }
    }

    public string sobrenome { get; set; }

    public string nomeCompleto => $"{nome} {sobrenome}";

    public int idade
    {
        get => _idade;
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("A idade não pode ser menor que 0");
            }
            _idade = value;
        }
    }

    public void Apresentar()
    {
        Console.WriteLine($"Meu nome é {nomeCompleto} e eu tenho {idade} anos.");
    }
}

//Programa
/*Pessoa p1 = new Pessoa();
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
            curso.ListarAlunos();*/