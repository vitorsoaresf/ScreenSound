﻿class Musica
{
    public Musica(Banda artista)
    {
        Artista = artista;
    }

    public string Nome { get; set; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }

    public Genero Genero { get; set; }
    public string DescricaoResumida => $"A música {Nome} pertence à banda {Artista}";

    

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine($"Disponível ao plano");
        }
        else
        {
            Console.WriteLine($"Adquira o plano Plus+");
        }
        
    }

}