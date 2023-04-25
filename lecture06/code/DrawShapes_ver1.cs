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

namespace DrawingShapes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Random rnd;

        public MainWindow()
        {
            InitializeComponent();
            rnd = new Random();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Ellipse ell = new Ellipse();
            
            // set the size of the new ellipse
            ell.Width = rnd.Next(30,150);
            ell.Height = rnd.Next(30, 100);

            // set the color 
            ell.Fill = System.Windows.Media.Brushes.Yellow;
            ell.Stroke = System.Windows.Media.Brushes.Black;
            
            // set the position of the new ellipse
            Canvas.SetTop(ell, rnd.Next(50, 400));
            Canvas.SetLeft(ell, rnd.Next(50, 400));

            // myCanvas.Children.Clear(); // remove all children
            myCanvas.Children.Add(ell);
            
        }
    }
}
