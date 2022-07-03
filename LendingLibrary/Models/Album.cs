namespace LendingLibrary.Models;

public class Album : CD
{
    public string Artist { get; set; }

    public Album(string title, string artist, int publicationYear, int numberOfTracks)
    {
         Title = title;
         Artist = artist; 
         PublicationYear = publicationYear;
         NumberOfTracks = numberOfTracks;
    }

    public Album(){} // Empty constructor
    public void PrintAlbum()
    {
        Console.WriteLine($"Album: {Title} ({PublicationYear}): {Artist} ({NumberOfTracks} tracks).");
    }
}