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