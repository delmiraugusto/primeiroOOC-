class Banda
{
    private List<Album> albums = new List<Album>();
    public string _Nome { get; }

    public Banda(string nome)
    {
        _Nome = nome;
    }

    public void AddAlbum(Album album)
    {
            albums.Add(album);
    }

    public void ExibirDiscografia() 
    {
        Console.WriteLine($"\nDiscografia da banda {_Nome}");
        foreach (Album a in albums)
        {
            Console.WriteLine($"Álbum: {a.Nome} ({a.DuracaoTotal})s");
        }
    }
}