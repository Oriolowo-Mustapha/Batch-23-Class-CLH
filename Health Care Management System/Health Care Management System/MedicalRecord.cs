public class MedicalRecord
{
    public int RecordID { get; set; }   
    public int PatientID { get; set; }  
    public string Diagnosis { get; set; }   
    public string Treatment { get; set; }   
    public DateTime Date {  get; set; }
    public string Notes { get; set; }

    public MedicalRecord()
    {

    }

    public MedicalRecord(int recordID, int patientID, string diagnosis, string treatment, DateTime date, string notes)
    {
        RecordID = recordID;
        PatientID = patientID;
        Diagnosis = diagnosis;
        Treatment = treatment;
        Date = date;
        Notes = notes;
    }

    public override string ToString()
    {
        return $"{RecordID}\t|\t{PatientID}\t|\t{Diagnosis}\t|\t{Treatment}\t|\t{Date}\t|\t{Notes}";
    }
}
