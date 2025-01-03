using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Musica
{
    public string _Nome { get; }
    public Banda _Artista { get; }
    public double _Duracao { get; set; }
    public bool _Disponivel { get; set; }
    public string DescricaoResumida => 
        $"A música {_Nome} pertence ao artista {_Artista._Nome}";

    public Musica(Banda banda, string nome)
    {
        _Artista = banda;
        _Nome = nome;
    }
    
    public void ExibirFichaTecnica() 
    {
        Console.WriteLine($"\nNome: {_Nome}");
        Console.WriteLine($"Artista: {_Artista._Nome}");
        Console.WriteLine($"Duracao: {_Duracao} min");
        if (_Disponivel)
        {
            Console.WriteLine("Está Disponível");
        }
        else
        {
            Console.WriteLine("Não está Disponível");
        }
    }
}
