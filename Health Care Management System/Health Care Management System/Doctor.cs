using System.Reflection;

public class Doctor
{
    public int DoctorID { get; set; }
    public string Name { get; set; }    
    public string Specialty { get; set; }
    public string ContactInfo { get; set; }


    public Doctor()
    {

    }

    public Doctor(int doctorID, string name, string specialty, string contactInfo)
    {
        DoctorID = doctorID;
        Name = name;
        Specialty = specialty;
        ContactInfo = contactInfo;
    }

    public override string ToString()
    {
        return $"{DoctorID}\t|\t{Name}\t|\t{Specialty}\t|\t{ContactInfo}";
    }

    
}
