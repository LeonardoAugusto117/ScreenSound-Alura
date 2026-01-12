Banda queen = new Banda("Queen");
Album albumQuenn = new Album("Greatest Hits");

Musica musica1 = new Musica(queen, "Bohemian Rhapsody")
{
    Duracao = 354,
    Disponivel = true
};


Musica musica2 = new Musica(queen, "Don't Stop Me Now")
{
    Duracao = 210,
    Disponivel = true

};

albumQuenn.AdicionarMusica(musica1);
albumQuenn.AdicionarMusica(musica2);
albumQuenn.exibirMusicas();

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();

queen.AdicionarAlbum(albumQuenn);
queen.ExibirAlbuns();

// Podecast Desafio

Console.WriteLine("\n--- Podcast Desafio ---\n");

Episodio ep1 = new(2, "Técnicas de facilitação", 45);
ep1.AdicionarConvidado("Maria");
ep1.AdicionarConvidado("Marcelo");

Episodio ep2 = new(1, "Tecnicas de aprendizado", 67);
ep2.AdicionarConvidado("Fernando");
ep2.AdicionarConvidado("Marcos");
ep2.AdicionarConvidado("Flavia");

Podcast podcast = new("Podcast especial", "Daniel");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);
podcast.ExibirDetalhes();