public class DoctorFile
{
    private static List<Doctor> doctors = new List<Doctor>();
    public static void AddDoctor()
    {
        int Count = 0;
        Console.Write("How many doctors do you want to add: ");
        int input = int.Parse(Console.ReadLine());

        for (int i = 0; i < input; i++)
        {
            Random random = new Random();
            int id = random.Next(100000, 999999);
            Console.WriteLine($"Doctors ID=> {id}");
            Console.Write("Doctor's Name=> ");
            string name = Console.ReadLine();
            Console.Write("Specialty=> ");
            string specialty = Console.ReadLine();
            Console.Write("Contact Info (Email or Phone Number) => ");
            string contactInfo = Console.ReadLine();
            //creating an instance of the product
            var doctor = new Doctor(id, name, specialty, contactInfo);
            //adding the product to list
            doctors.Add(doctor);
            // adding the product to file
            AddToFile(doctor);

            Count++;
        }
        Console.WriteLine($"You have successfully added {Count} patient(s)");
        Console.WriteLine($"The total patient in registered is {doctors.Count}");
        Console.WriteLine();
    }

    public static void AddToFile(Doctor doctor)
    {
        string path = "C:\\Users\\ORIOLOWO\\Documents\\Batch 23 Class\\Health Care Management System\\Health Care Management System\\Doctor.txt";
        if (File.Exists(path))
        {
            using var writer = new StreamWriter(path, true);
            writer.WriteLine(doctor.ToString());
        }
        else
        {
            using (File.Create(path))
            {

            }
            using var writer = new StreamWriter(path, true);
            writer.WriteLine(doctor.ToString());
        }
    }

    public static void ViewAllDoctors()
    {
        int count = 0;
        foreach (var item in doctors)
        {
            count++;
            Console.WriteLine($"{count}. Doctor ID : {item.DoctorID}\t|\tDoctor Name : {item.Name}\t|\tSpecialty : {item.Specialty}\t|\tContact Info : {item.ContactInfo}.");
        }
        Console.WriteLine();
        Console.WriteLine($"The total doctors in available are {doctors.Count}");
        Console.WriteLine();
    }

    public static Doctor Convert(string doctor) // convert back to object
    {
        var data = doctor.Split("\t|\t");
        return new Doctor(int.Parse(data[0]), data[1], data[2], data[3]);
    }

    public static void DeleteDoctor()
    {
        Console.WriteLine("How many doctor do you want to delete: ");
        int input = int.Parse(Console.ReadLine());
        int Count = 0;
        for (int i = 0; i < input; i++)
        {
            Console.Write("Enter Doctor's ID: ");
            int id = int.Parse(Console.ReadLine());

            foreach (var item in doctors)
            {
                if (item.DoctorID == id)
                {
                    doctors.Remove(item);
                    Count++;
                    break;
                }
            }
            string path = "C:\\Users\\ORIOLOWO\\Documents\\Batch 23 Class\\Health Care Management System\\Health Care Management System\\Doctor.txt";
            if (File.Exists(path))
            {
                File.WriteAllText(path, string.Empty);

                foreach (var item in doctors)
                {
                    AddToFile(item);
                }
            }
            Console.WriteLine($"You have successfully removed {Count} doctors");
        }
    }

    public static List<Doctor> RetrieveFromFile()
    {
        var listOfDoctors = new List<Doctor>(); 
        string path = "C:\\Users\\ORIOLOWO\\Documents\\Batch 23 Class\\Health Care Management System\\Health Care Management System\\Doctor.txt";
        if (File.Exists(path))
        {
            var datas = File.ReadAllLines(path);
            foreach (var data in datas)
            {
                var convert = Convert(data);
                listOfDoctors.Add(convert);
            }
        }
        doctors = listOfDoctors; //repopulate
        return listOfDoctors;
    }

    public static void SearchDoctor(int id)
    {
        int count = 1;
        foreach (var item in doctors)
        {
            var doctor = Convert(item.ToString());
            if (doctor.DoctorID == id)
            {
                // Console.WriteLine(item.ToString());
                Console.WriteLine($"{count}. Doctor ID : {item.DoctorID}\t|\tDoctor Name : {item.Name}\t|\tSpecialty : {item.Specialty}\t|\tContact Info : {item.ContactInfo}.");
                break;
            }
            if (doctors.Count == count)
            {
                Console.WriteLine("Doctor not found");
            }
            count++;
        }
    }

    public static Doctor Login(int doctorID)
    {
        DoctorFile.RetrieveFromFile();
        foreach (var docitar in doctors)
        {
            if (docitar.DoctorID == doctorID)
            {
                return docitar;
            }
        }
        return null;
    }
}
