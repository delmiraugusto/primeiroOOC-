class Podcast
{
    private string _Host { get; set; }
    private string _Nome { get; set; }
    private int _TotalEpisodios => listaEpisodios.Count;

    private List<Episodio> listaEpisodios = new();

    public Podcast(string host, string nome)
    {
        _Host = host;
        _Nome = nome;
    }

    public void AddEpisodios(Episodio e)
    {
        listaEpisodios.Add(e);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"O Podcast {_Nome} é do Host: {_Host}\n");
        foreach (Episodio episodio in listaEpisodios.OrderBy(e => e._Numero))
        {
            Console.WriteLine(episodio._Resumo);
        }
        Console.WriteLine($"\nEste podcast tem: {_TotalEpisodios} Episodios");
    }

}
