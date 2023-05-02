using MySqlConnector;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace DataTableExample
{
    public class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=test123;";

            // Prepare the connection
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);

            // Define the query
            string query = "Select * from Persons";
            MySqlCommand command = new MySqlCommand(query, databaseConnection);

            databaseConnection.Open();

            DataTable personsTable = new DataTable(); // just created, empty
            MySqlDataReader myDataReader = command.ExecuteReader();
            personsTable.Load(myDataReader); // loads from the SQL result

            // now that the DataTable is created, I can close the connection
            databaseConnection.Close();

            // the DataTable is still here :)
            // I will iterate over all the rows and columns, and write them 
            foreach (DataRow dataRow in personsTable.Rows)
            {
                Console.WriteLine("row starts here -----------");
                foreach (var item in dataRow.ItemArray)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("-------------- row ends here");
            }

        }
    }
}