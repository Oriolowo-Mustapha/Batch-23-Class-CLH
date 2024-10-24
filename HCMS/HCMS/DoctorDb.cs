using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Linq;
using MySql.Data.MySqlClient;

public class DoctorDB
{
    private static string ConnectionStringWithoutDB = "Server = localhost; User = root; password = password";
    private static string ConnectionString = "Server = localhost; User = root; database = Doctor; password = password";
    public static bool Task = false;
    private static List<Doctor> DOCTORS = new List<Doctor>();
    public static void CreateDoctorDB()
    {
        using (MySqlConnection connection = new MySqlConnection(ConnectionStringWithoutDB))
        {
            connection.Open();
            string query = "Create Database if not exists Doctor";

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

    public static void CreateDoctorTable()
    {
        using (MySqlConnection connection = new MySqlConnection(ConnectionString))
        {
            connection.Open();
            string query = "create table if not exists Doctors(id int primary Key not null , Name varchar(255) Not Null unique, Specialty varchar(255) Not Null, ContactInfo varchar(255) not null unique, Availability varchar(255) Not Null);";

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

    public static void AddDoctor()
    {
        Random random = new Random();
        Doctor doctor = new Doctor();
        Console.WriteLine("How Many Doctors Do You Want To Add: ");
        int input = int.Parse(Console.ReadLine());
        int count = 1;
        while (count <= input)
        {
            Console.WriteLine(count);
            int id = random.Next(99, 999);
            Console.WriteLine($"Doctor ID: {id}");
            Console.Write("Enter Doctor Name=> ");
            string name = Console.ReadLine().ToUpper();
            Console.Write("Enter Doctor Specialty=> ");
            string specialty = Console.ReadLine();
            Console.Write("Enter Doctor Contact Info (Email or Phone Number) => ");
            string contactInfo = Console.ReadLine();
            try
            {
                string availability = "Free";
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();
                    MySqlCommand insert = new MySqlCommand($"insert into Doctors (id, Name, Specialty, ContactInfo, Availability) values('{doctor.DoctorID = id}','{doctor.Name = name}', '{doctor.Specialty = specialty}','{doctor.ContactInfo = contactInfo}', '{doctor.AvailabilityStatus = availability}');", connection);


                    var execute = insert.ExecuteNonQuery();

                    if (execute == 0)
                    {
                        Console.WriteLine("Doctor Couldnt Be Added.");
                    }
                    else { 
                        Console.WriteLine("Doctor Added Successfully.\n");
                        count++;
                    }
                }
            }
            catch (MySqlException)
            {
                Console.WriteLine("Contact Info Has Been Used By An Existing Doctor.");
                Console.Write("Enter Doctor Contact Info (Email or Phone Number) => ");
                contactInfo = Console.ReadLine();
            }
            
        }
    }

    public static void DeleteDoctor()
    {
        bool run = true;
        while (run)
        {
            Console.Write("Doctor ID=> ");
            int id = int.Parse(Console.ReadLine());
            try
            {
                run = false;
                using (MySqlConnection connection = new MySqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query = $"delete from Doctors where id = {id};";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    var execute = command.ExecuteNonQuery();

                    if (execute > 0)
                    {
                        Console.WriteLine("Doctor Deleted Successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Doctor Couldnt Be Deleted.");
                    }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Input\nPls TryAgain");
                Console.Write("Doctor ID=> ");
                id = int.Parse(Console.ReadLine());
            }
        }
    }

    public static void GetAllDoctors()
    {
        using (MySqlConnection connection = new MySqlConnection(ConnectionString))
        {
            connection.Open();

            string selectQuery = "SELECT id, Name, Specialty, ContactInfo , Availability From Doctors";
            using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    Console.WriteLine("Doctors: ");
                    while (reader.Read())
                    {
                        Console.WriteLine($"ID: {reader["id"]}, Name: {reader["name"]}, Specialty: {reader["Specialty"]}, Contact Info: {reader["ContactInfo"]}, Avalability Status: {reader["Availability"]}");
                    }
                    if (!reader.Read())
                    {
                        Console.WriteLine("Doctor Has Not Been Registered Yet.");
                    }
                    Console.WriteLine("Press Any Key To Continue");
                    Console.ReadKey();
                }
            }
        }
    }

    public static void RetrieveFromDb()
    {
        using (MySqlConnection connection = new MySqlConnection(ConnectionString))
        {
            connection.Open();
            string selectQuery = $"SELECT * From Doctors";
            using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    { 
                        Doctor doc = new Doctor();
                        doc.DoctorID = reader.GetInt32(0);
                        doc.Name = reader.GetString(1);
                        doc.Specialty = reader.GetString(2);
                        doc.ContactInfo = reader.GetString(3);
                        doc.AvailabilityStatus = reader.GetString(4);
                        DOCTORS.Add(doc);
                    }
                }
            }
        }
    }

