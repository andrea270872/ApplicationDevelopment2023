
namespace SomeSillyGame
{
    class GameCharacter
    {
        private static string _secret = "nothing";
        public string theName { get; }

        public double posX;
        public double posY;

        public GameCharacter(string characterName, double positionX = 0, double positionY = 0)
        {
            this.theName = characterName;
            this.posX = positionX;
            this.posY = positionY;
        }

        public void ListenToMySecret(string someSecret)
        {
            _secret = someSecret;
            /* NOTE: you cannot write
             * 
             *    this._secret = someSecret;
             *    
             * Can you see why not?
             */
        }

        public string TellTheLatestSecret()
        {
            return _secret;
        }

        public static double distanceBetweenPoints(double px,double py,double qx,double qy)
        {
            double dist = Math.Sqrt( Math.Pow(px - qx,2) + Math.Pow(py - qy, 2) );
            return dist;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<GameCharacter> list = new List<GameCharacter>();
            list.Add(new GameCharacter("Adam"));
            list.Add(new GameCharacter("Bob",100,120));
            list.Add(new GameCharacter("Charlie",200,250));

            foreach (GameCharacter c in list) { 
                Console.WriteLine(c.theName + " knows ... " + c.TellTheLatestSecret());
            }

            list[1].ListenToMySecret("the meaning of life the universe and everything is ..."); // 42 ;)

            foreach (GameCharacter c in list)
            {
                Console.WriteLine(c.theName + " knows ... " + c.TellTheLatestSecret());
            }

            // just to see how far Adam and Bob are...
            Console.WriteLine("\nThe distance between Adam and Bob is ");
            Console.WriteLine(GameCharacter.distanceBetweenPoints(list[0].posX, list[0].posY,
                                                                list[1].posX, list[1].posY));
        }
    }
}