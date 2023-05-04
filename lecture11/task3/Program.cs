

namespace ModularMachines
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Problem: in a robot game there are basic robots that can be equipped during the game 
             * with different gadgets, and that can be given different roles.
             * 
             * A robot can have a role like:
             * - war robot - attack enemies
             * - finder - collect specific items
             * - reparator - fix other robots
             * and combinations of above.
             * 
             * A robot can also be given one or more gadgets for moving, so a robot can be able to:
             * - walk
             * - fly
             * - dive
             * and combinations of above.
             * 
             * Design a solution for this problem, so that you can finish the code below, 
             * and make it work as it should.
             * Eventually re-design the existing Robot class.
             */

            Robot robbie = new Robot();
            /*
             * do something to set this robot in a way so that it can:
             * - walk and fly
             * - and it is a finder robot
             * 
             */

            Console.WriteLine(robbie.describeRoles());   // it should print "finder"
            Console.WriteLine(robbie.describeMotions()); // it should print "walk, fly"


            Console.WriteLine("- press enter to finish -");
            Console.ReadLine();


            /*
             * Finally: consider the classes you designed.
             * How complex/long would it be to alter your design to include these new facts:
             * - a robot can be created positronic or it can be created electronic
             * - a robot can have a new motion skill which is to teleport (using artificially generated wormholes)
             * - a robot can be painted golden, black or iron-gray at different moments of the game; when describing the Roles, a robot will
             * also print its current color.
             */
        }
    }
}

