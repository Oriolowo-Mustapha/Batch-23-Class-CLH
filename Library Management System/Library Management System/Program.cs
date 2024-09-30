using System;
namespace LibraryManagementSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            Admin admin = new Admin();
            Books book = new Books();
            Menu menu = new Menu();
            Console.WriteLine("WELCOME TO LIBRARY MANAGEMENT SYSTEM");
            menu.Mainmenu();
        }
        
    }
}

