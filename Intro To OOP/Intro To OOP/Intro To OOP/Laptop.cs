public class Laptop
{
    public string Name { get; set; }
    public string Colour { get; set; }
    public double Price { get; set; }
    public int RamSize { get; set; }
    public string Model { get; set; }

    public void ToCall()
    {
        Console.WriteLine("A Laptop can be used for call.");
    }

    public void ToGame()
    {
        Console.WriteLine("A Laptop can be used to play games.");
    }


    public void ToCode()
    {
        Console.WriteLine("A Laptop can be used to write code.");
    }
}