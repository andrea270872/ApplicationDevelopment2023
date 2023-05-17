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

        }
    }
}