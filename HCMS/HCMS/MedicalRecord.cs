public class MedicalRecord
{
    public int RecordID { get; set; }
    public int DoctorID { get; set; }
    public int PatientID { get; set; }
    public string Diagnosis { get; set; }
    public string Treatment { get; set; }
    public DateTime Date { get; set; }
    public string Notes { get; set; }

    public MedicalRecord()
    {

    }

    public MedicalRecord(int recordID,int doctorID ,int patientID, string diagnosis, string treatment, DateTime date, string notes)
    {
        RecordID = recordID;
        DoctorID = doctorID;
        PatientID = patientID;
        Diagnosis = diagnosis;
        Treatment = treatment;
        Date = date;
        Notes = notes;
    }
}