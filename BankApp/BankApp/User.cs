public class User
{
    // List of users
    static List<User> users = new List<User>();
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string PhoneNumber { get; set; }
    public string Address { get; set; }
    public string State { get; set; }
    public string Country { get; set; }
    public string Gender { get; set; }
    public string Password { get; set; }

    public User()
    { }
    public User(string firstName, string lastName, string email, DateTime dateOfBirth, string phoneNumber, string address, string state, string country, string gender, string password)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        DateOfBirth = dateOfBirth;
        PhoneNumber = phoneNumber;
        Address = address;
        State = state;
        Country = country;
        Gender = gender;
        Password = password;
    }

    public void RegisterUser()
    {
        Console.Write("First Name: ");
        string firstName = Console.ReadLine();
        Console.Write("Last Name: ");
        string lastName = Console.ReadLine();
        Console.Write("Email: ");
        string email = Console.ReadLine();
        Console.Write("Date of Birth: ");
        DateTime dateOfBirth = DateTime.Parse(Console.ReadLine());
        Console.Write("Phone Number: ");
        string phoneNumber = Console.ReadLine();
        Console.Write("Address: ");
        string address = Console.ReadLine();
        Console.Write("State: ");
        string state = Console.ReadLine();
        Console.Write("Country: ");
        string country = Console.ReadLine();
        Console.Write("Gender: ");
        string gender = Console.ReadLine();
        Console.Write("Password: ");
        string password = Console.ReadLine();

        var user = new User(firstName, lastName, email, dateOfBirth, phoneNumber, address, state, country, gender, password);
        users.Add(user);

        Console.WriteLine("User registered successfully.");
        Console.WriteLine("Press Any Key To Continue");
        Console.ReadKey();
    }

    public User LoginUser()
    {
        Console.Write("Email: ");
        string email = Console.ReadLine();
        Console.Write("Password: ");
        string password = Console.ReadLine();

        foreach (var user in users)
        {
            if (user.Email == email && user.Password == password)
            {
                Console.WriteLine($"Welcome, {user.FirstName}!");
                return user;
            }
        }
        Console.WriteLine("Invalid login credentials. Try again");
        return null;
    }
}