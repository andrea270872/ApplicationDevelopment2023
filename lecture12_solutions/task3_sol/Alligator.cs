using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPGCharacters_solution
{
    class Alligator: Animal
    {
        private int weight;

        internal void setWeight(int weight)
        {
            this.weight = weight;
        }

        public override string ToString()
        {
            return "alligator "+this.weight;
        }

    }
}
