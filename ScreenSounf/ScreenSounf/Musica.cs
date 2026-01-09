class Mussica()
{

    public string Nome { get; set; } = "";
    public string Artista { get; set; } = "";
    public int Duracao { get; set; } = 0; // duração em segundos
    public bool Disponivel { get; set; }
    public string DescricaoResumida => $"Nome da Musica {Nome} é do artista {Artista}";


    public void ExxibirFichaTecnica() {
        Console.WriteLine("---- Ficha Técnica da Música ----");
        Console.WriteLine();
    }

    public void ExibirFichaTecnica()
    {
        ExxibirFichaTecnica();

        Console.WriteLine(DescricaoResumida);
        Console.WriteLine();
        Console.WriteLine($"Nome Musica: {Nome}");
        Console.WriteLine($"Nome Artista: {Artista}");
        Console.WriteLine($"Duração  da Musica: {Duracao}");

        // código omitido

        if (Disponivel)
        {
            Console.WriteLine("");
            Console.WriteLine("Disponível no plano.");
            Console.WriteLine("");
            Console.WriteLine("--------------------");
        }
        else
        {
            Console.WriteLine("");
            Console.WriteLine("Adquira o plano Plus+");
            Console.WriteLine("");
            Console.WriteLine("--------------------");
        }
    }


}


    