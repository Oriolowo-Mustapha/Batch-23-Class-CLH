public class MedicalRecordFile
{
    private static List<MedicalRecord> medicalRecords = new List<MedicalRecord>();
    public static void AddMedicalRecord()
    {
        Random random = new Random();
        int recordID = random.Next(100000, 999999);
        Console.WriteLine($"Record ID=> {recordID}");
        Console.Write("Patient ID=> ");
        int patientId = int.Parse(Console.ReadLine());
        Console.Write("Diagnosis=> ");
        string diagnosis = Console.ReadLine();
        Console.Write("Treatment=> ");
        string treatment = Console.ReadLine();
        Console.Write("Date (MM/DD/YYYY)=> ");
        DateTime date = DateTime.Parse(Console.ReadLine());
        Console.Write("Inference=> ");
        string note = Console.ReadLine();

        var medicalRecord = new MedicalRecord(recordID, patientId, diagnosis, treatment, date, note);
        medicalRecords.Add(medicalRecord);
        AddToFile(medicalRecord);
        Console.WriteLine($"Medical Record Added Successfully.");
        Console.WriteLine();
    }
    public static void AddToFile(MedicalRecord medicalRecord)
    {
        string path = "C:\\Users\\ORIOLOWO\\Documents\\Batch 23 Class\\Health Care Management System\\Health Care Management System\\Medical Record.txt";
        if (File.Exists(path))
        {
            using var writer = new StreamWriter(path, true);
            writer.WriteLine(medicalRecord.ToString());
        }
        else
        {
            using (File.Create(path))
            {

            }
            using var writer = new StreamWriter(path, true);
            writer.WriteLine(medicalRecord.ToString());
        }
    }

    public static void ViewAllPatientMedicalRecord()
    {
        int count = 0;
        foreach (var item in medicalRecords)
        {
            count++;
            Console.WriteLine($"{count}. Record ID : {item.RecordID}\t|\tPatient ID : {item.PatientID}\t|\tDiagnosis : {item.Diagnosis}\t|\tTreatment : {item.Treatment}\t|\tDate : {item.Date}\t|\tInference : {item.Notes}");
        }
        Console.WriteLine();
        Console.WriteLine($"The total products in stock is {medicalRecords.Count}");
        Console.WriteLine();
    }

    public static MedicalRecord Convert(string product) // convert back to object
    {
        var data = product.Split("\t|\t");
        return new MedicalRecord(int.Parse(data[0]), int.Parse(data[1]), data[2], data[3], DateTime.Parse(data[4]), data[5]);
    }

    public static void ViewPatientMedicalRecord(int patientID)
    {
        int count = 1;
        foreach (var item in medicalRecords)
        {
            var appointment = Convert(item.ToString());
            if (appointment.PatientID == patientID)
            {
                Console.WriteLine($"{count}. Record ID : {item.RecordID}\t|\tPatient ID : {item.PatientID}\t|\tDiagnosis : {item.Diagnosis}\t|\tTreatment : {item.Treatment}\t|\tDate : {item.Date}\t|\tInference : {item.Notes}");
                break;
            }
            if (medicalRecords.Count == count)
            {
                Console.WriteLine("Record not available.");
            }
            count++;
        }
    }

    public static void UpdateRecord(int id)
    {
        int count = 1;
        foreach (var item in medicalRecords)
        {
            var medicalRecord = Convert(item.ToString());
            if (medicalRecord.PatientID == id)
            {
                Console.Write("Patient ID=> ");
                int patientId = int.Parse(Console.ReadLine());
                Console.Write("Diagnosis=> ");
                string diagnosis = Console.ReadLine();
                Console.Write("Treatment=> ");
                string treatment = Console.ReadLine();
                Console.Write("Date (MM/DD/YYYY)=> ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Inference=> ");
                string note = Console.ReadLine();

                item.RecordID = item.RecordID;
                item.PatientID = patientId;
                item.Diagnosis = diagnosis;
                item.Treatment = treatment;
                item.Date = date;
                item.Notes = note;
                Console.WriteLine($"{count}. Record ID : {item.RecordID}\t|\tPatient ID : {item.PatientID}\t|\tDiagnosis : {item.Diagnosis}\t|\tTreatment : {item.Treatment}\t|\tDate : {item.Date}\t|\tInference : {item.Notes}");

                break;
            }
            if (medicalRecords.Count == count)
            {
                Console.WriteLine("Record not found");
            }
            count++;
        }
        string path = "C:\\Users\\ORIOLOWO\\Documents\\Batch 23 Class\\Health Care Management System\\Health Care Management System\\Medical Record.txt";
        if (File.Exists(path))
        {
            File.WriteAllText(path, string.Empty);

            foreach (var item in medicalRecords)
            {
                AddToFile(item);
            }

        }
    }

    public static List<MedicalRecord> RetrieveFromFile()
    {
        var report = new List<MedicalRecord>();
        string path = "C:\\Users\\ORIOLOWO\\Documents\\Batch 23 Class\\Health Care Management System\\Health Care Management System\\Medical Record.txt";
        if (File.Exists(path))
        {
            var datas = File.ReadAllLines(path);
            foreach (var data in datas)
            {
                var convert = Convert(data);
                report.Add(convert);
            }
        }
        medicalRecords = report; //repopulate
        return report;
    }
}
