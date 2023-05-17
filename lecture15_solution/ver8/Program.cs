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


            Party aParty = Party.MakePartyOfType("type 1");
            Console.WriteLine(aParty);


            // attacks!
            Human h = new Human("Billy", 5, 100);
            Dwarf d = new Dwarf("Keon Cobaltsmasher", 20, 200);

            Console.WriteLine("Attacks ... until one is dead!");
            do
            {
                Console.WriteLine(h);
                Console.WriteLine(d);
                h.Attack(d);
                d.Attack(h);
            } while (!(d.IsDead() || h.IsDead()));

            Console.WriteLine("\n\n=======================\n\n");
            Party party1 = Party.MakePartyOfType("type 1");

            Party temp1 = new Party("DoubleDwarf");
            temp1.add(new Dwarf("DeeDee", 10, 100));
            temp1.add(new Dwarf("DuuDuu", 50, 200));
            
            Party temp2 = new Party("SingleGuy");
            temp2.add(new Human("Ben Grim", 50, 1000));

            Party party2 = new Party("LargeParty");
            party2.add(new Werewolf("Fiffi", 5, 500));
            party2.add(temp1);
            party2.add(temp2);

            Console.WriteLine("\n\n=== Attacks ==================\n\n");

            Console.WriteLine("Party1 --------- ");
            Console.WriteLine(party1);
            Console.WriteLine("Party2 --------- ");
            Console.WriteLine(party2);

            for (int i=0;i<10;i++ )
            {
                Console.WriteLine("[ round "+ (i+1) +" ]");

                party1.Attack(party2);
                Console.WriteLine();
                party2.Attack(party1);

                Console.WriteLine("Party1 --------- ");
                Console.WriteLine(party1);
                Console.WriteLine("Party2 --------- ");
                Console.WriteLine(party2);
                Console.WriteLine("\n");
            }
        }
    }
}