var students = new List<Student>()
{
    new Student
    {
        Name = "Tobi",
        Age = 12,
        Gender = "Female"
    },
    new Student
    {
        Name = "Ade",
        Age = 13,
        Gender = "Male"
    },
    new Student
    {
        Name = "Bola",
        Age = 15,
        Gender = "Male"
    },
    new Student
    {
        Name = "Tola",
        Age = 12,
        Gender = "Female"
    },
    new Student
    {
        Name = "Goriola",
        Age = 50,
        Gender = "Male"
    },
    new Student
    {
        Name = "Fola",
        Age = 23,
        Gender = "Male"
    },

};
//PrintAllDetails("List Of All The Students", students);
static void PrintAllDetails(string title, List<Student> students)
{
foreach (var student in students)
{
    Console.WriteLine(student);
}
}

static void PrintDetailsUsingDelegate(string title, List<Student> students, MyDelegate myFilter)
{
    foreach (var student in students)
    {
        if (myFilter(student))
        {
            Console.WriteLine(student);
        }
    }
}
static bool isMale(Student student)
{
    return student.Gender.Equals("Male") && student.Age > 20;
}

//MyDelegate femaleDelegate = delegate (Student student)
//{
//    return student.Gender.Equals("Female");
//};
//PrintDetailsUsingDelegate("Female Student", students, femaleDelegate);

MyDelegate femaleLessThan20 = (Student student) =>
{
    return student.Gender.Equals("Female") && student.Age < 20;
};
PrintDetailsUsingDelegate("Female Student Less Than 20", students, femaleLessThan20);

MyDelegate femaleLessThan202 = (Student student) => student.Gender.Equals("Female") && student.Age < 20;

PrintDetailsUsingDelegate("Female Student Less Than 20", students, femaleLessThan202);

PrintDetailsUsingDelegate("Male with a starting their name: ", students, st => st.Name.StartsWith("a") && st.Gender.Equals("Male"));


MyDelegate isMale20 = delegate (Student student)
{
    return student.Gender.Equals("Male") && student.Age>20;
};
PrintDetailsUsingDelegate("Female Student", students, isMale20);
//MyDelegate md = new MyDelegate(isMale);
//PrintDetailsUsingDelegate("Male Student above 20", students, md);
public delegate bool MyDelegate(Student student);
public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }

    public override string ToString()
    {
        return $"Name: {Name}\tAge: {Age}\tGender: {Gender}";
    }
}
