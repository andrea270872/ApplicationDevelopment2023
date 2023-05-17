namespace RPGGame
{
    public abstract class Character
    {
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
    }
}