namespace RPGGame
{
    public class Werewolf : Character
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