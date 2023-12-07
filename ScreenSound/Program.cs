Banda banda = new();
banda.Nome = "Queen";

Album albumDoQueen = new Album();

albumDoQueen.Nome = "A night at the opera";

Musica musica1 = new(banda)
{
    Nome = "Love of my life",
    Duracao = 345
};


Musica musica2 = new(banda)
{
    Nome = "Bohemian Rhapsody",
    Duracao = 200

};

albumDoQueen.AdicionarMusica(musica1);
albumDoQueen.AdicionarMusica(musica2);

banda.AdicionarAlbum(albumDoQueen);
banda.ExibirDiscrografia();