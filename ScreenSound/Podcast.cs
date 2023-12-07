class Podcast
{
    private List<Episodio> _episodios = new();

    public Podcast(string host, string nome)
    {
        Host = host;
        Nome = nome;
    }

    public string Host { get; }
    public string Nome { get;  }
    public int TotalEpisodios => _episodios.Count;
    
    public void AdicionarEpisodio(Episodio ep)
    {
        _episodios.Add(ep);
    }


    public void ExibirDetalhes()
    {
        Console.WriteLine($"Podcast {Nome} apresentado por {Host}\n\n");
        
        foreach (var ep in _episodios.OrderBy(e => e.Ordem))
        {
            Console.WriteLine($"{ep.Resumo}\n");
        }
        
        Console.WriteLine($"Total de Episodios: {TotalEpisodios}\n");
    }
}