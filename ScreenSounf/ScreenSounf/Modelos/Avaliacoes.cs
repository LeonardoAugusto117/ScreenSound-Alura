namespace ScreenSound.Modelos;

internal class Avaliacoes
{
    public Avaliacoes(int nota)
    {
        Nota = nota;
    }

    public int Nota { get; }

    public static Avaliacoes Parse(string texto)
    {
        int nota = int.Parse(texto);
        return new Avaliacoes(nota);
    }
}
