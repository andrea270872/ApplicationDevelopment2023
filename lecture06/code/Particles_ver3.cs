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
using System.Windows.Threading;

namespace Particles
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Particle p;
        private Random rnd;
        private List<Particle> Particles;

        public MainWindow()
        {
            rnd = new Random();
            InitializeComponent();

            Particles = new List<Particle>();
            for (int i = 0; i < 10; i++)
            {
                Particles.Add(
                    new Particle(250,200, rnd.NextDouble()*4-2, rnd.NextDouble() * -4)
                    );
            }

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(15);
            timer.Tick += UpdateAndDrawAll;
            timer.Start();
        }

        private void UpdateAndDrawAll(object? sender, EventArgs e)
        {
            MyCanvas.Children.Clear(); // remove all children
            for (int i=0;i<Particles.Count;i++)
            {
                Particles[i].Update();
                DrawParticle(Particles[i]);

                if (Particles[i].GetY()>500) // no longer visible
                {
                    Particles[i].SetDead();
                }

                if (!Particles[i].IsAlive())
                {
                    Particles[i] = new Particle(250, 200,
                                                rnd.NextDouble() * 4 - 2, rnd.NextDouble() * -4);
                }
            }
        }

        private void DrawParticle(Particle p)
        {
            Ellipse circle = new Ellipse();
            circle.Width = 8;
            circle.Height = 8;
            Canvas.SetLeft(circle, p.GetX());
            Canvas.SetTop(circle, p.GetY());
            circle.Fill = System.Windows.Media.Brushes.Black;
            circle.Stroke = System.Windows.Media.Brushes.Gray;
            MyCanvas.Children.Add(circle);

            Line line = new Line();
            line.StrokeThickness = 1;
            line.Stroke = System.Windows.Media.Brushes.Blue;
            line.X1 = p.GetX() + 8 / 2;
            line.Y1 = p.GetY() + 8 / 2;
            line.X2 = line.X1 + p.GetVX() * 10;
            line.Y2 = line.Y1 + p.GetVY() * 10;
            MyCanvas.Children.Add(line);
        }
    }
}
 