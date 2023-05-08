using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExpressionTrees_solution
{
    class Addition: Expression
    {
        private Expression left, right;

        public Addition(Expression left,Expression right)
        {
            this.left = left;
            this.right = right;
        }

        internal override float interpret()
        {
            return this.left.interpret() + this.right.interpret();
        }

        public override string ToString()
        {
            return "(" + this.left + " + " + this.right + ")";
        }
    }
}
