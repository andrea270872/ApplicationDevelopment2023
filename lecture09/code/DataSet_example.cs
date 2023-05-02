using MySqlConnector;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace DataSetExample
{
    public class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=test123;";

            // Prepare the connection
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            databaseConnection.Open();

            DataSet test123DataSet = new DataSet();


            // loading (AKA filling) the persons table
            MySqlCommand personsCommand = new MySqlCommand("Select * from Persons", databaseConnection);
            MySqlDataAdapter personDataAdapter = new MySqlDataAdapter();
            personDataAdapter.SelectCommand = personsCommand;
            personDataAdapter.Fill(test123DataSet,"Persons");

            // loading (AKA filling) the shirts table
            MySqlCommand shirtsCommand = new MySqlCommand("Select * from shirts", databaseConnection);
            MySqlDataAdapter shirtsDataAdapter = new MySqlDataAdapter();
            shirtsDataAdapter.SelectCommand = shirtsCommand;
            shirtsDataAdapter.Fill(test123DataSet, "Shirts");

            // now that the DataSet is created, I can close the connection
            databaseConnection.Close();

            foreach (DataTable table in test123DataSet.Tables) {
                Console.WriteLine("\n[=== Table ======== " +  table.TableName);
                foreach (DataRow dataRow in table.Rows)
                {
                    Console.WriteLine("row starts here -----------");
                    foreach (var item in dataRow.ItemArray)
                    {
                        Console.WriteLine(item);
                    }
                    Console.WriteLine("-------------- row ends here");
                }
                Console.WriteLine("================== ]");
            }

        }
    }
}