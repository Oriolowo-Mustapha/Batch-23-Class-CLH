public class Doctor
{
    public int DoctorID { get; set; }
    public string Name { get; set; }
    public string Specialty { get; set; }
    public string ContactInfo { get; set; }
    public string AvailabilityStatus { get; set; }
    public Doctor()
    {

    }

    public Doctor(int doctorID, string name, string specialty, string contactInfo, string availabilityStatus)
    {
        DoctorID = doctorID;
        Name = name;
        Specialty = specialty;
        ContactInfo = contactInfo;
        AvailabilityStatus = availabilityStatus;
    }

    


}
