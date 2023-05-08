using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGCharacters_solution
{
    class RPGCharacterFactory
    {
        internal RPGCharacter newHumanFemale()
        {
            RPGCharacter c = new Human();
            c.setFemale();
            c.setAnimal(new Dragonfly());
            return c;
        }

        internal RPGCharacter newMaleOrcBlue()
        {
            Orc c = new Orc();
            c.setColor("blue");
            c.setMale();
            Alligator ally = new Alligator();
            ally.setWeight(250);
            c.setAnimal(ally);
            return c;
        }

        internal RPGCharacter newMaleOrcBrown()
        {
            Orc c = new Orc();
            c.setColor("brown");
            c.setMale();
            Alligator ally = new Alligator();
            ally.setWeight(100);
            c.setAnimal(ally);
            return c;
        }
    }
}
