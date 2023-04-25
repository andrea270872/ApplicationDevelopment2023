namespace Particles_textmode
{
    public class Particle
    {
        private double posX;
        private double posY;
        private double velX;
        private double velY;

        public Particle(double x,double y,double vX,double vY)
        {
            posX = x;
            posY = y;
            velX = vX;
            velY = vY;
        }

        public void update()
        {
            velY += .1; // gravity pulling down

            posX += velX;
            posY += velY;
        }

        public override string ToString()
        {
            return string.Format("P({0};{1}) v=({2};{3})",posX,posY,velX,velY);
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Particle p = new Particle(100,100,10,50);
            Console.WriteLine(p);
            for (int i = 0; i < 10; i++)
            {
                p.update();
                Console.WriteLine(p);
            }
            
        }
    }
}