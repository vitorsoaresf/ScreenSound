Musica musica1 = new Musica();
musica1.Nome = "minh_musica";
musica1.Artista = "Vitor";
musica1.Duracao = 273;
musica1.Disponivel = true;
Console.WriteLine(musica1.DescricaoResumida); 
musica1.ExibirFichaTecnica();

Musica musica2 =  new Musica();
musica2.Nome = "musica_Fidel";
musica2.Artista = "Fidel";
musica2.Duracao = 367;
musica2.Disponivel = false;
musica2.ExibirFichaTecnica();
