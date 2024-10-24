using MySql.Data.MySqlClient;

public class WalletDB
{
    private static string ConnectionStringWithoutDB = "Server = localhost; User = root; password = password";
    private static string ConnectionString = "Server = localhost; User = root; database = Wallet; password = password";

    public static void CreateWalletDB()
    {
        using (MySqlConnection connection = new MySqlConnection(ConnectionStringWithoutDB))
        {
            connection.Open();
            string query = "Create Database if not exists Wallet";

            MySqlCommand command = new MySqlCommand(query, connection);
            var execute = command.ExecuteNonQuery();

        
        }
    }

    public static void CreateWalletTable()
    {
        using (MySqlConnection connection = new MySqlConnection(ConnectionString))
        {
            connection.Open();
            string query = "CREATE TABLE IF NOT EXISTS Wallets (id INT PRIMARY KEY NOT NULL,Balance INT NOT NULL,Status VARCHAR(255) NOT NULL,UserID INT NOT NULL, FOREIGN KEY (UserID) REFERENCES Patients(id));";

            MySqlCommand command = new MySqlCommand(query, connection);
            var execute = command.ExecuteNonQuery();
        }
    }

    public static void LoginWallet(Patient patient)
    {
        Random random = new Random();

    }
}
