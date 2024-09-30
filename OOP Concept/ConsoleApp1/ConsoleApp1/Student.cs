public class Student : Person
{
    public string StudentNumber {  get; set; }

    public override int AddNum(int c, int d)
    {
        return c + d;
    }
}
