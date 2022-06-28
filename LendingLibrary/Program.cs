using LendingLibrary.Models;

namespace LendingLibrary
{
    class Program
    {
        static void Main()
        {
            var library = new Library();
            
            var novel1 = new Novel();
            novel1.Title = "Game of Thrones";
            novel1.Author = "George RR Martin";
            novel1.PublicationYear = 1996;
            novel1.Genre = "Fantasy";
            library.AddNovel(novel1);

            var novel2 = new Novel();
            novel2.Title = "Harry Potter";
            novel2.Author = "JK Rowling";
            novel2.PublicationYear = 2003;
            novel2.Genre = "Fantasy";
            library.AddNovel(novel2);

            var textbook1  = new Textbook();
            textbook1.Title = "Biology for VCE";
            textbook1.Author = "Tommins et. al.";
            textbook1.PublicationYear = 2021;
            textbook1.Subject = "Biology";
            //library.Addtextbookl(textbook1);

            var textbook2  = new Textbook();
            textbook2.Title = "Numbers and Operators";
            textbook2.Author = "Smith Jennings";
            textbook2.PublicationYear = 2019;
            textbook2.Subject = "Maths";


            var album1  = new Album();
            album1.Title = "Diva";
            album1.Artist = "Beyonce";
            album1.NumberOfTracks = 11;
            album1.PublicationYear = 2001;

            var album2  = new Album();
            album2.Title = "Live at the Opus";
            album2.Artist = "Lou Rawls";
            album2.NumberOfTracks = 9;
            album2.PublicationYear = 1970;

            var audioBook1  = new AudioBook();
            audioBook1.Title = "Little Women";
            audioBook1.Author = "Bronte";
            audioBook1.NumberOfTracks = 4;
            audioBook1.PublicationYear = 1871;

            var audioBook2  = new AudioBook();
            audioBook2.Title = "The Miracle Morning";
            audioBook2.Author = "Stephen Wilds";
            audioBook2.NumberOfTracks = 6;
            audioBook2.PublicationYear = 2011;

            library.ListOfNovels();


        }
    }
}
