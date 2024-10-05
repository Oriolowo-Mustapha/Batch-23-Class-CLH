using System.Reflection;
using System.Xml.Linq;

public class Appointment
{
    public int AppointmentID { get; set; }
    public int PatientID { get; set;}
    public int DoctorID { get; set;}
    public DateTime Date { get; set;}
    public string Reason { get; set;}   

    public Appointment()
    {

    }

    public Appointment(int appointmentID, int patientID, int doctorID, DateTime date, string reason)
    {
        AppointmentID = appointmentID;
        PatientID = patientID;
        DoctorID = doctorID;
        Date = date;
        Reason = reason;
    }

    public override string ToString()
    {
        return $"{AppointmentID}\t|\t{PatientID}\t|\t{DoctorID}\t|\t{Date}\t|\t{Reason}";
    }
}
