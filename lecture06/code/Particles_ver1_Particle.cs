using System;

namespace Particles
{
    public class Particle
    {
        private double posX;
        private double posY;
        private double velX;
        private double velY;

        public Particle(double x, double y, double vX, double vY)
        {
            posX = x;
            posY = y;
            velX = vX;
            velY = vY;
        }

        public void update()
        {
            velY += .05; // gravity pulling down

            posX += velX;
            posY += velY;
        }

        public override string ToString()
        {
            return string.Format("P({0};{1}) v=({2};{3})", posX, posY, velX, velY);
        }

        public double GetX()
        {
            return posX;
        }

        public double GetY()
        {
            return posY;
        }

        public double GetVX()
        {
            return velX;
        }

        public double GetVY()
        {
            return velY;
        }
    }
}
