namespace BootcampBase;

public class Curso
{
    public string nome { get; set; }
    public List<Pessoa> alunos { get; set; }

    public void AdicionarAluno(Pessoa aluno)
    {
        alunos.Add(aluno);
    }

    public int QuantidadeMatriculados()
    {
        return alunos.Count;
    }

    public bool RemoverAluno(Pessoa aluno)
    {
        return alunos.Remove(aluno);
    }

    public void ListarAlunos()
    {
        foreach (Pessoa aluno in alunos)
        {
            Console.WriteLine(aluno.nomeCompleto);
        }
    }
}