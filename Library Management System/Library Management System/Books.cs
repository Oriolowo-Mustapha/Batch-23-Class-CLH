using System.Diagnostics;
using System.Xml.Linq;

public class Books 
{
    Menu menu = new Menu();
    public static List<Books> books = new List<Books>();
      
    public string Name { get; set; }
    public string Author { get; set; }
    public string PublisherName { get; set; }
    public string ISBN{ get; set; }
    public int Quantity { get; set; }

    public Books()
    {

    }

    public Books(string name, string author, string publisherName, string isbn, int quantity)
    {
        Name = name;
        Author = author;
        PublisherName = publisherName;
        ISBN = isbn;
        Quantity = quantity;
    }
    public override string ToString()
    {
        return $"{Name}\t|\t{Author}\t|\t{PublisherName}\t|\t{ISBN}\t|\t{Quantity}";
    }
   

    

    

    public void CheckTotalNoofbooks(Admin admin)
    {
        if (admin.AdminAccount == admin.Email)
        {
            int count = 0;
            foreach (var book in books)
            {
                count++;
            }
            Console.WriteLine($"You have {count} books");
            Console.WriteLine("Press Any Key To Continue.");
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine("Invalid Account.");
        }
    }

    public void MakeABorrow(User user)
    {
        Borrow borrow = new Borrow();

        Console.Write("Enter Book Name: ");
        string borrowedBookName = Console.ReadLine();
        foreach (var book in books)
        {
            if (book.Name  == borrowedBookName)
            {
                Console.Write("Enter Quantity: ");
                int borrowedQuantity = int.Parse(Console.ReadLine());
                if (borrowedQuantity <= book.Quantity)
                {
                    book.Quantity -= borrowedQuantity;
                    borrow.BorrowBookQuantity = borrowedQuantity;
                    borrow.Email = user.Email;
                    borrow.BorrowedBookName = borrowedBookName;
                    borrow.DateOfCollectionOfBook = DateOnly.FromDateTime(DateTime.Now);
                    borrow.DateOfReturnOfBook = borrow.DateOfCollectionOfBook.AddDays(7);
                    borrow.borrows.Add(borrow);
                    Console.Write("Do you want to still borrow books (Y/N)");
                    char input = char.Parse(Console.ReadLine());

                    while (input == 'y' || input == 'Y')
                    {
                        MakeABorrow(user);
                        Console.WriteLine($"Book Borrowed Successfully to be return on or before {borrow.DateOfReturnOfBook}");
                    }
                    Console.WriteLine($"Book Borrowed Successfully to be return on or before {borrow.DateOfReturnOfBook}");
                    Console.WriteLine("Press Any Key To Continue");
                    Console.ReadKey();

                }
                else
                {
                    Console.WriteLine($"U can't borrow that much u can only borrow up to {book.Quantity} of this particular book. pls try again.");
                    MakeABorrow(user);
                }
            }
        }
        Console.WriteLine("Invalid Book Name.");
        MakeABorrow(user);
    }

    public void ReturnBook(User user)
    {
        Borrow borrow = new Borrow();
        if (user.UserAccount == user.Email)
        {
            Console.Write("Enter Book Name: ");
            string bookName = Console.ReadLine();
            foreach (var borrow1 in borrow.borrows)
            {
                if (borrow1.BorrowedBookName == bookName)
                {
                    Console.Write("Enter Quantity: ");
                    int borrowedQuantity = int.Parse(Console.ReadLine());
                    if (borrowedQuantity < borrow1.BorrowBookQuantity)
                    {
                        borrow1.BorrowBookQuantity -= borrowedQuantity;
                        Console.WriteLine($"Returned Successful.You still have {borrow1.BorrowBookQuantity - borrowedQuantity} books to return.");
                    }
                    else if (borrowedQuantity == borrow1.BorrowBookQuantity)
                    {
                        borrow1.BorrowBookQuantity -= borrowedQuantity;
                        Console.WriteLine($"Returned Successful.");
                    }
                    else
                    {
                        Console.WriteLine("Quantity is more than how much you returned.");
                        ReturnBook(user);
                    }


                }
                else
                {
                    Console.WriteLine("Invalid book name.");
                    ReturnBook(user);
                }
            }
        }
        else
        {
            Console.WriteLine("Invalid account. Pls try and relogin.");
        }
    }
}
