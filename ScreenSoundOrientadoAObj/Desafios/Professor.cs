class Professor
{
    public string Nome { get; set; }
    public List<string> DisciplinaLecionadas { get; set; } = new List<string>();

    public void AdicionarDisciplinaLecionada(string disciplina)
    {
        DisciplinaLecionadas.Add(disciplina);
    }

    public void ExibirDisciplinasLecionadas()
    {
        foreach (var disciplina in DisciplinaLecionadas)
        {
            Console.WriteLine($"{disciplina} \n");
        }
    }
}