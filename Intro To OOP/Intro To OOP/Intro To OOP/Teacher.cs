public class Teacher
{
    public string Name { get; set; }    
    public char Gender { get; set; }
    public int Age { get; set; }
    public string Rank { get; set; }
    public string AreaOfDiscipline { get; set; }

    public Teacher(string name, char gender, int age, string rank, string area)
    {
        Name = name;
        Gender = gender;
        Age = age;
        Rank = rank;
        AreaOfDiscipline = area;
    }

    public Teacher(string name, char gender, int age, string area)
    {
        Name = name;
        Gender = gender;
        Age = age;
        AreaOfDiscipline = area;
    }
}

