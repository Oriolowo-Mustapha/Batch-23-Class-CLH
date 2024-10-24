using MySql.Data.MySqlClient;
using Mysqlx.Prepare;

public class InstructorManager
{
    private static string ConnectionStringWithoutDB = "Server = localhost; User = root; password = password";
    private static string ConnectionString = "Server = localhost; User = root; database = StudentDataBase; password = password";
    public static void CreateInstructorsTable()
    {
        using (MySqlConnection connection = new MySqlConnection(ConnectionString))
        {
            connection.Open();
            string query = "create table if not exists StudentDataBase.intstructors(id int primary Key not null auto_increment, Name varchar(255) Not Null, Address varchar(255),  Email varbinary(200) not null unique, StudentID int ,foreign key (StudentID) references students(id))";

            MySqlCommand command = new MySqlCommand(query, connection);
            var execute = command.ExecuteNonQuery();

            if (execute == 0)
            {
                Console.WriteLine("Table Created Successfully.");
            }
            else
            {
                Console.WriteLine("Unable To Create Table.");
            }
        }
    }

    public static void CreateInstructors(Instructor instructor)
    {
        using (MySqlConnection connection = new MySqlConnection(ConnectionString))
        {
            connection.Open();
            MySqlCommand insert = new MySqlCommand($"insert into StudentDataBase.intstructors(name, address, email,studentid) values('{instructor.Name = "Chike"}', '{instructor.Address = "Anambra"}','{instructor.Email = "chi@gmail.com"}', '{instructor.StudentID =  7}');", connection);


            var execute = insert.ExecuteNonQuery();

            if (execute == 0)
            {
                Console.WriteLine("Unable To Create Teacher.");
                
            }
            else
            {
                Console.WriteLine("Teacher Created Successfully.");
            }
        }

    }

    public static void UpdateStaff()
    {
        using (MySqlConnection connection = new MySqlConnection(ConnectionString))
        {
            connection.Open();
            string query = "UPDATE StudentDataBase.intstructors SET name = 'Jide' where id = 1";

            MySqlCommand command = new MySqlCommand(query, connection);
            var execute = command.ExecuteNonQuery();

            if (execute > 0)
            {
                Console.WriteLine("Updated Successfully.");
            }
            else
            {
                Console.WriteLine("Unable To Update.");
            }
        }
    }

    public static void DeleteInstructor()
    {
        using (MySqlConnection connection = new MySqlConnection(ConnectionString))
        {
            connection.Open();
            string query = "delete from intstructors where id = 2;";

            MySqlCommand command = new MySqlCommand(query, connection);
            var execute = command.ExecuteNonQuery();

            if (execute > 0)
            {
                Console.WriteLine("Deleted Successfully.");
            }
            else
            {
                Console.WriteLine("Unable To Delete.");
            }
        }
    }

    public static void GetAllInstructors()
    {
        using (MySqlConnection connection = new MySqlConnection(ConnectionString))
        {
            connection.Open();

            string selectQuery = "SELECT id, name, address,email From intstructors";
            using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    Console.WriteLine("Instructors in the database: ");
                    while (reader.Read())
                    {
                        Console.WriteLine($"ID: {reader["id"]}, Name: {reader["name"]}, Address: {reader["address"]},Email: {reader["email"]}");
                    }
                }
            }
        }
    }

    public static void GetInstructors()
    {
        using (MySqlConnection connection = new MySqlConnection(ConnectionString))
        {
            connection.Open();

            string selectQuery = "SELECT id, name, address,email From intstructors where id = 7";
            using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    Console.WriteLine("Instructors: ");
                    if (!reader.Read())
                    {
                        Console.WriteLine("Instructors Not Found");
                    }
                    else
                    {

                        Console.WriteLine($"ID: {reader["id"]}, Name: {reader["name"]}, Address: {reader["address"]},Email: {reader["email"]}");
                    }
                    //while (reader.Read())
                    //{
                    //    Console.WriteLine($"ID: {reader["id"]}, Name: {reader["name"]}, Address: {reader["address"]},Email: {reader["email"]}");
                    //}
                }
            }
        }
    }

    public static void GetStudentsAndSupervisors()
    {
        using (MySqlConnection connection = new MySqlConnection(ConnectionString))
        {
            connection.Open();

            string selectQuery = $"SELECT students.id, students.name, intstructors.Name From students Inner Join intstructors on students.id = intstructors.StudentID";
            using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        Console.WriteLine($"ID: {reader["id"]}, Student name: {reader["name"]}, Instructors Name: {reader["Name"]}");
                    }
                        
                }
            }
        }
    }

    public static void GetStudentAndSupervisorsUsingInnerJoin()
    {
        using (MySqlConnection connection = new MySqlConnection(ConnectionString))
        {
            connection.Open();

            string selectQuery = $"SELECT students.id, students.name, intstructors.Name From students Inner Join intstructors on students.id = intstructors.StudentID where students.id = 7";
            using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        Console.WriteLine($"ID: {reader["id"]}, Student name: {reader["name"]}, Instructors Name: {reader["Name"]}");
                    }

                }
            }
        }
    }

    public static void GetStudentAndSupervisorsUsingLeftJoin()
    {
        using (MySqlConnection connection = new MySqlConnection(ConnectionString))
        {
            connection.Open();

            string selectQuery = $"SELECT students.id, students.name, intstructors.Name From students Left Join intstructors on students.id = intstructors.StudentID where students.id = 7";
            using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        Console.WriteLine($"ID: {reader["id"]}, Student name: {reader["name"]}, Instructors Name: {reader["Name"]}");
                    }

                }
            }
        }
    }

    public static void GetStudentAndSupervisorsUsingRightJoin()
    {
        using (MySqlConnection connection = new MySqlConnection(ConnectionString))
        {
            connection.Open();

            string selectQuery = $"SELECT students.id, students.name, intstructors.Name From students Right Join intstructors on students.id = intstructors.StudentID where students.id = 7";
            using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        Console.WriteLine($"ID: {reader["id"]}, Student name: {reader["name"]}, Instructors Name: {reader["Name"]}");
                    }

                }
            }
        }
    }

    public static void GetStudentsAndSupervisorsUsingFullJoin()
    {
        using (MySqlConnection connection = new MySqlConnection(ConnectionString))
        {
            connection.Open();

            string selectQuery = $"SELECT students.id, students.name, intstructors.Name From students Left Join intstructors on students.id = intstructors.StudentID Union All SELECT students.id, students.name, intstructors.Name From students Right Join intstructors on students.id = intstructors.StudentID";
            using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        Console.WriteLine($"ID: {reader["id"]}, Student name: {reader["name"]}, Instructors Name: {reader["Name"]}");
                    }

                }
            }
        }
    }
}