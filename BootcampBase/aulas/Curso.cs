namespace BootcampBase;

public class Curso
{
    public string nome { get; set; }
    public List<People> alunos { get; set; }

    public void AdicionarAluno(People aluno)
    {
        alunos.Add(aluno);
    }

    public int QuantidadeMatriculados()
    {
        return alunos.Count;
    }

    public bool RemoverAluno(People aluno)
    {
        return alunos.Remove(aluno);
    }

    public void ListarAlunos()
    {
        foreach (People aluno in alunos)
        {
            Console.WriteLine(aluno.nomeCompleto);
        }
    }
}