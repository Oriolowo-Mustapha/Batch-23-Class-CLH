public class Product
{
    public string Name { get; set;}
    public string BrandName { get; set;}
    public string Category { get; set;}
    public double Price { get; set;}  

    public Product(string name,string brandName,string category,double price)
    {
        Name = name;
        BrandName = brandName;
        Category = category;
        Price = price;
    }

    public Product() { }

    public override string ToString()
    {
        return $"{Name}|{BrandName}|{Category}|{Price}";
        
    }

}