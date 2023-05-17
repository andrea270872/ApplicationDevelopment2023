namespace RPGGame
{
    public class Party : Character
    {
        List<Character> members;
        public Party(string name, int xp=-1, int hp=-1) : base(name, xp, hp)
        {
            // I don't need xp and hp ... 

            members = new List<Character>();
        }

        public override string DoSomething()
        {
            return "jsut waiting...";
        }

        public override string? ToString()
        {
            String subs = "";
            foreach (Character c in members)
            {
                subs += "  " + c.ToString() + "\n";
            }
            return $"Party {name}\n" + subs;
        }

        public void add(Character c)
        {
            members.Add(c);
        }

        public int HeadCount()
        {
            int count = 0;
            foreach (Character c in members)
            {
                if (c.GetType() != typeof(Party)) // single character
                {
                    count++;
                } else
                {  // c is a Party object
                    count = count + ((Party)c).HeadCount();
                }
            }
            return count;
        }
    }
}