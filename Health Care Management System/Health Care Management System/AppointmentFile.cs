using System;

public class AppointmentFile
{
    private static List<Appointment> appointments = new List<Appointment>();

    public static void ScheduleAppointment()
    {
        Random random = new Random();
        int appointmentId = random.Next(100000, 999999);
        Console.WriteLine($"Appointment ID=> {appointmentId}");
        Console.Write("Enter Patient ID=> ");
        int patientId = int.Parse(Console.ReadLine());
        Console.Write("Enter Doctors ID=> ");
        int doctorsId = int.Parse(Console.ReadLine());
        Console.Write("Date (MM/DD/YYYY)=> ");
        DateTime date = DateTime.Parse(Console.ReadLine());
        Console.Write("Reason for appointment=> ");
        string reason = Console.ReadLine();
        
        var appointment = new Appointment(appointmentId, patientId, doctorsId, date, reason);
        appointments.Add(appointment);
        AddToFile(appointment);
        Console.WriteLine($"You have scheduled appointment.");
        Console.WriteLine();
    }
    public static void AddToFile(Appointment appointment)
    {
        string path = "C:\\Users\\ORIOLOWO\\Documents\\Batch 23 Class\\Health Care Management System\\Health Care Management System\\Appointment.txt";
        if (File.Exists(path))
        {
            using var writer = new StreamWriter(path, true);
            writer.WriteLine(appointment.ToString());
        }
        else
        {
            using (File.Create(path))
            {

            }
            using var writer = new StreamWriter(path, true);
            writer.WriteLine(appointment.ToString());
        }
    }

    public static Appointment Convert(string product) // convert back to object
    {
        var data = product.Split("\t|\t");
        return new Appointment(int.Parse(data[0]), int.Parse(data[1]), int.Parse(data[2]), DateTime.Parse(data[3]), data[4]);
    }


    public static void GetAllAppointment()
    {
        int count = 0;
        foreach (var item in appointments)
        {
            count++;
            Console.WriteLine($"{count}. Appointment ID : {item.AppointmentID}\t|\tPatient ID : {item.PatientID}\t|\tDoctor ID : {item.DoctorID}\t|\tDate : {item.Date}\t|\tReason : {item.Reason}");
        }
        Console.WriteLine();
        Console.WriteLine($"The total products in stock is {appointments.Count}");
        Console.WriteLine();
    }

    public static void GetAppointmentByPatientID(int patientId)
    {
        int count = 1;
        foreach (var item in appointments)
        {
            var appointment = Convert(item.ToString());
            if (appointment.PatientID == patientId)
            {
                Console.WriteLine($"{count}. Appointment ID : {item.AppointmentID}\t|\tPatient ID : {item.PatientID}\t|\tDoctor ID : {item.DoctorID}\t|\tDate : {item.Date}\t|\tReason : {item.Reason}");
                break;
            }
            if (appointments.Count == count)
            {
                Console.WriteLine("Appointment not available.");
            }
            count++;
        }
    }

    public static void GetAppointmentByDoctorID(int doctorId)
    {
        int count = 1;
        foreach (var item in appointments)
        {
            var appointment = Convert(item.ToString());
            if (appointment.DoctorID == doctorId)
            {
                Console.WriteLine($"{count}. Appointment ID : {item.AppointmentID}\t|\tPatient ID : {item.PatientID}\t|\tDoctor ID : {item.DoctorID}\t|\tDate : {item.Date}\t|\tReason : {item.Reason}");
                break;
            }
            if (appointments.Count == count)
            {
                Console.WriteLine("Appointment not available.");
            }
            count++;
        }
    }

    public static void RescheduleAppointment(int id)
    {
        int count = 1;
        foreach (var item in appointments)
        {
            var appointment = Convert(item.ToString());
            if (appointment.AppointmentID == id)
            {
                Console.Write("Date (MM/DD/YYYY)=> ");
                DateTime date = DateTime.Parse(Console.ReadLine());

                item.AppointmentID = item.AppointmentID;
                item.PatientID = item.PatientID;
                item.DoctorID = item.DoctorID;
                item.Date = date;
                item.Reason = item.Reason;
                Console.WriteLine($"{count}. Appointment ID : {item.AppointmentID}\t|\tPatient ID : {item.PatientID}\t|\tDoctor ID : {item.DoctorID}\t|\tDate : {item.Date}\t|\tReason : {item.Reason}");

                break;
            }
            if (appointments.Count == count)
            {
                Console.WriteLine("Patient not found");
            }
            count++;
        }
        string path = "C:\\Users\\ORIOLOWO\\Documents\\Batch 23 Class\\Health Care Management System\\Health Care Management System\\Appointment.txt";
        if (File.Exists(path))
        {
            File.WriteAllText(path, string.Empty);

            foreach (var item in appointments)
            {
                AddToFile(item);
            }

        }
    }
    public static void CancelAppointment()
    {
        Console.WriteLine("How many appointment do you want to cancel: ");
        int input = int.Parse(Console.ReadLine());
        int Count = 0;
        for (int i = 0; i < input; i++)
        {
            Console.WriteLine("Appointment ID");
            int id = int.Parse(Console.ReadLine());

            foreach (var item in appointments)
            {
                if (item.PatientID == id)
                {
                    appointments.Remove(item);
                    Count++;
                    break;
                }
            }
            string path = "C:\\Users\\ORIOLOWO\\Documents\\Batch 23 Class\\Health Care Management System\\Health Care Management System\\Appointment.txt";
            if (File.Exists(path))
            {
                File.WriteAllText(path, string.Empty);

                foreach (var item in appointments)
                {
                    AddToFile(item);
                }
            }
            Console.WriteLine($"You have successfully cancelled {Count} appointment");
        }
    }

    public static List<Appointment> RetrieveFromFile()
    {
        var appointment = new List<Appointment>();
        string path = "C:\\Users\\ORIOLOWO\\Documents\\Batch 23 Class\\Health Care Management System\\Health Care Management System\\Appointment.txt";
        if (File.Exists(path))
        {
            var datas = File.ReadAllLines(path);
            foreach (var data in datas)
            {
                var convert = Convert(data);
                appointment.Add(convert);
            }
        }
        appointments = appointment; //repopulate
        return appointment;
    }

}
