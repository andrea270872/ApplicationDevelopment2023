using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExpressionTrees_solution
{
    class Number : Expression
    {
        private float value;

        public Number(float value)
        {
            this.value = value;
        }

        internal override float interpret()
        {
            return this.value;
        }

        public override string ToString()
        {
            return "<"+this.value + ">";
        }
    }
}
