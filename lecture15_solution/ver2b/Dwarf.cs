namespace RPGGame
{
    public class Dwarf : Character
    {
        public Dwarf(string name, int xp, int hp) : base( name, xp, hp)
        {

        }

        public override string? ToString()
        {
            return $"dwarf-{this.name},XP:{xp},HP:{hp}";
        }
    }
}