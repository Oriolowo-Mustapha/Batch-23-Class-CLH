public class Patient
{
    public int PatientID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }
    public string ContactInfo { get; set; }

    public Patient()
    {
    }

    public Patient(int patientID, string name, int age, string gender, string contactInfo)
    {
        PatientID = patientID;
        Name = name;
        Age = age;
        Gender = gender;
        ContactInfo = contactInfo;
    }

}
