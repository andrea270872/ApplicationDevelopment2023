namespace RPGGame
{
    public class Dwarf
    {
        private string name;
        private int xp;
        private int hp;

        public Dwarf(string name, int xp, int hp)
        {
            this.name = name;
            this.xp = xp;
            this.hp = hp;
        }

        public override string? ToString()
        {
            return $"dwarf-{this.name},XP:{xp},HP:{hp}";
        }
    }
}