    public static Doctor DoctorLogin(int doctorID)
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
                    string selectQuery = $"SELECT id , Name, Specialty, ContactInfo, Availability From Doctors where id = {doctorID}";
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
                                Doctor doc = new Doctor();
                                doc.DoctorID = reader.GetInt32(0);
                                doc.Name = reader.GetString(1);
                                doc.Specialty = reader.GetString(2);
                                doc.ContactInfo = reader.GetString(3);
                                doc.AvailabilityStatus = reader.GetString(4);
                                DOCTORS.Add(doc);
                                return doc;
                            }
                        }
                    }
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Input.\nPls TryAgain.");
                doctorID = int.Parse(Console.ReadLine());
            }

        }
        return null;
    }

    public static bool CheckDoctor(int id)
    {
        using (MySqlConnection connection = new MySqlConnection(ConnectionString))
        {
            connection.Open();

            string selectQuery = $"SELECT id From Doctors where id = {id}";
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

    //public static bool CheckDoctorAvailablity(int id)
    //{
    //    foreach (var item in DOCTORS)
    //    {
    //        if (item.DoctorID == id)
    //        {
    //            if (item.AvailabilityStatus == "Free")
    //            {
    //                return true;
    //            }
    //        }
    //    }
    //    return false;
    //}

    //public static string CheckSpecialty(int id)
    //{
    //    foreach (var item in DOCTORS)
    //    {
    //        if (item.DoctorID == id)
    //        {
    //            return item.Specialty;
    //        }
    //    }
    //    return null;
    //}

    public static string GetDocName(int id)
    {
        foreach (var item in DOCTORS)
        {
            if (item.DoctorID == id)
            {
                return item.Name;
            }
        }
        return null;
    }

    //public static int GetDocID(string name)
    //{
    //    foreach (var item in DOCTORS)
    //    {
    //        if (item.Name == name)
    //        {
    //            return item.DoctorID;
    //        }
    //    }
    //    return 0;
    //}

    public static void CheckDoctor()
    {
        using (MySqlConnection connection = new MySqlConnection(ConnectionString))
        {
            connection.Open();

            string selectQuery = $"SELECT * From Doctors where Availability = 'Free'";
            using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine($"ID: {reader["id"]}, Name: {reader["Name"]}, Specialty: {reader["Specialty"]}, Contact Info: {reader["ContactInfo"]}, Avalability Status: {reader["Availability"]}");
                    }
                }
            }
        }
    }

    public static void UpdateStatus(string status, int id)
    {
        using (MySqlConnection connection = new MySqlConnection(ConnectionString))
        {
            connection.Open();
            string query = $"UPDATE Doctors SET Availability = '{status}' where id = {id}";

            MySqlCommand command = new MySqlCommand(query, connection);
            var execute = command.ExecuteNonQuery();
        }
    }

    public static void GetDoctor(string name)
    {
        using (MySqlConnection connection = new MySqlConnection(ConnectionString))
        {
            connection.Open();

            string selectQuery = $"SELECT * From Doctors where Name Like '%" + name + "%'";
            using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    Console.WriteLine("Doctor: ");
                    while (reader.Read())
                    {
                        Console.WriteLine($"ID: {reader["id"]}, Name: {reader["name"]}, Specialty: {reader["Specialty"]}, Contact Info: {reader["ContactInfo"]}, Avalability Status: {reader["Availability"]}");
                    }
                    if (!reader.Read())
                    {
                        Console.WriteLine("Doctor Not Found");
                    }
                    Console.WriteLine("Press Any Key To Continue");
                    Console.ReadKey();
                }
                
            }
        }
    }
}

