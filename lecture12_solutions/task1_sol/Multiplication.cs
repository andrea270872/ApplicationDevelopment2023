using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressionTrees_solution
{
    class Multiplication: Expression
    {
        private Expression left, right;

        public Multiplication(Expression left, Expression right)
        {
            this.left = left;
            this.right = right;
        }

        internal override float interpret()
        {
            return this.left.interpret() * this.right.interpret();
        }

        public override string ToString()
        {
            return "(" + this.left + " x " + this.right + ")";
        }
    }
}
