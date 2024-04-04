class Podcast
{
    // Assim que for inicializado o podcast precisamos (e temos acesso) desses atributos
    public Podcast(string host, string nome)
    {
        Host = host;
        Nome = nome;
    }
    public string Host { get; }
    public string Nome { get; }
    private List<Episodio> Episodios { get; set; } = new List<Episodio>();

    public void AdicionarEpisodio(Episodio episodio)
    {
        Episodios.Add(episodio);
    }

    public void ExibirDetalhesPodcast()
    {
        Console.WriteLine($"Podcast >|{Nome}|< apresentado por [{Host}]\n");
        foreach (var episodio in Episodios)
        {
            Console.WriteLine($"{episodio.Resumo}\n");
        }
    }

}