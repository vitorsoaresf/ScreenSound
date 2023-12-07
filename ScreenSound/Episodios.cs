class Episodio
{
    private List<string> _Convidados = new();

    public Episodio(int duracao, int ordem, string titulo)
    {
        Duracao = duracao;
        Ordem = ordem;
        Titulo = titulo;
    }

    public int Duracao { get; }
    public int Ordem { get;  }
    public string Titulo{ get;  }
    public string Resumo => $"{Ordem}. {Titulo} - ({Duracao} min) - " +
        $"{string.Join(", ", _Convidados)}";

   

    public void AdicionarConvidados(string nome)
    {
        _Convidados.Add(nome); 
    }

}