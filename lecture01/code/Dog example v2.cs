namespace Dog_example
{
    class Animal
    {
        public int weight = 0;
    }

    class Dog : Animal
    {
        public string name = "aDog"; // initial name of all dogs
        public string DescribeYourself()
        {
            return name + " and weights " + weight + " kg";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog();
            dog1.name = "fufi";
            dog1.weight = 5;
            Console.WriteLine(dog1.DescribeYourself());

            Dog dog2 = new Dog();
            dog2.name = "butch";
            dog2.weight = 15;
            Console.WriteLine(dog2.DescribeYourself());
        }
    }
}

