namespace Mp3PlayerApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * An mp3 player is usually in state "off". From state "off" it can be turned on, then it will be in state "standby".
             * From state standby it can go to state "playing", and from state "playing" it can do to state "standby" again.
             * Eventually from "standby" the mp3 player can go into state "off" again.
             * Moreover, when an mp3 player is in state "off" the display indicates "-", while when in "standby" the display shows "[]";
             * when in state "playing" the display shows the number and name of the song being player, something like "04 Take on me".
             * An mp3 player should remember its state and be able to output a description of its state.
             * 
             * Finish desiging and implementing the class mp3 player. It should be possible to run the program below.
             */

            Mp3Player player1 = new Mp3Player();
            Mp3Player player2 = new Mp3Player();

            Console.WriteLine("Current state of player1 and player2");
            Console.WriteLine(player1.description()); // should output that the player1 is in state "off"
            Console.WriteLine(player1.displayInfo()); // should output "-"
            Console.WriteLine(player2.description());
            Console.WriteLine(player2.displayInfo());

            // the following changes state of player1 from "off" to "standby", then to "playing"
            player1.switchOn();
            player1.playSong();

            Console.WriteLine("Current state of player1 and player2");
            Console.WriteLine(player1.description()); // should output that the player1 is in state "playing"
            Console.WriteLine(player1.displayInfo()); // should output "01 song"
            Console.WriteLine(player2.description());
            Console.WriteLine(player2.displayInfo());

            player1.stop();
            player1.switchOff();

            Console.WriteLine("Current state of player1 and player2");
            Console.WriteLine(player1.description()); // should output that the player1 is in state "off"
            Console.WriteLine(player1.displayInfo()); // should output "-"
            Console.WriteLine(player2.description());
            Console.WriteLine(player2.displayInfo());

            Console.WriteLine("- press enter to finish -");
            Console.ReadLine();
        }
    }
}
