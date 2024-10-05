public class Admin
{
    public int ID { get; set; }



    public Admin()
    {
        ID = 1234;

    }


    public static Admin Login(int id)
    {
        Admin admin = new Admin();
        if (admin.ID == id)
        {
            return admin;
        }
        else
        {
            return null;
        }
    }
}

