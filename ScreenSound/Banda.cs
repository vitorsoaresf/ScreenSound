class Banda
{
    public string Nome { get; set; }
    private List<Album> _albums = new List<Album>();

    public void AdicionarAlbum(Album album)
    {
        _albums.Add(album);
    }

    public void ExibirDiscrografia()
    {
        Console.WriteLine($"Discografia da banda {Nome}");
        _albums.ForEach(album => Console.WriteLine($"Álbum: {album.Nome}  ({album.DuracaoTotal})"));
    }
}