class Album {

    private List<Musica> musicas = new List<Musica>();
    public string Nome { get; set; }
    public double DuracaoTotal => musicas.Sum(m => m._Duracao);

    public void AdicionarMusica(Musica musica) { 
        musicas.Add(musica);
    }

    public void ExibirMusicaAlbum() {
        Console.WriteLine($"Lista de músicas do álbum {Nome}\n");
        foreach (Musica musicasDoAlbum in musicas)
        {
            Console.WriteLine($"Música: {musicasDoAlbum._Nome}");
        }
        Console.WriteLine($"\nPara ouvir este álbum inteiro você precisa de {DuracaoTotal}s");
    }
}