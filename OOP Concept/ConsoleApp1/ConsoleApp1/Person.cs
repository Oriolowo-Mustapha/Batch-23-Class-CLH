﻿public abstract class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }

    public abstract int AddNum(int c, int d); 
}