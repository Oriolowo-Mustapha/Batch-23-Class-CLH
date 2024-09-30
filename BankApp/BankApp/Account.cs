public class Account 
{
    // 
    static List<Account> accounts = new List<Account>();
    public string AccountNumber { get; set; }
    public string BVN { get; set; }
    public string NIN { get; set; }
    public string AccountName { get; set; }
    public double Balance { get; set; }
    public DateTime DateOpened { get; set; }
    public string AccountType { get; set; }
    public string AccountStatus { get; set; }
    public string AccountHolder { get; set; }
    public int Pin { get; set; }

    public Account()
    {

    }

    public Account(string accountNumber, string accountName, string accountHolder, string bvn, string nin, string accountType, int pin)
    {
        AccountNumber = accountNumber;
        AccountName = accountName;
        AccountHolder = accountHolder;
        BVN = bvn;
        NIN = nin;
        AccountType = accountType;
        Balance = 0.0;
        DateOpened = DateTime.Now;
        AccountStatus = "Active";
        Pin = pin;
    }

    public void OpenAccount(User user)
    {
        Console.Write("Enter account type (Savings/Current): ");
        string accountType = Console.ReadLine();
        Console.WriteLine("Enter BVN: ");
        string bvn = Console.ReadLine();
        Console.WriteLine("Enter NIN: ");
        string nin = Console.ReadLine();
        Console.WriteLine("Enter PIN: ");
        int pin = int.Parse(Console.ReadLine());
        Random random = new Random();
        string accountNumber = random.Next(10000, 99999).ToString();
        string accountName = $"{user.FirstName} {user.LastName}";
        Account account = new Account(accountNumber, accountName, user.Email, bvn, nin, accountType, pin);
        accounts.Add(account);
        Console.WriteLine($"Account created successfully\nAccount Number: {accountNumber}");
    }

    public void ViewUserAccounts(User user)
    {
        //empty list of user accounts
        List<Account> userAccounts = new List<Account>();
        foreach (var account in accounts)
        {
            if (account.AccountHolder == user.Email)
            {
                userAccounts.Add(account);
            }
        }

        if (userAccounts.Count == 0)
        {
            Console.WriteLine("Currently, you do not have any account");
        }
        else
        {
            Console.WriteLine("LIST OF MY ACCOUNTS");
            foreach (var account in userAccounts)
            {
                Console.WriteLine($"AccountHolder --> {account.AccountHolder}\nAccount Number --> {account.AccountNumber}\nBalance --> {account.Balance}\nStatus --> {account.AccountStatus}\n");
            }
        }
    }

    public void Deposit(User user)
    {
        Console.Write("Enter account number: ");
        string accountNumber = Console.ReadLine();
        //check the account
        foreach (var account in accounts)
        {
            //check if the account exist and the user is the owner of the account
            if (account.AccountNumber == accountNumber && account.AccountHolder == user.Email)
            {
                if (account.AccountStatus == "Active")
                {
                    Console.Write("Enter deposit amount: ");
                    double amount = double.Parse(Console.ReadLine());
                    Console.Write("Enter pin : ");
                    int pin = int.Parse(Console.ReadLine());
                    if (account.Pin == pin)
                    {
                        account.Balance += amount;
                        Console.WriteLine("Deposit successful.");
                        Console.WriteLine($"Balance --> {account.Balance}");
                        Console.WriteLine("Press Any Key To Continue: ");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Invalid Pin");
                        Console.Write("Enter pin : ");
                        pin = int.Parse(Console.ReadLine());
                    }

                }
                else
                {
                    Console.WriteLine("Account is InActive. Transaction can not be completed");
                }
            }
            Console.WriteLine("Account is invalid!");
            Console.Write("Enter account number: ");
            accountNumber = Console.ReadLine();
        }
        
    }

    public void Withdrwal(User user)
    {
        Console.Write("Enter account number: ");
        string accountNumber = Console.ReadLine();
        //Check the account
        foreach (var account in accounts)
        {
            //Check if the account exist and the user is the owner of the account
            if (account.AccountNumber == accountNumber && account.AccountHolder == user.Email)
            {
                // Check if the account is active
                if (account.AccountStatus == "Active")
                {
                    Console.Write("Enter withdrwal amount: ");
                    double amount = double.Parse(Console.ReadLine());
                    if (amount > account.Balance)
                    {
                        Console.WriteLine("Insufficient Balance.Pls TryAgain");
                        Console.Write("Enter withdrwal amount: ");
                        amount = double.Parse(Console.ReadLine());
                    }
                    else
                    {
                        Console.Write("Enter Pin : ");
                        int pin = int.Parse(Console.ReadLine());
                        if (account.Pin == pin)
                        {
                            account.Balance -= amount;
                            Console.WriteLine("Withdrawal Successful.");
                            Console.WriteLine($"Balance --> {account.Balance}");
                            Console.WriteLine("Press Any Key To Continue: ");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Invalid Pin");
                            Console.Write("Enter pin : ");
                            pin = int.Parse(Console.ReadLine());
                        }
                    }

                }
                else
                {
                    Console.WriteLine("Account is InActive. Transaction can not be completed");
                }
            }
        }
        Console.WriteLine("Account is invalid!");
        Console.Write("Enter account number: ");
        accountNumber = Console.ReadLine();
    }

    public void Transfer(User user)
    {
        Transactions transaction = new Transactions();
        Guid guid = Guid.NewGuid();
        foreach (var account in accounts)
        {
            if (account.AccountStatus == "Active")
            {
                Console.WriteLine("Enter Recievers Account Number: ");
                string recieversAccNo = Console.ReadLine();
                if (recieversAccNo.Length > 5)
                {
                    Console.WriteLine("Invalid Account Number.");
                    Console.WriteLine("Enter Recievers Account Number: ");
                    recieversAccNo = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Enter Amount: ");
                    int amount = int.Parse(Console.ReadLine());

                    Console.WriteLine("Narration: ");
                    string narration = Console.ReadLine();

                    Console.Write("Enter Pin: ");
                    int pin = int.Parse(Console.ReadLine());
                    if (account.Pin == pin)
                    {
                        if (account.Balance < amount)
                        {
                            Console.WriteLine("Insufficient Fund");
                            transaction.TransactionStatus = "Failed";
                            Console.WriteLine("Enter Amount: ");
                            amount = int.Parse(Console.ReadLine());
                        }
                        else
                        {
                            account.Balance -= amount;
                            transaction.SenderAccount = account.AccountNumber;
                            transaction.RecieverAccount = recieversAccNo;
                            transaction.TransactionDate = DateTime.Now;
                            transaction.Narration = narration;
                            transaction.TransactionStatus = "Successful";
                            transaction.TrasactionAmount = amount;
                            transaction.TransactionReference = guid;
                            transaction.transactions.Add(transaction);

                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid Pin.");
                    }



                }
            }
        }
    }

    public void ViewBalance(User user)
    {
        foreach (var account in accounts)
        {
            if (account.AccountHolder == user.Email && account.AccountStatus == "Active") 
            {
                Console.WriteLine("Enter Account Number: ");
                string accountNumber = Console.ReadLine();
                if (account.AccountNumber == accountNumber && accountNumber.Length == 5)
                {
                    Console.WriteLine("Enter Pin: ");
                    int pin = int.Parse(Console.ReadLine());
                    if (pin == account.Pin)
                    {
                        Console.WriteLine($"Account Balance --> {account.Balance}");
                        Console.WriteLine("Press Any Key To Continue.");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Invalid Pin.Pls TryAgain");
                        Console.WriteLine("Enter Pin: ");
                        pin = int.Parse(Console.ReadLine());
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Account Number.Pls TryAgain");
                    Console.WriteLine("Enter Account Number: ");
                    accountNumber = Console.ReadLine();
                }
            }
            Console.WriteLine("Invalid Account Details.Pls TryAgain");
        }
    }
}