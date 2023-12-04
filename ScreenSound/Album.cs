class Album
{
    private List<Musica> _musicas = new List<Musica>();
    public string Nome { get; set; }
    public int DuracaoTotal => _musicas.Sum(musica=> musica.Duracao);

    public void AdicionarMusica(Musica musica)
    {
        _musicas.Add(musica);
    }

    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"A lista de músicas do álbum {Nome}:\n");
        
        _musicas.ForEach(musica => { Console.WriteLine($"Música: {musica.DescricaoResumida} com dura" +
            $"ção de {musica.Duracao}"); });

        Console.WriteLine($"Para ouvir esse álbum inteiro você precisa de {DuracaoTotal} segundos. \n");

    }
}