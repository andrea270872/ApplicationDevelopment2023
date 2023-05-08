using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPGCharacters_solution
{
    class Orc:RPGCharacter
    {
        private string color;
        internal void setColor(string color)
        {
            this.color = color;
        }

        public override string ToString()
        {
            return "a " + this.color + " Orc (" + this.genderDescription() + ")" 
                + " with " + this.companion;
        }

    }
}
