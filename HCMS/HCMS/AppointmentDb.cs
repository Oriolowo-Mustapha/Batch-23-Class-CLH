using MySql.Data.MySqlClient;
using System.Numerics;
using System.Reflection.PortableExecutable;

public class AppointmentDb
{
    private static string ConnectionStringWithoutDB = "Server = localhost; User = root; password = password";
    private static string ConnectionString = "Server = localhost; User = root; database = Appointment; password = password";
    private static bool AcceptedTask = false;
    private static bool DeclinedTask = false;
    private static bool CancelledTask = false;
    private static List<Appointment> appointments = new List<Appointment>();
    private static List<Appointment> Cappointments = new List<Appointment>();
    private static List<Requested_Appointment> rappointments = new List<Requested_Appointment>();
    public static bool CreateAppointmentDB()
    {
        using (MySqlConnection connection = new MySqlConnection(ConnectionStringWithoutDB))
        {
            connection.Open();
            string query = "Create Database if not exists Appointment";

            MySqlCommand command = new MySqlCommand(query, connection);
            var execute = command.ExecuteNonQuery();

            if (execute > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public static bool CreateAppointmentTable()
    {
        using (MySqlConnection connection = new MySqlConnection(ConnectionString))
        {
            connection.Open();
            string query = "create table if not exists Appointments(id int primary Key not null auto_increment, PatientID int Not Null, DoctorID int Not Null, Date varchar(255) not null, Status varchar(255) Not Null, Complaint varchar(255));";

            MySqlCommand command = new MySqlCommand(query, connection);
            var execute = command.ExecuteNonQuery();

            if (execute == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }

    public static bool CreateRequestedAppointmentByPatientTable()
    {
        using (MySqlConnection connection = new MySqlConnection(ConnectionString))
        {
            connection.Open();
            string query = "create table if not exists RequestedAppointments(id int primary Key not null auto_increment, PatientID int Not Null, Complaint varchar(255) Not Null);";

            MySqlCommand command = new MySqlCommand(query, connection);
            var execute = command.ExecuteNonQuery();

            if (execute == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }

    public static bool CreateAcceptedAppointmentTable()
    {
        using (MySqlConnection connection = new MySqlConnection(ConnectionString))
        {
            connection.Open();
            string query = "create table if not exists AcceptedAppointments(id int primary Key not null auto_increment, PatientID int Not Null, DoctorID int Not Null, Date varchar(255) not null, Status varchar(255) Not Null, Complaint varchar(255));";

            MySqlCommand command = new MySqlCommand(query, connection);
            var execute = command.ExecuteNonQuery();

            if (execute == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }

    public static bool CreateDeclinedAppointmentTable()
    {
        using (MySqlConnection connection = new MySqlConnection(ConnectionString))
        {
            connection.Open();
            string query = "create table if not exists DeclinedAppointments(id int primary Key not null auto_increment, PatientID int Not Null, DoctorID int Not Null, Date varchar(255) not null, Status varchar(255) Not Null, Complaint varchar(255));";

            MySqlCommand command = new MySqlCommand(query, connection);
            var execute = command.ExecuteNonQuery();

            if (execute == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }

    public static bool CreateCancelledAppointmentTable()
    {
        using (MySqlConnection connection = new MySqlConnection(ConnectionString))
        {
            connection.Open();
            string query = "create table if not exists CancelledAppointments(id int primary Key not null auto_increment, PatientID int Not Null, DoctorID int Not Null, Date varchar(255) not null, Status varchar(255) Not Null, Complaint varchar(255));";

            MySqlCommand command = new MySqlCommand(query, connection);
            var execute = command.ExecuteNonQuery();

            if (execute == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }

    public static void ScheduleAppointment()
    {
        Appointment appointment = new Appointment();
        bool run = true;
        while (run)
        {
            DoctorDB.CheckDoctor();
            Console.Write("Doctor ID=> ");
            int DoctorID = int.Parse(Console.ReadLine());
            try
            {
                if (DoctorDB.CheckDoctor(DoctorID) == true)
                {
                    Console.Write("Patient ID=> ");
                    int PatientID = int.Parse(Console.ReadLine());
                    PatientDB.CheckPatient(PatientID);

                    if (PatientDB.CheckPatient(PatientID) == true)
                    {
                        try
                        {
                            Console.Write("Date (YYYY-MM-DD)=> ");
                            DateTime date = DateTime.Parse(Console.ReadLine());
                            try
                            {
                                run = false;
                                string status = "Reserved";
                                string docStatus = "Occupied";
                                DoctorDB.UpdateStatus(docStatus, DoctorID);
                                Console.WriteLine("Complaint: ");
                                string complain = Console.ReadLine();
                                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                                {
                                    connection.Open();
                                    MySqlCommand insert = new MySqlCommand($"insert into Appointments (PatientID, DoctorID, Date, Status ,Complaint) values('{appointment.PatientID = PatientID}', '{appointment.DoctorID = DoctorID}','{appointment.Date = date}','{appointment.Status = status}','{appointment.Complain = complain}');", connection);


                                    var execute = insert.ExecuteNonQuery();

                                    if (execute == 0)
                                    {
                                        Console.WriteLine($"Failed To Schedule Appointment");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"Appointment Scheduled on {date}.");
                                    }
                                }
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Invalid Input.");
                                Console.Write("Date=> ");
                                date = DateTime.Parse(Console.ReadLine());
                            }

                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Invalid Input.");
                            Console.Write("Patient ID=> ");
                            PatientID = int.Parse(Console.ReadLine());
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid ID.");
                        Console.Write("Patient ID=> ");
                        PatientID = int.Parse(Console.ReadLine());
                    }
                }
                else
                {
                    Console.WriteLine("Doctor Unavailable.");
                    Console.Write("Doctor ID=> ");
                    DoctorID = int.Parse(Console.ReadLine());
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Input.");
                Console.Write("Doctor ID=> ");
                DoctorID = int.Parse(Console.ReadLine());
            }

            
        }
    }

    public static void RequestScheduleAppointmentByPatient(Patient patient)
    {
        Requested_Appointment requested_Appointment = new Requested_Appointment();
        bool run = true;
        while (run)
        {
            int PatientID = patient.PatientID;
            if (PatientDB.CheckPatient(PatientID) == true)
            {
                run = false;
                Console.WriteLine("Complains: ");
                string complain = Console.ReadLine();

                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();
                    MySqlCommand insert = new MySqlCommand($"insert into RequestedAppointments (PatientID, Complaint) values('{requested_Appointment.PatientID = PatientID}', '{requested_Appointment.Reason = complain}');", connection);


                    var execute = insert.ExecuteNonQuery();

                    if (execute == 0)
                    {
                        Console.WriteLine("Requested Unsuccessfull.");
                    }
                    else
                    {
                        Console.WriteLine("Requested Successfull.");
                        RetrieveFromRequestedDb();
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid ID.");
                Console.Write("Patient ID=> ");
                PatientID = patient.PatientID;
            }
        }
    }

    public static string CheckRequestScheduleAppointmentByPatient(int patientID, int requestID)
    {
        foreach (var item in rappointments)
        {
            if (item.PatientID == patientID && item.AppointmentID == requestID)
            {
                return item.Reason;
            }
        }
        return null;
    }

    public static void ScheduleAppointmentRequestedByPatient()
    {
        Appointment appointment = new Appointment();
        bool run = true;
        while (run)
        {
            Console.Write("Request Appointment ID: ");
            int requestID = int.Parse(Console.ReadLine());
            try
            {
                DoctorDB.CheckDoctor();
                Console.Write("Doctor ID=> ");
                int DoctorID = int.Parse(Console.ReadLine());
                try
                {
                    if (DoctorDB.CheckDoctor(DoctorID) == true)
                    {
                        Console.Write("Patient ID=> ");
                        int PatientID = int.Parse(Console.ReadLine());
                        PatientDB.CheckPatient(PatientID);

                        if (PatientDB.CheckPatient(PatientID) == true)
                        {
                            try
                            {
                                Console.Write("Date (YYYY-MM-DD)=> ");
                                DateTime date = DateTime.Parse(Console.ReadLine());
                                try
                                {
                                    run = false;
                                    string status = "Reserved";
                                    string complain = CheckRequestScheduleAppointmentByPatient(PatientID, requestID);
                                    using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                                    {
                                        connection.Open();
                                        MySqlCommand insert = new MySqlCommand($"insert into Appointments (PatientID, DoctorID, Date, Status, Complaint) values('{appointment.PatientID = PatientID}', '{appointment.DoctorID = DoctorID}','{appointment.Date = date}','{appointment.Status = status}','{appointment.Complain = complain}');", connection);


                                        var execute = insert.ExecuteNonQuery();

                                        if (execute == 0)
                                        {
                                            Console.WriteLine("Failed To Schedule Appointment");
                                        }
                                        else
                                        { 
                                            Console.WriteLine($"Appointment Scheduled on {date}.");
                                            AcceptedTask = false;
                                        }
                                    }
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine("Invalid Input.");
                                    Console.Write("Date=> ");
                                    date = DateTime.Parse(Console.ReadLine());
                                }

                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Invalid Input.");
                                Console.Write("Patient ID=> ");
                                PatientID = int.Parse(Console.ReadLine());
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid ID.");
                            Console.Write("Patient ID=> ");
                            PatientID = int.Parse(Console.ReadLine());
                        }
                    }
                    else
                    {
                        Console.WriteLine("Doctor Unavailable.");
                        Console.Write("Doctor ID=> ");
                        DoctorID = int.Parse(Console.ReadLine());
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid Input.");
                    Console.Write("Doctor ID=> ");
                    DoctorID = int.Parse(Console.ReadLine());
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Input.");
                Console.Write("Request Appointment ID: ");
                requestID = int.Parse(Console.ReadLine());
            }
        }
    }

    public static void GetAppointmentByDoctorID(Doctor doctor)
    {
        Appointment appointment = new Appointment();
        List<Appointment> appointmentsToAccept = new List<Appointment>();
        List<Appointment> appointmentsToDecline = new List<Appointment>();

        using (MySqlConnection connection = new MySqlConnection(ConnectionString))
        {
            connection.Open();

            string selectQuery = $"SELECT id, PatientID, DoctorID, Date, Status, Complaint FROM Appointments WHERE DoctorID = {doctor.DoctorID}";
            using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Appointment appointment1 = new Appointment();
                        appointment1.AppointmentID = reader.GetInt32(0);
                        appointment1.PatientID = reader.GetInt32(1);
                        appointment1.DoctorID = reader.GetInt32(2);
                        appointment1.Date = reader.GetDateTime(3);
                        appointment1.Status = reader.GetString(4);
                        appointment1.Complain = reader.GetString(5);

                        Console.WriteLine("Appointment: ");
                        Console.WriteLine($"ID: {reader["id"]}, PatientID: {reader["PatientID"]}, DoctorID: {reader["DoctorID"]}, Date: {reader["Date"]}, Status: {reader["Status"]}, Complaint: {reader["Complaint"]}");

                        Console.WriteLine("1. ACCEPT APPOINTMENT.");
                        Console.WriteLine("2. DECLINE APPOINTMENT.");
                        Console.Write("Choose Any One Of The Following Options: ");
                        int option = int.Parse(Console.ReadLine());

                        if (option == 1)
                        {
                            appointmentsToAccept.Add(appointment1);
                        }
                        else if (option == 2)
                        {
                            appointmentsToDecline.Add(appointment1);
                        }
                        else
                        {
                            Console.WriteLine("Invalid Input.");
                        }
                    }
                } 

                
                foreach (var item in appointmentsToAccept)
                {
                    string query = $"UPDATE Appointments SET Status = 'Accepted' WHERE id = {item.AppointmentID}";
                    MySqlCommand commandupdate = new MySqlCommand(query, connection);
                    var execute = commandupdate.ExecuteNonQuery();

                    string docStatus = "Occupied";
                    DoctorDB.UpdateStatus(docStatus, item.DoctorID);

                    MySqlCommand insert = new MySqlCommand($"INSERT INTO AcceptedAppointments (PatientID, DoctorID, Date, Status ,Complaint) VALUES('{item.PatientID}', '{item.DoctorID}','{item.Date}','{item.Status}','{item.Complain}');", connection);
                    var execute2 = insert.ExecuteNonQuery();

                    if (execute2 == 0)
                    {
                        Console.WriteLine("Appointment Couldnt Be Accepted due to some internal errors.");
                    }
                    else
                    {
                        Console.WriteLine("Appointment Accepted.\n");
                        deleteAcceptedAppointment();
                        AcceptedTask = true;
                    }
                }

     
                foreach (var item in appointmentsToDecline)
                {
                    string query = $"UPDATE Appointments SET Status = 'Declined' WHERE id = {item.AppointmentID}";
                    MySqlCommand commandupdate = new MySqlCommand(query, connection);
                    var execute = commandupdate.ExecuteNonQuery();

                    MySqlCommand insert = new MySqlCommand($"INSERT INTO DeclinedAppointments (PatientID, DoctorID, Date, Status ,Complaint) VALUES('{item.PatientID}', '{item.DoctorID}','{item.Date}','{item.Status}','{item.Complain}');", connection);
                    var execute2 = insert.ExecuteNonQuery();

                    if (execute2 == 0)
                    {
                        Console.WriteLine("Appointment Couldnt Be Declined due to some internal errors.");
                    }
                    else
                    {
                        Console.WriteLine("Appointment Declined.\n");
                        DeclinedTask = true;
                    }
                }
            }
        }
    }

    public static void GetAppointmentByPatientID(Patient patient)
    {
        using (MySqlConnection connection = new MySqlConnection(ConnectionString))
        {
            connection.Open();

            string selectQuery = $"SELECT id, PatientID, DoctorID, Date, Status, Complaint From Appointments where PatientID = {patient.PatientID}";
            MySqlCommand command = new MySqlCommand(selectQuery, connection);
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Console.WriteLine($"ID: {reader["id"]}, PatientID: {reader["PatientID"]}, DoctorID: {reader["DoctorID"]}, Date: {reader["Date"]}, Status: {reader["Status"]}, Complaint: {reader["Complaint"]}");
                }
            }
            Console.WriteLine("No Appointment Have Been Schduled Yet.");
        }
    }

    public static void RetrieveFromDb()
    {
        using (MySqlConnection connection = new MySqlConnection(ConnectionString))
        {
            connection.Open();
            string selectQuery = $"SELECT * From Appointments";
            using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Appointment appointment = new Appointment();
                        appointment.AppointmentID = reader.GetInt32(0);
                        appointment.PatientID = reader.GetInt32(1);
                        appointment.DoctorID = reader.GetInt32(2);
                        appointment.Date = reader.GetDateTime(3);
                        appointment.Status = reader.GetString(4);
                        appointment.Complain = reader.GetString(5);
                        appointments.Add(appointment);
                    }
                }
            }
        }
    }

    public static void RetrieveFromRequestedDb()
    {
        using (MySqlConnection connection = new MySqlConnection(ConnectionString))
        {
            connection.Open();
            string selectQuery = $"SELECT * From RequestedAppointments";
            using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Requested_Appointment requested_Appointment = new Requested_Appointment();
                        requested_Appointment.AppointmentID = reader.GetInt32(0);
                        requested_Appointment.PatientID = reader.GetInt32(1);
                        requested_Appointment.Reason = reader.GetString(2);
                        rappointments.Add(requested_Appointment);
                    }
                }
            }
        }
    }

    public static void RescheduleAppointment(int id)
    {
        bool run = true;
        while (run)
        {
            DoctorDB.CheckDoctor();
            Console.Write("Doctor ID=> ");
            int DoctorID = int.Parse(Console.ReadLine());
            try
            {
                DoctorDB.CheckDoctor(DoctorID);
                if (DoctorDB.CheckDoctor(DoctorID) == true)
                {
                    Console.Write("Date=> ");
                    string date = Console.ReadLine();
                    try
                    {
                        run = false;
                        string status = "Reserved";
                        using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                        {
                            connection.Open();
                            string query = $"UPDATE Appointments SET DoctorID = {DoctorID}, Date = {date}, Status = {status} where id = {id}";


                            MySqlCommand commandupdate = new MySqlCommand(query, connection);
                            var execute = commandupdate.ExecuteNonQuery();

                            if (execute == 0)
                            {
                                Console.WriteLine("Updated Successful.");
                                DeclinedTask = false;
                            }
                            else
                            {
                                Console.WriteLine("Updated Unsuccessfull.");
                            }
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid Input.");
                        Console.Write("Date=> ");
                        date = Console.ReadLine();
                    }


                }
                else
                {
                    Console.WriteLine("Doctor Unavailable.");
                    Console.Write("Doctor ID=> ");
                    DoctorID = int.Parse(Console.ReadLine());
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Input.");
                Console.Write("Doctor ID=> ");
                DoctorID = int.Parse(Console.ReadLine());
            }


        }
    }

    public static void GetAccepted(int id)
    {
        if (AcceptedTask == true)
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                connection.Open();
                string selectQuery = $"SELECT * From AcceptedAppointments where PatientID = {id}";
                using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Appointment appointment = new Appointment();
                            appointment.DoctorID = reader.GetInt32(2);
                            Console.WriteLine($"Your Appointment Has Been Accepted By Dr {DoctorDB.GetDocName(appointment.DoctorID)}");
                            AcceptedTask = false;
                        }
                    }
                }
            }
        }
    }

    public static void GetDeclined(int id)
    {
        if (DeclinedTask == true)
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                connection.Open();
                string selectQuery = $"SELECT * From DeclinedAppointments where PatientID = {id}";
                using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Appointment appointment = new Appointment();
                            appointment.DoctorID = reader.GetInt32(2);
                            Console.WriteLine($"Your Appointment Has Been Declined By Dr {DoctorDB.GetDocName(appointment.DoctorID)}\nThe Admin Will Reschedule The Appointment Shortly.");
                            DeclinedTask  = false;
                        }
                    }
                }
            }
        }
    }

    public static void GetCancelled()
    {
        foreach (var item in Cappointments)
        {
            if (Cappointments.Count > 0)
            {
                Console.WriteLine($"Your Appointment Has Been Cancelled By {PatientDB.GetPatientName(item.PatientID)}");
                CancelledTask = false;
            }
        }
    }

    public static void CheckIfRequested()
    {
        foreach (var item in rappointments)
        {
            if (rappointments.Count > 0)
            {
                Console.WriteLine($"Appointment (RequestID = {item.AppointmentID}) Has Been Requested By {PatientDB.GetPatientName(item.PatientID)}");
            }
        }
    }

    public static void ViewAllAppointments()
    {
        using (MySqlConnection connection = new MySqlConnection(ConnectionString))
        {
            connection.Open();
            string selectQuery = $"SELECT * From Appointments ";
            using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"ID: {reader["id"]}, PatientID: {reader["PatientID"]}, DoctorID: {reader["DoctorID"]}, Date: {reader["Date"]}, Status: {reader["Status"]}, Complaint: {reader["Complaint"]}");
                    }
                    Console.WriteLine("Press Any Key To Continue");
                    Console.ReadKey();
                }

            }
        }
    }

    public static void ViewAllAcceptedAppointments()
    {
        using (MySqlConnection connection = new MySqlConnection(ConnectionString))
        {
            connection.Open();
            string selectQuery = $"SELECT * From AcceptedAppointments;";
            using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"ID: {reader["id"]}, PatientID: {reader["PatientID"]}, DoctorID: {reader["DoctorID"]}, Date: {reader["Date"]}, Status: {reader["Status"]}, Complaint: {reader["Complaint"]}");
                    }
                    Console.WriteLine("Press Any Key To Continue");
                    Console.ReadKey();
                }
            }
        }
    }

    public static void ViewAllDeclinedAppointments()
    {
        using (MySqlConnection connection = new MySqlConnection(ConnectionString))
        {
            connection.Open();
            string selectQuery = $"SELECT * From DeclinedAppointments ";
            using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"ID: {reader["id"]}, PatientID: {reader["PatientID"]}, DoctorID: {reader["DoctorID"]}, Date: {reader["Date"]}, Status: {reader["Status"]}, Complaint: {reader["Complaint"]}");
                    }
                    Console.WriteLine("Press Any Key To Continue");
                    Console.ReadKey();
                }
            }
        }
    }

    public static void CancelAppointment(Patient patient)
    {
        Appointment appointment = new Appointment();
        Console.Write("Are You Sure You Want To Cancel Appointment (Y For Yes) And (N For No): ");
        string prompt = Console.ReadLine();
        if (prompt == "Y" || prompt == "y")
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                connection.Open();
                string query = $"UPDATE Appointments SET Status = 'Cancelled' where PatientID = {patient.PatientID}";

                MySqlCommand command = new MySqlCommand(query, connection);
                var execute = command.ExecuteNonQuery();

                string selectQuery = $"SELECT * From Appointments where Status = 'Cancelled'";
                using (MySqlCommand command2 = new MySqlCommand(selectQuery, connection))
                {
                    using (MySqlDataReader reader = command2.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Appointment appointment1 = new Appointment();
                            appointment1.AppointmentID = reader.GetInt32(0);
                            appointment1.PatientID = reader.GetInt32(1);
                            appointment1.DoctorID = reader.GetInt32(2);
                            appointment1.Date = reader.GetDateTime(3);
                            appointment1.Status = reader.GetString(4);
                            appointment1.Complain = reader.GetString(5);
                            Cappointments.Add(appointment1);
                            string docStatus = "Free";
                            DoctorDB.UpdateStatus(docStatus, appointment1.DoctorID);
                        }
                    }
                }
                foreach (var item in Cappointments)
                {
                    MySqlCommand insert = new MySqlCommand($"insert into CancelledAppointments (PatientID, DoctorID, Date, Status ,Complaint) values('{appointment.PatientID = item.PatientID}', '{appointment.DoctorID = item.DoctorID}','{appointment.Date = item.Date}','{appointment.Status = item.Status}','{appointment.Complain = item.Complain}');", connection);


                    var execute2 = insert.ExecuteNonQuery();

                    if (execute2 == 0)
                    {
                        Console.WriteLine("Appointment Cancellation Failed");
                    }
                    else
                    {
                        Console.WriteLine("Appointment Cancelled.");
                        CancelledTask = true;
                    }
                }
            }
        }
        else if(prompt == "N" || prompt == "n")
        {
            Console.WriteLine("Press Any Key To Continue");
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine("Invalid Input.");
            Console.WriteLine();
        }
    }

    public static void UpdateStatus(string status, int id)
    {
        using (MySqlConnection connection = new MySqlConnection(ConnectionString))
        {
            connection.Open();
            string query = $"UPDATE AcceptedAppointments SET Status = {status} where DoctorID = {id}";

            MySqlCommand command = new MySqlCommand(query, connection);
            var execute = command.ExecuteNonQuery();
        }
    }

    public static void ViewAllCancelledAppointments()
    {
        using (MySqlConnection connection = new MySqlConnection(ConnectionString))
        {
            connection.Open();
            string selectQuery = $"SELECT * From CancelledAppointments ";
            using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"ID: {reader["id"]}, PatientID: {reader["PatientID"]}, DoctorID: {reader["DoctorID"]}, Date: {reader["Date"]}, Status: {reader["Status"]}, Complaint: {reader["Complaint"]}");
                    }
                    Console.WriteLine("Press Any Key To Continue");
                    Console.ReadKey();
                }
            }
        }
    }

    public static void ViewAllEndedAppointments()
    {
        using (MySqlConnection connection = new MySqlConnection(ConnectionString))
        {
            connection.Open();
            string selectQuery = $"SELECT * From AcceptedAppointments where Status = 'Ended'";
            using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"ID: {reader["id"]}, PatientID: {reader["PatientID"]}, DoctorID: {reader["DoctorID"]}, Date: {reader["Date"]}, Status: {reader["Status"]}, Complaint: {reader["Complaint"]}");
                    }
                    Console.WriteLine("Press Any Key To Continue");
                    Console.ReadKey();
                }
            }
        }
    }

    public static void deleteAcceptedAppointment()
    {
        using (MySqlConnection connection = new MySqlConnection(ConnectionString))
        {
            connection.Open();
            string query = $"delete from Appointments where Status = 'Accepted';";

            MySqlCommand command = new MySqlCommand(query, connection);
            var execute = command.ExecuteNonQuery();
        }
    }

    public static void deleteDeclinedAppointment()
    {
        using (MySqlConnection connection = new MySqlConnection(ConnectionString))
        {
            connection.Open();
            string query = $"delete from Appointments where Status = 'Declined';";

            MySqlCommand command = new MySqlCommand(query, connection);
            var execute = command.ExecuteNonQuery();
        }
    }
}
