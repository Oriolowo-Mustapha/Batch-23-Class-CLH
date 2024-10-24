public class Requested_Appointment
{
    public int AppointmentID { get; set; }
    public int PatientID { get; set; }
    public string Reason { get; set; }

    public Requested_Appointment()
    {

    }

    public Requested_Appointment(int appointmentID, int patientID, string reason)
    {
        AppointmentID = appointmentID;
        PatientID = patientID;
        Reason = reason;
    }
}
