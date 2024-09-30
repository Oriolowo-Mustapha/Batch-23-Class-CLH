public class School
{
    public string NameOfSchool { get; set; }
    public int NoOfClasses { get; set;}
    public int NoOfLaboratories { get; set;}
    public int NoOfTeachers { get; set;}
    public int NoOfStudents { get; set;}

    public School(string name, int nClass, int nLab,int nTeach, int nStud) 
    { 
        NameOfSchool = name;
        NoOfClasses = nClass;
        NoOfLaboratories = nLab;
        NoOfTeachers = nTeach;
        NoOfStudents = nStud;
    }

    public School(string name, int nClass, int nTeach, int nStud)
    {
        NameOfSchool = name;
        NoOfClasses = nClass;
        NoOfTeachers = nTeach;
        NoOfStudents = nStud;
    }
}