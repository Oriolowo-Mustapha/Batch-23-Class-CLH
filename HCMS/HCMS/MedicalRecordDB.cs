using MySql.Data.MySqlClient;
using System.Numerics;
using System.Reflection;
using System.Xml.Linq;

public class MedicalRecordDB
{
    private static string ConnectionStringWithoutDB = "Server = localhost; User = root; password = password";
    private static string ConnectionString = "Server = localhost; User = root; database = MedicalRecord; password = password";

    public static bool CreateMedicalRecordDB()
    {
        using (MySqlConnection connection = new MySqlConnection(ConnectionStringWithoutDB))
        {
            connection.Open();
            string query = "Create Database if not exists MedicalRecord";

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

    public static bool CreateMedicalRecordTable()
    {
        using (MySqlConnection connection = new MySqlConnection(ConnectionString))
        {
            connection.Open();
            string query = "create table if not exists MedicalRecords(id int primary Key not null auto_increment, DoctorID int Not Null ,PatientID int Not Null , Diagnosis varchar(255) Not Null, Treatment varchar(255) not null , Date Date Not Null, Notes varchar(255) not null );";

            MySqlCommand command = new MySqlCommand(query, connection);
            var execute = command.ExecuteNonQuery();

            if (execute == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public static void AddMedicalRecord(Doctor doctor)
    {
        MedicalRecord medicalRecord = new MedicalRecord();
        bool run = true;
        while (run)
        {
            Console.Write("Patient ID=> ");
            int patientId = int.Parse(Console.ReadLine());
            try
            {
                if (PatientDB.CheckPatient(patientId) == true)
                {
                    Console.Write("Diagnosis=> ");
                    string diagnosis = Console.ReadLine();
                    Console.Write("Treatment=> ");
                    string treatment = Console.ReadLine();
                    Console.Write("Date (MM/DD/YYYY)=> ");
                    DateTime date = DateTime.Today;
                    try
                    {
                        run = false;
                        Console.Write("Observations=> ");
                        string note = Console.ReadLine();

                        using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                        {
                            connection.Open();
                            MySqlCommand insert = new MySqlCommand($"insert into MedicalRecords (DoctorID, PatientID, Diagnosis, Treatment, Date, Notes) values('{medicalRecord.DoctorID = doctor.DoctorID}','{medicalRecord.PatientID = patientId}', '{medicalRecord.Diagnosis = diagnosis}','{medicalRecord.Treatment = treatment}', '{medicalRecord.Date = date}','{medicalRecord.Notes = note}');", connection);
                            var execute = insert.ExecuteNonQuery();

                            if (execute == 0)
                            {
                                Console.WriteLine("Failed To Add Record.");
                            }
                            else
                            {
                                Console.WriteLine("Medical Record Added Successfully.");
                                DoctorDB.UpdateStatus("Free", doctor.DoctorID);
                                AppointmentDb.UpdateStatus("Ended", doctor.DoctorID);
                            }
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid Input\nPLS TryAgain.");
                        Console.Write("Date (MM/DD/YYYY)=> ");
                        date = DateTime.Today;
                    }
                }
                else
                {
                    Console.WriteLine("Patient Not Found");
                    Console.Write("Patient ID=> ");
                    patientId = int.Parse(Console.ReadLine());
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Input\nPLS TryAgain.");
                Console.Write("Patient ID=> ");
                patientId = int.Parse(Console.ReadLine());
            }
                
        }
    }

    public static void GetAllMedicalRecords()
    {
        using (MySqlConnection connection = new MySqlConnection(ConnectionString))
        {
            connection.Open();

            string selectQuery = "SELECT * From MedicalRecords";
            using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    Console.WriteLine("Records: ");
                    while (reader.Read())
                    {
                        Console.WriteLine($"ID: {reader["id"]}, DoctorID: {reader["DoctorID"]}, PatientID: {reader["PatientID"]}, Diagnosis: {reader["Diagnosis"]}, Treatment: {reader["Treatment"]}, Date: {reader["Date"]}, Observations: {reader["Notes"]}");
                    }
                    Console.WriteLine("Press Any Key To Continue");
                    Console.ReadKey();
                }
            }
        }
    }

    public static void GetMedicalRecords(string name)
    {
        PatientDB.GetPatient(name);
        Console.Write("Enter Patient ID To View Medical Record: ");
        int patientID = int.Parse(Console.ReadLine());
        using (MySqlConnection connection = new MySqlConnection(ConnectionString))
        {
            connection.Open();

            string selectQuery = $"SELECT * From MedicalRecords where PatientID = {patientID}";
            using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    Console.WriteLine("Records: ");
                    while (reader.Read())
                    {
                        Console.WriteLine($"ID: {reader["id"]}, DoctorID: {reader["DoctorID"]}, PatientID: {reader["PatientID"]}, Diagnosis: {reader["Diagnosis"]}, Treatment: {reader["Treatment"]}, Date: {reader["Date"]}, Observations: {reader["Notes"]}");
                    }
                    if (!reader.Read())
                    {
                        Console.WriteLine("No Record Available");
                    }
                    Console.WriteLine("Press Any Key To Continue");
                    Console.ReadKey();
                }
            }
        }
    }

    public static void GetPatientMedicalRecords(int id)
    {
        using (MySqlConnection connection = new MySqlConnection(ConnectionString))
        {
            connection.Open();

            string selectQuery = $"SELECT * From MedicalRecords where PatientID = {id}";
            using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    Console.WriteLine("Records: ");
                    while (reader.Read())
                    {
                        Console.WriteLine($"ID: {reader["id"]}, DoctorID: {reader["DoctorID"]}, PatientID: {reader["PatientID"]}, Diagnosis: {reader["Diagnosis"]}, Treatment: {reader["Treatment"]}, Date: {reader["Date"]}, Observations: {reader["Notes"]}");
                    }
                    if (!reader.Read())
                    {
                        Console.WriteLine("No Record Available");
                    }
                    Console.WriteLine("Press Any Key To Continue");
                    Console.ReadKey();
                }
            }
        }
    }

    public static void UpdateRecord(string name)
    {
        PatientDB.GetPatient(name);
        Console.Write("Enter Patient ID To View Medical Record: ");
        int patientID = int.Parse(Console.ReadLine());

        Console.Write("Diagnosis=> ");
        string diagnosis = Console.ReadLine();
        Console.Write("Treatment=> ");
        string treatment = Console.ReadLine();
        Console.Write("Observations=> ");
        string note = Console.ReadLine();

        using (MySqlConnection connection = new MySqlConnection(ConnectionString))
        {
            connection.Open();
            string query = $"UPDATE MedicalRecords SET Diagnosis = {diagnosis} , Treatment = {treatment}, Notes = {note} where id = {patientID}";

            MySqlCommand command = new MySqlCommand(query, connection);
            var execute = command.ExecuteNonQuery();

            if (execute > 0)
            {
                Console.WriteLine("Updated Successfully.");
            }
            else
            {
                Console.WriteLine("Info Couldnt Be Upadated.");
            }
        }
    }
}
