// COLLECTIONS OF OBJECT

// int[] numbers = new int[5];  //int is an alias of Int32 class
// Car[] cars= new Car[5]; //array of cars
// List<int> numberList= new List<int>();
// List<int> numbersList1 = new();
// List<int> numbersList2 = [];
// List<Car> carsList = new List<Car>();
// List<Car> cars1 = new();
// List<Car> cars2 = [];

//Car carManager = new Car();\
//Account accounManager = new Account();
//Book book = new Book();
Student stud = new Student();

bool running = true;

while (running)
{
    //Console.Clear();
    //Console.WriteLine("Welcome to Car Management APP");
    //Console.WriteLine("1. Add Car");
    //Console.WriteLine("2. Display All Cars");
    //Console.WriteLine("3. Exit");

    //Console.WriteLine("Choose an option");

    //string option = Console.ReadLine();

    //switch (option)
    //{
    //    case "1":
    //        carManager.AddCar();
    //        break;
    //    case "2":
    //        carManager.GetCars();
    //        break;
    //    case "3":
    //        running = false;
    //        break;

    //    default:
    //        Console.WriteLine("Invalid option, try again");
    //        break;
    //}

    //Console.Clear();
    //Console.WriteLine("Welcome to Account Management APP");
    //Console.WriteLine("1. Add Account");
    //Console.WriteLine("2. Display All Accounts");
    //Console.WriteLine("3. Exit");

    //Console.WriteLine("Choose an option");

    //string option = Console.ReadLine();

    //switch (option)
    //{
    //    case "1":
    //        accounManager.AddAccount();
    //        break;
    //    case "2":
    //        accounManager.GetAccount();
    //        break;
    //    case "3":
    //        running = false;
    //        break;

    //    default:
    //        Console.WriteLine("Invalid option, try again");
    //        break;
    //}

    //Console.Clear();
    //Console.WriteLine("Welcome to Library Management APP");
    //Console.WriteLine("1. Add Books");
    //Console.WriteLine("2. Display All Books");
    //Console.WriteLine("3. Exit");

    //Console.WriteLine("Choose an option");

    //string option = Console.ReadLine();

    //switch (option)
    //{
    //    case "1":
    //        book.AddBook();
    //        break;
    //    case "2":
    //        book.GetBook();
    //        break;
    //    case "3":
    //        running = false;
    //        break;

    //    default:
    //        Console.WriteLine("Invalid option, try again");
    //        break;
    //}

    Console.Clear();
    Console.WriteLine("Welcome to Student Management APP");
    Console.WriteLine("1. Add Student");
    Console.WriteLine("2. Display All Student");
    Console.WriteLine("3. Exit");

    Console.WriteLine("Choose an option");

    string option = Console.ReadLine();

    switch (option)
    {
        case "1":
            stud.AddStud();
            break;
        case "2":
            stud.GetStud();
            break;
        case "3":
            running = false;
            break;

        default:
            Console.WriteLine("Invalid option, try again");
            break;
    }

}