/*Banda banda = new("Queen");

Album albumDoQueen = new Album("A night at the opera");

Musica musica1 = new Musica(banda, "Love of my life")
{
   Duracao = 345,
   Disponivel = true,
};

Musica musica2 = new(banda, "Bohemian Rhapsody")
{
   Duracao = 200,
   Disponivel = false,
};

albumDoQueen.AdicionarMusica(musica1);
albumDoQueen.AdicionarMusica(musica2);
banda.AdicionarAlbum(albumDoQueen);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
albumDoQueen.ExibirMusicasDoAlbum();
banda.ExibirDiscrografia();
*/

Episodio ep1 = new(20, 2, "Teste1");
ep1.AdicionarConvidados("Viton");
ep1.AdicionarConvidados("Maria");
Console.WriteLine(ep1.Resumo);

Episodio ep2 = new(30, 1, "Teste2");
ep2.AdicionarConvidados("Joao");
ep2.AdicionarConvidados("Junior");
Console.WriteLine(ep2.Resumo);

Podcast podcast = new("Podcast especial", "Treta mágica");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);
podcast.ExibirDetalhes();


