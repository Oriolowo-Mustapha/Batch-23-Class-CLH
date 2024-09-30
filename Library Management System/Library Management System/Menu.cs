public class Menu
{
    
    public void adminMenu(Admin admin)
    {
        Books book = new Books();
        bool run = true;
        while (run)
        {
            Console.WriteLine("1. ADD BOOK");
            Console.WriteLine("2. REMOVE BOOK. ");
            Console.WriteLine("3. VIEW BOOKS.");
            Console.WriteLine("4. CHECK TOTAL NUMBER OF BOOKS.");
            Console.WriteLine("5. LOGOUT");
            Console.WriteLine("CHOOSE AN AN OPTION.");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    FileBook.AddBook(admin);
                    break;
                case "2":
                    FileBook.RemoveBook();
                    break;
                case "3":
                    FileBook.RetrieveFromFile();
                    FileBook.ViewBook();
                    break;
                case "4":
                    book.CheckTotalNoofbooks(admin);
                    break;
                case "5":
                    run = false;
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }

        }
        Mainmenu();
    }
    public void userMenu(User loggedInUser)
    {
        User user = new User();
        Borrow borrow = new Borrow();
        Books book = new Books();
        bool run = true;
        while (run)
        {

            Console.WriteLine("1. BORROW BOOK");
            Console.WriteLine("2. RETURN BOOK. ");
            Console.WriteLine("3. VIEW BOOKS.");
            Console.WriteLine("4. LOGOUT");
            Console.WriteLine("CHOOSE AN AN OPTION.");
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    book.MakeABorrow(loggedInUser);
                    break;
                case "2":
                    book.ReturnBook(loggedInUser);
                    break;
                case "3":
                    FileBook.RetrieveFromFile();
                    FileBook.ViewBook();
                    break;
                case "4":
                    run = false;
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        }
        Mainmenu();
    }

    public void Mainmenu()
    {
        User user = new User();
        bool running = true;
        while (running)
        {
            Console.WriteLine("1. SIGN UP. ");
            Console.WriteLine("2. LOGIN.");
            Console.WriteLine("3. Exit.");
            Console.WriteLine("CHOOSE AN AN OPTION.");
            string opt = Console.ReadLine();

            
            switch (opt)
            {
                case "1":
                    user.Register();
                    break;
                case "2":
                    AllocateEmail();
                    break;
                case "3":
                    running = false;
                    break;
                default:
                    Console.WriteLine("INVALID INPUT.");
                    break;
            }
        }
    }

    public void AllocateEmail()
    {
        User user = new User();
        Admin admin = new Admin();
        Menu menu = new Menu();

        Console.Write("Email: ");
        string email = Console.ReadLine();

        Console.Write("Password: ");
        string password = Console.ReadLine();

        while (admin.Email  == email)
        {
            if (admin.Password == password )
            {
                var loggedInAdmin = admin.Login(email, password);
                menu.adminMenu(loggedInAdmin);
            }
            else
            {
                Console.WriteLine("Password Does Not Match.\tPls Relogin.");
                break;
            }
            break;
        }
        var loggedInUser = user.Login(email, password);
        while (loggedInUser != null)
        {
            menu.userMenu(loggedInUser);
        }
        Console.WriteLine("INVALID ACCOUNT DELTAILS");
        AllocateEmail();

    }

}
