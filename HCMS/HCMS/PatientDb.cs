using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

public class PatientDB
{
    private static string ConnectionStringWithoutDB = "Server = localhost; User = root; password = password";
    private static string ConnectionString = "Server = localhost; User = root; database = Patient; password = password";
    private static List<Patient> patients = new List<Patient>();
    public static bool Task = false;
    public static void CreatePatientDB()
    {
        using (MySqlConnection connection = new MySqlConnection(ConnectionStringWithoutDB))
        {
            connection.Open();
            string query = "Create Database if not exists Patient";

            MySqlCommand command = new MySqlCommand(query, connection);
            var execute = command.ExecuteNonQuery();

            if (execute > 0)
            {
                Task = true;
            }
            else
            {
                Task = false;
            }
        }
    }

    public static void CreatePatientTable()
    {
        using (MySqlConnection connection = new MySqlConnection(ConnectionString))
        {
            connection.Open();
            string query = "create table if not exists Patients(id int primary Key not null auto_increment, Name varchar(255) Not Null unique, Age int not null, Gender varchar(255) , ContactInfo varchar(255) not null unique);";

            MySqlCommand command = new MySqlCommand(query, connection);
            var execute = command.ExecuteNonQuery();

            if (execute == 0)
            {
                Task = true;
            }
            else
            {
                Task = false;
            }
        }
    }

