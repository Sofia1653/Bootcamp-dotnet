namespace BootcampBase;

public class Pessoa
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