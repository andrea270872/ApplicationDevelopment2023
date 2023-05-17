using System;

namespace RPGGame
{
    public abstract class SingleCharacter : Character
    {
        protected SingleCharacter(string name, int xp, int hp) : base(name, xp, hp)
        {
        }

        /*
         When a character attacks another, the character with higher XP damages the one with less XP. 
         The damage should be an int random number from 1 to 6. 
         The attacker removes the damage points from the attacked HPs.
         */
        public virtual void Attack(SingleCharacter other)
        {
            int damage = random.Next(1, 6 + 1); // from 1 to 6, both included
            if (this.xp > other.xp)
            {  // I attack
                other.hp -= damage;
            } else
            {  // the other attacks
                this.hp -= damage;  
            }
        }

    }
}
