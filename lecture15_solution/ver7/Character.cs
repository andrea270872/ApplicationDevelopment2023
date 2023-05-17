﻿namespace RPGGame
{
    public abstract class Character
    {
        static protected Random random = new Random();

        protected int hp;
        protected String name;
        protected int xp;

        public Character(string name, int xp, int hp)
        {
            this.hp = hp;
            this.name = name;
            this.xp = xp;
        }

        public override string? ToString()
        {
            return $"{this.name},XP:{xp},HP:{hp}";
        }

        // Returns a random text, depending on which type of character
        public abstract string DoSomething();

        public bool IsDead()
        {
            return hp <= 0;
        }
    }
}