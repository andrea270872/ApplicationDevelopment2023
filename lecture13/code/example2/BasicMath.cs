
namespace TestDrivenDev_example1
{
    public class BasicMaths
    {
        public double Add(double num1, double num2)
        {
            return num1 + num2;
        }
        public double Substract(double num1, double num2)
        {
            return num1 - num2;
        }
        public double divide(double num1, double num2)
        {
            return num1 / num2;
        }
        public double Multiply(double num1, double num2)
        {
            /*
            // To trace error while testing, writing + operator instead of * operator.  
            return num1 + num2;
            */
            return num1 * num2;
        }

        public double Square(double num)
        {
            /*
            return 0; // dummy implementation
            */
            return num*num;
        }
    }
}