﻿class Album
{
    public Album(string nome) => Nome = nome;

    private List<Musica> musicas = new List<Musica>();
    public string Nome { get; }
    public int DuracaoTotal => musicas.Sum(musica => musica.Duracao); // Soma das músicas

    public void AdicionarMusica(Musica musica)
    {
        // Posso adicionar lógicas internas aqui
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
