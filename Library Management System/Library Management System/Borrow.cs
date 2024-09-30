public class Borrow 
{
    public List<Borrow> borrows = new List<Borrow>();
    
    public DateOnly DateOfCollectionOfBook { get; set; }
    public DateOnly DateOfReturnOfBook { get; set; }
    public string Email { get; set; }
    public string BorrowedBookName { get; set; }   
    public int BorrowBookQuantity { get; set; } 
    
}
