using System;
using System.Net.NetworkInformation;

namespace RPGGame
{
    public class Human : Character
    {
        public Human(string name, int xp, int hp) : base(name, xp, hp)
        {

        }

        public override string DoSomething()
        {
            System.Random random = new System.Random();
            String[] actions = new string[]
            {
                "Eating", "Sharpening my sword", "Tying my boot"
            };
            int choice = random.Next(0, actions.Length);
            return actions[choice];
        }
    }
}