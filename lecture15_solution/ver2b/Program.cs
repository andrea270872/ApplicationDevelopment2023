namespace RPGGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human h = new Human("Billy", 5, 100);
            Console.WriteLine(h);

            Dwarf d = new Dwarf("Keon Cobaltsmasher", 20, 200);
            Console.WriteLine(d);
        }
    }
}