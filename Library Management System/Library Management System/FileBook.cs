using System.ComponentModel.Design;
using System.Diagnostics;

public class FileBook
{
    private static List<Books> books = new List<Books>();

    public static void AddBook(Admin admin)
    {
        if (admin.AdminAccount == admin.Email)
        {
            int Count = 0;
            Console.Write("How many books do you want to add: ");
            int input = int.Parse(Console.ReadLine());

            for (int i = 0; i < input; i++)
            {
                Console.Write("Book Name: ");
                string name = Console.ReadLine();

                Console.Write("Author: ");
                string author = Console.ReadLine();

                Console.Write("Publisher Name: ");
                string publisherName = Console.ReadLine();

                Random random = new Random();
                string isbn = random.Next(1000000000, int.MaxValue).ToString();

                Console.Write("Enter Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                var book1 = new Books(name, author, publisherName, isbn, quantity);
                books.Add(book1);
                Console.WriteLine("Book Added Successfully.");
                Console.WriteLine($"Book ISBN => {isbn}\n");
                // adding the book to file
                AddToFile(book1);
                Count++;
            }
            Console.WriteLine($"You have successfully added {Count} books");
            Console.WriteLine($"The total products in stock is {books.Count}");
            Console.WriteLine();
            Console.WriteLine("Press Any Key To Continue.");
            Console.ReadKey();

        }
    }

    public static void AddToFile(Books books)
    {
        string path = "C:\\Users\\ORIOLOWO\\Documents\\Batch 23 Class\\Library Management System\\Library Management System\\Book.txt";
        if (File.Exists(path))
        {
            using var writer = new StreamWriter(path, true);
            writer.WriteLine(books.ToString());
        }
        else
        {
            using (File.Create(path))
            {

            }
            using var writer = new StreamWriter(path, true);
            writer.WriteLine(books.ToString());
        }
    }

    public static List<Books> RetrieveFromFile()
    {
        var listOfBooks = new List<Books>(); //to retrieve file content
        string path = "C:\\Users\\ORIOLOWO\\Documents\\Batch 23 Class\\Library Management System\\Library Management System\\Book.txt";
        if (File.Exists(path))
        {
            var datas = File.ReadAllLines(path);
            foreach (var data in datas)
            {
                var convert = Convert(data);
                listOfBooks.Add(convert);
            }
        }
        books = listOfBooks; //repopulate
        return listOfBooks;
    }
    public static Books Convert(string book) // convert back to object
    {
        var data = book.Split("\t|\t");
        return new Books(data[0], data[1], data[2], data[3], int.Parse(data[4]));
    }
    //All products
    public static void ViewBook()
    {
        int count = 0;
        foreach (var item in books)
        {
            count++;
            Console.WriteLine($"{count}.Book Name=> | {item.Name} | Book Author=> {item.Author} | Publisher Name=> {item.PublisherName} | ISBN=> {item.ISBN} | Book Quantity=> {item.Quantity.ToString("$")}");
        }
        Console.WriteLine();
        Console.WriteLine($"The total products in stock is {books.Count}");
        Console.WriteLine();
    }

    public static void AddDeletedBooksToFile(Books books)
    {
        string path = "C:\\Users\\ORIOLOWO\\Documents\\Batch 23 Class\\Library Management System\\Library Management System\\Deleted Books.txt";
        if (File.Exists(path))
        {
            using var writer = new StreamWriter(path, true);
            writer.WriteLine(books.ToString());
        }
        else
        {
            using (File.Create(path))
            {

            }
            using var writer = new StreamWriter(path, true);
            writer.WriteLine(books.ToString());
        }
    }

    public static void RemoveBook()
    {
        Console.Write("ISBN: ");
        string isbn = Console.ReadLine();
        int count = 1;
        foreach (var item in books)
        {
            var book = Convert(item.ToString());
            if (item.ISBN == isbn)
            {
                
                Console.Write("Enter Quantity To Be Removed: ");
                int quantity = int.Parse(Console.ReadLine());
                if (item.Quantity > quantity)
                {
                    item.Quantity -= quantity;
                    Console.WriteLine($"Book Name=> | {item.Name} | Book Author=> {item.Author} | Publisher Name=> {item.PublisherName} | ISBN=> {item.ISBN} | Book Quantity=> {item.Quantity.ToString("$")}");
                    break;
                }
                else if(item.Quantity == quantity)
                {
                    AddDeletedBooksToFile(item);
                    books.Remove(item);
                    break;
                }
                else
                {
                    Console.WriteLine("Insufficient Book.\t Kidly recheck and know the actual amount.");
                }


            }
            if (books.Count == count)
            {
                Console.WriteLine("Book not found");
            }
            count++;
        }
        string path = "C:\\Users\\ORIOLOWO\\Documents\\Batch 23 Class\\Library Management System\\Library Management System\\Book.txt";
        if (File.Exists(path))
        {
            File.WriteAllText(path, string.Empty);

            foreach (var item in books)
            {
                AddToFile(item);
            }

        }
    }


}
