using MySqlConnector;

namespace SQL_connection_v1
{
    public class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=test123;";
            // Your query,
            string query = "SELECT * FROM Persons";

            // Prepare the connection
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                // Open the database
                databaseConnection.Open();
                Console.WriteLine("1- connection established");

                // Execute the query
                reader = commandDatabase.ExecuteReader();
                Console.WriteLine("2- Select executed");

                // read and write to console all rows
                while (reader.Read())
                {
                    Console.WriteLine("  " + reader[0] + "/" + 
                                        reader[1] + "/" +
                                        reader[2] + "/" +
                                        reader[3] + "/" +
                                        reader[4]  );
                }

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