Album albumQuenn = new Album();
albumQuenn.Nome = "Greatest Hits";

Musica musica1 = new Musica();
musica1.Nome = "Bohemian Rhapsody";
musica1.Duracao = 354;

Musica musica2 = new Musica();
musica2.Nome = "Don't Stop Me Now";
musica2.Duracao = 210;


albumQuenn.AdicionarMusica(musica1);
albumQuenn.AdicionarMusica(musica2);


albumQuenn.exibirMusicas();