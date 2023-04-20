using System;
using System.Collections.Generic;
using System.Globalization;
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
        List<Product> ShoppingCart;

        public MainWindow()
        {
            InitializeComponent();

            ShoppingCart = new List<Product>(); 
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // I have to use the CultureInfo.InvariantCulture parameter, 
            // to ensure that 1,5 is converted to 1.5 correctly!
            double priceValue = double.Parse(PriceText.Text, CultureInfo.InvariantCulture);

            Product temp = new Product(NameText.Text, BrandText.Text, priceValue);
            ShoppingCart.Add(temp);
            refreshTextBlock();
        }

        private void refreshTextBlock()
        {
            if (ShoppingCart.Count == 0)
            {
                listTextBlock.Text = "nothing";
            } else
            {
                listTextBlock.Text = "";
                for (int i = 0; i < ShoppingCart.Count; i++)
                {
                    listTextBlock.Text += ShoppingCart[i] + "\n";
                }
            }

        }
    }
}
