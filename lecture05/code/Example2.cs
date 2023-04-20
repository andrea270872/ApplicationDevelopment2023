using System;
using System.Collections.Generic;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // read a text box, convert it to a number
            int userNumber = int.Parse(myNumberBox.Text);
            MessageBox.Show("You typed: " + myText.Text + 
                "\nAnd your number is "+ userNumber + 
                "\nThe double is " + 2*userNumber);

            // write back to another textbox
            myText.Text = "double is " + 2 * userNumber;
        }
    }
}
