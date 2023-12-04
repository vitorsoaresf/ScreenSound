Album albumDoQueen = new Album();

albumDoQueen.Nome = "A night at the opera";

Musica musica1 = new()
{
    Nome = "Love of my life",
    Duracao = 345
};


Musica musica2 = new()
{
    Nome = "Bohemian Rhapsody",
    Duracao = 200

};

albumDoQueen.AdicionarMusica(musica1);
albumDoQueen.AdicionarMusica(musica2);

albumDoQueen.ExibirMusicasDoAlbum();