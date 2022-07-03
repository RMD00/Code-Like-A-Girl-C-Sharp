namespace LendingLibrary.Models;
public class Library : Media
{
    // for Novels
    public List<Novel> novels = new List<Novel>{};
    
    public void ListOfNovels()
    {
        foreach (var Novel in novels)
        {
            Novel.PrintNovel();
        }
    }
    public void AddNovel(Novel novel)
    {
        novels.Add(novel);    
    }

    // For Textbooks
    public List<Textbook> textbooks = new List<Textbook>{};
    public void ListOfTextbooks()
    {
        foreach (var Textbook in textbooks)
        {
            Textbook.PrintTextbook();
        }
    }
    public void AddTextbook(Textbook textbook)
    {
        textbooks.Add(textbook);    
    }

    // For Audio Books
    public List<AudioBook> audioBooks = new List<AudioBook>{};
    public void ListOfAudioBooks()
    {
        foreach (var AudioBook in audioBooks)
        {
            AudioBook.PrintAudioBook();
        }
    }
    public void AddAudioBook(AudioBook AudioBook)
    {
        audioBooks.Add(AudioBook);    
    }

    // For Albums
    public List<Album> album = new List<Album>{};
    public void ListOfAlbums()
    {
        foreach (var Album in album)
        {
            Album.PrintAlbum();
        }
    }
    public void AddAlbum(Album Album)
    {
        album.Add(Album);    
    }
}