using MySqlConnector;

namespace SQL_connection_v1
{
    public class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=test123;";

            // Prepare the connection
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);

            try
            {
                // Open the database
                databaseConnection.Open();
                Console.WriteLine("1- connection established");

                // Define the query
                string query = "INSERT INTO Persons (PersonID,LastName,FirstName,Address,City) " +
                    "VALUES (null,'Jensen','Jens','Jensvej 1','Kolding');";
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);

                // Execute the query
                commandDatabase.ExecuteNonQuery(); // different from SELECT!
                Console.WriteLine("2- Insert executed");

                Console.WriteLine("3- connection closed");
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                // Show any error message.
                Console.WriteLine(ex.Message);
            }

        }
    }
}