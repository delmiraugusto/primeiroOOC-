class Episodio
{
    private int _Duracao {get; set;}
    public int _Numero {get; set;}
    public string _Resumo => $"{_Numero}, {_Titulo} ({_Duracao}) min - {string.Join(", ", convidados)}";
   
    
    private string _Titulo { get; }
    
    private List<string> convidados = new();

    public Episodio(int numero, string titulo, int duracao)
    {
        _Numero = numero;
        _Titulo = titulo;
        _Duracao = duracao;
    }

    public void AddConvidado(string convidado)
    {
        convidados.Add(convidado);
    }
}