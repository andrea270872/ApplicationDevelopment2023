namespace RPGGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Human h = new Human("Billy", 5, 100);
            Console.WriteLine(h);

            Dwarf d = new Dwarf("Keon Cobaltsmasher", 20, 200);
            Console.WriteLine(d);

            Werewolf w = new Werewolf("wolfgang", 0, 500);
            Console.WriteLine(w);*/

            List<Character> characters = new List<Character>();
            characters.Add(new Human("Billy", 5, 100));
            characters.Add(new Dwarf("Keon Cobaltsmasher", 20, 200));
            characters.Add(new Werewolf("wolfgang", 0, 500));

            foreach (Character character in characters)
            {
                Console.WriteLine(character);
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"---{i+1}---");
                foreach (Character character in characters)
                {
                    Console.WriteLine( character.DoSomething() );
                }
            }

            Console.WriteLine("......................");

            Party p1 = new Party("Shorts");
            p1.add(new Dwarf("OakArm", 10, 100));
            p1.add(new Dwarf("StoutNose", 50, 200));
            Console.WriteLine(p1);

            Party p2 = new Party("Single Guy");
            p2.add(new Werewolf("Wolfy", 5,500));
            Console.WriteLine(p2);

            Party p3 = new Party("Larger");
            p3.add(new Werewolf("Wolfy", 5, 500));
            p3.add(p1);
            Console.WriteLine(p3);

            Console.WriteLine(p3.HeadCount()); // 3
        }
    }
}