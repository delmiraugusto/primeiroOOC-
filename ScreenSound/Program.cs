Episodio ep1 = new(2, "Técnicas de facilitação", 45);
ep1.AddConvidado("Delmir");
ep1.AddConvidado("Augusto");

Episodio ep2 = new(1, "Técnicas de aprendizado", 65);
ep2.AddConvidado("Delmir");
ep2.AddConvidado("Gorges");
ep2.AddConvidado("Silva");

Podcast podcast = new("Delmir", "C#");
podcast.AddEpisodios(ep1);
podcast.AddEpisodios(ep2);
podcast.ExibirDetalhes();
