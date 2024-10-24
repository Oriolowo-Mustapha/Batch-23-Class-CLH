using System;

public class AppointmentFile
{
    private static List<Appointment> appointments = new List<Appointment>();
    private static List<Appointment> acceptAppointments = new List<Appointment>();

    public static void ScheduleAppointment()
    {
        Random random = new Random();
        //int count = 1;
        int appointmentId = random.Next(100000, 999999);
        Console.WriteLine($"Appointment ID=> {appointmentId}");
        Console.Write("Enter Patient ID=> ");
        int patientId = int.Parse(Console.ReadLine());
        Console.Write("Enter Doctors ID=> ");
        int doctorsId = int.Parse(Console.ReadLine());
        int count = 1;
        foreach (var item in appointments)
        {
            var appointmentConv = Convert(item.ToString());
            if (appointmentConv.AppointmentStatus == "Occupied" && appointmentConv.AppointmentStatus == "Declined")
            {
                Console.WriteLine("Doctor Unavailable\nPls Reschedule Appointment");
                Console.WriteLine("Press Any Key To Continue");
                Console.ReadKey();
                RescheduleAppointment(appointmentId);
            }
            else if (appointmentConv.AppointmentStatus == "Free")
            {
                Console.Write("Date (MM/DD/YYYY)=> ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Reason for appointment=> ");
                string reason = Console.ReadLine();
                appointmentConv.AppointmentStatus = "Occupied";

                var appointment = new Appointment(appointmentId, patientId, doctorsId, date, reason, appointmentConv.AppointmentStatus);
                appointments.Add(appointment);

                AddToFile(appointment);
                Console.WriteLine($"You have scheduled appointment.");
                Console.WriteLine("Press Any Key To Continue");
                Console.ReadKey();
                break;
            }
            else if (appointmentConv.AppointmentStatus == "Occupied")
            {
                Console.WriteLine("Doctor Unavailabe.");
                ScheduleAppointment();
            }
            if (appointments.Count == count)
            {
                Console.WriteLine("Appointment not available.");
                Console.WriteLine("Press Any Key To Continue");
                Console.ReadKey();
            }
            count++;
        }
    }
    public static void ScheduleAppointment2()
    {
        Random random = new Random();
        //int count = 1;
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
        string AppointmentStatus = "Occupied";

        var appointment = new Appointment(appointmentId, patientId, doctorsId, date, reason, AppointmentStatus);
        appointments.Add(appointment);

        AddToFile(appointment);
        Console.WriteLine($"You have scheduled an appointment.");
        Console.WriteLine("Press Any Key To Continue");
        Console.ReadKey();

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

    public static void AddAcceptedAppointmentToFile(Appointment appointment)
    {
        string path = "C:\\Users\\ORIOLOWO\\Documents\\Batch 23 Class\\Health Care Management System\\Health Care Management System\\Accepted Appointment.txt";
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
        return new Appointment(int.Parse(data[0]), int.Parse(data[1]), int.Parse(data[2]), DateTime.Parse(data[3]), data[4], data[5]);
    }


    public static void GetAllAppointment()
    {
        int count = 0;
        foreach (var item in appointments)
        {
            count++;
            Console.WriteLine($"{count}. Appointment ID : {item.AppointmentID}\t|\tPatient ID : {item.PatientID}\t|\tDoctor ID : {item.DoctorID}\t|\tDate : {item.Date}\t|\tReason : {item.Reason}\t|\tDoctor Status: {item.AppointmentStatus}");
        }
        Console.WriteLine();
        Console.WriteLine($"The total appointment scheduled {acceptAppointments.Count}");
        Console.WriteLine("Press Any Key To Continue");
        Console.ReadKey();
        Console.WriteLine();
    }

    public static int Get()
    {
        int count = 0;
        foreach (var item in appointments)
        {
            count++;
        }
        return count;
    }

    public static void GetAllAcceptedAppointment()
    {
        int count = 0;
        foreach (var item in acceptAppointments)
        {
            count++;
            Console.WriteLine($"{count}. Appointment ID : {item.AppointmentID}\t|\tPatient ID : {item.PatientID}\t|\tDoctor ID : {item.DoctorID}\t|\tDate : {item.Date}\t|\tReason : {item.Reason}\t|\tDoctor Status: {item.AppointmentStatus}");
        }
        Console.WriteLine();
        Console.WriteLine($"The total appointment accpeted {appointments.Count}");
        Console.WriteLine("Press Any Key To Continue");
        Console.ReadKey();
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
                Console.WriteLine($"{count}. Appointment ID : {item.AppointmentID}\t|\tPatient ID : {item.PatientID}\t|\tDoctor ID : {item.DoctorID}\t|\tDate : {item.Date}\t|\tReason : {item.Reason}\t|\tDoctor Status: {item.AppointmentStatus}");
                Console.WriteLine("Press Any Key To Continue");
                Console.ReadKey();
                break;
            }
            if (appointments.Count == count)
            {
                Console.WriteLine("Appointment not available.");
                Console.WriteLine("Press Any Key To Continue");
                Console.ReadKey();
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
                Console.WriteLine($"{count}. Appointment ID : {item.AppointmentID}\t|\tPatient ID : {item.PatientID}\t|\tDoctor ID : {item.DoctorID}\t|\tDate : {item.Date}\t|\tReason : {item.Reason}\t|\tDoctor Status: {item.AppointmentStatus}");

                Console.WriteLine("1. ACCEPT APPOINTMENT.");
                Console.WriteLine("2. DECLINE APPOINTMENT.");
                Console.Write("CHOOSE ANY THE FOLLOWING=> ");
                int input = int.Parse(Console.ReadLine());
                if (input == 1)
                {
                    item.AppointmentID = item.AppointmentID;
                    item.PatientID = item.PatientID;
                    item.DoctorID = item.DoctorID;
                    item.Date = item.Date;
                    item.Reason = item.Reason;
                    item.AppointmentStatus = "Occupied";

                    var appointment2 = new Appointment(item.AppointmentID, item.PatientID, item.DoctorID, item.Date, item.Reason, item.AppointmentStatus);
                    AddToFile(appointment);
                    RemoveAcceptedAppointment(item.AppointmentID);
                    AddAcceptedAppointmentToFile(item);
                    acceptAppointments.Add(item);
                    Console.WriteLine("Appointment Accepted.");
                    Console.WriteLine("Press Any Key To Continue");
                    Console.ReadKey();
                }
                else if (input == 2)
                {
                    item.AppointmentID = item.AppointmentID;
                    item.PatientID = item.PatientID;
                    item.DoctorID = item.DoctorID;
                    item.Date = item.Date;
                    item.Reason = item.Reason;
                    item.AppointmentStatus = "Declined";
                    var appointment2 = new Appointment(item.AppointmentID, item.PatientID, item.DoctorID, item.Date, item.Reason, item.AppointmentStatus);
                    Console.WriteLine("Appointment Declined.");
                    Console.WriteLine("Press Any Key To Continue");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Invalid Input.");
                    Console.WriteLine("Press Any Key To Continue");
                    Console.ReadKey();
                }
                break;
            }
            if (appointments.Count == count)
            {
                Console.WriteLine("Appointment not available.");
                Console.WriteLine("Press Any Key To Continue");
                Console.ReadKey();
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

    public static void RescheduleAppointment(int id)
    {
        int count = 1;
        foreach (var item in appointments)
        {
            var appointment = Convert(item.ToString());
            if (appointment.AppointmentID == id)
            {
                Console.Write("Enter Doctors ID=> ");
                int doctorsId = int.Parse(Console.ReadLine());

                Console.Write("Date (MM/DD/YYYY)=> ");
                DateTime date = DateTime.Parse(Console.ReadLine());

                item.AppointmentID = item.AppointmentID;
                item.PatientID = item.PatientID;
                item.DoctorID = doctorsId;
                item.Date = date;
                item.Reason = item.Reason;
                item.AppointmentStatus = "Free";
                var appointment2 = new Appointment(item.AppointmentID, item.PatientID, item.DoctorID, item.Date, item.Reason, item.AppointmentStatus);
                Console.WriteLine("Appointment Rescheduled.");
                Console.WriteLine();
                Console.WriteLine($"{count}. Appointment ID : {item.AppointmentID}\t|\tPatient ID : {item.PatientID}\t|\tDoctor ID : {item.DoctorID}\t|\tDate : {item.Date}\t|\tReason : {item.Reason}\t|\tDoctor Status: {item.AppointmentStatus}");
                Console.WriteLine("Press Any Key To Continue");
                Console.ReadKey();
                break;
            }
            if (appointments.Count == count)
            {
                Console.WriteLine("Patient not found");
                Console.WriteLine("Press Any Key To Continue");
                Console.ReadKey();
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
            Console.WriteLine("Press Any Key To Continue");
            Console.ReadKey();
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

    public static List<Appointment> RetrieveAcceptedAppointmentFromFile()
    {
        var acceptAppointment = new List<Appointment>();
        string path = "C:\\Users\\ORIOLOWO\\Documents\\Batch 23 Class\\Health Care Management System\\Health Care Management System\\Accepted Appointment.txt";
        if (File.Exists(path))
        {
            var datas = File.ReadAllLines(path);
            foreach (var data in datas)
            {
                var convert = Convert(data);
                acceptAppointment.Add(convert);
            }
        }
        acceptAppointments = acceptAppointment; //repopulate
        return acceptAppointment;
    }

    public static void RemoveAcceptedAppointment(int id)
    {
        foreach (var item in appointments)
        {
            if (item.AppointmentID == id)
            {
                appointments.Remove(item);
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
    }

    public static void RescheduleDeclined(Admin loggedInAdmin)
    {
        int count = 1;
        foreach (var item in appointments)
        {
            var appointmentConv = Convert(item.ToString());
            if (appointmentConv.AppointmentStatus == "Declined" || appointmentConv.AppointmentStatus == "Occupied")
            {
                Console.WriteLine($"Appointment Declined by Doctor {appointmentConv.DoctorID}\n Pls Reschedule");
                Console.WriteLine("Press Any Key To Continue.");
                Console.ReadKey();
                RescheduleAppointment(appointmentConv.AppointmentID);
            }
            else if (appointmentConv.AppointmentStatus == "Free")
            {
                Menu.adminMenu(loggedInAdmin);
            }
            if (appointments.Count == count)
            {
                Console.WriteLine("Appointment not available.");
                Console.WriteLine("Press Any Key To Continue");
                Console.ReadKey();
            }
            count++;
        }
    }
}
