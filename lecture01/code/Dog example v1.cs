namespace Dog_example
{
    class Dog
    {
        public string name = "aDog"; // initial name of all dogs
        public string DescribeYourself()
        {
            return name;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog();
            dog1.name = "fufi";
            Console.WriteLine( dog1.DescribeYourself() );
        }
    }
}
