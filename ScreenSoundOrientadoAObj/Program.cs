//Banda queen = new("Queen");

//Album albumDoQueen = new("A night at the opera");

//Musica musica1 = new(queen, "Love of my life")
//{
//    Duracao = 213,
//    Disponivel = true,
//};

//Musica musica2 = new(queen, "Bohemian Rhapsody")
//{
//    Duracao = 354,
//    Disponivel = true
//};

//albumDoQueen.AdicionarMusica(musica1);
//albumDoQueen.AdicionarMusica(musica2);
//albumDoQueen.ExibirMusicasDoAlbum();
//Console.WriteLine();

//musica1.ExibirFichaTécnica();
//musica2.ExibirFichaTécnica();
//Console.WriteLine();

//queen.AdicionarAlbum(albumDoQueen);
//queen.ExibirDiscografia();

Podcast astros = new("Guiler", "CosmoCast");
Episodio ep1 = new(01, "Interestelar")
{
    DuracaoEmMinutos = 300
};
Episodio ep2 = new(02, "Materia escura")
{
    DuracaoEmMinutos = 321
};
Episodio ep3 = new(03, "Relatividade estrita")
{
    DuracaoEmMinutos = 399
};
ep1.AdicionarConvidados("Serjão");
ep2.AdicionarConvidados("Bill Nelson");
ep3.AdicionarConvidados("Elon Musk");
ep3.AdicionarConvidados("Steve Jobs");

astros.AdicionarEpisodio(ep1);
astros.AdicionarEpisodio(ep2);
astros.AdicionarEpisodio(ep3);

astros.ExibirDetalhesPodcast();
