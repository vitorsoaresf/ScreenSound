class Banda
{
    private List<Album> _albums = new List<Album>();

    public Banda(string nome) 
    {
        Nome = nome;
    }

    public string Nome { get; }

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