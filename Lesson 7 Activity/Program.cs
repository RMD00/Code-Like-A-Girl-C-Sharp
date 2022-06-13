Console.WriteLine("Welcome to the library!");

var members = CreateMembers();
var recommendedBooks = CreateBookList();

Console.WriteLine($"Here is a list of the Book Club members:");
foreach(var member in members)
        {
            Console.WriteLine($"{member.firstName} {member.lastName}: {member.firstName}'s favourite book is: {member.favouriteBook}."); 
            Console.WriteLine($"Books on {member.firstName}'s reading list:");
            foreach (var book in recommendedBooks)
            {
                Console.WriteLine($"{book.title} by {book.author}");
            }
        }

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

    var books = new List<Book> 
    {
        book1, book2, 
    };

    return books;
}
public class Member
    {
        public string firstName;
        public string lastName;
        public string favouriteBook;
        public List<Book> readingList;
    }
public class Book
    {
        public string title; 
        public string author;
    };

    