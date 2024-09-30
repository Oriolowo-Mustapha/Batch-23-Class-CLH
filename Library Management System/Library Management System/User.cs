using System.Xml.Linq;

public class User
{
    private static List<User> users = new List<User>();
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public int PhoneNumber { get; set; }
    public string UserAccount { get; set; }

    public User()
    {

    }

    public User(string firstName, string lastName, string email, string password, int phoneNumber, string userAccount)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Password = password;
        PhoneNumber = phoneNumber;
        UserAccount = userAccount;
    }

    public override string ToString()
    {
        return $"{FirstName}\t|\t{LastName}\t|\t{Email}\t|\t{Password}\t|\t{PhoneNumber}\t|\t{UserAccount}";
    }

    public void Register()
    {
        Console.Write("FirstName: ");
        string firstName = Console.ReadLine();

        Console.Write("LastName: ");
        string lastName = Console.ReadLine();

        Console.Write("Email: ");
        string email = Console.ReadLine();

        Console.Write("Password: ");
        string password = Console.ReadLine();

        Console.Write("Phone Number: ");
        int phoneNumber = int.Parse(Console.ReadLine());

        foreach (var useracc in users)
        {
            if (useracc.Email == email)
            {
                Console.WriteLine("Account Already Existed. Pls Login");
            }
        }
        User user = new User(firstName, lastName, email, password, phoneNumber, email);
        users.Add(user);
        AddToFile(user);
        Console.WriteLine("User Registered Successfully.");
        Console.WriteLine("Press Any Key To Continue.");
        Console.ReadKey();
    }

    public static void AddToFile(User user)
    {
        string path = "C:\\Users\\ORIOLOWO\\Documents\\Batch 23 Class\\Library Management System\\Library Management System\\Users.txt";
        if (File.Exists(path))
        {
            using var writer = new StreamWriter(path, true);
            writer.WriteLine(user.ToString());
        }
        else
        {
            using (File.Create(path))
            {

            }
            using var writer = new StreamWriter(path, true);
            writer.WriteLine(user.ToString());
        }
    }
    public static List<User> RetrieveFromFile()
    {
        var listOfUsers = new List<User>(); //to retrieve file content
        string path = "C:\\Users\\ORIOLOWO\\Documents\\Batch 23 Class\\Library Management System\\Library Management System\\Users.txt";
        if (File.Exists(path))
        {
            //using var reader = new StreamReader(path, true);
            var datas = File.ReadAllLines(path);
            foreach (var data in datas)
            {
                var convert = Convert(data);
                listOfUsers.Add(convert);
            }
        }
        users = listOfUsers; //repopulate
        return listOfUsers;
    }

    public static User Convert(string product) // convert back to object
    {
        var data = product.Split("\t|\t");
        return new User(data[0], data[1], data[2], data[3], int.Parse(data[4]), data[5]);
    }

    public User Login(string email, string password)
    {
        RetrieveFromFile();
        foreach (var user in users)
        {
            if (user.Email == email && user.Password == password)
            {
                return user;
            }
        }
        return null;
    }

    
}