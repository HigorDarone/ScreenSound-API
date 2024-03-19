using ScreenSound_API.Modelos;
using ScreenSound_API.Filtros;
using System.Text.Json;


using (HttpClient client = new HttpClient())
{
   try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
       

        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        //LinqFiltro.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqOrdenar.ExibirListaDeArtistasOrdenados(musicas);
        //LinqFiltro.FiltrarArtistaPorGeneroMusical(musicas, "pop");
        //LinqFiltro.FiltrarMusicasDeUmArtista(musicas, "Travis Scott");
        //LinqFiltro.FiltrarMusicasPorAno(musicas, "2015");
        //LinqFiltro.FiltrarListaDeTonalidadeOrdenados(musicas, "C#");
        LinqFiltro.FiltrarListaDeTonalidadeOrdenadospeloCsharp(musicas);


        //var musicasPreferidasDoHigor = new MusicasPreferidas("Higor");
        //musicasPreferidasDoHigor.AdicionarMusicasFavoritas(musicas[1]);
        //musicasPreferidasDoHigor.AdicionarMusicasFavoritas(musicas[10]);
        //musicasPreferidasDoHigor.AdicionarMusicasFavoritas(musicas[20]);
       // musicasPreferidasDoHigor.AdicionarMusicasFavoritas(musicas[30]);
       // musicasPreferidasDoHigor.AdicionarMusicasFavoritas(musicas[40]);

      //  musicasPreferidasDoHigor.ExibirMusicasFavoritas();

       // musicasPreferidasDoHigor.GerarArquivoJson();


        //musicas[10].ExibirDetalhesDaMusica();


        //var musicasPreferidasDaDuda = new MusicasPreferidas("Duda");
        //musicasPreferidasDaDuda.AdicionarMusicasFavoritas(musicas[234]);
        //musicasPreferidasDaDuda.AdicionarMusicasFavoritas(musicas[556]);
        //musicasPreferidasDaDuda.AdicionarMusicasFavoritas(musicas[123]);
        //musicasPreferidasDaDuda.AdicionarMusicasFavoritas(musicas[12]);
        //musicasPreferidasDaDuda.AdicionarMusicasFavoritas(musicas[56]);

        //musicasPreferidasDaDuda.ExibirMusicasFavoritas();

    }
    catch (Exception ex) 
    {
      Console.WriteLine($"Temos um problema {ex.Message}");
    }
}