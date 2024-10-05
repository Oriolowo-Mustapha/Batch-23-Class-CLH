public class PatientFile
{
    private static List<Patient> patients = new List<Patient>();

    public static void AddPatient()
    {
        int Count = 0;
        Console.WriteLine("How many patient do you want to add");
        int input = int.Parse(Console.ReadLine());

        for (int i = 0; i < input; i++)
        {
            Random random = new Random();
            int id = random.Next(100000, 999999);
            Console.WriteLine($"Patient ID=> {id}");
            Console.Write("Enter Patient Name=> ");
            string name = Console.ReadLine();
            Console.Write("Enter Patient Age=> ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter Patient Gender=> ");
            string gender = Console.ReadLine();
            Console.Write("Enter Patient Contact Info (Email or Phone Number) => ");
            string contactInfo = Console.ReadLine();
            
            //creating an instance of the product
            var patient = new Patient(id, name, age, gender, contactInfo);
            //adding the product to list
            patients.Add(patient);
            // adding the product to file
            AddToFile(patient);

            Count++;
        }
        Console.WriteLine($"You have successfully added {Count} patient(s)");
        Console.WriteLine($"The total patient in registered is {patients.Count}");
        Console.WriteLine();
    }

    public static void AddToFile(Patient patient)
    {
        string path = "C:\\Users\\ORIOLOWO\\Documents\\Batch 23 Class\\Health Care Management System\\Health Care Management System\\Patient.txt";
        if (File.Exists(path))
        {
            using var writer = new StreamWriter(path, true);
            writer.WriteLine(patient.ToString());
        }
        else
        {
            using (File.Create(path))
            {

            }
            using var writer = new StreamWriter(path, true);
            writer.WriteLine(patient.ToString());
        }
    }



    public static Patient Convert(string patient) // convert back to object
    {
        var data = patient.Split("\t|\t");
        return new Patient(int.Parse(data[0]), data[1], int.Parse(data[2]), data[3], data[4]);
    }

    public static void UpdatePatientRecord(int id)
    {
        int count = 1;
        foreach (var item in patients)
        {
            var patient = Convert(item.ToString());
            if (patient.PatientID == id)
            {
                Console.Write("Enter Patient Name=> ");
                string name = Console.ReadLine();
                Console.Write("Enter Patient Age=> ");
                int age = int.Parse(Console.ReadLine());
                Console.Write("Enter Patient Gender=> ");
                string gender = Console.ReadLine();
                Console.Write("Enter Patient Contact Info=> ");
                string contactInfo = Console.ReadLine();

                item.Name = name;
                item.Age = age;
                item.Gender = gender;
                item.ContactInfo = contactInfo;
                Console.WriteLine($"Patient Name : {item.Name}\t|\tPatient Age : {item.Age}\t|\tPatient Gender : {item.Gender}\t|\tPatient Contact Information : {item.ContactInfo}\t|\tPatient ID : {item.PatientID}.");

                break;
            }
            if (patients.Count == count)
            {
                Console.WriteLine("Patient not found");
            }
            count++;
        }
        string path = "C:\\Users\\ORIOLOWO\\Documents\\Batch 23 Class\\Health Care Management System\\Health Care Management System\\Patient.txt";
        if (File.Exists(path))
        {
            File.WriteAllText(path, string.Empty);

            foreach (var item in patients)
            {
                AddToFile(item);
            }

        }
    }

    public static void SearchPatient (int id)
    {
        int count = 1;
        foreach (var item in patients)
        {
            var patient = Convert(item.ToString());
            if (patient.PatientID == id)
            {
                // Console.WriteLine(item.ToString());
                Console.WriteLine($"Patient Name : {item.Name}\t|\tPatient Age : {item.Age}\t|\tPatient Gender : {item.Gender}\t|\tPatient Contact Information : {item.ContactInfo}\t|\tPatient ID : {item.PatientID}.");
                break;
            }
            if (patients.Count == count)
            {
                Console.WriteLine("Patient not found");
            }
            count++;
        }
    }

    public static void ViewAllPatients()
    {
        int count = 0;
        foreach (var item in patients)
        {
            count++;
            Console.WriteLine($"Patient Name : {item.Name}\t|\tPatient Age : {item.Age}\t|\tPatient Gender : {item.Gender}\t|\tPatient Contact Information : {item.ContactInfo}\t|\tPatient ID : {item.PatientID}.");
        }
        Console.WriteLine();
        Console.WriteLine($"The total patient in available are {patients.Count}");
        Console.WriteLine();
    }

    public static void DeletePatient()
    {
        Console.WriteLine("How many patient do you want to delete: ");
        int input = int.Parse(Console.ReadLine());
        int Count = 0;
        for (int i = 0; i < input; i++)
        {
            Console.WriteLine("Enter patient ID");
            int id = int.Parse(Console.ReadLine());

            foreach (var item in patients)
            {
                if (item.PatientID == id)
                {
                    patients.Remove(item);
                    Count++;
                    break;
                }
            }
            string path = "C:\\Users\\ORIOLOWO\\Documents\\Batch 23 Class\\Health Care Management System\\Health Care Management System\\Patient.txt";
            if (File.Exists(path))
            {
                File.WriteAllText(path, string.Empty);

                foreach (var item in patients)
                {
                    AddToFile(item);
                }
            }
            Console.WriteLine($"You have successfully removed {Count} patients");
        }
    }

    public static List<Patient> RetrieveFromFile()
    {
        var listOfPatient = new List<Patient>();
        string path = "C:\\Users\\ORIOLOWO\\Documents\\Batch 23 Class\\Health Care Management System\\Health Care Management System\\Patient.txt";
        if (File.Exists(path))
        {
            var datas = File.ReadAllLines(path);
            foreach (var data in datas)
            {
                var convert = Convert(data);
                listOfPatient.Add(convert);
            }
        }
        patients = listOfPatient; //repopulate
        return listOfPatient;
    }

    public static Patient Login(int patientID)
    {
        DoctorFile.RetrieveFromFile();
        foreach (var patient in patients)
        {
            if (patient.PatientID == patientID)
            {
                return patient;
            }
        }
        return null;
    }
}
