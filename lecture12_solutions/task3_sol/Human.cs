using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPGCharacters_solution
{
    class Human : RPGCharacter
    {
        public override string ToString()
        {
            return "a Human (" + this.genderDescription() + ")" 
                + " with " + this.companion; ;
        }
    }
}
