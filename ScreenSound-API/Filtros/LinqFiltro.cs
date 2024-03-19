using ScreenSound_API.Modelos;


namespace ScreenSound_API.Filtros;

internal class LinqFiltro
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        var todosOsGenerosMusicais = musicas.Select(generos =>
        generos.Genero).Distinct().ToList();
        

        foreach (var genero in todosOsGenerosMusicais)
        {
            Console.WriteLine($"-- {genero}");
        }

    }

    public static void FiltrarArtistaPorGeneroMusical(List<Musica> musicas, string genero)
    {
        var artistasPorGeneroMusical = musicas.Where(musica =>
        musica.Genero!.Contains(genero)).Select(musica =>
        musica.Artista).ToList().Distinct();
        Console.WriteLine($"Exibindo os artista por genero musical  >>>> {genero}");

       foreach(var artista  in artistasPorGeneroMusical)
        {
            Console.WriteLine($" -- {artista}");
        }
    }

    public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string nomeDoArtista)
    {
        var musicasDoArtista = musicas.Where(musica =>
        musica.Artista!.Equals(nomeDoArtista)).ToList();
        Console.WriteLine(nomeDoArtista);

        foreach (var musica in musicasDoArtista)
        {
            Console.WriteLine($" -- {musica.Nome}");
        }
    }

    public static void FiltrarMusicasPorAno(List<Musica> musicas, string anoDaMusica) 
    {
        var lancamentoDaMusica = musicas.Where(musica =>
        musica.Ano!.Contains(anoDaMusica)).Select(musica =>
        musica.Nome);

        Console.WriteLine($"Musicas do Ano {anoDaMusica}");

        foreach (var musica in lancamentoDaMusica )
        {
            Console.WriteLine($"MUSICA:  {musica}    ANO: {anoDaMusica}");
        }
    
    }
    public static void FiltrarListaDeTonalidadeOrdenados(List<Musica> musicas, string tonalidade)
    {
        var tonalidadesOrdenadas = musicas.Where(musicas =>
        musicas.Tonalidade!.Contains(tonalidade)).Select(musicas =>
        musicas.Nome);

        Console.WriteLine($"Musicas com a tonalidade {tonalidade}");

        foreach (var musica in tonalidadesOrdenadas)
        {
            Console.WriteLine($"MUSICA:  {musica}    TONALIDADE: {tonalidade}");
        }

    }

    public static void FiltrarListaDeTonalidadeOrdenadospeloCsharp(List<Musica> musicas)
    {
        var musicasEMCsharp = musicas.Where(musica =>
        musica.Tonalidade.Equals("C")).Select(musica =>musica.Nome).ToList();

        Console.WriteLine("Muscicas em C#");
        foreach (var musica in musicasEMCsharp) 
        {
            Console.WriteLine($"-- {musica}" );
        }



    }

}
