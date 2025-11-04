using System.Threading.Channels;

class Musica
{
    public Musica(Banda artista,string nome)
    {
        Artista = artista;
        Nome = nome;
    }
    public string Nome { get; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida => //Leitura simplificada { get; }
        $"A música {Nome} pertence a banda {Artista.Nome}";

    public void FichaTecnicaMusica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao}");
        
        if (Disponivel)
        {
            Console.WriteLine("A música está disponível.");
        }
        else
        {
            Console.WriteLine("A música não está disponível.");
        }
        Console.WriteLine(DescricaoResumida);
    }
        
}