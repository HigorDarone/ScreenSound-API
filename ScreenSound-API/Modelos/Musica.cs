
using System.Text.Json.Serialization;

namespace ScreenSound_API.Modelos;

internal class Musica
{
    private string[] tonalidade = { "C", "C#", "D", "Eb", "E", "F#", "F#", "G", "Ab", "A", "Bb", "B" };

    [JsonPropertyName("song")]
    public string? Nome {  get; set; }

    [JsonPropertyName("artist")]
    public string? Artista { get; set; }

    [JsonPropertyName("duration_ms")]
    public int Duracao { get; set; }

    [JsonPropertyName("genre")]
    public string? Genero { get; set; }

    [JsonPropertyName("year")]
    public string? Ano {  get; set; }

    [JsonPropertyName("key")]
    public int Key { get; set; }

    public string Tonalidade { 
        get
        {
            return tonalidade[Key];
        }
    }

    public void ExibirDetalhesDaMusica()
    {
        Console.WriteLine($"Artista {Artista}");
        Console.WriteLine($"Musica {Nome}");
        Console.WriteLine($"Duracao em segundos {Duracao / 1000}");
        Console.WriteLine($"Genero {Genero}");
        Console.WriteLine($"Ano {Ano}");
        Console.WriteLine($"Tonalidade {Tonalidade}");
    }
}
