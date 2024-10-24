public class Appointment
{
    public int AppointmentID { get; set; }
    public int PatientID { get; set; }
    public int DoctorID { get; set; }
    public DateTime Date { get; set; }
    public string Status { get; set; }
    public string Complain { get; set; }    
    public Appointment()
    {

    }

    public Appointment(int appointmentID, int patientID, int doctorID, DateTime date,  string status, string complain)
    {
        AppointmentID = appointmentID;
        PatientID = patientID;
        DoctorID = doctorID;
        Date = date;
        Status = status;
        Complain = complain;
    }


}
