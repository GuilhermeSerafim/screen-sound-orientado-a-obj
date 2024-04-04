Banda queen = new("Queen");

Album albumDoQueen = new("A night at the opera");

Musica musica1 = new(queen, "Love of my life")
{
    Duracao = 213,
    Disponivel = true,
};

Musica musica2 = new(queen, "Bohemian Rhapsody")
{
    Duracao = 354,
    Disponivel = true
};

albumDoQueen.AdicionarMusica(musica1);
albumDoQueen.AdicionarMusica(musica2);
albumDoQueen.ExibirMusicasDoAlbum();
Console.WriteLine();

musica1.ExibirFichaTécnica();
musica2.ExibirFichaTécnica();
Console.WriteLine();

queen.AdicionarAlbum(albumDoQueen);
queen.ExibirDiscografia();