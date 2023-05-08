namespace ExpressionTrees
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * A mathematical expression can be a number 
             *   or the addition of 2 expressions,
             *   or the multiplication of 2 expressions...
             * 
             * Expressions are represented in this application as trees.
             * 
             * Your task is to finish implementing the interpret() method in the derived classes, 
             * so that it will be possible to compute the value of an expression tree.
             * 
             * Then you should add a new derived class, 
             * so that it will be possible to compute the value of multiplcations too.
             */

            /*
             *  ex1 -> (5)
             *   
             * The value of this tree should simply be 5.
             */ 
            Expression ex1 = new Number(5);
            float v1 = ex1.interpret();
            Console.WriteLine(ex1); // here the program should print the tree in preorder => "5"
            Console.WriteLine(v1);
            Debug.Assert( v1 == 5 , "The value of this expression should be 5!");

            /*
             * ex4   -> (+)
             *         /   \
             *       (5)   (3)
             *    
             * The value of this tree should be 5+3 => 8
             */
            Expression ex2 = new Number(5);
            Expression ex3 = new Number(3);
            Expression ex4 = new Addition(ex2,ex3);
            float v2 = ex4.interpret();
            Console.WriteLine(ex4); // here the program should print the tree in preorder => "5+3"
            Console.WriteLine(v2);
            Debug.Assert(v2 == 8, "The value of this expression should be 8!");


            Console.WriteLine("- press enter to finish -");
            Console.ReadLine();
        }
    }
}
