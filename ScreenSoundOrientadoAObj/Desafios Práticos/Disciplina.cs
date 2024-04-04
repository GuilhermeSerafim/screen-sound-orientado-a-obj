class Disciplina
{
    public string NomeDisciplina { get; set; }
    private List<Aluno> AlunosMatriculados { get; set; } = new List<Aluno>();

    public void AdicionarAluno(Aluno aluno)
    {
        AlunosMatriculados.Add(aluno);
    }
    public void MostrarAlunosDisciplina()
    {
        Console.WriteLine($"Lista de alunos da disciplina {NomeDisciplina}");
        foreach (var aluno in AlunosMatriculados)
        {
            Console.WriteLine($"Aluno: {aluno.Nome}");
            foreach (var nota in aluno.Notas)
            {
                Console.Write($"{nota}, ");
            }
            Console.WriteLine("\n");
        }
    }
}