class Convidados
{
    public string Nome { get; set; }
    public string Profissao { get; set; }
    public int Idade { get; set; }
    public Convidados(string nome, string profissao, int idade)
    {
        Nome = nome;
        Profissao = profissao;
        Idade = idade;
    }
}