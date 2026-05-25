using GIT.Esercizio1.Domain;
namespace GIT.Esercizio1.ProjectConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            CD cd = new CD("Greatest Hits", "Artista Esempio");
            cd.Songs = new List<Song>();

            cd.Songs.Add(new Song("Canzone Uno", "Artista Esempio", 210));
            cd.Songs.Add(new Song("Canzone Due", "Artista Esempio", 180));
            cd.Songs.Add(new Song("Canzone Tre", "Artista Esempio", 95));

            Console.WriteLine(cd.toString());
            Console.WriteLine($"Durata totale: {cd.duration()} secondi");

            Console.WriteLine("\nCanzoni brevi (meno di 120 secondi):");
            foreach (Song song in cd.Songs)
            {
                if (song.shortSong(120))
                    Console.WriteLine(song.toString());
            }
        }
    }
}
