using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGCharacters_solution
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * You are writing an RPG and have been given (by the game designer) a few types of characters 
             * you need to design and implement.
             * For example:
             * - in this RPG there are characters like Humans and Orcs
             * - also characters can be male or female,
             * - and a character always has an animal-companion, and animals can be small Alligators or large dragonflies
             * - when you create an alligator you must provide a weight in kilograms, 
             * - when you create an orc you have to specify what color it is: brown, blue or gray.
             * For some restrictions however you need to be sure that the following rules are always respected when generating a new character:
             * - Humans can only be female, while Orcs must be male
             * - a female character can only any a dragonfly as companion, while a male character will always have an alligator.
             * 
             * Redesign the given classes, so that you can generate only the right combination of race, gender and animal-companions, 
             * and try to make the code more simple (to improve readability).
             * Fix the ToString methods in the provided classes, so that each RPGCharacter can return its own description.
             */

            RPGCharacterFactory factory = new RPGCharacterFactory(); // only 1 instance of this class is needed in this program!

            RPGCharacter anika = factory.newHumanFemale();
            Console.WriteLine(anika);

            RPGCharacter billy = factory.newMaleOrcBlue(); // factory.newMaleOrcBrown();
            Console.WriteLine(billy);


            Console.WriteLine("- press enter to finish -");
            Console.ReadLine();
        }
    }
}
