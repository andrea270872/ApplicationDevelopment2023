using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExpressionTrees_solution
{
    abstract class Expression
    {
        internal virtual float interpret()
        {
            return 0.0f;
        }

        public override string ToString() { 
            return "anExpression";
        }
    }
}
