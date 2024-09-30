using System.Security.Cryptography.X509Certificates;

public class Admin
{
    public string Email {  get; set; }  
    public string Password { get; set; }
    public string AdminAccount { get; set; }    

    
    public Admin()
    {
        Email = "admin@gmail.com";
        Password = "admin";
        AdminAccount = "admin@gmail.com";

    }


    public Admin Login(string email, string password)
    {
        Admin admin = new Admin();
        if (admin.Email == email )
        {
            if (password == admin.Password)
            {
                return admin;
            }
            else
            {
                return null;
            }
        }
        else
        {
            return null;
        }
    }

   
}