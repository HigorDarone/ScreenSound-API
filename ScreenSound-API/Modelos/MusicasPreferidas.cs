
namespace ScreenSound_API.Modelos;

using System.Text.Json;
using System.Xml;

internal class MusicasPreferidas
{

    public string? Nome {  get; set; }
    public List<Musica> ListaDeMusicasFavoritas;

    public MusicasPreferidas(string nome) 
    {
        Nome = nome;
       ListaDeMusicasFavoritas = new List<Musica>(); 
    }

    public void AdicionarMusicasFavoritas(Musica musica)
    {
        ListaDeMusicasFavoritas.Add(musica);
    }

    public void ExibirMusicasFavoritas()
    {
        Console.WriteLine($"Essas sao as musicas favoritas do {Nome}");
        foreach(var musica in ListaDeMusicasFavoritas) 
        {
            Console.WriteLine($"- {musica.Nome} de {musica.Artista}");
            
        }
        Console.WriteLine();
    }

    public void GerarArquivoJson()
    {
        string json = JsonSerializer.Serialize(new
        {
            nome = Nome,
            musicas = ListaDeMusicasFavoritas
        });

        string nomeDoArquivo = $"musicas-favoritas-{Nome}.Json";

        File.WriteAllText(nomeDoArquivo, json);
        Console.WriteLine($"O arquivo Json foi criado com sucesso! {Path.GetFullPath(nomeDoArquivo)}");
    }


}
