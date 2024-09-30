public class Transactions
{
    public List<Transactions>  transactions = new List<Transactions>();
    public DateTime TransactionDate { get; set; }
    public string SenderAccount { get; set; }
    public string RecieverAccount { get; set; }
    public Guid TransactionReference { get; set; }
    public string TransactionStatus { get; set; }
    public string Narration { get; set; }
    public double TrasactionAmount { get; set; }

    public Transactions()
    {
    }
    public Transactions(DateTime transactionDate, string senderAccount, string recieverAccount, Guid transactionReference, string transactionStatus, string narration, double trasactionAmount)
    {
        TransactionDate = transactionDate;
        SenderAccount = senderAccount;
        RecieverAccount = recieverAccount;
        TransactionReference = transactionReference;
        TransactionStatus = transactionStatus;
        Narration = narration;
        TrasactionAmount = trasactionAmount;
    }



}