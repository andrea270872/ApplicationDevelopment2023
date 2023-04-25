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
            for (int i = 0; i < 100; i++)
            {
                Particles.Add(
                    new Particle(250, 200, rnd.NextDouble() * 4 - 2, rnd.NextDouble() * -4)
                    );
            }

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(15);
            timer.Tick += UpdateAndDrawAll;
            timer.Start();

            // draw all particles and lines
            MyCanvas.Children.Clear(); // remove all children
            for (int i = 0; i < Particles.Count; i++)
            {
                DrawParticle(Particles[i]);
            }
        }

        private void UpdateAndDrawAll(object? sender, EventArgs e)
        {
            
            for (int i=0;i<Particles.Count;i++)
            {
                Particles[i].Update();
                MoveParticleAtIndex(i); // more efficient!

                if (Particles[i].GetY()>500) // no longer visible
                {
                    Particles[i].SetDead();
                }

                if (!Particles[i].IsAlive())
                {
                    Particles[i].Initialize(250, 200,  rnd.NextDouble() * 4 - 2, rnd.NextDouble() * -4);
                }
            }
        }

        private void MoveParticleAtIndex(int i)
        {
            // remember -> we added 1 circle and 1 line
            // so:
            //      the first circle is a pos 0
            //      the second circle is a pos 2
            //      the third circle is a pos 4
            // ...
            Ellipse theCircle = (Ellipse)MyCanvas.Children[i * 2];
            Canvas.SetLeft(theCircle, Particles[i].GetX());
            Canvas.SetTop(theCircle, Particles[i].GetY());

            Line theLine = (Line)MyCanvas.Children[i * 2+1];
            theLine.X1 = Particles[i].GetX() + 8 / 2;
            theLine.Y1 = Particles[i].GetY() + 8 / 2;
            theLine.X2 = theLine.X1 + Particles[i].GetVX() * 10;
            theLine.Y2 = theLine.Y1 + Particles[i].GetVY() * 10;
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
 