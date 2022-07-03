namespace LendingLibrary.Models;

public class Textbook : Book
{
    public string Subject { get; set; }

    public Textbook(string title, string author, int publicationYear, string subject)
    {
         Title = title;
         Author = author; 
         PublicationYear = publicationYear;
         Subject = subject;
    }

    public Textbook(){} // Empty constructor   
     public void PrintTextbook()
    {
        Console.WriteLine($"Textbook: {Title} ({Subject}, {PublicationYear}) by {Author}.");
    }
}