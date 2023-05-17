namespace RPGGame
{
    public class Werewolf : SingleCharacter
    {
        public Werewolf(string name, int xp, int hp) : base(name, xp, hp)
        {
        }

        public override string DoSomething()
        {
            return "Howling at the moon";
        }
    }
}