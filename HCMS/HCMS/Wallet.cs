public class Wallet
{
    public int Id { get; set; }
    public double Balance { get; set; }
    public string Status { get; set; }
    public int UserId { get; set; }

    public Wallet()
    {

    }

    public Wallet(int id, double balance, string status, int userid)
    {
        Id = id;
        Balance = balance;
        Status = status;
        UserId = userid;
    }
}


