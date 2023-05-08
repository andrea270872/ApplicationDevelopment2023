namespace Testing_a_Baloon
{
    public class Baloon
    {
        public string color = "red";
        public void paintBlue() { color = "blue"; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // testing the baloon paintBlue method
            // 1- I need to create an instance of Baloon
            Baloon b = new Baloon();

            // 2- look at the color of the baloon
            Console.WriteLine("this baloon is " + b.color);

            // 3- paint, AKA call the method I want to test
            Console.WriteLine("painting the baloon ... ");
            b.paintBlue();

            // 4- look at the color of the baloon again!
            Console.WriteLine("this baloon is " + b.color);
        }
    }
}