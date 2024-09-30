using System.Security.Claims;

public class ProductManager
{
    Product product = new Product();
    private static List<Product> products = new List<Product>();
    private static List<Product> Deletedproducts = new List<Product>();

    public  void AddProduct()
    {
        int count = 0;
        Console.Write("How many Product do u want to add: ");
        int input = int.Parse(Console.ReadLine());

        for (int i = 0; i < input; i++)
        {
            Console.Write("Product Name: ");
            string newName = Console.ReadLine();
            Console.Write("Brand Name:  ");
            string newBrand = Console.ReadLine();
            Console.Write("Category: ");
            string newCategory = Console.ReadLine();
            Console.Write("Price: ");
            double newPrice = double.Parse(Console.ReadLine());
            var product1 = new Product(newName, newBrand, newCategory, newPrice);

             products.Add(product1);
             AddToFile(product1);
            Console.WriteLine();
            count++;
        }
        Console.WriteLine();
        Console.WriteLine($"You Have Successfully Added {count} product");
        Console.WriteLine($"You Have {count} product naw");

    }

    public static void AddToFile(Product product)
    {
        string path = "C:\\Users\\ORIOLOWO\\Documents\\Batch 23 Class\\FileConversion\\FileConversion\\product.txt";

        if (File.Exists(path))
        {
            using var writer = new StreamWriter(path, true);
            writer.WriteLine(product.ToString());
        }
        else
        {
            using (File.Create(path))
            {

            }
            using var writer = new StreamWriter(path, true);
            writer.WriteLine(product.ToString());
        }
    }

    public static Product Convert(string product)
    {
        var data  = product.Split("|");
        return new Product(data[0], data[1], data[2], double.Parse(data[3]));
    }

    public static List<Product> RetrieveFromFile()
    {
        var listOfProducts = new List<Product>();
        string path = "C:\\Users\\ORIOLOWO\\Documents\\Batch 23 Class\\FileConversion\\FileConversion\\product.txt";
        if (File.Exists(path))
        {
            using var streamReader = new StreamReader(path, true);
            var datas = File.ReadAllLines(path);
            foreach (var item in datas)
            {
                var convert = Convert(item);
                listOfProducts.Add(convert);
            }
            
        }
        products = listOfProducts;
        return listOfProducts;
    }

    public static  void GetAll()
    {
        foreach (var item in products)
        {
            Console.WriteLine($"Product Name => {item.Name}\nBrand Name => {item.BrandName}\nCategory => {item.Category}\n Price => {item.Price}");
        }
    }

    public static void GetProduct(string productName)
    {
        int count = 1;
        foreach (var item in products)
        {
            var product = Convert(item.ToString());
            count++;
            if (product.Name == productName)
            {
                Console.WriteLine($"Product Name => {item.Name}\nBrand Name => {item.BrandName}\nCategory => {item.Category}\n Price => {item.Price}");
                break;
            }
            if (products.Count == count-1)
            {
                Console.WriteLine("Product not available");
            }
            count++;
        }
    }

    public static void AddStockDeletedToFile(Product product)
    {
        string path = "C:\\Users\\ORIOLOWO\\Documents\\Batch 23 Class\\FileConversion\\FileConversion\\product.txt";

        if (File.Exists(path))
        {
            using var writer = new StreamWriter(path, true);
            writer.WriteLine(product.ToString());
        }
        else
        {
            using (File.Create(path))
            {

            }
            using var writer = new StreamWriter(path, true);
        }
    }

    public static void RemoveProduct()
    {
        Console.WriteLine("How many product do u want to remove: ");
        int input = int.Parse(Console.ReadLine());
        int count = 0;
        for (int i = 0; i < input; i++)
        {
            Console.WriteLine("Enter Product Name: ");
            string productName = Console.ReadLine();

            foreach (var item in products)
            {
                if (item.Name == productName)
                {
                    AddStockDeletedToFile (item);
                    products.Remove(item);
                    count++;
                    break;
                }
            }
        }
        string path = "C:\\Users\\ORIOLOWO\\Documents\\Batch 23 Class\\FileConversion\\FileConversion\\product.txt";
        if (File.Exists(path))
        {
            File.WriteAllText(path, string.Empty);
            foreach (var item in products)
            {
                AddToFile(item);
            }
        }Console.WriteLine($"You have successfully removed {count} product");
    }
    public static Product ConvertDeletedStock(string product)
    {
        var data = product.Split("|");
        return new Product(data[0], data[1], data[2], double.Parse(data[3]));
    }

    public static List<Product> RetrieveDeletedStockFromFile()
    {
        var listOfDeletedProducts = new List<Product>();
        string path = "C:\\Users\\ORIOLOWO\\Documents\\Batch 23 Class\\FileConversion\\FileConversion\\Deletedstock.txt";
        if (File.Exists(path))
        {
            //using var streamReader = new StreamReader(path, true);
            var datas = File.ReadAllLines(path);
            foreach (var item in datas)
            {
                var convert = ConvertDeletedStock(item);
                listOfDeletedProducts.Add(convert);
            }

        }
        
        Deletedproducts = listOfDeletedProducts;
        return listOfDeletedProducts;
    }

    public static void GetAllDeletedProduct()
    {
        foreach (var item in Deletedproducts)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
        Console.WriteLine($"The total products removed is {Deletedproducts.Count}");
        Console.WriteLine();
    }

    public static void UpdateProduct(string productName)
    {
        int count = 1;
        foreach (var item in products)
        {
            var product = Convert(item.ToString());
            count++;
            if (product.Name == productName)
            {
                Console.Write("Product Name: ");
                string newName = Console.ReadLine();
                Console.Write("Brand Name:  ");
                string newBrand = Console.ReadLine();
                Console.Write("Category: ");
                string newCategory = Console.ReadLine();
                Console.Write("Price: ");
                double newPrice = double.Parse(Console.ReadLine());

                item.Name = newName;
                item.Price = newPrice;
                item.BrandName = newBrand;
                item.Category = newCategory;
                break;
            }
            if (products.Count == count)
            {
                Console.WriteLine("Product not available");
            }
        }
        string path = "C:\\Users\\ORIOLOWO\\Documents\\Batch 23 Class\\FileConversion\\FileConversion\\product.txt";
        if (File.Exists(path))
        {
            File.WriteAllText(path, string.Empty);
            foreach (var item in products)
            {
                AddToFile(item);
            }
        }
    }
}