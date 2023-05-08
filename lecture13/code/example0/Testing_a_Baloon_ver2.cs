namespace Testing_a_Baloon
{
    public class Baloon
    {
        public string color = "red";
        //public void paintBlue() { color = "blue"; }
        public void paintBlue() { color = "yellow"; }
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

            // ------- a better, more automatic, way -----------------------
            Baloon b2 = new Baloon();
            b2.paintBlue();
            string finalColor = b2.color;

            // I EXPECT THE COLOR TO BE BLUE AFTER THE METHOD IS CALLED!
            // If not... then ERROR
            if (finalColor != "blue")
            {
               throw new Exception("ERROR! the finalColor should be blue, but instead it is " + finalColor);
            }
            // else: nothing, it means the test was a success! We just continue...
        }
    }
}