namespace LendingLibrary.Models;

public class AudioBook : CD
{
    public string Author { get; set; }

    public AudioBook(string title, string author, int publicationYear, int numberOfTracks)
    {
         Title = title;
         Author = author; 
         PublicationYear = publicationYear;
         NumberOfTracks = numberOfTracks;
    }

    public AudioBook(){} // Empty constructor   
     public void PrintAudioBook()
    {
        Console.WriteLine($"Audio Book: {Title} ({PublicationYear}): {Author} ({NumberOfTracks} tracks).");
    }
}