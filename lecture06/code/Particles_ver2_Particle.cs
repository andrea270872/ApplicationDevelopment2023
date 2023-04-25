using System;

namespace Particles
{
    public class Particle
    {
        private int LifeSpan;
        private double posX;
        private double posY;
        private double velX;
        private double velY;

        public Particle(double x, double y, double vX, double vY)
        {
            LifeSpan = 200;
            posX = x;
            posY = y;
            velX = vX;
            velY = vY;
        }

        public void Update()
        {
            if (this.IsAlive())
            {
                LifeSpan -= 1;
                velY += .05; // gravity pulling down

                posX += velX;
                posY += velY;
            }
        }

        public bool IsAlive()
        {
            return LifeSpan > 0;
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
