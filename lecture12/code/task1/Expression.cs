namespace ExpressionTrees
{
    abstract class Expression
    {
        public float interpret()
        {
            return 0.0f;
        }

        public override string ToString() { 
            return "anExpression";
        }
    }
}
