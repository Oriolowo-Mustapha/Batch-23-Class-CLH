public class Account
{
    List<Account> accounts = new List<Account>(); 
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }   
    public string Password { get; set; }
    public int AccountNumber { get; set; }

    public void AddAccount()
    {
        Console.Write("First Name: ");
        string fname = Console.ReadLine();

        Console.Write("Last Name: ");
        string lname = Console.ReadLine();

        Console.Write("Email: ");
        string email = Console.ReadLine();

        Console.Write("Password: ");
        string password = Console.ReadLine();

        Console.Write("Account: ");
        int accNum = int.Parse(Console.ReadLine());

        Account acc = new Account();
        acc.FirstName = fname;
        acc.LastName = lname;
        acc.Email = email;
        acc.Password = password;
        acc.AccountNumber = accNum;

        accounts.Add(acc);
        Console.WriteLine("Account has been added succesfully.");
        Console.WriteLine("Press any key to continue.");
        Console.ReadKey();
    }

    public void GetAccount()
    {
        if (accounts.Count == 0)
        {
            Console.WriteLine("There is no existing account in the list.");
        }
        else
        {
            foreach (var account in accounts)
            {
                Console.WriteLine($"Firstname: {account.FirstName}");
                Console.WriteLine($"Lastname: {account.LastName}");
                Console.WriteLine($"Email: {account.Email}");
                Console.WriteLine($"Password: {account.Password}");
                Console.WriteLine($"Account Number: {account.AccountNumber}");
            }
        }
        Console.WriteLine("Press Any Key To Continue.");
        Console.ReadKey();
    }
}
