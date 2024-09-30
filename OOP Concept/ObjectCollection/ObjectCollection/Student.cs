public class Student
{
    List<Student> students = new List<Student>();
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int AdmisNo { get; set; }

    public void AddStud()
    {
        Console.WriteLine("STUDENT CREDENTIALS");
        Console.Write("First Name: ");
        string fname = Console.ReadLine();

        Console.Write("Last Name: ");
        string lname = Console.ReadLine();

        Console.Write("Addmission NO: ");
        int addNo = int.Parse(Console.ReadLine());

        Student student = new Student();
        student.FirstName = fname;
        student.LastName = lname;
        student.AdmisNo = addNo;

        students.Add(student);
        Console.WriteLine("Student have been added successfully.");
        Console.Write("Press any key to continue");
        Console.ReadKey();
    }

    public void GetStud()
    {
        if (students.Count == 0)
        {
            Console.WriteLine("There is no record of any the student in the List. ");
        }
        else
        {
            foreach (var item in students)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName}");
                Console.WriteLine("Admission Number: " + item.AdmisNo);
            }
        }
        Console.Write("Press any key to continue");
        Console.ReadKey();
    }

}