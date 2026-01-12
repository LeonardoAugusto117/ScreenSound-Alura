class Banda
{
    private List<Album> albums = new List<Album>();

    public Banda(string nome)
    {
        Nome = nome;
    }

    public string Nome { get;}
    public void AdicionarAlbum(Album album)
    {
        albums.Add(album);
    }

    public void ExibirAlbuns()
    {
        Console.WriteLine($"Álbuns da banda {Nome}:\n");
        foreach (var album in albums)
        {
            Console.WriteLine($"- {album.Nome} ({album.DuracaoTotal})");
        }
    }
}