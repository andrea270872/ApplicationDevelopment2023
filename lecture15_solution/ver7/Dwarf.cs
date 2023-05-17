namespace RPGGame
{
    public class Dwarf : SingleCharacter
    {
        public Dwarf(string name, int xp, int hp) : base( name, xp, hp)
        {

        }

        public override string DoSomething()
        {
            return "Using my axe";
        }

        public override string? ToString()
        {
            return $"dwarf-{this.name},XP:{xp},HP:{hp}";
        }
    }
}