namespace RPGGame
{
    public class Human
    {
        private string name;
        private int xp;
        private int hp;

        public Human(string name, int xp, int hp)
        {
            this.name = name;
            this.xp = xp;
            this.hp = hp;
        }

        public override string? ToString()
        {
            return $"{this.name},XP:{xp},HP:{hp}";
        }
    }
}