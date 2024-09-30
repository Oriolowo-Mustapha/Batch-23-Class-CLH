User UserManager = new User();
Account AccountManager = new Account();

Console.WriteLine("Welcome to MarineFord Banking System");

bool running = true;

while (running)
{
    Console.WriteLine("1. REGISTER");
    Console.WriteLine("2. LOGIN");
    Console.WriteLine("3. EXIT");
    Console.Write("CHOOSE AN OPTION: ");
    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            UserManager.RegisterUser();
            break;
        case "2":
            var loggedInUser = UserManager.LoginUser();
            if (loggedInUser != null)
            {
                bool run = true;
                while (run)
                {
                    Console.WriteLine("1. OPEN ACCOUNT");
                    Console.WriteLine("2. VIEW ACCOUNT");
                    Console.WriteLine("3. DEPOSIT");
                    Console.WriteLine("4. WITHDRAWL");
                    Console.WriteLine("5. TRANSFER");
                    Console.WriteLine("6. VIEW BALANCE");
                    Console.WriteLine("7. CLOSE ACCOUNT");
                    Console.WriteLine("8. EXIT");
                    Console.Write("CHOOSE AN OPTION: ");
                    string input = Console.ReadLine();

                    switch (input)
                    {
                        case "1":
                            AccountManager.OpenAccount(loggedInUser);
                            break;
                        case "2":
                            AccountManager.ViewUserAccounts(loggedInUser);
                            break;
                        case "3":
                            AccountManager.Deposit(loggedInUser);
                            break;
                        case "4":
                            AccountManager.Withdrwal(loggedInUser);
                            break;
                        case "5":
                            AccountManager.Transfer(loggedInUser);
                            break;
                        case "6":
                            AccountManager.ViewBalance(loggedInUser);
                            break;
                        default:
                            Console.WriteLine("Invalid option.");
                            break;
                    }
                }
            }
            break;
        case "3":
            running = false;
            break;
        default:
            Console.WriteLine("Invalid option.");
            break;
    }
}