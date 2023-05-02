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

            // now I can try to change some data in the tables
            // Table 0 is persons
            test123DataSet.Tables[0].Rows.Add(null, "Stewart", "Rod", "Beverly Drive 666", "Los Angeles");
            
            // Table 1 is shirts
            test123DataSet.Tables[1].Rows.Add(null, "fancy t-shirt", "lilla", 3); // Rod's

            // now to push the new tables into the DB!
            // - Create 2 command builders object  
            MySqlCommandBuilder builder1 = new MySqlCommandBuilder(personDataAdapter);
            MySqlCommandBuilder builder2 = new MySqlCommandBuilder(shirtsDataAdapter);
            personDataAdapter.Update(test123DataSet, "Persons");
            shirtsDataAdapter.Update(test123DataSet, "Shirts");
        }
    }
}