namespace ExpressionTrees
{
    class Addition: Expression
    {
        private Expression left, right;

        public Addition(Expression left,Expression right)
        {
            this.left = left;
            this.right = right;
        }
    }
}
