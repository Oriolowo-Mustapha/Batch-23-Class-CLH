public class Food
{
    public string NameOfFood { get; set; }
    public int Price { get; set; }
    public bool IsSwallow { get; set; }

    public Food(string name, int price, bool isSwallow) 
    {
        NameOfFood = name;
        Price = price;
        IsSwallow = isSwallow;    
    }
    public Food(string name, int price)
    {
        NameOfFood = name;
        Price = price;
    }
}