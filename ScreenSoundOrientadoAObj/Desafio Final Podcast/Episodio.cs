using System.Reflection;

class Episodio
{
    public Episodio(int ordem, string titulo)
    {
        Ordem = ordem;
        Titulo = titulo;
    }
    private string Titulo { get; }
    public int Ordem { get; }
    private List<string> Convidados { get; set; } = new List<string>();
    public int DuracaoEmMinutos { get; set; }
    public string Resumo =>
        $"Episódio {Ordem}: {Titulo} " +
        $"\nNossos convidados são: {string.Join(", ", Convidados)} " +
        $"\nDuração em minutos: {DuracaoEmMinutos}";

    public void AdicionarConvidados(string convidado)
    {
        Convidados.Add(convidado);
    }
}