    public static void ViewPersonalInfo(int id)
    {
        using (MySqlConnection connection = new MySqlConnection(ConnectionString))
        {
            connection.Open();

            string selectQuery = $"SELECT * From patients where id = {id}";
            using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Console.WriteLine($"ID: {reader["id"]}, Name: {reader["name"]}, Age: {reader["age"]}, Gender: {reader["gender"]}, Contact Info: {reader["ContactInfo"]}");
                    }
                }
            }
        }
    }

    public static void AddPatient()
    {
        Patient patient = new Patient();
        Console.WriteLine("How Many Patients Do You Want To Add: ");
        int input = int.Parse(Console.ReadLine());
        int count = 1;
        while (count <= input)
        {
            Console.WriteLine($"{count}.");
            Console.Write("Enter Patient Name=> ");
            string name = Console.ReadLine().ToUpper();
            Console.Write("Enter Patient Age=> ");
            int age = int.Parse(Console.ReadLine());
            try
            {
                Console.Write("Enter Patient Gender=> ");
                string gender = Console.ReadLine();
                Console.Write("Enter Patient Contact Info (Email or Phone Number) => ");
                string contactInfo = Console.ReadLine();
                try
                {
                    using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                    {
                        connection.Open();
                        MySqlCommand insert = new MySqlCommand($"insert into Patients (name, age, gender, ContactInfo) values('{patient.Name = name}', '{patient.Age = age}','{patient.Gender = gender}','{patient.ContactInfo = contactInfo}');", connection);


                        var execute = insert.ExecuteNonQuery();

                        if (execute == 0)
                        {
                            Console.WriteLine("Patient Couldnt Be Added Successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Patient Added Successfully.\n");
                            count++;
                        }
                    }
                }
                catch (MySqlException)
                {
                    Console.WriteLine("Contact Info Has Been Used By An Existing Patient.\nPls Tryagain");
                    Console.Write("Enter Patient Contact Info (Email or Phone Number) => ");
                    contactInfo = Console.ReadLine();
                }
                
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Input\nPls Try Again.");
                Console.Write("Enter Patient Age=> ");
                age = int.Parse(Console.ReadLine());
            }

        }
    }

    public static void UpdatePersonalInfo(Patient patient)
    {
        bool run = true;
        while (run)
        {
            Console.Write("Patient Contact Info (Email or Phone Number) => ");
            string contactInfo = Console.ReadLine();
            try
            {
                run = false;
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = $"UPDATE Patients SET ContactInfo = {contactInfo} where id = {patient.PatientID}";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    var execute = command.ExecuteNonQuery();

                    if (execute > 0)
                    {
                        Console.WriteLine("Updated Successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Info Couldnt Be Updated.");
                    }
                }
            }
            catch (MySqlException)
            {
                Console.WriteLine("Contact Info Has Been Used By Patient.");
                Console.Write("Patient Contact Info (Email or Phone Number) => ");
                contactInfo = Console.ReadLine();
            }
        }
    }

    public static void DeletePatient()
    {
        bool run = true;
        while (run)
        {
            Console.Write("Patient ID=> ");
            int id = int.Parse(Console.ReadLine());
            try
            {
                run = false;
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = $"delete from Patients where id = {id};";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    var execute = command.ExecuteNonQuery();

                    if (execute > 0)
                    {
                        Console.WriteLine("Patient Deleted Successfully");
                    }
                    else
                    {
                        Console.WriteLine("Patient Couldnt Be Deleted");
                    }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Input.\nPls TryAgain.");
                Console.Write("Patient ID=> ");
                id = int.Parse(Console.ReadLine());
            }
        }
    }

    public static void GetAllPatient()
    {
        using (MySqlConnection connection = new MySqlConnection(ConnectionString))
        {
            connection.Open();

            string selectQuery = "SELECT id, name, age, gender, ContactInfo From Patients";
            using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    Console.WriteLine("Patients: ");
                    while (reader.Read())
                    {
                        Console.WriteLine($"ID: {reader["id"]}, Name: {reader["name"]}, Age: {reader["age"]}, Gender: {reader["gender"]}, Contact Info: {reader["ContactInfo"]}");
                    }
                    if (!reader.Read())
                    {
                        Console.WriteLine("No Patient Has Been Registered");
                    }
                    Console.WriteLine("Press Any Key To Continue");
                    Console.ReadKey();
                }
            }
        }
    }

    public static void GetPatient(string name)
    {
        using (MySqlConnection connection = new MySqlConnection(ConnectionString))
        {
            connection.Open();

            string selectQuery = $"SELECT * From Patients where Name Like '%" + name + "%'";
            using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    Console.WriteLine("Patient: ");
                    while (reader.Read())
                    {
                        Console.WriteLine($"ID: {reader["id"]}, Name: {reader["name"]}, Age: {reader["age"]}, Gender: {reader["gender"]}, Contact Info: {reader["ContactInfo"]}");
                        
                    }
                    if (!reader.Read())
                    {
                        Console.WriteLine("Patient Not Found");
                    }
                    Console.WriteLine("Press Any Key To Continue");
                    Console.ReadKey();
                }
            }
        }
    }

    public static bool CheckPatient(int id)
    {
        using (MySqlConnection connection = new MySqlConnection(ConnectionString))
        {
            connection.Open();

            string selectQuery = $"SELECT id From patients where id = {id}";
            using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (!reader.Read())
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
        }
    }
    public static void RetrieveFromDb()
    {
        using (MySqlConnection connection = new MySqlConnection(ConnectionString))
        {
            connection.Open();
            string selectQuery = $"SELECT * From Patients";
            using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Patient patient = new Patient();
                        patient.PatientID = reader.GetInt32(0);
                        patient.Name = reader.GetString(1);
                        patient.Age = reader.GetInt32(2);
                        patient.Gender = reader.GetString(3);
                        patient.ContactInfo = reader.GetString(4);
                        patients.Add(patient);
                    }
                }
            }
        }
    }

    public static string GetPatientName(int id)
    {
        foreach (var item in patients)
        {
            if (item.PatientID == id)
            {
                return item.Name;
            }
        }
        return null;
    }

    public static int GetPatientID(string name)
    {
        foreach (var item in patients)
        {
            if (item.Name == name)
            {
                return item.PatientID;
            }
        }
        return 0;
    }

    public static Patient PatientLogin(int patientID)
    {
        bool run = true;
        while (run)
        {
            try
            {
                run = false;
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();
                    string selectQuery = $"SELECT id ,name, age, gender, ContactInfo From Patients where id = {patientID}";
                    using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (!reader.Read())
                            {
                                return null;
                            }
                            else
                            {
                                Patient patient = new Patient();
                                patient.PatientID = reader.GetInt32(0);
                                patient.Name = reader.GetString(1);
                                patient.Age = reader.GetInt32(2);
                                patient.Gender = reader.GetString(3);
                                patient.ContactInfo = reader.GetString(4);
                                patients.Add(patient);
                                return patient;
                            }
                        }
                    }
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Input.\nPls TryAgain.");
                patientID = int.Parse(Console.ReadLine());
            }

        }
        return null;
    }
}
