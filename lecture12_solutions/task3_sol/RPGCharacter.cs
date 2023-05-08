using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPGCharacters_solution
{
    class RPGCharacter
    {
        protected int gender;
        protected Animal companion;

        internal void setMale()
        {
            this.gender = 1;
        }

        internal void setFemale()
        {
            this.gender = 2;
        }

        internal string genderDescription()
        {
            if (this.gender==1)
                return "male";
            if (this.gender==2)
                return "female";
            return "<unspecified>";
        }

        internal void setAnimal(Animal animal)
        {
            this.companion = animal;
        }

        public override string ToString()
        {
            return "anRPGCharacter";
        }
    }
}
