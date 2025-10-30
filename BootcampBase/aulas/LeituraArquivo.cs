namespace BootcampBase;

public class LeituraArquivo
{
    public (bool Sucesso, string[] Linhas, int QuantidadeLinhas) LerArquivo(string caminho)
    {
        try
        {
            string[] linhas = File.ReadAllLines(caminho);
            return (true, linhas, linhas.Count());
        }
        catch (Exception)
        {
            return (false, new string[0], 0);
        }
    }
}

//Programa
/*LeituraArquivo arquivo = new LeituraArquivo();
var (sucesso, linhasArquivo, quantidadeLinhas) = arquivo.LerArquivo("aulas/arquivoLeitura.txt");
if (sucesso)
{
    Console.WriteLine("Quantidade linhas: " + quantidadeLinhas);
    foreach (string linha in linhasArquivo)
    {
        Console.WriteLine(linha);
    }
}
else
{
    Console.WriteLine("Não foi possível ler o arquivo");
}*/