Console.WriteLine("Welcome to the library!");

var members = CreateMembers();
var recommendedBooks = CreateBookList();

Console.WriteLine($"Here is a list of the Book Club members:");
foreach(var member in members)
        {
            member.PrintMember();
            foreach (var book in recommendedBooks)
            {
                book.PrintBook();
            }
        }

// METHODS
static List<Member> CreateMembers()
{
    var person1 = new Member
    {
        firstName = "Jane",
        lastName = "Doe",
        favouriteBook = "Harry Potter",
        readingList = new List<Book> { new Book() },
    };

    var person2 = new Member
    {
        firstName = "Betty",
        lastName = "White",
        favouriteBook = "The Red Queen",
        readingList = new List<Book> { new Book() },
    };
       
    var members = new List<Member> 
    {
        person1, person2,
    };

    return members;
}

// Create Members calls the method of create booklist. it is currently returning the reading list. Try to create one for recommended list for each member.

static List<Book> CreateBookList()
{
    var book1 = new Book
    {
        title = "Carrie",
        author = "Stephen King"
    };

    var book2 = new Book();
    book2.title = "Crown of Thorns";
    book2.author = "Sarah J Maas";

    var book3 = new Book();
    book3.title = "Peter Rabbit";
    book3.author = "Beatrix Potter";

    var books = new List<Book> 
    {
        book1, book2, book3,
    };

    return books;
}

// OBJECTS
public class Member
    {
        public string firstName;
        public string lastName;
        public string favouriteBook;
        public List<Book> readingList;
        public void PrintMember()
        {                  
            Console.WriteLine($"{firstName} {lastName}: {firstName}'s favourite book is: {favouriteBook}."); 
            Console.WriteLine($"Books on {firstName}'s reading list:");
        }
    }
public class Book
    {
        public string title; 
        public string author;

        public void PrintBook()
        {
            Console.WriteLine($"{title} by {author}");
        }
    }

