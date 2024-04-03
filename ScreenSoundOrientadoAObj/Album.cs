class Album
{
    private List<Musica> musicas = new List<Musica>();  
    public string Nome { get; set; }
    public int DuracaoTotal => musicas.Sum(musica => musica.Duracao); // Soma das músicas

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Exibindo músicas do album {Nome}:\n");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Música: {musica.Nome}");
        }
        Console.WriteLine($"Duração total em segundos do álbum {Nome}: {DuracaoTotal}s");
    }
}
