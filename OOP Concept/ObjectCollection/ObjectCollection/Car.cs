public class Car
{
    //field
    List<Car> cars = new List<Car>(); // list of cars, empty list
    //Car[] cars = new Car[10];
    public string Model { get; set; }
    public string Brand { get; set; }

    public void AddCar()
    {
        Console.WriteLine("Enter the model of the car");
        string model = Console.ReadLine();
        Console.WriteLine("Enter the brand of the car");
        string brand = Console.ReadLine();
        //creating an object of Car
        Car car = new Car();
        car.Model = model;
        car.Brand = brand;

        //add the object to the list
        cars.Add(car);
        Console.WriteLine("Car added succesfully");
        Console.WriteLine("Press any key to continue");
        Console.ReadKey();
    }

    //get all cars
    public void GetCars()
    {
        if (cars.Count == 0)
        {
            Console.WriteLine("Currently no cars in the list");
        }
        else
        {
            foreach (var car in cars)
            {
                Console.WriteLine($"Model: {car.Model}  Brand: {car.Brand}");
            }
        }
        Console.WriteLine("Press any key to continue");
        Console.ReadKey();
    }
}