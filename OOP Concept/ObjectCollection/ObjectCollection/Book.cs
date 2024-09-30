public class Book
{
    List<Book> books = new List<Book>();

    public string Author { get; set; }
    public string Title { get; set; }
    public int Pages { get; set; }

    public void AddBook()
    {
        Console.Write("Author: ");
        string name = Console.ReadLine();

        Console.Write("Title: ");
        string title = Console.ReadLine();

        Console.Write("Number Of Pages: ");
        int pages = int.Parse(Console.ReadLine());

        Book book = new Book();
        book.Author = name;
        book.Title = title;
        book.Pages = pages;

        books.Add(book);
        Console.WriteLine("Book added successfully into the library.");
        Console.WriteLine("Press any key to continue.");
        Console.ReadKey();
    }

    public void GetBook()
    {
        if (books.Count == 0)
        {
            Console.WriteLine("No book currently in the library.");
        }
        else
        {
            foreach (var book in books)
            {
                Console.WriteLine($"Author: {book.Author}");
                Console.WriteLine($"Title: {book.Title}");
                Console.WriteLine($"Pages: {book.Pages}");
                Console.WriteLine();
            }
        }
        Console.WriteLine("Press Any Key To Continue.");
        Console.ReadKey();
    }
}
