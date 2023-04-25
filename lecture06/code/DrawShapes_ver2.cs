using System;
using System.Collections.Generic;
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

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
             Shape theShape;
             if (rnd.Next(0, 2) == 0)
             {
                 theShape = new Ellipse(); // I'm using polymorphism here... can you see why?! ;)

                 // set the size of the new ellipse
                 theShape.Width = rnd.Next(30, 150);
                 theShape.Height = rnd.Next(30, 100);

                 // set the color 
                 theShape.Fill = System.Windows.Media.Brushes.Yellow;
                 theShape.Stroke = System.Windows.Media.Brushes.Black;

                 // set the position of the new ellipse
                 Canvas.SetTop(theShape, rnd.Next(50, 400));
                 Canvas.SetLeft(theShape, rnd.Next(50, 400));
             }
             else
             {
                 theShape = new Rectangle(); // polymorphism again!

                 // set the size
                 theShape.Width = rnd.Next(1,5)*10; // can only be 10,20,30,40,50
                 theShape.Height = rnd.Next(1,5)*10; 

                 // set the color 
                 theShape.Fill = System.Windows.Media.Brushes.Blue;
                 theShape.Stroke = System.Windows.Media.Brushes.White;

                 // set the position of the new ellipse
                 Canvas.SetTop(theShape, rnd.Next(1,20)*20); // can only be 20,40,80,..400
                 Canvas.SetLeft(theShape, rnd.Next(1,20)*20);
             }

             myCanvas.Children.Add(theShape);
         }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            myCanvas.Children.Clear(); // remove all children
        }
    }
}
