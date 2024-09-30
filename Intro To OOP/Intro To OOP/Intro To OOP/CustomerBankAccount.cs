public class CustomerBankAccount
{
    public string CustomerName { get; set; }
    public string CustomerEmail { get; set; }
    public int CustomerPhone { get; set; }
    public string CustomerCity { get; set; }    
    public string CustomerRegion { get; set; }  
    public int CustomerPostalCode { get; set;}
    public string CustomerCountry { get; set; } 
    public int CustomerAccNumber { get; set; }

    public CustomerBankAccount(string customerName, string customerEmail, int customerPhone, string customerCity, string customerRegion, int customerPostalCode, string customerCountry, int customerAccNumber)
    {
        CustomerName = customerName;
        CustomerEmail = customerEmail;
        CustomerPhone = customerPhone;
        CustomerCity = customerCity;
        CustomerRegion = customerRegion;
        CustomerPostalCode = customerPostalCode;
        CustomerCountry = customerCountry;
        CustomerAccNumber = customerAccNumber;
    }

    public CustomerBankAccount(string customerName, string customerEmail, int customerPhone, string customerCountry, int customerAccNumber)
    {
        CustomerName = customerName;
        CustomerEmail = customerEmail;
        CustomerPhone = customerPhone;
        CustomerCountry = customerCountry;
        CustomerAccNumber = customerAccNumber;
    }
}

