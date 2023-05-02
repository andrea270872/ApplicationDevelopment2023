using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DataGrid
{
    public partial class SimpleDataGridSample : Window
    {
        private DataSet test123DataSet;
        private MySqlDataAdapter personDataAdapter;

        public SimpleDataGridSample()
        {
            InitializeComponent();

            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=test123;";

            // Prepare the connection
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            databaseConnection.Open();

            // use an Adapter to load data from the SQL table into a DataSet
            test123DataSet = new DataSet();
            personDataAdapter = new MySqlDataAdapter("Select * from Persons", databaseConnection);
            personDataAdapter.Fill(test123DataSet, "Persons");
            new MySqlCommandBuilder(personDataAdapter); // needed to be able to update the table back to the DB

            databaseConnection.Close();

            // and here is the magic
            //    TO DO check if test123DataSet.Tables["Persons"] is null or not...
            dgSimple.ItemsSource = test123DataSet.Tables["Persons"].DefaultView;


            // adding an event handler to the dataset object
            test123DataSet.Tables["Persons"].RowChanged += OnRowModified;
        }

        private void OnRowModified(object sender, DataRowChangeEventArgs e)
        {
            // DEBUG  MessageBox.Show("Updating the table Persons ... done! :) ");
            personDataAdapter.Update(test123DataSet.Tables["Persons"]);
        }
    }
}